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
        //setContentView(R.layout.activity_edit_incident)

        binding = ActivityEditIncidentBinding.inflate(layoutInflater)
        setContentView(binding.root
        )
        //Recogemos el tipo de incidencia que se ha pasado mediante un Intent
        val tipo = intent.extras?.getString("tipo").orEmpty()
        binding.txtTipoIncidencia.text = tipo

        //El campo -> Fecha de creacion se autocompleta con la fecha actual siempre y cuando el ID incidencia sea 0
        val actuallyDate = LocalDateTime.now()
            .format(DateTimeFormatter.ofPattern("MMM dd yyyy"))

        binding.editTextFechaCreacion.setText(actuallyDate)


    }
}