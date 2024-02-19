package es.intermodular.equipo2.incidenciasies.datos.incidencias

import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse
import retrofit2.Response
import retrofit2.http.GET

interface IncidenciaApiService {
<<<<<<< HEAD

    //Añadimos los métodos que usaremos
    @GET("api/incidencias")
    suspend fun getIncidencias(): List<IncidenciaResponse>

=======
    @GET("getIncidencias")
    suspend fun getIncidencias(): Response<List<IncidenciaResponse>>
>>>>>>> 0e95a16facfb85a58e109b571363c9b15ed19c0a
}