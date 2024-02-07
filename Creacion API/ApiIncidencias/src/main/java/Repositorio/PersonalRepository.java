package Repositorio;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import Modelo.Personal;

public interface PersonalRepository extends JpaRepository<Personal, Integer> {
    // Aquí puedes definir métodos adicionales para consultar la base de datos si lo deseas
}
