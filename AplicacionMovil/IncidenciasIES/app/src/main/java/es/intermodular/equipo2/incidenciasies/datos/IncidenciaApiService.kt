package es.intermodular.equipo2.incidenciasies.datos

import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse
import retrofit2.http.GET

interface IncidenciaApiService {

    //Añadimos los métodos que usaremos
    @GET("api/incidencias")
    suspend fun getIncidencias(): List<IncidenciaResponse>


}