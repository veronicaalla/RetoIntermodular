package es.luisherrero.apirest1.controller;

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

import es.luisherrero.apirest1.model.Equipo;
import es.luisherrero.apirest1.repository.EquipoRepository;


@RestController
@RequestMapping("/api/equipos")
public class equipoControlador {

    @Autowired
    private EquipoRepository equipoRepository;

    @GetMapping
    public List<Equipo> obtenerEquipos() {
        return equipoRepository.findAll();
    }

    @GetMapping("/{id}")
    public Equipo obtenerEquipoPorId(@PathVariable int id) {
        return equipoRepository.findById(id).orElse(null);
    }

    @PostMapping
    public Equipo nuevoEquipo(@RequestBody Equipo nuevoEquipo) {
        return equipoRepository.save(nuevoEquipo);
    }

    @PutMapping("/{id}")
    public Equipo editarEquipo(@RequestBody Equipo equipoEditado, @PathVariable int id) {
        if (equipoRepository.existsById(id)) {
            equipoEditado.setId(id);
            return equipoRepository.save(equipoEditado);
        } else {
            return null;
        }
    }

    @DeleteMapping("/{id}")
    public Equipo borrarEquipo(@PathVariable int id) {
        if (equipoRepository.existsById(id)) {
            Equipo equipo = equipoRepository.findById(id).get();
            equipoRepository.delete(equipo);
            return equipo;
        } else {
            return null;
        }
    }
}
