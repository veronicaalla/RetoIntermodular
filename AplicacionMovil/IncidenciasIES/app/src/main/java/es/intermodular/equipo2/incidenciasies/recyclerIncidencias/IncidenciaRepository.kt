package es.intermodular.equipo2.incidenciasies.recyclerIncidencias

import es.intermodular.equipo2.incidenciasies.datos.incidencias.IncidenciaApi
import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse
import retrofit2.Response

class IncidenciaRepository {

    suspend fun getIncidencias(): Response<List<IncidenciaResponse>> = IncidenciaApi.retrofitService.getIncidencias()
}