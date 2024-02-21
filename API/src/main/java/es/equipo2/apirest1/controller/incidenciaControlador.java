package es.equipo2.apirest1.controller;

import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.util.List;
import java.util.Map;
import java.sql.Date;
import java.sql.Time;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.time.Duration;
import java.util.ArrayList;
import java.util.HashMap;

import org.apache.pdfbox.pdmodel.PDDocument;
import org.apache.pdfbox.pdmodel.PDPage;
import org.apache.pdfbox.pdmodel.PDPageContentStream;
import org.apache.pdfbox.pdmodel.common.PDRectangle;
import org.apache.pdfbox.pdmodel.font.PDType1Font;
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
            headerRow.createCell(11).setCellValue("Tiempo Dec");

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

    @GetMapping("/excelAbiertas")
    public ResponseEntity<byte[]> exportarExcelAbiertas() {
        List<Incidencia> incidenciasAbiertas = incidenciaRepository.findByEstado(Estado_Incidencia.abierta);

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

            // Crear un mapa para almacenar los nombres completos de los creadores y responsables por ID
            Map<Integer, String> nombresCompletos = obtenerNombresCompletos();

            int rowNum = 1;
            for (Incidencia incidencia : incidenciasAbiertas) {
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

    @GetMapping("/excelTiempoPorAdmin")
    public ResponseEntity<byte[]> exportarExcelTiempoPorAdmin() {
        List<Incidencia> incidencias = incidenciaRepository.findAll();

        try (Workbook workbook = new XSSFWorkbook(); ByteArrayOutputStream baos = new ByteArrayOutputStream()) {
            Sheet sheet = workbook.createSheet("Incidencias");
            Row headerRow = sheet.createRow(0);
            headerRow.createCell(0).setCellValue("Responsable");
            headerRow.createCell(1).setCellValue("Suma de Tiempo Dec");

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
            contentStream.showText("Tiempo Dec");
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