package es.equipo2.apirest1.repository;

import org.springframework.data.jpa.repository.JpaRepository;

import es.equipo2.apirest1.model.Perfiles;

public interface PerfilesRepository extends JpaRepository<Perfiles, Integer> {
    // Aquí puedes definir métodos adicionales para consultar la base de datos si lo deseas
}
