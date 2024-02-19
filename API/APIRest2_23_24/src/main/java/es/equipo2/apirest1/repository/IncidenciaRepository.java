package es.equipo2.apirest1.repository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import es.equipo2.apirest1.model.Incidencia;
import es.equipo2.apirest1.model.Personal;

public interface IncidenciaRepository extends JpaRepository<Incidencia, Integer> {
	List<Incidencia> findByCreador(Personal creador);
}
