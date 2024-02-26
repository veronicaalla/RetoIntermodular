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

import es.equipo2.apirest1.model.Perfiles;
import es.equipo2.apirest1.model.Personal;
import es.equipo2.apirest1.model.Tipo_Perfil;
import es.equipo2.apirest1.repository.PerfilesRepository;
import es.equipo2.apirest1.repository.PersonalRepository;

@RestController
@RequestMapping("/api/personal")
public class personalControlador {

    @Autowired
    private PersonalRepository personalRepository;
    @Autowired
    private PerfilesRepository perfilesRepository;

    @GetMapping
    public List<Personal> obtenerTodoPersonal() {
        return personalRepository.findAll();
    }

    @GetMapping("/{id}")
    public Personal obtenerPersonalPorId(@PathVariable int id) {
        return personalRepository.findById(id).orElse(null);
    }
    
    // Método para filtrar personal por nombre
    @GetMapping("/nombre/{nombre}")
    public List<Personal> filtrarPorNombre(@PathVariable String nombre) {
        return personalRepository.findByNombre(nombre);
    }

    // Método para filtrar personal por apellido1
    @GetMapping("/apellido1/{apellido}")
    public List<Personal> filtrarPorApellido1(@PathVariable String apellido) {
        return personalRepository.findByApellido1(apellido);
    }

    // Método para filtrar personal por apellido2
    @GetMapping("/apellido2/{apellido}")
    public List<Personal> filtrarPorApellido2(@PathVariable String apellido) {
        return personalRepository.findByApellido2(apellido);
    }

    @GetMapping("/ultimo-id")
    public Integer obtenerUltimoId() {
        return personalRepository.findMaxId();
    }
    
    @PostMapping
    public Personal nuevoPersonal(@RequestBody Personal nuevoPersonal) {
        return personalRepository.save(nuevoPersonal);
    }

    @PutMapping("/{id}")
    public Personal editarPersonal(@RequestBody Personal personalEditado, @PathVariable int id) {
        if (personalRepository.existsById(id)) {
            personalEditado.setId(id);
            return personalRepository.save(personalEditado);
        } else {
            return null;
        }
    }

    @DeleteMapping("/{id}")
    public Personal borrarPersonal(@PathVariable int id) {
        if (personalRepository.existsById(id)) {
            Personal personal = personalRepository.findById(id).get();
            personalRepository.delete(personal);
            return personal;
        } else {
            return null;
        }
    }
    
    @DeleteMapping("/desactivar-usuario")
    public String desactivarUsuario(@RequestParam("idUsuario") int idUsuario, 
                                    @RequestParam("idAdmin") int idAdmin, 
                                    @RequestParam("contrasenaAdmin") String contrasenaAdmin) {
        // Verificar si el usuario con el ID proporcionado es un administrador
        if (!esAdministrador(idAdmin)) {
            return "Error: El usuario administrador no es válido.";
        }
        
        // Verificar si el usuario existe
        Optional<Personal> optionalUsuario = personalRepository.findById(idUsuario);
        if (optionalUsuario.isPresent()) {
            Personal usuario = optionalUsuario.get(); // Desempaquetar el valor del Optional
            // Modificar el campo "activo" a false
            usuario.setActivo(false);
            personalRepository.save(usuario); // Guardar el usuario modificado en la base de datos
            return "El usuario ha sido desactivado correctamente.";
        } else {
            return "Error: El usuario no existe.";
        }
    }

    
    // Método para verificar si el usuario es un administrador
    private boolean esAdministrador(int idAdmin) {
        // Buscar el perfil del administrador por su ID
        java.util.Optional<Perfiles> adminPerfilOptional = perfilesRepository.findById(idAdmin);

        // Verificar si el perfil del administrador existe y si su tipo es "Administrador"
        if (adminPerfilOptional.isPresent()) {
            Perfiles adminPerfil = adminPerfilOptional.get();
            return adminPerfil.getPerfil() == Tipo_Perfil.administrador;
        } else {
            return false; // El perfil del administrador no existe
        }
    }
}