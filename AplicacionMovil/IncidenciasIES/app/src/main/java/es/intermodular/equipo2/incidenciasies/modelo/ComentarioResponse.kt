package es.intermodular.equipo2.incidenciasies.modelo

import com.google.gson.annotations.SerializedName
import java.io.Serializable
import java.sql.Date

data class ComentarioResponse(
    @SerializedName("id")
    val id: Int,

    @SerializedName("adjuntoUrl")
    val adjuntoUrl: String,

    @SerializedName("texto")
    val texto: String,

    @SerializedName("fechahora")
    val fechahora: Date,

    @SerializedName("incidencia")
    val incidencia: IncidenciaResponse,

    @SerializedName("personal")
    val personal: PersonalResponse
) : Serializable