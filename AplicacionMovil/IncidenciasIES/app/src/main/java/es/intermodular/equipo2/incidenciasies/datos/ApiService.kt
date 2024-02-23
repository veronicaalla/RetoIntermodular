package es.intermodular.equipo2.incidenciasies.datos

import es.intermodular.equipo2.incidenciasies.modelo.CrearIncidencia
import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse
import es.intermodular.equipo2.incidenciasies.modelo.PerfilReponse
import retrofit2.Call
import retrofit2.Response
import retrofit2.http.Body
import retrofit2.http.GET
import retrofit2.http.POST
import retrofit2.http.Path
import retrofit2.http.Query

interface ApiService {

    //region Incidencias
    @GET("incidencias/creador/{id}")
    suspend fun getIncidenciasUsuario(
        @Path("id") usuarioId: Int
    ): Response<List<IncidenciaResponse>>


    //Obtener el id del subtipo si tengo tipo y subtipo


    //Obtener el id del subtipo si tengo tipo, subtipo y subsubtipo


    //Obtener id incidencia
    @GET("incidencias-subtipos/id")
    fun obtenerIdPorTipoSubtipoYSubsubtipo(
        @Query("tipo") tipo: String,
        @Query("subtipo") subtipo: String,
        @Query("subsubtipo") subsubtipo: String?
    ): Call<Int>


    //Crear incidencia
    @POST("incidencias")
    fun crearIncidencia(@Body nuevaIncidencia: CrearIncidencia): Call<IncidenciaResponse>

    //endregion

    //region Perfiles
    @GET("perfiles/login")
    fun login(
        @Query("dominio") dominio: String, @Query("password") password: String
    ): Call<PerfilReponse>
    //endregion


}