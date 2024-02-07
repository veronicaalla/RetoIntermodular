package es.intermodular.equipo2.incidenciasies.CrearModificarIncidencia

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import es.intermodular.equipo2.incidenciasies.R
import es.intermodular.equipo2.incidenciasies.databinding.ActivityEditIncidentBinding
import java.time.LocalDateTime
import java.time.format.DateTimeFormatter

class EditIncident : AppCompatActivity() {

    private lateinit var binding: ActivityEditIncidentBinding

    //Le pasamos los parametros de el tipo de incidencia

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_edit_incident)

        //Recogemos el tipo de incidencia que se ha pasado mediante un Intent
        val typeOfIncidents = intent.extras?.getString("EXTRA_TYPE_INCIDENTS").orEmpty()

        //El campo -> Fecha de creacion se autocompleta con la fecha actual siempre y cuando el ID incidencia sea 0
        val actuallyDate = LocalDateTime.now()
            .format(DateTimeFormatter.ofPattern("MMM dd yyyy, hh:mm:ss a"))

        binding.editTextFechaCreacion.setText(actuallyDate)


    }
}