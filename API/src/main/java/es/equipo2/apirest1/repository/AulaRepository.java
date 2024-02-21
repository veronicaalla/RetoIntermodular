package es.equipo2.apirest1.repository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import es.equipo2.apirest1.model.Aula;

public interface AulaRepository extends JpaRepository<Aula, Integer>{
	List<Aula> findByPlanta(int planta);
}
