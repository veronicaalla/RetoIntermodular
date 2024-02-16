package es.equipo2.apirest1.repository;

import org.springframework.data.jpa.repository.JpaRepository;

import es.equipo2.apirest1.model.Personal;

public interface PersonalRepository extends JpaRepository<Personal, Integer>{
	Personal findByNombre(String nombre);
}
