package es.luisherrero.apirest1.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import es.luisherrero.apirest1.model.Personal;

public interface PersonalRepository extends JpaRepository<Personal, Integer>{

}
