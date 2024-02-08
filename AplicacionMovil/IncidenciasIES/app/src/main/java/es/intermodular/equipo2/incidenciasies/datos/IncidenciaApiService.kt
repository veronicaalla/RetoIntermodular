package es.intermodular.equipo2.incidenciasies.datos

import es.intermodular.equipo2.incidenciasies.modelo.Incidencia
import retrofit2.http.GET

interface IncidenciaApiService {

    //Añadimos los métodos que usaremos
    @GET("incidencias.json")
    suspend fun getIncidencias(): List<Incidencia>
}