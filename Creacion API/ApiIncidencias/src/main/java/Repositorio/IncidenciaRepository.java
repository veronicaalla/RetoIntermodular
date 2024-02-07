package Repositorio;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import Modelo.Incidencia;

public interface IncidenciaRepository extends JpaRepository<Incidencia, Integer> {
    // Aquí puedes definir métodos adicionales para consultar la base de datos si lo deseas
}
