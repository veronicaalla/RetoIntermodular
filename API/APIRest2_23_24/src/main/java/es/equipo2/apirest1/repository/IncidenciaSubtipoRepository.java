package es.equipo2.apirest1.repository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import es.equipo2.apirest1.model.IncidenciasSubtipo;
import es.equipo2.apirest1.model.Tipo_Incidencias;

public interface IncidenciaSubtipoRepository extends JpaRepository<IncidenciasSubtipo, Integer> {
	List<IncidenciasSubtipo> findByTipo(Tipo_Incidencias tipo);
}
