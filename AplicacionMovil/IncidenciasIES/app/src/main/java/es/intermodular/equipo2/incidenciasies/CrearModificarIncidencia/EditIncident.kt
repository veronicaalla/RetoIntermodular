package es.intermodular.equipo2.incidenciasies.CrearModificarIncidencia

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import es.intermodular.equipo2.incidenciasies.R
import es.intermodular.equipo2.incidenciasies.databinding.ActivityEditIncidentBinding
import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse
import java.time.LocalDate
import java.time.LocalDateTime
import java.time.format.DateTimeFormatter
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

        var claseAnterior = intent.getIntExtra("incidencia", -1)
        if (claseAnterior == 1) {
            var incidencia =
                intent.getSerializableExtra(EXTRA_EDIT_INCIDENCIA) as IncidenciaResponse
            Log.i("Incidencia a editar", incidencia.toString())
        } else if (claseAnterior == 0) {
            var tipoIncidencia = intent.getStringExtra("tipo").toString()
            Log.i("Tipo incidencia ", tipoIncidencia)


            crearIncidencia(tipoIncidencia)
        }

        //region FUNCIONALIDAD DE LOS BOTONES

        binding.btnCancelar.setOnClickListener {
            finish()
        }

        binding.btnAceptar.setOnClickListener {
            Log.i("Editar incidencia", "Editar")
        }
        //endregion

    }

    private fun crearIncidencia(tipoIncidencia: String) {
        /* binding.txtTipoIncidencia.text = ""
         binding.txtTipoIncidencia.text = tipoIncidencia*/
        //Debemos obtener el tipo de incidencia, para ello, debemos recoger del string palabra
        //por palabra de forma individual, para poder llamar a la api


        val tipoI = tipoIncidencia.split(" ")
        val tipo = tipoI[0]
        val subTipo = tipoI[1]
        val subSubTipo =
            tipoI.getOrElse(2) { "" } // if there are only 2 words, word3 will be an empty string

        Log.i("tipo:", tipo)
        Log.i("subTipo:", subTipo)
        Log.i("subSubTipo", subSubTipo)

        //Le asignamos el tipo de incidencia
        binding.txtTipoIncidencia.text = tipoIncidencia

        //Le asignamos la fecha de creación, que es la actual
        val fechaActual = LocalDate.now()
        binding.txtFechaCreacion.text = fechaActual.toString()

    }

    private fun modificarIncidencia(incidencia: IncidenciaResponse) {

    }
}