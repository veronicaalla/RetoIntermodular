package es.intermodular.equipo2.incidenciasies.datos

import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse
import retrofit2.Response
import retrofit2.http.GET
import retrofit2.http.Path

interface IncidenciaApiService {
    @GET("/creador/{id}")
    suspend fun getIncidenciasUsuario(
        @Path("id") usuarioId: Int
    ): Response<List<IncidenciaResponse>>
}