package Controlador;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import Modelo.Perfiles;
import Repositorio.PerfilesRepository;


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

    @PostMapping
    public Perfiles nuevoPerfil(@RequestBody Perfiles nuevoPerfil) {
        return perfilesRepository.save(nuevoPerfil);
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
