package es.equipo2.apirest1.controller;

import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

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

import es.equipo2.apirest1.model.PerfilConPersonalDTO;
import es.equipo2.apirest1.model.Perfiles;
import es.equipo2.apirest1.model.Personal;
import es.equipo2.apirest1.model.Tipo_Perfil;
import es.equipo2.apirest1.repository.PerfilesRepository;
import es.equipo2.apirest1.repository.PersonalRepository;

@RestController
@RequestMapping("/api/perfiles")
public class PerfilesControlador {

	@Autowired
    private PerfilesRepository perfilesRepository;
	@Autowired
    private PersonalRepository personalRepository;

    @GetMapping
    public List<Perfiles> obtenerPerfiles() {
        return perfilesRepository.findAll();
    }
    
    @GetMapping("/{id}")
    public Perfiles obtenerPerfilPorId(@PathVariable int id) {
        return perfilesRepository.findById(id).orElse(null);
    }
    
    @GetMapping("/con-personal")
    public PerfilConPersonalDTO obtenerPerfilConPersonalPorId(@RequestParam int perfilesId) throws Exception {
        Optional<Perfiles> perfilesOptional = perfilesRepository.findById(perfilesId);
        if (perfilesOptional.isPresent()) {
            Perfiles perfiles = perfilesOptional.get();
            Personal personal = personalRepository.findById(perfiles.getPersonal_id()).orElse(null);
            
            PerfilConPersonalDTO perfilConPersonalDTO = new PerfilConPersonalDTO();
            perfilConPersonalDTO.setPerfil(perfiles);
            perfilConPersonalDTO.setPersonal(personal);
            
            return perfilConPersonalDTO;
        } else {
            // Manejo de error si no se encuentra el perfil con el ID proporcionado
            throw new Exception("Perfil no encontrado con el ID: " + perfilesId);
        }
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

        // Buscar el perfil por dominio y contraseña codificada
        Perfiles perfil = perfilesRepository.findByDominioAndPassword(dominio, password);

        if (perfil != null) {
            return ResponseEntity.ok(perfil);
        } else {
            return ResponseEntity.status(HttpStatus.UNAUTHORIZED).body("Dominio o contraseña incorrectos");
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
