package es.intermodular.equipo2.incidenciasies.datos

import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse
import es.intermodular.equipo2.incidenciasies.modelo.PerfilReponse
import retrofit2.Call
import retrofit2.Response
import retrofit2.http.GET
import retrofit2.http.Path
import retrofit2.http.Query

interface ApiService {

    //region Incidencias
    @GET("incidencias/creador/{id}")
    suspend fun getIncidenciasUsuario(
        @Path("id") usuarioId: Int
    ): Response<List<IncidenciaResponse>>

    //endregion

    //region Perfiles
    @GET("perfiles/login")
     fun login(
        @Query("dominio") dominio: String, @Query("password") password: String
    ): Call<PerfilReponse>
    //endregion
}