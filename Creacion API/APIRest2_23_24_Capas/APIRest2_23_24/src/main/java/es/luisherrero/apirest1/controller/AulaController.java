package es.luisherrero.apirest1.controller;

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
import org.springframework.web.bind.annotation.RestController;

import es.luisherrero.apirest1.model.Aula;
import es.luisherrero.apirest1.repository.AulaRepository;


@RestController
@RequestMapping("/api")
public class AulaController {
	@Autowired
	private AulaRepository cocheRepository;
	
	@GetMapping("/aula")
	public ResponseEntity<?> obtenerCoches(){
		List<Aula> coches=cocheRepository.findAll();
		if(coches.isEmpty())
			return ResponseEntity.notFound().build();
		else
			return ResponseEntity.ok(coches);
	}
	
	
	@GetMapping("/aula/{num}")
	public ResponseEntity<?> obtenerUno(@PathVariable Integer id)
	{
		Aula coche = cocheRepository.findById(id).orElse(null); 
		if(coche==null) 
			return ResponseEntity.notFound().build(); 
		else 
			return ResponseEntity.ok(coche);
	}
	
	@PostMapping("/aula")
	public ResponseEntity<Aula> nuevoCoche(@RequestBody Aula nuevo)
	{
		Aula cocheGuardado=cocheRepository.save(nuevo);
		return ResponseEntity
				.status(HttpStatus.CREATED)
				.body(cocheGuardado);
	}

	@PutMapping("/aula/{num}")
	public ResponseEntity<?> editarCoche(@RequestBody Aula cocheEdit, @PathVariable Integer id)
	{
		Aula coche = cocheRepository
				.findById(id).orElse(null); 
		if(coche==null) 
			return ResponseEntity.notFound().build(); 
		else {
			coche.setCodigo(cocheEdit.getCodigo());
			coche.setDescripcion(cocheEdit.getDescripcion());
			coche.setPlanta(cocheEdit.getPlanta());
			return ResponseEntity
					.ok(cocheRepository.save(coche));
		}
		   
	}

	@DeleteMapping("/aula/{num}")
	public ResponseEntity<?> borrarCoche(@PathVariable Integer id)
	{
		if(cocheRepository.existsById(id))
		{
			Aula coche = cocheRepository.findById(id).get();
			cocheRepository.delete(coche);
			return ResponseEntity.noContent().build();
		}
		else
		{
			return ResponseEntity.notFound().build();
		}
	}
	

}
