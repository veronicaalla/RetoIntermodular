package es.intermodular.equipo2.incidenciasies.modelo

import com.google.gson.annotations.SerializedName
import java.io.Serializable

/*
data class Incidencia(

    @SerializedName("num")
    val idIncidencia: Int,

    @SerializedName("adjunto_url")
    val adjunto_url: String,

    @SerializedName("descripcion")
    val descripcion: String,

    @SerializedName("estado")
    val estado: String,

    @SerializedName("fechaCierre")
    val fechaCierre: java.util.Date,

    @SerializedName("fechaCreacion")
    val fechaCreacion: java.util.Date,

    @SerializedName("tipo")
    val tipo: String

) : Serializable
*/

data class Incidencia(


    val idIncidencia: Int,


    val adjunto_url: String,


    val descripcion: String,


    val estado: String,


    val fechaCierre: java.util.Date,


    val fechaCreacion: java.util.Date,

    val tipo: String

) : Serializable