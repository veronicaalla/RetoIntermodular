package es.intermodular.equipo2.incidenciasies.datos.notificaciones

import es.intermodular.equipo2.incidenciasies.datos.RetrofitBuilder

object NotificacionesApi {

    private val retrofit = RetrofitBuilder.build()
    val retrofitService: NotificacionesApiService by lazy { retrofit.create(NotificacionesApiService::class.java) }

}