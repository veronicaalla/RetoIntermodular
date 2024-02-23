package es.intermodular.equipo2.incidenciasies.modelo

import com.google.gson.annotations.SerializedName
import java.io.Serializable
import java.sql.Time

data class IncidenciaResponse(

    @SerializedName("num")
    val idIncidencia: Int?,
    @SerializedName("adjuntoUrl")
    val adjunto_url: String,
    @SerializedName("descripcion")
    val descripcion: String,
    @SerializedName("estado")
    val estado: String,
    @SerializedName("fechaCierre")
    val fechaCierre: java.util.Date?,
    @SerializedName("fechaCreacion")
    val fechaCreacion: java.util.Date?,
    @SerializedName("tiempo_dec")
    val tiempoDesc: Time?,
    @SerializedName("tipo")
    var tipo: String,
    @SerializedName("equipo")
    val equipo: EquipoResponse,
    @SerializedName("incidenciasSubtipo")
    val tipoIncidencia: IncidenciasSubtipoResponse,
    @SerializedName("creador")
    val creador: PersonalResponse,
    @SerializedName("responsable")
    val responsable: PersonalResponse


) : Serializable

