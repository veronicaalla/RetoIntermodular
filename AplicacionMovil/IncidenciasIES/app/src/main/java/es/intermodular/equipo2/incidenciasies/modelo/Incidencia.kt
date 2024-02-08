package es.intermodular.equipo2.incidenciasies.modelo

import com.google.gson.annotations.SerializedName
import java.io.Serializable
import java.sql.Date

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
    val fechaCierre: Date,

    @SerializedName("fechaCreacion")
    val fechaCreacion: Date,

    @SerializedName("tipo")
    val tipo: String

) : Serializable