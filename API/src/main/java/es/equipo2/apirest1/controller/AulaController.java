package es.equipo2.apirest1.controller;

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
import org.springframework.web.bind.annotation.RestController;

import es.equipo2.apirest1.model.Aula;
import es.equipo2.apirest1.repository.AulaRepository;


@RestController
@RequestMapping("/api/aula")
public class AulaController {
	@Autowired
    private AulaRepository aulaRepository;
		
	@GetMapping
    public List<Aula> obtenerAulas() {
        return aulaRepository.findAll();
    }

    @GetMapping("/{num}")
    public Aula obtenerAulaPorNum(@PathVariable Integer num) {
        return aulaRepository.findById(num).orElse(null);
    }
	
	@GetMapping("/planta/{planta}")
    public List<Aula> obtenerAulasPorPlanta(@PathVariable int planta) {
        return aulaRepository.findByPlanta(planta);
    }
	
	@PostMapping("/aula")
	public ResponseEntity<Aula> nuevoCoche(@RequestBody Aula nuevo)
	{
		Aula cocheGuardado=aulaRepository.save(nuevo);
		return ResponseEntity
				.status(HttpStatus.CREATED)
				.body(cocheGuardado);
	}

	@PostMapping
    public ResponseEntity<Aula> crearAula(@RequestBody Aula nuevaAula) {
        return ResponseEntity.status(HttpStatus.CREATED).body(aulaRepository.save(nuevaAula));
    }

    @PutMapping("/{num}")
    public ResponseEntity<Aula> actualizarAula(@RequestBody Aula aulaEditada, @PathVariable Integer num) {
        return aulaRepository.findById(num)
                .map(aula -> {
                    aula.setCodigo(aulaEditada.getCodigo());
                    aula.setDescripcion(aulaEditada.getDescripcion());
                    aula.setPlanta(aulaEditada.getPlanta());
                    return ResponseEntity.ok(aulaRepository.save(aula));
                })
                .orElse(ResponseEntity.notFound().build());
    }

    @DeleteMapping("/{num}")
    public ResponseEntity<Void> borrarAula(@PathVariable Integer num) {
        if (aulaRepository.existsById(num)) {
            aulaRepository.deleteById(num);
            return ResponseEntity.noContent().build();
        } else {
            return ResponseEntity.notFound().build();
        }
    }
	

}
