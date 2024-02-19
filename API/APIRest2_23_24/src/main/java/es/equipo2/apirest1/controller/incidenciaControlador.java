package es.equipo2.apirest1.controller;

import java.sql.Date;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import es.equipo2.apirest1.model.Estado_Incidencia;
import es.equipo2.apirest1.model.Incidencia;
import es.equipo2.apirest1.model.Personal;
import es.equipo2.apirest1.model.Tipo_Incidencias;
import es.equipo2.apirest1.repository.IncidenciaRepository;
import es.equipo2.apirest1.repository.PersonalRepository;


@RestController
@RequestMapping("/api/incidencias")
public class incidenciaControlador {

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