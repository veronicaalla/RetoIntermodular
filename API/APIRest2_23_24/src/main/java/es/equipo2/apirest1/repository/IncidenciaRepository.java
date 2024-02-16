package es.equipo2.apirest1.repository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

<<<<<<< HEAD:API/APIRest2_23_24/src/main/java/es/luisherrero/apirest1/repository/IncidenciaRepository.java
import es.luisherrero.apirest1.model.Incidencia;
import es.luisherrero.apirest1.model.Personal;
=======
import es.equipo2.apirest1.model.Incidencia;
>>>>>>> main:API/APIRest2_23_24/src/main/java/es/equipo2/apirest1/repository/IncidenciaRepository.java

public interface IncidenciaRepository extends JpaRepository<Incidencia, Integer> {
	List<Incidencia> findByCreador(Personal creador);
}
