package es.intermodular.equipo2.incidenciasies.modelo

import com.google.gson.annotations.SerializedName
import java.io.Serializable

data class PerfilResponse(

    @SerializedName("activo")
    val activo: Int,

    @SerializedName("apellido1")
    val apellido1: String,

    @SerializedName("apellido2")
    val apellido2: String,

    @SerializedName("cp")
    val cp: Int,

    @SerializedName("direccion")
    val direccion: String,

    @SerializedName("dni")
    val dni: String,

    @SerializedName("localidad")
    val localidad: String,

    @SerializedName("nombre")
    val nombre: String,

    @SerializedName("tlf")
    val tlf: String,

    @SerializedName("departamento")
    val departamento: DepartamentoResponse


) : Serializable