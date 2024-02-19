package es.intermodular.equipo2.incidenciasies.recyclerIncidencias

import es.intermodular.equipo2.incidenciasies.datos.IncidenciaApi
import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse

class IncidenciaRepository {

    suspend fun getIncidencias():List<IncidenciaResponse> = IncidenciaApi.retrofitService.getIncidencias()
}