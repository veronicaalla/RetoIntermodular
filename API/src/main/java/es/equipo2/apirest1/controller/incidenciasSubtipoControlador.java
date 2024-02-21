package es.equipo2.apirest1.controller;

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

import es.equipo2.apirest1.model.Incidencia;
import es.equipo2.apirest1.model.IncidenciasSubtipo;
import es.equipo2.apirest1.model.Tipo_Incidencias;
import es.equipo2.apirest1.repository.IncidenciaSubtipoRepository;
import jakarta.persistence.EntityManager;

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
    
    @GetMapping("/tipo/{tipo}")
    public List<IncidenciasSubtipo> buscarPorTipo(@PathVariable Tipo_Incidencias tipo) {
        return incidenciasSubtipoRepository.findByTipo(tipo);
    }

    @GetMapping("/subsubtipos/{subtipo}")
    public List<IncidenciasSubtipo> obtenerSubsubtiposPorSubtipo(@PathVariable String subtipo) {
        return incidenciasSubtipoRepository.findBySubtipoNombre(subtipo);
    }

    @GetMapping("/ids/{tipo}/{subtipo}/{subsubtipo}")
    public List<IncidenciasSubtipo> buscarIds(@PathVariable Tipo_Incidencias tipo,
                                               @PathVariable String subtipo,
                                               @PathVariable String subsubtipo) {
        return incidenciasSubtipoRepository.findByTipoAndSubtipoNombreAndSubSubtipo(tipo, subtipo, subsubtipo);
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
