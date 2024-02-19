package es.equipo2.apirest1.repository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import es.equipo2.apirest1.model.Perfiles;
import es.equipo2.apirest1.model.Tipo_Perfil;

public interface PerfilesRepository extends JpaRepository<Perfiles, Integer> {
	List<Perfiles> findByPerfil(Tipo_Perfil perfil);
	List<Perfiles> findByDominio(String dominio);
}
