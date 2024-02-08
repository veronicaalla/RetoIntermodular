package es.luisherrero.apirest1.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import es.luisherrero.apirest1.model.Departamento;

public interface DepartamentoRepository extends JpaRepository<Departamento, Integer>{

}
