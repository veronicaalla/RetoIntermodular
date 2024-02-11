package es.equipo2.apirest1.repository;

import org.springframework.data.jpa.repository.JpaRepository;

import es.equipo2.apirest1.model.Incidencia;

public interface IncidenciaRepository extends JpaRepository<Incidencia, Integer> {
    // Aquí puedes definir métodos adicionales para consultar la base de datos si lo deseas
}
