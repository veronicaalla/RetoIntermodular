package Repositorio;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import Modelo.Perfiles;

public interface PerfilesRepository extends JpaRepository<Perfiles, Integer> {
    // Aquí puedes definir métodos adicionales para consultar la base de datos si lo deseas
}
