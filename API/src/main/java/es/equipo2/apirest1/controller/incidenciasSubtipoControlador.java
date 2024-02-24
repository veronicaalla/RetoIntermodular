package es.equipo2.apirest1.controller;

import java.util.List;
import java.util.Set;
import java.util.stream.Collectors;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import es.equipo2.apirest1.model.Incidencia;
import es.equipo2.apirest1.model.IncidenciasSubtipo;
import es.equipo2.apirest1.model.Tipo_Incidencias;
import es.equipo2.apirest1.repository.IncidenciaSubtipoRepository;
import jakarta.persistence.EntityManager;
import jakarta.persistence.TypedQuery;

@RestController
@RequestMapping("/api/incidencias-subtipos")
public class incidenciasSubtipoControlador {

	@Autowired
    private EntityManager entityManager;
	
    @Autowired
    private IncidenciaSubtipoRepository incidenciasSubtipoRepository;

    @GetMapping
    public List<IncidenciasSubtipo> obtenerIncidenciasSubtipos() {
        return incidenciasSubtipoRepository.findAll();
    }

    @GetMapping("/{id}")
    public IncidenciasSubtipo obtenerIncidenciaSubtipoPorId(@PathVariable int id) {
        return incidenciasSubtipoRepository.findById(id).orElse(null);
    }
    
    @GetMapping("/subtipos")
    public Set<String> obtenerSubtiposPorTipo(@RequestParam Tipo_Incidencias tipo) {
        List<IncidenciasSubtipo> subtipos = incidenciasSubtipoRepository.findByTipo(tipo);
        return subtipos.stream()
                .map(IncidenciasSubtipo::getSubtipoNombre) // o cualquier otro campo que quieras devolver
                .collect(Collectors.toSet());
    }
    
    @GetMapping("/subsubtipos")
    public Set<String> obtenerSubtiposRelacionados(@RequestParam String subtipo) {
        List<IncidenciasSubtipo> subtipos = incidenciasSubtipoRepository.findBySubtipoNombre(subtipo);
        Set<String> subtiposRelacionados = subtipos.stream()
                .map(IncidenciasSubtipo::getSubSubtipo)
                .collect(Collectors.toSet());
        return subtiposRelacionados;
    }
    
    @GetMapping("/id")
    public Integer obtenerIdPorTipoSubtipoYSubsubtipo(
            @RequestParam Tipo_Incidencias tipo,
            @RequestParam String subtipo,
            @RequestParam(required = false) String subsubtipo) {
        try {
            if (subsubtipo != null) {
                IncidenciasSubtipo incidenciasSubtipo = incidenciasSubtipoRepository.findByTipoAndSubtipoNombreAndSubSubtipo(tipo, subtipo, subsubtipo);
                return incidenciasSubtipo != null ? incidenciasSubtipo.getId() : null;
            } else {
                IncidenciasSubtipo incidenciasSubtipo = incidenciasSubtipoRepository.findByTipoAndSubtipoNombre(tipo, subtipo);
                return incidenciasSubtipo != null ? incidenciasSubtipo.getId() : null;
            }
        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
    }
        
    @PostMapping
    public IncidenciasSubtipo nuevoIncidenciaSubtipo(@RequestBody IncidenciasSubtipo nuevoIncidenciaSubtipo) {
        return incidenciasSubtipoRepository.save(nuevoIncidenciaSubtipo);
    }

    @PutMapping("/{id}")
    public IncidenciasSubtipo editarIncidenciaSubtipo(@RequestBody IncidenciasSubtipo incidenciaSubtipoEditado, @PathVariable int id) {
        if (incidenciasSubtipoRepository.existsById(id)) {
            incidenciaSubtipoEditado.setId(id);
            return incidenciasSubtipoRepository.save(incidenciaSubtipoEditado);
        } else {
            return null;
        }
    }

    @DeleteMapping("/{id}")
    public IncidenciasSubtipo borrarIncidenciaSubtipo(@PathVariable int id) {
        if (incidenciasSubtipoRepository.existsById(id)) {
            IncidenciasSubtipo incidenciasSubtipo = incidenciasSubtipoRepository.findById(id).get();
            incidenciasSubtipoRepository.delete(incidenciasSubtipo);
            return incidenciasSubtipo;
        } else {
            return null;
        }
    }
}
