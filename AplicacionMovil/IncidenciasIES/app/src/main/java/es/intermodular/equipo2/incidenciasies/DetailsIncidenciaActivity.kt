package es.intermodular.equipo2.incidenciasies

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import es.intermodular.equipo2.incidenciasies.CrearModificarIncidencia.EditIncident
import es.intermodular.equipo2.incidenciasies.databinding.ActivityDetailsIncidenciaBinding
import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse

class DetailsIncidenciaActivity : AppCompatActivity() {

    private lateinit var binding: ActivityDetailsIncidenciaBinding
    companion object {
        const val EXTRA_ID = "extra_id"
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        //Inflamos la vista
        binding = ActivityDetailsIncidenciaBinding.inflate(layoutInflater)
        setContentView(binding.root)

        //NOTA:
        //Cuando obtenemos el estado de la incidencia, dependiendo de su ESTADO
        //el btn (no clicable) será de un color u otro

        // Obtenemos los datos de la incidencia seleccionada
        val incidenciaResponse = intent.extras?.get("incidencia") as IncidenciaResponse

        // Mostramos los datos en los campos de texto y botones
        binding.txtTipoIncidencia.text = incidenciaResponse.tipoIncidencia.tipo
        binding.txtfechaCreacion.text = incidenciaResponse.fechaCreacion.toString()
        binding.DescripcionIncidencia.text = incidenciaResponse.descripcion
        binding.EquipoIncidencia.text = incidenciaResponse.equipo.id.toString() // Aquí accedemos al campo "id" dentro de "equipo"
        binding.btnEstadoIncidencia.text = incidenciaResponse.estado
        binding.FechaCierreIncidencia.text = incidenciaResponse.fechaCierre.toString()


        // Aquí puedes manejar el clic en los botones btnVolver y btnModificar
        binding.btnVolver.setOnClickListener {
            // Implementa aquí la lógica para volver a la actividad anterior
        }

        binding.btnModificar.setOnClickListener {
            // Implementa aquí la lógica para modificar la incidencia
        }

    }
}
