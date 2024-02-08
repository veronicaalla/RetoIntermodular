package es.intermodular.equipo2.incidenciasies.datos

object IncidenciaApi {

    private val retrofit = RetrofitBuilder.build()
    val retrofitService: IncidenciaApiService by lazy { retrofit.create(IncidenciaApiService::class.java) }

}