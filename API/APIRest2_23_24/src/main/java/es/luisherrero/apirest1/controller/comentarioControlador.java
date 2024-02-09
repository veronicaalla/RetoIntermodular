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

import es.luisherrero.apirest1.model.Comentario;
import es.luisherrero.apirest1.repository.ComentarioRepository;


@RestController
@RequestMapping("/api/comentarios")
public class comentarioControlador {

    @Autowired
    private ComentarioRepository comentarioRepository;

    @GetMapping
    public List<Comentario> obtenerComentarios() {
        return comentarioRepository.findAll();
    }

    @GetMapping("/{id}")
    public Comentario obtenerComentarioPorId(@PathVariable int id) {
        return comentarioRepository.findById(id).orElse(null);
    }

    @PostMapping
    public Comentario crearComentario(@RequestBody Comentario nuevoComentario) {
        return comentarioRepository.save(nuevoComentario);
    }

    @PutMapping("/{id}")
    public Comentario actualizarComentario(@RequestBody Comentario comentarioEditado, @PathVariable int id) {
        if (comentarioRepository.existsById(id)) {
            comentarioEditado.setId(id);
            return comentarioRepository.save(comentarioEditado);
        } else {
            return null;
        }
    }

    @DeleteMapping("/{id}")
    public Comentario borrarComentario(@PathVariable int id) {
        if (comentarioRepository.existsById(id)) {
            Comentario comentario = comentarioRepository.findById(id).get();
            comentarioRepository.delete(comentario);
            return comentario;
        } else {
            return null;
        }
    }
}