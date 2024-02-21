package es.equipo2.apirest1.repository;

import org.springframework.data.jpa.repository.JpaRepository;

import es.equipo2.apirest1.model.Comentario;

public interface ComentarioRepository extends JpaRepository<Comentario, Integer>{

}
