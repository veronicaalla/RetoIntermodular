package es.intermodular.equipo2.incidenciasies.datos

import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse
import retrofit2.Response
import retrofit2.http.GET

interface IncidenciaApiService {
    @GET("getIncidencias")
    suspend fun getIncidencias(): Response<List<IncidenciaResponse>>
}