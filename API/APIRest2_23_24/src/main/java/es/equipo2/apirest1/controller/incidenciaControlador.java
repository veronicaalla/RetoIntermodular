package es.equipo2.apirest1.controller;

import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.util.List;
import java.sql.Date;
import java.sql.Time;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;

import org.apache.poi.ss.usermodel.*;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;
import org.springframework.http.HttpHeaders;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Example;
import org.springframework.data.domain.ExampleMatcher;
import org.springframework.data.domain.ExampleMatcher.StringMatcher;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestParam;

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
    
    @GetMapping("/excel")
    public ResponseEntity<byte[]> exportarExcel() {
    	List<Incidencia> incidencias = incidenciaRepository.findAll();

        try (Workbook workbook = new XSSFWorkbook(); ByteArrayOutputStream baos = new ByteArrayOutputStream()) {
            Sheet sheet = workbook.createSheet("Incidencias");
            Row headerRow = sheet.createRow(0);
            headerRow.createCell(0).setCellValue("Número");
            headerRow.createCell(1).setCellValue("Descripción");
            headerRow.createCell(2).setCellValue("Estado");
            headerRow.createCell(3).setCellValue("Fecha Creación");
            headerRow.createCell(4).setCellValue("Fecha Cierre");
            headerRow.createCell(5).setCellValue("Tipo");
            headerRow.createCell(6).setCellValue("Subtipo ID");
            headerRow.createCell(7).setCellValue("Adjunto URL");
            headerRow.createCell(8).setCellValue("Creador ID");
            headerRow.createCell(9).setCellValue("Responsable ID");
            headerRow.createCell(10).setCellValue("Equipo ID");
            headerRow.createCell(11).setCellValue("Tiempo Dec");

            int rowNum = 1;
            for (Incidencia incidencia : incidencias) {
                Row row = sheet.createRow(rowNum++);
                row.createCell(0).setCellValue(incidencia.getNum());
                row.createCell(1).setCellValue(incidencia.getDescripcion());
                row.createCell(2).setCellValue(incidencia.getEstado().toString());
                row.createCell(3).setCellValue(incidencia.getFechaCreacion().toString());
                if (incidencia.getFechaCierre() != null) {
                    row.createCell(4).setCellValue(incidencia.getFechaCierre().toString());
                } else {
                    row.createCell(4).setCellValue(""); // Opcional: puedes establecer un valor predeterminado
                }
                row.createCell(5).setCellValue(incidencia.getTipo().toString());
                row.createCell(6).setCellValue(incidencia.getIncidenciasSubtipo().getId());
                row.createCell(7).setCellValue(incidencia.getAdjuntoUrl());
                row.createCell(8).setCellValue(incidencia.getCreador().getId());
                row.createCell(9).setCellValue(incidencia.getResponsable().getId());
                if (incidencia.getEquipo() != null) {
                    row.createCell(10).setCellValue(incidencia.getEquipo().getId());
                } else {
                    row.createCell(10).setCellValue(""); // Opcional: puedes establecer un valor predeterminado
                }
                if (incidencia.getTiempo_dec() != null) {
                    row.createCell(11).setCellValue(incidencia.getTiempo_dec().toString());
                } else {
                    row.createCell(11).setCellValue(""); // Opcional: puedes establecer un valor predeterminado
                }
            }

            workbook.write(baos);
            HttpHeaders headers = new HttpHeaders();
            headers.setContentType(MediaType.APPLICATION_OCTET_STREAM);
            headers.setContentDispositionFormData("filename", "incidencias.xlsx");
            headers.setContentLength(baos.size());

            return new ResponseEntity<>(baos.toByteArray(), headers, HttpStatus.OK);
        } catch (IOException e) {
            e.printStackTrace();
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }

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