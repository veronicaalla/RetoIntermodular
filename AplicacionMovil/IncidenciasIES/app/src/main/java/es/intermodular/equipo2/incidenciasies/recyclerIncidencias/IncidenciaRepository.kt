package es.intermodular.equipo2.incidenciasies.recyclerIncidencias

import es.intermodular.equipo2.incidenciasies.datos.IncidenciaApi
import es.intermodular.equipo2.incidenciasies.modelo.Incidencia

class IncidenciaRepository {

    suspend fun getIncidencias():List<Incidencia> = IncidenciaApi.retrofitService.getIncidencias()
}