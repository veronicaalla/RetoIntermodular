package es.luisherrero.apirest1.repository;

import org.springframework.data.jpa.repository.JpaRepository;

import es.luisherrero.apirest1.model.IncidenciasSubtipo;

public interface IncidenciaSubtipoRepository extends JpaRepository<IncidenciasSubtipo, Integer> {
    // Aquí puedes definir métodos adicionales para consultar la base de datos si lo deseas
}
