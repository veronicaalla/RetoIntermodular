package es.intermodular.equipo2.incidenciasies.modelo

import com.google.gson.annotations.SerializedName
import java.io.Serializable

class ComentarioResponse (

    @SerializedName("idComentario")
    val id: Int,

    @SerializedName("textoComentario")
    val texto: String,

    @SerializedName("fechaHora")
    val fechahora: java.util.Date,

    @SerializedName("incidenciaNum")
    val incidencia_num: IncidenciaResponse,

    @SerializedName("PersonalId")
    val personal_id: PersonalResponse,

    @SerializedName("adjuntoUrl")
    val adjunto_url: String,

) : Serializable