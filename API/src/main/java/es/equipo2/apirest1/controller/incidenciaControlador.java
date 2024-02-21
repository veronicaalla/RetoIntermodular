package es.equipo2.apirest1.controller;

import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.List;
import java.util.Map;
import java.util.stream.Collectors;
import java.sql.Date;
import java.sql.Time;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.time.Duration;
import java.time.LocalTime;
import java.util.ArrayList;
import java.util.Base64;
import java.util.HashMap;

import org.apache.commons.io.IOUtils;
import org.apache.pdfbox.pdmodel.PDDocument;
import org.apache.pdfbox.pdmodel.PDPage;
import org.apache.pdfbox.pdmodel.PDPageContentStream;
import org.apache.pdfbox.pdmodel.common.PDRectangle;
import org.apache.pdfbox.pdmodel.font.PDType1Font;
import org.apache.poi.ss.usermodel.*;
import org.apache.poi.ss.util.CellRangeAddress;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;
import org.springframework.http.HttpHeaders;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.core.io.ByteArrayResource;
import org.springframework.core.io.Resource;
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
        List<Incidencia> incidencias = incidenciaRepository.findAll();
        return incidencias;
    }
    
    @GetMapping("ficheroPorId/{id}")
    public ResponseEntity<Resource> obtenerIncidenciaPorId(@PathVariable int id) {
    	// Buscar la incidencia por su ID
        Incidencia incidencia = incidenciaRepository.findById(id).orElse(null);

        if (incidencia != null) {
            String adjuntoUrl = incidencia.getAdjuntoUrl();

            if (adjuntoUrl != null && !adjuntoUrl.isEmpty()) {
                try {
                    // Decodificar Base64 a bytes
                    byte[] adjuntoData = Base64.getDecoder().decode(adjuntoUrl.substring(0, adjuntoUrl.lastIndexOf(".")));

                    // Definir los headers de respuesta para indicar la descarga del archivo
                    HttpHeaders headers = new HttpHeaders();
                    headers.setContentType(MediaType.APPLICATION_OCTET_STREAM);
                    headers.setContentDispositionFormData("attachment", "archivo" + adjuntoUrl.substring(adjuntoUrl.lastIndexOf(".")));

                    // Devolver los datos decodificados como un archivo binario
                    ByteArrayResource resource = new ByteArrayResource(adjuntoData);
                    return ResponseEntity.ok()
                            .headers(headers)
                            .body(resource);
                } catch (IllegalArgumentException e) {
                    e.printStackTrace();
                    // Manejar el error si la decodificación falla
                    return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body(null);
                }
            }
        }

        // Si no se encuentra la incidencia o el campo adjuntoUrl está vacío, devolver un error
        return ResponseEntity.status(HttpStatus.NOT_FOUND).body(null);
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
            headerRow.createCell(11).setCellValue("Tiempo Dedicado");

         // Crear un mapa para almacenar los nombres completos de los creadores y responsables por ID
            Map<Integer, String> nombresCompletos = obtenerNombresCompletos();
            
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
                row.createCell(8).setCellValue(nombresCompletos.get(incidencia.getCreador().getId()));
                row.createCell(9).setCellValue(nombresCompletos.get(incidencia.getResponsable().getId()));
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
    
    @GetMapping("/excelAdministrador")
    public ResponseEntity<byte[]> exportarExcel(@RequestParam int idAdministrador) {
        // Buscar todas las incidencias resueltas por el administrador específico
        List<Incidencia> incidencias = incidenciaRepository.findByResponsableIdAndEstado(idAdministrador, Estado_Incidencia.resuelta);

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
            headerRow.createCell(8).setCellValue("Creador");
            headerRow.createCell(9).setCellValue("Responsable");
            headerRow.createCell(10).setCellValue("Equipo ID");
            headerRow.createCell(11).setCellValue("Tiempo Dedicado");

            // Crear un mapa para almacenar los nombres completos de los creadores y responsables por ID
            Map<Integer, String> nombresCompletos = obtenerNombresCompletos();

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
                row.createCell(8).setCellValue(nombresCompletos.get(incidencia.getCreador().getId()));
                row.createCell(9).setCellValue(nombresCompletos.get(incidencia.getResponsable().getId()));
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

    // Método para obtener los nombres completos de los creadores y responsables
    private Map<Integer, String> obtenerNombresCompletos() {
        List<Personal> personas = personalRepository.findAll();
        Map<Integer, String> nombresCompletos = new HashMap<>();
        for (Personal persona : personas) {
            String nombreCompleto = persona.getNombre() + " " + persona.getApellido1() + " " + persona.getApellido2();
            nombresCompletos.put(persona.getId(), nombreCompleto);
        }
        return nombresCompletos;
    }

    @GetMapping("/excelAbiertasPorCreador")
    public ResponseEntity<byte[]> exportarExcelAbiertasPorCreador(@RequestParam int idCreador) {
        List<Incidencia> incidenciasAbiertasPorCreador = incidenciaRepository.findByEstadoAndCreadorId(Estado_Incidencia.abierta, idCreador);

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
            headerRow.createCell(11).setCellValue("Tiempo Dedicado");

            // Crear un mapa para almacenar los nombres completos de los creadores y responsables por ID
            Map<Integer, String> nombresCompletos = obtenerNombresCompletos();

            int rowNum = 1;
            for (Incidencia incidencia : incidenciasAbiertasPorCreador) {
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
                row.createCell(8).setCellValue(nombresCompletos.get(incidencia.getCreador().getId()));
                row.createCell(9).setCellValue(nombresCompletos.get(incidencia.getResponsable().getId()));
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
            headers.setContentDispositionFormData("filename", "incidencias_por_creador.xlsx");
            headers.setContentLength(baos.size());

            return new ResponseEntity<>(baos.toByteArray(), headers, HttpStatus.OK);
        } catch (IOException e) {
            e.printStackTrace();
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }



    @GetMapping("/excelTiempoPorAdmin")
    public ResponseEntity<byte[]> exportarExcelTiempoPorAdmin() {
        List<Incidencia> incidencias = incidenciaRepository.findAll();

        try (Workbook workbook = new XSSFWorkbook(); ByteArrayOutputStream baos = new ByteArrayOutputStream()) {
            Sheet sheet = workbook.createSheet("Incidencias");
            Row headerRow = sheet.createRow(0);
            headerRow.createCell(0).setCellValue("Responsable");
            headerRow.createCell(1).setCellValue("Suma de Tiempo Dedicado");

            // Agrupar incidencias por responsable y calcular la suma de Tiempo Dec
            Map<Personal, Duration> tiemposPorResponsable = new HashMap<>();
            for (Incidencia incidencia : incidencias) {
                Personal responsable = incidencia.getResponsable();
                Duration tiempoDec = incidencia.getTiempo_dec() != null ? Duration.ofHours(incidencia.getTiempo_dec().getHours()).plusMinutes(incidencia.getTiempo_dec().getMinutes()) : Duration.ZERO;
                tiemposPorResponsable.merge(responsable, tiempoDec, Duration::plus);
            }

            // Escribir los resultados en el Excel
            int rowNum = 1;
            for (Map.Entry<Personal, Duration> entry : tiemposPorResponsable.entrySet()) {
                Row row = sheet.createRow(rowNum++);
                row.createCell(0).setCellValue(entry.getKey().getNombre() + " " + entry.getKey().getApellido1() + " " + entry.getKey().getApellido2());
                row.createCell(1).setCellValue(entry.getValue().toString());
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
    
    @GetMapping("/excel/tiempoMedioPorTipo")
    public ResponseEntity<byte[]> exportarExcelTiempoMedioPorTipo() {
        // Obtener todas las incidencias
        List<Incidencia> incidencias = incidenciaRepository.findAll();

        // Agrupar incidencias por tipo
        Map<Tipo_Incidencias, List<Incidencia>> incidenciasPorTipo = new HashMap<>();
        for (Incidencia incidencia : incidencias) {
        	Tipo_Incidencias tipo = incidencia.getTipo();
            incidenciasPorTipo.computeIfAbsent(tipo, k -> new ArrayList<>()).add(incidencia);
        }

        // Calcular el tiempo medio dedicado para cada tipo de incidencia
        Map<Tipo_Incidencias, Time> tiempoMedioPorTipo = new HashMap<>();
        for (Map.Entry<Tipo_Incidencias, List<Incidencia>> entry : incidenciasPorTipo.entrySet()) {
        	Tipo_Incidencias tipo = entry.getKey();
            List<Incidencia> incidenciasTipo = entry.getValue();
            long totalMilliseconds = 0;
            long count = 0;
            for (Incidencia incidencia : incidenciasTipo) {
                Time tiempoDec = incidencia.getTiempo_dec();
                if (tiempoDec != null) {
                    totalMilliseconds += tiempoDec.getTime();
                    count++;
                }
            }
            if (count != 0) {
                long tiempoMedioMillis = totalMilliseconds / count;
                Time tiempoMedio = new Time(tiempoMedioMillis);
                tiempoMedioPorTipo.put(tipo, tiempoMedio);
            }
        }

        // Crear el libro de trabajo Excel
        try (Workbook workbook = new XSSFWorkbook(); ByteArrayOutputStream baos = new ByteArrayOutputStream()) {
            Sheet sheet = workbook.createSheet("Tiempo Medio Por Tipo de Incidencia");

            // Escribir los encabezados
            Row headerRow = sheet.createRow(0);
            headerRow.createCell(0).setCellValue("Tipo de Incidencia");
            headerRow.createCell(1).setCellValue("Tiempo Medio Dedicado");

            // Escribir los datos
            int rowNum = 1;
            for (Map.Entry<Tipo_Incidencias, Time> entry : tiempoMedioPorTipo.entrySet()) {
                Row row = sheet.createRow(rowNum++);
                row.createCell(0).setCellValue(entry.getKey().toString());
                row.createCell(1).setCellValue(entry.getValue().toString());
            }

            // Guardar el libro de trabajo en el flujo de bytes
            workbook.write(baos);

            // Configurar encabezados de respuesta
            HttpHeaders headers = new HttpHeaders();
            headers.setContentType(MediaType.APPLICATION_OCTET_STREAM);
            headers.setContentDispositionFormData("filename", "tiempo_medio_por_tipo.xlsx");
            headers.setContentLength(baos.size());

            // Devolver la respuesta con el archivo Excel
            return new ResponseEntity<>(baos.toByteArray(), headers, HttpStatus.OK);
        } catch (IOException e) {
            e.printStackTrace();
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }

    @GetMapping("/excelEstadisticas")
    public ResponseEntity<byte[]> exportarExcelEstadisticas() {
        List<Incidencia> incidencias = incidenciaRepository.findAll();
        
        try (Workbook workbook = new XSSFWorkbook(); ByteArrayOutputStream baos = new ByteArrayOutputStream()) {
            Sheet sheet = workbook.createSheet("Incidencias");
            
            // Crear una fila para el encabezado
            Row headerRow = sheet.createRow(0);
            headerRow.createCell(0).setCellValue("Tipo de Incidencia");
            headerRow.createCell(1).setCellValue("Porcentaje de Aparición");
            
            // Contar la cantidad total de incidencias
            int totalIncidencias = incidencias.size();
            
            // Crear un mapa para almacenar la cantidad de incidencias por tipo
            Map<Tipo_Incidencias, Integer> incidenciasPorTipo = new HashMap<>();
            for (Incidencia incidencia : incidencias) {
            	Tipo_Incidencias tipo = incidencia.getTipo();
                incidenciasPorTipo.put(tipo, incidenciasPorTipo.getOrDefault(tipo, 0) + 1);
            }
            
            // Crear las celdas con el tipo de incidencia y el porcentaje de aparición
            int rowNum = 1;
            for (Map.Entry<Tipo_Incidencias, Integer> entry : incidenciasPorTipo.entrySet()) {
                Row row = sheet.createRow(rowNum++);
                row.createCell(0).setCellValue(entry.getKey().toString());
                double porcentaje = (double) entry.getValue() / totalIncidencias * 100;
                row.createCell(1).setCellValue(String.format("%.2f%%", porcentaje));
            }
            
            // Ajustar el tamaño de las columnas para que se ajusten al contenido
            sheet.autoSizeColumn(0);
            sheet.autoSizeColumn(1);
            
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
    
    @GetMapping("/excelTiempoIncidencia")
    public ResponseEntity<byte[]> exportarExcelTiempoIncidencia() {
        List<Incidencia> incidencias = incidenciaRepository.findAll();
        
        try (Workbook workbook = new XSSFWorkbook(); ByteArrayOutputStream baos = new ByteArrayOutputStream()) {
            Sheet sheet = workbook.createSheet("Incidencias");
            
            // Crear una fila para el encabezado
            Row headerRow = sheet.createRow(0);
            headerRow.createCell(0).setCellValue("Número de Incidencia");
            headerRow.createCell(1).setCellValue("Tiempo Dedicado");
            
            // Crear las celdas con el número de la incidencia y su tiempo dedicado
            int rowNum = 1;
            for (Incidencia incidencia : incidencias) {
                Row row = sheet.createRow(rowNum++);
                row.createCell(0).setCellValue(incidencia.getNum());
                row.createCell(1).setCellValue(incidencia.getTiempo_dec() != null ? incidencia.getTiempo_dec().toString() : "");
            }
            
            // Ajustar el tamaño de las columnas para que se ajusten al contenido
            sheet.autoSizeColumn(0);
            sheet.autoSizeColumn(1);
            
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

    @GetMapping("/pdf")
    public ResponseEntity<byte[]> exportarPdf() {
        List<Incidencia> incidencias = incidenciaRepository.findAll();
        Map<Integer, String> nombresCompletos = obtenerNombresCompletos();

        try (ByteArrayOutputStream baos = new ByteArrayOutputStream();
             PDDocument document = new PDDocument()) {
            PDPage page = new PDPage();
            // Hacer la hoja más ancha (por ejemplo, 1000 puntos de ancho)
            page.setMediaBox(new PDRectangle(1250, 600)); // Cambiar el tamaño según tus necesidades
            document.addPage(page);

            PDPageContentStream contentStream = new PDPageContentStream(document, page);

            // Establecer la posición inicial para escribir en el PDF
            float x = 50; // Margen izquierdo
            float y = page.getMediaBox().getHeight() - 50; // Margen superior

            // Escribir cabeceras
            contentStream.beginText();
            contentStream.setFont(PDType1Font.HELVETICA_BOLD, 10);
            contentStream.newLineAtOffset(x, y);
            contentStream.showText("Número");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Descripción");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Estado");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Fecha Creación");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Fecha Cierre");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Tipo");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Subtipo ID");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Adjunto URL");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Creador");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Responsable");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Equipo ID");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Tiempo Dedicado");
            contentStream.endText();

            // Escribir datos de incidencias
            y -= 20;
            for (Incidencia incidencia : incidencias) {
                contentStream.beginText();
                contentStream.setFont(PDType1Font.HELVETICA, 6);
                contentStream.newLineAtOffset(x, y);

                // Comprobar y escribir cada valor
                contentStream.showText(incidencia.getNum() != 0 ? String.valueOf(incidencia.getNum()) : "");
                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(incidencia.getDescripcion() != null ? incidencia.getDescripcion() : "");
                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(incidencia.getEstado() != null ? incidencia.getEstado().toString() : "");
                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(incidencia.getFechaCreacion() != null ? incidencia.getFechaCreacion().toString() : "");
                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(incidencia.getFechaCierre() != null ? incidencia.getFechaCierre().toString() : "");
                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(incidencia.getTipo() != null ? incidencia.getTipo().toString() : "");
                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(incidencia.getIncidenciasSubtipo() != null ? String.valueOf(incidencia.getIncidenciasSubtipo().getId()) : "");
                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(incidencia.getAdjuntoUrl() != null ? incidencia.getAdjuntoUrl() : "");

                // Obtener nombres completos del creador y el responsable
                String nombreCreador = nombresCompletos.getOrDefault(incidencia.getCreador().getId(), "");
                String nombreResponsable = nombresCompletos.getOrDefault(incidencia.getResponsable().getId(), "");

                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(nombreCreador);
                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(nombreResponsable);

                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(incidencia.getEquipo() != null ? String.valueOf(incidencia.getEquipo().getId()) : "");
                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(incidencia.getTiempo_dec() != null ? incidencia.getTiempo_dec().toString() : "");

                contentStream.endText();
                y -= 20;
            }

            contentStream.close();

            document.save(baos);

            HttpHeaders headers = new HttpHeaders();
            headers.setContentType(MediaType.APPLICATION_PDF);
            headers.setContentDispositionFormData("filename", "incidencias.pdf");
            headers.setContentLength(baos.size());

            return new ResponseEntity<>(baos.toByteArray(), headers, HttpStatus.OK);
        } catch (IOException e) {
            e.printStackTrace();
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }

    @GetMapping("/pdfAdministrador")
    public ResponseEntity<byte[]> exportarPdfAdministrador(@RequestParam int idAdministrador) {
        // Buscar todas las incidencias resueltas por el administrador específico
        List<Incidencia> incidencias = incidenciaRepository.findByResponsableIdAndEstado(idAdministrador, Estado_Incidencia.resuelta);
        Map<Integer, String> nombresCompletos = obtenerNombresCompletos();

        try (ByteArrayOutputStream baos = new ByteArrayOutputStream();
             PDDocument document = new PDDocument()) {
            PDPage page = new PDPage();
            // Hacer la hoja más ancha (por ejemplo, 1000 puntos de ancho)
            page.setMediaBox(new PDRectangle(1250, 600)); // Cambiar el tamaño según tus necesidades
            document.addPage(page);

            PDPageContentStream contentStream = new PDPageContentStream(document, page);

            // Establecer la posición inicial para escribir en el PDF
            float x = 50; // Margen izquierdo
            float y = page.getMediaBox().getHeight() - 50; // Margen superior

            // Escribir cabeceras
            contentStream.beginText();
            contentStream.setFont(PDType1Font.HELVETICA_BOLD, 10);
            contentStream.newLineAtOffset(x, y);
            contentStream.showText("Número");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Descripción");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Estado");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Fecha Creación");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Fecha Cierre");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Tipo");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Subtipo ID");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Adjunto URL");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Creador");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Responsable");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Equipo ID");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Tiempo Dedicado");
            contentStream.endText();

            // Escribir datos de incidencias
            y -= 20;
            for (Incidencia incidencia : incidencias) {
                contentStream.beginText();
                contentStream.setFont(PDType1Font.HELVETICA, 6);
                contentStream.newLineAtOffset(x, y);

                // Comprobar y escribir cada valor
                contentStream.showText(incidencia.getNum() != 0 ? String.valueOf(incidencia.getNum()) : "");
                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(incidencia.getDescripcion() != null ? incidencia.getDescripcion() : "");
                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(incidencia.getEstado() != null ? incidencia.getEstado().toString() : "");
                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(incidencia.getFechaCreacion() != null ? incidencia.getFechaCreacion().toString() : "");
                if (incidencia.getFechaCierre() != null) {
                    contentStream.newLineAtOffset(100, 0);
                    contentStream.showText(incidencia.getFechaCierre().toString());
                }
                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(incidencia.getTipo() != null ? incidencia.getTipo().toString() : "");
                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(incidencia.getIncidenciasSubtipo() != null ? String.valueOf(incidencia.getIncidenciasSubtipo().getId()) : "");
                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(incidencia.getAdjuntoUrl() != null ? incidencia.getAdjuntoUrl() : "");

                // Obtener nombres completos del creador y el responsable
                String nombreCreador = nombresCompletos.getOrDefault(incidencia.getCreador().getId(), "");
                String nombreResponsable = nombresCompletos.getOrDefault(incidencia.getResponsable().getId(), "");

                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(nombreCreador);
                contentStream.newLineAtOffset
                (100, 0);
                contentStream.showText(nombreResponsable);

                if (incidencia.getEquipo() != null) {
                    contentStream.newLineAtOffset(100, 0);
                    contentStream.showText(String.valueOf(incidencia.getEquipo().getId()));
                }
                if (incidencia.getTiempo_dec() != null) {
                    contentStream.newLineAtOffset(100, 0);
                    contentStream.showText(incidencia.getTiempo_dec().toString());
                }
                
                contentStream.endText();
                y -= 20;
            }

            contentStream.close();

            document.save(baos);

            HttpHeaders headers = new HttpHeaders();
            headers.setContentType(MediaType.APPLICATION_PDF);
            headers.setContentDispositionFormData("filename", "incidencias.pdf");
            headers.setContentLength(baos.size());

            return new ResponseEntity<>(baos.toByteArray(), headers, HttpStatus.OK);
        } catch (IOException e) {
            e.printStackTrace();
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }
    
    @GetMapping("/pdfAbiertasPorCreador")
    public ResponseEntity<byte[]> exportarPdfAbiertasPorCreador(@RequestParam int idCreador) {
        List<Incidencia> incidenciasAbiertasPorCreador = incidenciaRepository.findByEstadoAndCreadorId(Estado_Incidencia.abierta, idCreador);
        Map<Integer, String> nombresCompletos = obtenerNombresCompletos();

        try (ByteArrayOutputStream baos = new ByteArrayOutputStream();
             PDDocument document = new PDDocument()) {
            PDPage page = new PDPage();
            page.setMediaBox(new PDRectangle(1250, 600)); // Ancho de la página
            document.addPage(page);

            PDPageContentStream contentStream = new PDPageContentStream(document, page);

            float x = 50; // Margen izquierdo
            float y = page.getMediaBox().getHeight() - 50; // Margen superior

            contentStream.beginText();
            contentStream.setFont(PDType1Font.HELVETICA_BOLD, 10);
            contentStream.newLineAtOffset(x, y);
            contentStream.showText("Número");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Descripción");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Estado");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Fecha Creación");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Fecha Cierre");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Tipo");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Subtipo ID");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Adjunto URL");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Creador");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Responsable");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Equipo ID");
            contentStream.newLineAtOffset(100, 0);
            contentStream.showText("Tiempo Dedicado");
            contentStream.endText();

            y -= 20;
            for (Incidencia incidencia : incidenciasAbiertasPorCreador) {
                contentStream.beginText();
                contentStream.setFont(PDType1Font.HELVETICA, 6);
                contentStream.newLineAtOffset(x, y);

                contentStream.showText(incidencia.getNum() != 0 ? String.valueOf(incidencia.getNum()) : "");
                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(incidencia.getDescripcion() != null ? incidencia.getDescripcion() : "");
                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(incidencia.getEstado() != null ? incidencia.getEstado().toString() : "");
                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(incidencia.getFechaCreacion() != null ? incidencia.getFechaCreacion().toString() : "");
                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(incidencia.getFechaCierre() != null ? incidencia.getFechaCierre().toString() : "");
                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(incidencia.getTipo() != null ? incidencia.getTipo().toString() : "");
                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(incidencia.getIncidenciasSubtipo() != null ? String.valueOf(incidencia.getIncidenciasSubtipo().getId()) : "");
                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(incidencia.getAdjuntoUrl() != null ? incidencia.getAdjuntoUrl() : "");

                String nombreCreador = nombresCompletos.getOrDefault(incidencia.getCreador().getId(), "");
                String nombreResponsable = nombresCompletos.getOrDefault(incidencia.getResponsable().getId(), "");

                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(nombreCreador);
                contentStream.newLineAtOffset(100, 0);
                contentStream.showText(nombreResponsable);

                if (incidencia.getEquipo() != null) {
                    contentStream.newLineAtOffset(100, 0);
                    contentStream.showText(String.valueOf(incidencia.getEquipo().getId()));
                }
                if (incidencia.getTiempo_dec() != null) {
                    contentStream.newLineAtOffset(100, 0);
                    contentStream.showText(incidencia.getTiempo_dec().toString());
                }
                
                contentStream.endText();
                y -= 20;
            }

            contentStream.close();

            document.save(baos);

            HttpHeaders headers = new HttpHeaders();
            headers.setContentType(MediaType.APPLICATION_PDF);
            headers.setContentDispositionFormData("filename", "incidencias_abiertas_por_creador.pdf");
            headers.setContentLength(baos.size());

            return new ResponseEntity<>(baos.toByteArray(), headers, HttpStatus.OK);
        } catch (IOException e) {
            e.printStackTrace();
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }

    @GetMapping("/pdfTiempoPorAdmin")
    public ResponseEntity<byte[]> exportarPdfTiempoPorAdmin() {
        List<Incidencia> incidencias = incidenciaRepository.findAll();

        try (ByteArrayOutputStream baos = new ByteArrayOutputStream();
             PDDocument document = new PDDocument()) {
            PDPage page = new PDPage();
            document.addPage(page);

            PDPageContentStream contentStream = new PDPageContentStream(document, page);

            float x = 50; // Margen izquierdo
            float y = page.getMediaBox().getHeight() - 50; // Margen superior

            contentStream.beginText();
            contentStream.setFont(PDType1Font.HELVETICA_BOLD, 10);
            contentStream.newLineAtOffset(x, y);
            contentStream.showText("Responsable");
            contentStream.newLineAtOffset(200, 0);
            contentStream.showText("Suma de Tiempo Dedicado");
            contentStream.endText();

            // Agrupar incidencias por responsable y calcular la suma de Tiempo Dec
            Map<Personal, Duration> tiemposPorResponsable = new HashMap<>();
            for (Incidencia incidencia : incidencias) {
                Personal responsable = incidencia.getResponsable();
                Duration tiempoDec = incidencia.getTiempo_dec() != null ? Duration.ofHours(incidencia.getTiempo_dec().getHours()).plusMinutes(incidencia.getTiempo_dec().getMinutes()) : Duration.ZERO;
                tiemposPorResponsable.merge(responsable, tiempoDec, Duration::plus);
            }

            // Escribir los resultados en el PDF
            y -= 20;
            for (Map.Entry<Personal, Duration> entry : tiemposPorResponsable.entrySet()) {
                contentStream.beginText();
                contentStream.setFont(PDType1Font.HELVETICA, 10);
                contentStream.newLineAtOffset(x, y);

                contentStream.showText(entry.getKey().getNombre() + " " + entry.getKey().getApellido1() + " " + entry.getKey().getApellido2());
                contentStream.newLineAtOffset(200, 0);
                contentStream.showText(entry.getValue().toString());

                contentStream.endText();
                y -= 20;
            }

            contentStream.close();

            document.save(baos);

            HttpHeaders headers = new HttpHeaders();
            headers.setContentType(MediaType.APPLICATION_PDF);
            headers.setContentDispositionFormData("filename", "incidencias_tiempo_por_admin.pdf");
            headers.setContentLength(baos.size());

            return new ResponseEntity<>(baos.toByteArray(), headers, HttpStatus.OK);
        } catch (IOException e) {
            e.printStackTrace();
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }

    @GetMapping("/pdfTiempoMedioPorTipo")
    public ResponseEntity<byte[]> exportarPdfTiempoMedioPorTipo() {
        // Obtener todas las incidencias
        List<Incidencia> incidencias = incidenciaRepository.findAll();

        // Agrupar incidencias por tipo
        Map<Tipo_Incidencias, List<Incidencia>> incidenciasPorTipo = new HashMap<>();
        for (Incidencia incidencia : incidencias) {
            Tipo_Incidencias tipo = incidencia.getTipo();
            incidenciasPorTipo.computeIfAbsent(tipo, k -> new ArrayList<>()).add(incidencia);
        }

        // Calcular el tiempo medio dedicado para cada tipo de incidencia
        Map<Tipo_Incidencias, Time> tiempoMedioPorTipo = new HashMap<>();
        for (Map.Entry<Tipo_Incidencias, List<Incidencia>> entry : incidenciasPorTipo.entrySet()) {
            Tipo_Incidencias tipo = entry.getKey();
            List<Incidencia> incidenciasTipo = entry.getValue();
            long totalMilliseconds = 0;
            long count = 0;
            for (Incidencia incidencia : incidenciasTipo) {
                Time tiempoDec = incidencia.getTiempo_dec();
                if (tiempoDec != null) {
                    totalMilliseconds += tiempoDec.getTime();
                    count++;
                }
            }
            if (count != 0) {
                long tiempoMedioMillis = totalMilliseconds / count;
                Time tiempoMedio = new Time(tiempoMedioMillis);
                tiempoMedioPorTipo.put(tipo, tiempoMedio);
            }
        }

        try (ByteArrayOutputStream baos = new ByteArrayOutputStream();
             PDDocument document = new PDDocument()) {
            PDPage page = new PDPage();
            document.addPage(page);

            PDPageContentStream contentStream = new PDPageContentStream(document, page);

            float x = 50; // Margen izquierdo
            float y = page.getMediaBox().getHeight() - 50; // Margen superior

            contentStream.beginText();
            contentStream.setFont(PDType1Font.HELVETICA_BOLD, 10);
            contentStream.newLineAtOffset(x, y);
            contentStream.showText("Tipo de Incidencia");
            contentStream.newLineAtOffset(200, 0);
            contentStream.showText("Tiempo Medio Dedicado");
            contentStream.endText();

            y -= 20;
            for (Map.Entry<Tipo_Incidencias, Time> entry : tiempoMedioPorTipo.entrySet()) {
                contentStream.beginText();
                contentStream.setFont(PDType1Font.HELVETICA, 10);
                contentStream.newLineAtOffset(x, y);

                contentStream.showText(entry.getKey().toString());
                contentStream.newLineAtOffset(200, 0);
                contentStream.showText(entry.getValue().toString());

                contentStream.endText();
                y -= 20;
            }

            contentStream.close();

            document.save(baos);

            HttpHeaders headers = new HttpHeaders();
            headers.setContentType(MediaType.APPLICATION_PDF);
            headers.setContentDispositionFormData("filename", "tiempo_medio_por_tipo.pdf");
            headers.setContentLength(baos.size());

            return new ResponseEntity<>(baos.toByteArray(), headers, HttpStatus.OK);
        } catch (IOException e) {
            e.printStackTrace();
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }

    @GetMapping("/pdfEstadisticas")
    public ResponseEntity<byte[]> exportarPdfEstadisticas() {
        List<Incidencia> incidencias = incidenciaRepository.findAll();

        try (ByteArrayOutputStream baos = new ByteArrayOutputStream();
             PDDocument document = new PDDocument()) {
            PDPage page = new PDPage();
            document.addPage(page);

            PDPageContentStream contentStream = new PDPageContentStream(document, page);

            float x = 50; // Margen izquierdo
            float y = page.getMediaBox().getHeight() - 50; // Margen superior

            contentStream.beginText();
            contentStream.setFont(PDType1Font.HELVETICA_BOLD, 10);
            contentStream.newLineAtOffset(x, y);
            contentStream.showText("Tipo de Incidencia");
            contentStream.newLineAtOffset(200, 0);
            contentStream.showText("Porcentaje de Aparición");
            contentStream.endText();

            // Contar la cantidad total de incidencias
            int totalIncidencias = incidencias.size();

            // Crear un mapa para almacenar la cantidad de incidencias por tipo
            Map<Tipo_Incidencias, Integer> incidenciasPorTipo = new HashMap<>();
            for (Incidencia incidencia : incidencias) {
                Tipo_Incidencias tipo = incidencia.getTipo();
                incidenciasPorTipo.put(tipo, incidenciasPorTipo.getOrDefault(tipo, 0) + 1);
            }

            y -= 20;
            // Escribir las estadísticas en el PDF
            for (Map.Entry<Tipo_Incidencias, Integer> entry : incidenciasPorTipo.entrySet()) {
                contentStream.beginText();
                contentStream.setFont(PDType1Font.HELVETICA, 10);
                contentStream.newLineAtOffset(x, y);

                contentStream.showText(entry.getKey().toString());
                double porcentaje = (double) entry.getValue() / totalIncidencias * 100;
                contentStream.newLineAtOffset(200, 0);
                contentStream.showText(String.format("%.2f%%", porcentaje));

                contentStream.endText();
                y -= 20;
            }

            contentStream.close();

            document.save(baos);

            HttpHeaders headers = new HttpHeaders();
            headers.setContentType(MediaType.APPLICATION_PDF);
            headers.setContentDispositionFormData("filename", "incidencias.pdf");
            headers.setContentLength(baos.size());

            return new ResponseEntity<>(baos.toByteArray(), headers, HttpStatus.OK);
        } catch (IOException e) {
            e.printStackTrace();
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }

    @GetMapping("/pdfTiempoIncidencia")
    public ResponseEntity<byte[]> exportarPdfTiempoIncidencia() {
        List<Incidencia> incidencias = incidenciaRepository.findAll();

        try (ByteArrayOutputStream baos = new ByteArrayOutputStream();
             PDDocument document = new PDDocument()) {
            PDPage page = new PDPage();
            document.addPage(page);

            PDPageContentStream contentStream = new PDPageContentStream(document, page);

            float x = 50; // Margen izquierdo
            float y = page.getMediaBox().getHeight() - 50; // Margen superior

            contentStream.beginText();
            contentStream.setFont(PDType1Font.HELVETICA_BOLD, 10);
            contentStream.newLineAtOffset(x, y);
            contentStream.showText("Número de Incidencia");
            contentStream.newLineAtOffset(200, 0);
            contentStream.showText("Tiempo Dedicado");
            contentStream.endText();

            y -= 20;
            // Escribir los datos en el PDF
            for (Incidencia incidencia : incidencias) {
                contentStream.beginText();
                contentStream.setFont(PDType1Font.HELVETICA, 10);
                contentStream.newLineAtOffset(x, y);

                contentStream.showText(String.valueOf(incidencia.getNum()));
                contentStream.newLineAtOffset(200, 0);
                contentStream.showText(incidencia.getTiempo_dec() != null ? incidencia.getTiempo_dec().toString() : "");

                contentStream.endText();
                y -= 20;
            }

            contentStream.close();

            document.save(baos);

            HttpHeaders headers = new HttpHeaders();
            headers.setContentType(MediaType.APPLICATION_PDF);
            headers.setContentDispositionFormData("filename", "incidencias.pdf");
            headers.setContentLength(baos.size());

            return new ResponseEntity<>(baos.toByteArray(), headers, HttpStatus.OK);
        } catch (IOException e) {
            e.printStackTrace();
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }

    @PostMapping
    public Incidencia nuevaIncidencia(@RequestBody Incidencia nuevaIncidencia) {
        // Verificar si hay un archivo adjunto para codificar
        String adjuntoPath = nuevaIncidencia.getAdjuntoUrl();
        if (adjuntoPath != null && !adjuntoPath.isEmpty()) {
            try {
                // Codificar el contenido del archivo a Base64 y agregarle la extensión
                String adjuntoBase64 = encodeFileToBase64(adjuntoPath);
                nuevaIncidencia.setAdjuntoUrl(adjuntoBase64);
            } catch (IOException e) {
                e.printStackTrace();
                // Manejar el error si ocurre una excepción de E/S
            }
        }

        return incidenciaRepository.save(nuevaIncidencia);
    }

    @PutMapping("/{num}")
    public Incidencia editarIncidencia(@RequestBody Incidencia incidenciaEditada, @PathVariable int num) {
        if (incidenciaRepository.findById(num).isPresent()) {
            Incidencia incidenciaExistente = incidenciaRepository.findById(num).get();

            // Verificar si hay un archivo adjunto para codificar
            String adjuntoPath = incidenciaEditada.getAdjuntoUrl();
            if (adjuntoPath != null && !adjuntoPath.isEmpty()) {
                try {
                    // Codificar el contenido del archivo a Base64 y agregarle la extensión
                    String adjuntoBase64 = encodeFileToBase64(adjuntoPath);
                    incidenciaEditada.setAdjuntoUrl(adjuntoBase64);
                } catch (IOException e) {
                    e.printStackTrace();
                    // Manejar el error si ocurre una excepción de E/S
                }
            }

            incidenciaEditada.setNum(num);
            return incidenciaRepository.save(incidenciaEditada);
        } else {
            return null;
        }
    }

    // Método para codificar el contenido de un archivo a Base64 y agregarle la extensión del archivo
    private String encodeFileToBase64(String filePath) throws IOException {
        Path path = Paths.get(filePath);
        byte[] fileContent = Files.readAllBytes(path);
        String base64Encoded = Base64.getEncoder().encodeToString(fileContent);
        // Agregar la extensión del archivo al final de la cadena codificada
        String extension = getFileExtension(filePath);
        base64Encoded += "." + extension;
        return base64Encoded;
    }

    // Método para obtener la extensión de un archivo a partir de su ruta
    private String getFileExtension(String filePath) {
        return filePath.substring(filePath.lastIndexOf(".") + 1);
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