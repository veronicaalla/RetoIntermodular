package es.intermodular.equipo2.incidenciasies.datos

import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory

object RetrofitBuilder {
    //Añadimos '/' para poder acceder a ello
    private const val URL_BASE =
        "" //Añadir llamada a la db

    fun build(): Retrofit =
        Retrofit.Builder()
            .baseUrl(URL_BASE)
            .addConverterFactory(GsonConverterFactory.create())
            .build()

}