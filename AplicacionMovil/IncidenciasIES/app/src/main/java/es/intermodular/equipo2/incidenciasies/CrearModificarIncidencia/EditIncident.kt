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

    private lateinit var incidencia:IncidenciaResponse

    companion object {
        const val EXTRA_EDIT_INCIDENCIA = "extra_incidencia_index"
        const val EXTRA_EDITED_INCIDENCIA = "extra_edited_incidencia"
        private const val REQUEST_CODE_EDIT = 1
    }
    private lateinit var binding: ActivityEditIncidentBinding

    //Le pasamos los parametros de el tipo de incidencia

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        //setContentView(R.layout.activity_edit_incident)

        binding = ActivityEditIncidentBinding.inflate(layoutInflater)
        setContentView(binding.root)

        //Recogemos la incidencia en caso de haber seleccionado una
        incidencia = intent.getSerializableExtra(EXTRA_EDIT_INCIDENCIA) as IncidenciaResponse
        Log.i("Incidencia a editar", incidencia.toString())
        if (incidencia==null){

            //Recogemos el tipo de incidencia que se ha pasado mediante un Intent
            val tipo = intent.extras?.getString("tipo").orEmpty()
            binding.txtTipoIncidencia.text = tipo

            //El campo -> Fecha de creacion se autocompleta con la fecha actual siempre y cuando el ID incidencia sea 0
            val actuallyDate = LocalDateTime.now()
                .format(DateTimeFormatter.ofPattern("MMM dd yyyy"))

            binding.editTextFechaCreacion.setText(actuallyDate)
        }





    }
}