package es.equipo2.apirest1.repository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import es.equipo2.apirest1.model.Personal;

public interface PersonalRepository extends JpaRepository<Personal, Integer>{

	List<Personal> findByNombre(String nombre);

	List<Personal> findByApellido1(String apellido);

	List<Personal> findByApellido2(String apellido);
	
}
