package es.equipo2.apirest1.controller;


import java.util.List;
import java.util.Optional;

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

import es.equipo2.apirest1.model.Departamento;
import es.equipo2.apirest1.model.Perfiles;
import es.equipo2.apirest1.model.Tipo_Perfil;
import es.equipo2.apirest1.repository.DepartamentoRepository;
import es.equipo2.apirest1.repository.PerfilesRepository;


@RestController
@RequestMapping("/api/departamentos")
public class departamentoControlador {

    @Autowired
    private DepartamentoRepository departamentoRepository;
    
    @Autowired
    private PerfilesRepository perfilesRepository;

    @GetMapping
    public List<Departamento> obtenerDepartamentos() {
        return departamentoRepository.findAll();
    }

    @GetMapping("/{id}")
    public Departamento obtenerDepartamentoPorId(@PathVariable int id) {
        return departamentoRepository.findById(id).orElse(null);
    }

    @PostMapping
    public Departamento nuevoDepartamento(@RequestBody Departamento nuevoDepartamento) {
        return departamentoRepository.save(nuevoDepartamento);
    }

    @PutMapping("/{id}")
    public Departamento editarDepartamento(@RequestBody Departamento departamentoEditado, @PathVariable int id) {
        if (departamentoRepository.existsById(id)) {
            departamentoEditado.setInt_(id); // Asignar el id al campo int_
            return departamentoRepository.save(departamentoEditado);
        } else {
            return null;
        }
    }
    
    @PutMapping("/desactivar-departamento")
    public String desactivarDepartamento(@RequestParam("idDepartamento") int idDepartamento,
                                         @RequestParam("idAdmin") int idAdmin,
                                         @RequestParam("contrasena") String contrasena) {
        // Verificar si el usuario es administrador
        if (!esAdministrador(idAdmin)) {
            return "Error: El usuario no es administrador. No se puede realizar el cambio.";
        }

        // Verificar si el departamento existe
        if (departamentoRepository.existsById(idDepartamento)) {
            Departamento departamento = departamentoRepository.findById(idDepartamento).get();
            // Cambiar el estado activo a false
            departamento.setActivo(false);
            departamentoRepository.save(departamento);
            return "El departamento ha sido desactivado correctamente.";
        } else {
            return "Error: El departamento no existe.";
        }
    }

    private boolean esAdministrador(int idPerfil) {
        // Buscar el perfil por su ID
        Optional<Perfiles> optionalPerfil = perfilesRepository.findById(idPerfil);

        // Verificar si se encontró el perfil
        if (optionalPerfil.isPresent()) {
            Perfiles perfil = optionalPerfil.get();
            // Verificar si el tipo de perfil es "administrador"
            return perfil.getPerfil() == Tipo_Perfil.administrador;
        }

        return false; // No se encontró ningún perfil con el ID proporcionado
    }

    @PutMapping("/modificar-idpersonal")
    public String modificarIdPersonalDepartamento(@RequestParam("idDepartamento") int idDepartamento,
                                                  @RequestParam("idNuevoPersonal") int idNuevoPersonal,
                                                  @RequestParam("idAdmin") int idAdmin,
                                                  @RequestParam("contrasena") String contrasena) {
        // Verificar si el usuario es administrador y si la contraseña es correcta
        if (!esAdministrador(idAdmin, contrasena)) {
            return "Error: El usuario no es administrador o la contraseña es incorrecta. No se puede realizar el cambio.";
        }

        // Verificar si el departamento existe
        if (departamentoRepository.existsById(idDepartamento)) {
            Departamento departamento = departamentoRepository.findById(idDepartamento).get();
            // Modificar el ID del personal del departamento
            departamento.setPersonal(idNuevoPersonal);
            departamentoRepository.save(departamento);
            return "El ID del personal del departamento ha sido modificado correctamente.";
        } else {
            return "Error: El departamento no existe.";
        }
    }

    // Método para verificar si el usuario es administrador y si la contraseña es correcta
    private boolean esAdministrador(int idAdmin, String contrasena) {
        // Verificar si el usuario con el ID proporcionado es administrador
        Optional<Perfiles> optionalPerfil = perfilesRepository.findById(idAdmin);

        if (optionalPerfil.isPresent()) {
            Perfiles perfil = optionalPerfil.get();
            // Verificar si el perfil es administrador y si la contraseña es correcta
            return perfil.getPerfil() == Tipo_Perfil.administrador&& perfil.getPassword().equals(contrasena);
        }

        return false; // El perfil del administrador no existe
    }
    
    @DeleteMapping("/{id}")
    public Departamento borrarDepartamento(@PathVariable int id) {
        if (departamentoRepository.existsById(id)) {
            Departamento departamento = departamentoRepository.findById(id).get();
            departamentoRepository.delete(departamento);
            return departamento;
        } else {
            return null;
        }
    }
}