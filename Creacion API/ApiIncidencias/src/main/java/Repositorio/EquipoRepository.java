package Repositorio;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import Modelo.Equipo;

public interface EquipoRepository extends JpaRepository<Equipo, Integer> {
    // Aquí puedes definir métodos adicionales para consultar la base de datos si lo deseas
}
