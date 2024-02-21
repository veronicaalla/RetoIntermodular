package es.equipo2.apirest1.controller;

import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import es.equipo2.apirest1.model.Perfiles;
import es.equipo2.apirest1.model.Tipo_Perfil;
import es.equipo2.apirest1.repository.PerfilesRepository;

@RestController
@RequestMapping("/api/perfiles")
public class PerfilesControlador {

	@Autowired
    private PerfilesRepository perfilesRepository;

    @GetMapping
    public List<Perfiles> obtenerPerfiles() {
        return perfilesRepository.findAll();
    }

    @GetMapping("/{id}")
    public Perfiles obtenerPerfilPorId(@PathVariable int id) {
        return perfilesRepository.findById(id).orElse(null);
    }
    
    @GetMapping("/tipo/{perfil}")
    public List<Perfiles> obtenerPerfilPorTipo(@PathVariable Tipo_Perfil perfil) {
        return perfilesRepository.findByPerfil(perfil);
    }
    
    @GetMapping("/dominio/{dominio}")
    public List<Perfiles> obtenerPerfilPorDominio(@PathVariable String dominio) {
        return perfilesRepository.findByDominio(dominio);
    }

    @PostMapping
    public Perfiles nuevoPerfil(@RequestBody Perfiles nuevoPerfil) {
        return perfilesRepository.save(nuevoPerfil);
    }
    
    @GetMapping("/login")
    public ResponseEntity<?> login(@RequestParam String dominio, @RequestParam String password) {
        // Codificar la contraseña utilizando MD5
        String passwordCodificado = md5(password);

        // Buscar el perfil por dominio y contraseña codificada
        Perfiles perfil = perfilesRepository.findByDominioAndPassword(dominio, passwordCodificado);

        if (perfil != null) {
            return ResponseEntity.ok(perfil);
        } else {
            return ResponseEntity.status(HttpStatus.UNAUTHORIZED).body("Dominio o contraseña incorrectos");
        }
    }
    private String md5(String password) {
        try {
            MessageDigest md = MessageDigest.getInstance("MD5");
            byte[] messageDigest = md.digest(password.getBytes());

            // Convertir el array de bytes a una representación hexadecimal
            StringBuilder sb = new StringBuilder();
            for (byte b : messageDigest) {
                sb.append(String.format("%02x", b));
            }
            return sb.toString();
        } catch (NoSuchAlgorithmException e) {
            throw new RuntimeException("Error al codificar la contraseña", e);
        }
    }
    
    @PutMapping("/{id}")
    public Perfiles editarPerfil(@RequestBody Perfiles perfilEditado, @PathVariable int id) {
        if (perfilesRepository.existsById(id)) {
            perfilEditado.setPersonal_id(id);
            return perfilesRepository.save(perfilEditado);
        } else {
            return null;
        }
    }

    @DeleteMapping("/{id}")
    public Perfiles borrarPerfil(@PathVariable int id) {
        if (perfilesRepository.existsById(id)) {
            Perfiles perfil = perfilesRepository.findById(id).get();
            perfilesRepository.delete(perfil);
            return perfil;
        } else {
            return null;
        }
    }
}
