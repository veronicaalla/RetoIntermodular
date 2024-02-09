package Repositorio;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import Modelo.Departamento;

public interface DepartamentoRepository extends JpaRepository<Departamento, Integer> {
    // Aquí puedes definir métodos adicionales para consultar la base de datos si lo deseas
}