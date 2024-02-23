package es.intermodular.equipo2.incidenciasies.CrearModificarIncidencia

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.telecom.Call
import android.util.Log
import es.intermodular.equipo2.incidenciasies.R
import es.intermodular.equipo2.incidenciasies.databinding.ActivityEditIncidentBinding
import es.intermodular.equipo2.incidenciasies.datos.Api
import es.intermodular.equipo2.incidenciasies.datos.ApiService
import es.intermodular.equipo2.incidenciasies.modelo.CrearIncidencia
import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse
import retrofit2.Response
import java.time.LocalDate
import java.time.LocalDateTime
import java.time.format.DateTimeFormatter
import javax.security.auth.callback.Callback

class EditIncident : AppCompatActivity() {

    companion object {
        const val EXTRA_EDIT_INCIDENCIA = "extra_incidencia_index"
        const val EXTRA_EDITED_INCIDENCIA = "extra_edited_incidencia"
        const val TIPO_INCIDENCIA: String = ""
        private const val REQUEST_CODE_EDIT = 1
    }

    private lateinit var binding: ActivityEditIncidentBinding

    //Le pasamos los parametros de el tipo de incidencia

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        binding = ActivityEditIncidentBinding.inflate(layoutInflater)
        setContentView(binding.root)


        //Comprobamos desde que clase ha accedido
        //1 -> Principal (editando una incidencia)
        //0 -> SelectTypeIncidents (creando una nueva)
        var claseAnterior = intent.getIntExtra("incidencia", -1)
        if (claseAnterior == 1) {
            var incidencia =
                intent.getSerializableExtra(EXTRA_EDIT_INCIDENCIA) as IncidenciaResponse
            Log.i("Incidencia a editar", incidencia.toString())


        } else if (claseAnterior == 0) {

            //Lo primero de todo, obtenemos cual es el perfil del usuario
            val idPerfil = intent.getIntExtra("idPerfil", -1)
            Log.i("id del perfil", idPerfil.toString())

            //Recogemos el tipo de Incidencia y lo mostramos
            var tipoIncidencia = intent.getStringExtra("tipo").toString()
            //Le asignamos el tipo de incidencia
            binding.txtTipoIncidencia.text = tipoIncidencia

            //Le asignamos la fecha de creación, que es la actual -> No debemos asignarsela a la clase debido a que ya esta de forma automatica indicado
            val fechaActual = LocalDate.now()
            binding.txtFechaCreacion.text = fechaActual.toString()

            binding.btnAceptar.setOnClickListener {
                crearIncidencia(tipoIncidencia, idPerfil)
            }
        }

        //region FUNCIONALIDAD DE LOS BOTONES

        binding.btnCancelar.setOnClickListener {
            finish()
        }

        //endregion

    }


    private fun crearIncidencia(
        tipoIncidencia: String, idPerfil: Int
    ) {
        //Para crear la incidencia, la llamada la API recibe una incidencia
        //por lo tanto, 1º debemos crearla
        var nuevaIncidencia = CrearIncidencia()

        //Le pasamos el id del creador, que corresponde con el del perfil
        nuevaIncidencia.creador_id = idPerfil


        //---------- PASO DE TIPO Y SUBTIPO ------------
        //Una vez obtenido el tipo de incidencia, en un string
        //Debemos separarlos, para poder hacer una llamada a la API
        //para que nos devuelva el id
        val tipoI = tipoIncidencia.split(" ")
        val tipo = tipoI[0]
        val subTipo = tipoI[1]
        val subSubTipo =
            tipoI.getOrElse(2) { "" } // if there are only 2 words, word3 will be an empty string

        Log.i("tipo:", tipo)
        Log.i("subTipo:", subTipo)
        Log.i("subSubTipo", subSubTipo)

        //El tipo de datos, se lo podemos pasar de forma automatica
        nuevaIncidencia.tipo = tipo

        //Llamamos a la api, para obtener el id del subtipo
        //Controlamos si existe el subsubtipo
        if (subSubTipo.isEmpty()) {

        } else {

        }


        //Le asiganamos la descripcion
        nuevaIncidencia.descripcion = binding.editTextDescripcion.text.toString()

        //Le asignamos el equipoId
        if (binding.editTextEquipoIncidencia.text.isNotEmpty()) {
            //Convertimos el texto en un int
            var equipoIncidenca = binding.editTextEquipoIncidencia.toString()
            var idEquipo = equipoIncidenca.toInt()
            nuevaIncidencia.equipoId = idEquipo
        }
        //---------------


    }

    private fun modificarIncidencia(incidencia: IncidenciaResponse) {

    }
}