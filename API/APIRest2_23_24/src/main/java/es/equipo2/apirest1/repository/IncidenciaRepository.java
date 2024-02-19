package es.equipo2.apirest1.repository;

import java.sql.Date;
import java.sql.Time;
import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.repository.query.Param;
import org.springframework.web.bind.annotation.PathVariable;

import es.equipo2.apirest1.model.Estado_Incidencia;
import es.equipo2.apirest1.model.Incidencia;
import es.equipo2.apirest1.model.Personal;
import es.equipo2.apirest1.model.Tipo_Incidencias;

public interface IncidenciaRepository extends JpaRepository<Incidencia, Integer> {
	 List<Incidencia> findByCreadorId(int idPersonal);
	 List<Incidencia> findByresponsableId(int idPersonal);
	 List<Incidencia> findByEstado(Estado_Incidencia estado);
	 List<Incidencia> findByTipo(Tipo_Incidencias tipo);
	 List<Incidencia> findByFechaCreacion(Date fechaCreacion);
	 List<Incidencia> findByFechaCierre(Date fechaCreacion);
	 
	 List<Incidencia> findByDescripcionContainingAndEstadoAndFechaCreacionAndFechaCierreAndTipoAndCreadorIdAndResponsableId(String descripcion, Estado_Incidencia estado, Date fechaCreacion, Date fechaCierre, Tipo_Incidencias tipo, Integer creadorId, Integer responsableId);
}
