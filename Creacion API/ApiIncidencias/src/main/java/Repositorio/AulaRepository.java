package Repositorio;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import Modelo.Aula;

public interface AulaRepository extends JpaRepository<Aula, Integer> {
    // Aquí puedes definir métodos adicionales para consultar la base de datos si lo deseas
}
