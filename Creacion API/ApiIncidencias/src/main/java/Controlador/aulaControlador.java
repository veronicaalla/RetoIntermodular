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

import Modelo.Aula;
import Repositorio.AulaRepository;


@RestController
@RequestMapping("/api")
public class aulaControlador {
    
    @Autowired
    private AulaRepository aulaRepository;
    
    @GetMapping("/aulas")
    public List<Aula> obtenerAulas() {
        return aulaRepository.findAll();
    }
    
    @GetMapping("/{id}")
    public Aula obtenerAulaPorId(@PathVariable int id) {
        return aulaRepository.findById(id).orElse(null);
    }
    
    @PostMapping
    public Aula crearAula(@RequestBody Aula nuevaAula) {
        return aulaRepository.save(nuevaAula);
    }
    
    @PutMapping("/{id}")
    public Aula actualizarAula(@RequestBody Aula aulaEditada, @PathVariable int id) {
        java.util.Optional<Aula> aulaExistente = aulaRepository.findById(id);
        if (aulaExistente.isPresent()) {
            Aula aula = aulaExistente.get();
            // Actualizar los atributos relevantes de aula con los de aulaEditada
            aula.setCodigo(aulaEditada.getCodigo());
            aula.setDescripcion(aulaEditada.getDescripcion());
            aula.setPlanta(aulaEditada.getPlanta());
            // Guardar el aula actualizada
            return aulaRepository.save(aula);
        } else {
            return null;
        }
    }
    
    @DeleteMapping("/{id}")
    public Aula borrarAula(@PathVariable int id) {
        java.util.Optional<Aula> aulaExistente = aulaRepository.findById(id);
        if (aulaExistente.isPresent()) {
            Aula aula = aulaExistente.get();
            aulaRepository.delete(aula);
            return aula;
        } else {
            return null;
        }
    }
}