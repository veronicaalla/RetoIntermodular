package es.intermodular.equipo2.incidenciasies

import android.app.Activity
import android.content.Intent
import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import androidx.core.content.ContextCompat
import es.intermodular.equipo2.incidenciasies.databinding.ActivityDetailsIncidenciaBinding
import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse

class DetailsIncidenciaActivity : AppCompatActivity() {

    private lateinit var binding: ActivityDetailsIncidenciaBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        //Inflamos la vista
        binding = ActivityDetailsIncidenciaBinding.inflate(layoutInflater)
        setContentView(binding.root)

        //Recogemos la incidencia
        val incidencia = intent.getSerializableExtra("verIncidencia") as IncidenciaResponse

        // Configuramos el onClickListener para el botón "Volver"
        binding.btnVolver.setOnClickListener {
            val intent = Intent()
            setResult(Activity.RESULT_OK, intent)
            finish()
        }

        //Establecemos los datos de la incidencia en los elementos de la interfaz de usuario
        binding.txtTipoIncidencia.text = incidencia.tipo
        binding.txtfechaCreacion.text = incidencia.fechaCreacion.toString()
        binding.DescripcionIncidencia.text = incidencia.descripcion
        binding.EquipoIncidencia.text = incidencia.equipo.id.toString()
        binding.btnEstadoIncidencia.text = incidencia.estado
        binding.FechaCierreIncidencia.text = incidencia.fechaCierre.toString()

        /*
        // Cambiar el color de fondo del botón según el estado de la incidencia
        when (incidencia.estado) {
            "En Abierto" -> binding.btnEstadoIncidencia.setBackgroundColor(ContextCompat.getColor(this, R.color.colorEnAbierto))
            "Asignado" -> binding.btnEstadoIncidencia.setBackgroundColor(ContextCompat.getColor(this, R.color.colorAsignado))
            "En Proceso" -> binding.btnEstadoIncidencia.setBackgroundColor(ContextCompat.getColor(this, R.color.colorEnProceso))
            "Cerrado" -> binding.btnEstadoIncidencia.setBackgroundColor(ContextCompat.getColor(this, R.color.colorCerrado))
            "Resuelto" -> binding.btnEstadoIncidencia.setBackgroundColor(ContextCompat.getColor(this, R.color.colorResuelto))
            else -> binding.btnEstadoIncidencia.setBackgroundColor(ContextCompat.getColor(this, R.color.theme1))
        }
        */
    }
}
