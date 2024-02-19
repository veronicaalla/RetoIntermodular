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

import es.equipo2.apirest1.model.Personal;
import es.equipo2.apirest1.repository.PersonalRepository;

@RestController
@RequestMapping("/api/personal")
public class personalControlador {

    @Autowired
    private PersonalRepository personalRepository;

    @GetMapping
    public List<Personal> obtenerTodoPersonal() {
        return personalRepository.findAll();
    }

    @GetMapping("/{id}")
    public Personal obtenerPersonalPorId(@PathVariable int id) {
        return personalRepository.findById(id).orElse(null);
    }

    @PostMapping
    public Personal nuevoPersonal(@RequestBody Personal nuevoPersonal) {
        return personalRepository.save(nuevoPersonal);
    }

    @PutMapping("/{id}")
    public Personal editarPersonal(@RequestBody Personal personalEditado, @PathVariable int id) {
        if (personalRepository.existsById(id)) {
            personalEditado.setId(id);
            return personalRepository.save(personalEditado);
        } else {
            return null;
        }
    }

    @DeleteMapping("/{id}")
    public Personal borrarPersonal(@PathVariable int id) {
        if (personalRepository.existsById(id)) {
            Personal personal = personalRepository.findById(id).get();
            personalRepository.delete(personal);
            return personal;
        } else {
            return null;
        }
    }
}