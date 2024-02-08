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

import es.luisherrero.apirest1.model.Departamento;
import es.luisherrero.apirest1.repository.DepartamentoRepository;


@RestController
@RequestMapping("/api/departamentos")
public class departamentoControlador {

    @Autowired
    private DepartamentoRepository departamentoRepository;

    @GetMapping
    public List<Departamento> obtenerDepartamentos() {
        return departamentoRepository.findAll();
    }

    @GetMapping("/{id}")
    public Departamento obtenerDepartamentoPorId(@PathVariable int id) {
        return departamentoRepository.findById(id).orElse(null);
    }

    @PostMapping
    public Departamento nuevoDepartamento(@RequestBody Departamento nuevoDepartamento) {
        return departamentoRepository.save(nuevoDepartamento);
    }

    @PutMapping("/{id}")
    public Departamento editarDepartamento(@RequestBody Departamento departamentoEditado, @PathVariable int id) {
        if (departamentoRepository.existsById(id)) {
            departamentoEditado.setInt_(id); // Asignar el id al campo int_
            return departamentoRepository.save(departamentoEditado);
        } else {
            return null;
        }
    }

    @DeleteMapping("/{id}")
    public Departamento borrarDepartamento(@PathVariable int id) {
        if (departamentoRepository.existsById(id)) {
            Departamento departamento = departamentoRepository.findById(id).get();
            departamentoRepository.delete(departamento);
            return departamento;
        } else {
            return null;
        }
    }
}