package es.intermodular.equipo2.incidenciasies.CrearModificarIncidencia

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import es.intermodular.equipo2.incidenciasies.R
import es.intermodular.equipo2.incidenciasies.databinding.ActivityEditIncidentBinding
import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse
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

        //Recogemos la incidencia en caso de haber seleccionado una

        var tipoIncidencia = intent.getStringExtra("tipo").toString()

        if (tipoIncidencia != "") {
            crearIncidencia(tipoIncidencia)
        } else {
            //SI el tipo de incidencia esta vacio, significa que se le ha pasado directamente la incidencia
            var incidencia =
                intent.getSerializableExtra(EXTRA_EDIT_INCIDENCIA) as IncidenciaResponse
            Log.i("Incidencia a editar", incidencia.toString())
            modificarIncidencia(incidencia)
        }


    }

    private fun crearIncidencia(tipoIncidencia: String) {

    }

    private fun modificarIncidencia(incidencia: IncidenciaResponse) {

    }
}