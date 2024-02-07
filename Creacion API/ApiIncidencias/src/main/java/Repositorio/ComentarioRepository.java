package Repositorio;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import Modelo.Comentario;

public interface ComentarioRepository extends JpaRepository<Comentario, Integer> {
    // Aquí puedes definir métodos adicionales para consultar la base de datos si lo deseas
}
