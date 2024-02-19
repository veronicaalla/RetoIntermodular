package es.equipo2.apirest1.controller;

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

import es.equipo2.apirest1.model.Incidencia;
import es.equipo2.apirest1.model.Personal;
import es.equipo2.apirest1.repository.IncidenciaRepository;
import es.equipo2.apirest1.repository.PersonalRepository;


@RestController
@RequestMapping("/api/incidencias")
public class incidenciaControlador {

    @Autowired
    private IncidenciaRepository incidenciaRepository;
    
    @Autowired
    private PersonalRepository personalRepository;

    @GetMapping
    public List<Incidencia> obtenerIncidencias() {
        return incidenciaRepository.findAll();
    }
    
    @GetMapping("/{creador}")
    public List<Incidencia> obtenerIncidenciasPorPersona(@PathVariable Personal creador) {
    	Personal persona = personalRepository.findByNombre(creador.getNombre());
        return incidenciaRepository.findByCreador(persona);
    }

    @GetMapping("/{num}")
    public Incidencia obtenerIncidenciaPorNumero(@PathVariable int num) {
        return incidenciaRepository.findById(num).orElse(null);
    }

    @PostMapping
    public Incidencia nuevaIncidencia(@RequestBody Incidencia nuevaIncidencia) {
        return incidenciaRepository.save(nuevaIncidencia);
    }

    @PutMapping("/{num}")
    public Incidencia editarIncidencia(@RequestBody Incidencia incidenciaEditada, @PathVariable int num) {
        if (incidenciaRepository.findById(num).isPresent()) {
            incidenciaEditada.setNum(num);
            return incidenciaRepository.save(incidenciaEditada);
        } else {
            return null;
        }
    }

    @DeleteMapping("/{num}")
    public Incidencia borrarIncidencia(@PathVariable int num) {
        if (incidenciaRepository.findById(num).isPresent()) {
            Incidencia incidencia = incidenciaRepository.findById(num).get();
            incidenciaRepository.delete(incidencia);
            return incidencia;
        } else {
            return null;
        }
    }
}