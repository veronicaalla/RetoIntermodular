package es.equipo2.apirest1.controller;

import java.sql.Date;
import java.sql.Time;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Example;
import org.springframework.data.domain.ExampleMatcher;
import org.springframework.data.domain.ExampleMatcher.StringMatcher;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import es.equipo2.apirest1.model.Estado_Incidencia;
import es.equipo2.apirest1.model.Incidencia;
import es.equipo2.apirest1.model.Personal;
import es.equipo2.apirest1.model.Tipo_Incidencias;
import es.equipo2.apirest1.repository.IncidenciaRepository;
import es.equipo2.apirest1.repository.PersonalRepository;
import jakarta.persistence.EntityManager;
import jakarta.persistence.EntityManagerFactory;
import jakarta.persistence.PersistenceContext;
import jakarta.persistence.PersistenceUnit;
import jakarta.persistence.criteria.CriteriaBuilder;
import jakarta.persistence.criteria.CriteriaQuery;
import jakarta.persistence.criteria.Predicate;
import jakarta.persistence.criteria.Root;


@RestController
@RequestMapping("/api/incidencias")
public class incidenciaControlador {
	
	@PersistenceUnit
    private EntityManagerFactory entityManagerFactory;
	 
    @Autowired
    private IncidenciaRepository incidenciaRepository;
    
    @Autowired
    private PersonalRepository personalRepository;

    @GetMapping
    public List<Incidencia> obtenerIncidencias() {
        return incidenciaRepository.findAll();
    }
    
    @GetMapping("/creador/{id}")
    public List<Incidencia> obtenerIncidenciasPorPersona(@PathVariable int id) {
        return incidenciaRepository.findByCreadorId(id);
    }
    
    @GetMapping("/responsable/{id}")
    public List<Incidencia> obtenerIncidenciasPorResponsable(@PathVariable int id) {
        return incidenciaRepository.findByresponsableId(id);
    }

    @GetMapping("/{num}")
    public Incidencia obtenerIncidenciaPorNumero(@PathVariable int num) {
        return incidenciaRepository.findById(num).orElse(null);
    }
    
    @GetMapping("/estado/{estado}")
    public List<Incidencia> buscarPorEstado(@PathVariable Estado_Incidencia estado) {
        return incidenciaRepository.findByEstado(estado);
    }
    
    @GetMapping("/tipo/{tipo}")
    public List<Incidencia> buscarPorTipo(@PathVariable Tipo_Incidencias tipo) {
        return incidenciaRepository.findByTipo(tipo);
    }
    
    @GetMapping("/fecha-creacion/{fechaCreacion}")
    public List<Incidencia> buscarPorFechaCreacion(@PathVariable String fechaCreacion) throws ParseException {
    	// Convertir el String de fecha a java.sql.Date
        SimpleDateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
        java.util.Date parsedDate = dateFormat.parse(fechaCreacion);
        Date fechaCreacionSql = new Date(parsedDate.getTime());

        // Llamar al método de búsqueda en el repositorio con la fecha convertida
        return incidenciaRepository.findByFechaCreacion(fechaCreacionSql);
    }
    
    @GetMapping("/fecha-cierre/{fechaCierre}")
    public List<Incidencia> buscarPorFechaCierre(@PathVariable String fechaCierre) throws ParseException {
    	// Convertir el String de fecha a java.sql.Date
        SimpleDateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
        java.util.Date parsedDate = dateFormat.parse(fechaCierre);
        Date fechaCierreSql = new Date(parsedDate.getTime());

        // Llamar al método de búsqueda en el repositorio con la fecha convertida
        return incidenciaRepository.findByFechaCierre(fechaCierreSql);
    }

    @GetMapping("/buscar")
    public List<Incidencia> buscarIncidencias(@RequestParam(required = false) String descripcion,
                                               @RequestParam(required = false) Estado_Incidencia estado,
                                               @RequestParam(required = false) Date fechaCreacion,
                                               @RequestParam(required = false) Date fechaCierre,
                                               @RequestParam(required = false) Tipo_Incidencias tipo,
                                               @RequestParam(required = false) Integer creadorId,
                                               @RequestParam(required = false) Integer responsableId) {

        // Obtener el EntityManager
        EntityManager entityManager = entityManagerFactory.createEntityManager();
        CriteriaBuilder builder = entityManager.getCriteriaBuilder();
        CriteriaQuery<Incidencia> criteriaQuery = builder.createQuery(Incidencia.class);
        Root<Incidencia> root = criteriaQuery.from(Incidencia.class);
        List<Predicate> predicates = new ArrayList<>();

        // Construir predicados basados en los parámetros proporcionados
        if (descripcion != null && !descripcion.isEmpty()) {
            predicates.add(builder.like(builder.lower(root.get("descripcion")), "%" + descripcion.toLowerCase() + "%"));
        }
        if (estado != null) {
            predicates.add(builder.equal(root.get("estado"), estado));
        }
        if (fechaCreacion != null) {
            predicates.add(builder.equal(root.get("fechaCreacion"), fechaCreacion));
        }
        if (fechaCierre != null) {
            predicates.add(builder.equal(root.get("fechaCierre"), fechaCierre));
        }
        if (tipo != null) {
            predicates.add(builder.equal(root.get("tipo"), tipo));
        }
        if (creadorId != null) {
            predicates.add(builder.equal(root.get("creador").get("id"), creadorId));
        }
        if (responsableId != null) {
            predicates.add(builder.equal(root.get("responsable").get("id"), responsableId));
        }

        // Agregar todos los predicados al criterio de consulta
        criteriaQuery.where(predicates.toArray(new Predicate[0]));

        // Ejecutar la consulta y devolver los resultados
        List<Incidencia> incidencias = entityManager.createQuery(criteriaQuery).getResultList();

        // Cerrar el EntityManager
        entityManager.close();

        return incidencias;
    }

    // Método para convertir una cadena de fecha en un objeto Date
    private Date parseFecha(String fechaStr) {
        try {
            SimpleDateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
            java.util.Date parsedDate = dateFormat.parse(fechaStr);
            return new Date(parsedDate.getTime());
        } catch (ParseException | NullPointerException e) {
            // Manejar la excepción si la cadena de fecha no tiene el formato correcto o es nula
            return null;
        }
    }

    
    @PostMapping
    public Incidencia nuevaIncidencia(@RequestBody Incidencia nuevaIncidencia) {
        return incidenciaRepository.save(nuevaIncidencia);
    }

    @PutMapping("/{num}")
    public Incidencia editarIncidencia(@RequestBody Incidencia incidenciaEditada, @PathVariable int num) {
        if (incidenciaRepository.findById(num).isPresent()) {
            incidenciaEditada.setNum(num);
            return incidenciaRepository.save(incidenciaEditada);
        } else {
            return null;
        }
    }

    @DeleteMapping("/{num}")
    public Incidencia borrarIncidencia(@PathVariable int num) {
        if (incidenciaRepository.findById(num).isPresent()) {
            Incidencia incidencia = incidenciaRepository.findById(num).get();
            incidenciaRepository.delete(incidencia);
            return incidencia;
        } else {
            return null;
        }
    }
}