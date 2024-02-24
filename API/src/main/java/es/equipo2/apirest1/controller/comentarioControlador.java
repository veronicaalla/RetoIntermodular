package es.equipo2.apirest1.controller;

import java.io.File;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.Base64;
import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ContentDisposition;
import org.springframework.http.HttpHeaders;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import es.equipo2.apirest1.model.Comentario;
import es.equipo2.apirest1.repository.ComentarioRepository;


@RestController
@RequestMapping("/api/comentarios")
public class comentarioControlador {

    @Autowired
    private ComentarioRepository comentarioRepository;

    @GetMapping
    public List<Comentario> obtenerComentarios() {
        return comentarioRepository.findAll();
    }

    @GetMapping("/{id}")
    public Comentario obtenerComentarioPorId(@PathVariable int id) {
        return comentarioRepository.findById(id).orElse(null);
    }
    
    @GetMapping("/incidencia/{incidenciaId}")
    public List<Comentario> obtenerComentariosPorIncidencia(@PathVariable int incidenciaId) {
        return comentarioRepository.findByIncidenciaNum(incidenciaId);
    }

    @PostMapping
    public Comentario crearComentario(@RequestBody Comentario nuevoComentario) {
        return comentarioRepository.save(nuevoComentario);
    }

    @PutMapping("/{id}")
    public Comentario actualizarComentario(@RequestBody Comentario comentarioEditado, @PathVariable int id) {
        if (comentarioRepository.existsById(id)) {
            comentarioEditado.setId(id);
            return comentarioRepository.save(comentarioEditado);
        } else {
            return null;
        }
    }

    @PostMapping("/subirArchivo")
    public ResponseEntity<String> subirArchivo(@RequestParam("ubicacionArchivo") String ubicacionArchivo,
                                               @RequestParam("extension") String extension,
                                               @RequestParam("id") int id) {
        try {
            // Leer los bytes del archivo desde la ubicación proporcionada
            byte[] archivoBytes = Files.readAllBytes(Paths.get(ubicacionArchivo));

            // Decodificar el archivo Base64 a bytes
            byte[] archivoDecodificado = Base64.getDecoder().decode(archivoBytes);

            // Generar un nombre para el archivo compuesto por "comentario" + su ID + extensión
            String nombreArchivo = "comentario" + id + "." + extension;

            // Guardar el archivo en el sistema de archivos (o en el almacenamiento de tu elección)
            String rutaGuardado = guardarArchivoEnSistemaDeArchivos(nombreArchivo, archivoDecodificado);

            // Actualizar el comentario en la base de datos con la ubicación del archivo
            // (asumiendo que tienes comentarioRepository disponible)
            Optional<Comentario> optionalComentario = comentarioRepository.findById(id);
            if (optionalComentario.isPresent()) {
                Comentario comentario = optionalComentario.get();
                comentario.setAdjuntoUrl(rutaGuardado);
                comentarioRepository.save(comentario);

                return ResponseEntity.ok("Archivo subido exitosamente con nombre: " + nombreArchivo);
            } else {
                return ResponseEntity.notFound().build();
            }
        } catch (IOException e) {
            e.printStackTrace();
            return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body("Error al procesar el archivo.");
        }
    }

    private String guardarArchivoEnSistemaDeArchivos(String nombreArchivo, byte[] archivoBytes) throws IOException {
        String nombreDirectorio = "comentarios";
        String rutaDirectorio = System.getProperty("user.dir") + File.separator + nombreDirectorio;
        Path rutaArchivo = Paths.get(rutaDirectorio, nombreArchivo);

        // Guardar el archivo en el directorio especificado
        Files.write(rutaArchivo, archivoBytes);

        // Devolver la ruta completa del archivo guardado
        return rutaArchivo.toString();
    }
    
    @GetMapping("/descargarArchivoBase64")
    public ResponseEntity<byte[]> descargarArchivoBase64(@RequestParam("id") int id) {
        Optional<Comentario> optionalComentario = comentarioRepository.findById(id);
        if (optionalComentario.isPresent()) {
            Comentario comentario = optionalComentario.get();
            String ubicacionArchivo = comentario.getAdjuntoUrl();
            String extension = obtenerExtension(ubicacionArchivo);
            
            try {
                // Leer los bytes del archivo desde la ubicación proporcionada
                byte[] archivoBytes = Files.readAllBytes(Paths.get(ubicacionArchivo));

                // Codificar los bytes del archivo a Base64
                byte[] archivoCodificado = Base64.getEncoder().encode(archivoBytes);

                // Convertir la extensión a bytes
                byte[] extensionBytes = extension.getBytes();

                // Concatenar el punto y la extensión al final del contenido del archivo codificado
                byte[] contenidoFinal = new byte[archivoCodificado.length + 1 + extensionBytes.length];
                System.arraycopy(archivoCodificado, 0, contenidoFinal, 0, archivoCodificado.length);
                contenidoFinal[archivoCodificado.length] = '.'; // Agregar el punto
                System.arraycopy(extensionBytes, 0, contenidoFinal, archivoCodificado.length + 1, extensionBytes.length);

                // Devolver el archivo codificado como parte de la respuesta HTTP
                HttpHeaders headers = new HttpHeaders();
                headers.setContentType(MediaType.TEXT_PLAIN);
                headers.setContentDisposition(ContentDisposition.builder("attachment").filename("comentarioCodificado.txt").build());
                
                return ResponseEntity.ok().headers(headers).body(contenidoFinal);
            } catch (IOException e) {
                e.printStackTrace();
                return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body(null); // Devolver error 500 si ocurre algún error
            }
        } else {
            return ResponseEntity.notFound().build(); // Devolver error 404 si no se encuentra el comentario
        }
    }

    private String obtenerExtension(String ubicacionArchivo) {
        // Extraer la extensión del nombre del archivo
        return ubicacionArchivo.substring(ubicacionArchivo.lastIndexOf(".") + 1);
    }

    
    @DeleteMapping("/{id}")
    public Comentario borrarComentario(@PathVariable int id) {
        if (comentarioRepository.existsById(id)) {
            Comentario comentario = comentarioRepository.findById(id).get();
            comentarioRepository.delete(comentario);
            return comentario;
        } else {
            return null;
        }
    }
}