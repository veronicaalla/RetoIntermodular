package Repositorio;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import Modelo.IncidenciasSubtipo;

public interface IncidenciaSubtipoRepository extends JpaRepository<IncidenciasSubtipo, Integer> {
    // Aquí puedes definir métodos adicionales para consultar la base de datos si lo deseas
}
