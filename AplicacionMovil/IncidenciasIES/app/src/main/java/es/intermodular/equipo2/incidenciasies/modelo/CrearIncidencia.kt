package es.intermodular.equipo2.incidenciasies.modelo

import java.time.LocalDateTime

class CrearIncidencia {

    constructor() {
        // Inicializamos los atributos aquí
    }

    var tipo: String = ""
        get() = field
        set(value) {
            field = value
        }

    var subtipo_id: Int = 0
        get() = field
        set(value) {
            field = value
        }

    var fechaCreacion: LocalDateTime = LocalDateTime.now()

    var descripcion: String = ""
        get() = field
        set(value) {
            field = value
        }

    var equipoId: Int? = null
        get() = field
        set(value) {
            field = value
        }

    var estado: String = "abierta" //Por defecto


    var creador_id: Int = 0
        get() = field
        set(value) {
            field = value
        }
}

//ENUM('abierta', 'asignada', 'en_proceso', 'enviada_a_Infortec', 'resuelta', 'cerrada')