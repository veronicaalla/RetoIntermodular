package es.intermodular.equipo2.incidenciasies

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import androidx.recyclerview.widget.RecyclerView
import es.intermodular.equipo2.incidenciasies.databinding.ActivitySpecificListIncidentsBinding

class SpecificListIncidents : AppCompatActivity() {

    private lateinit var binding: ActivitySpecificListIncidentsBinding
    var recyclerView: RecyclerView? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        //Inflamos la vista
        binding = ActivitySpecificListIncidentsBinding.inflate(layoutInflater)
        setContentView(binding.root)

        //Recogemos el valor del Intent que se ha pasado
        val typeOfIncidents = intent.extras?.getString("EXTRA_TYPE_INCIDENTS").orEmpty()

        binding.tituloIncidencias.text = "Indicencias $typeOfIncidents"

        binding.menuAtras.setOnClickListener {
            finish()
        }

        when (typeOfIncidents) {
            "Abiertas" -> {
                binding.toolbar.setBackgroundColor(getResources().getColor(R.color.colorEnAbierto))
            }

            "Asignadas" -> {
                binding.toolbar.setBackgroundColor(getResources().getColor(R.color.colorAsignado))
            }

            "En Proceso" -> {
                binding.toolbar.setBackgroundColor(getResources().getColor(R.color.colorEnProceso))
            }

            "Resueltas" -> {
                binding.toolbar.setBackgroundColor(getResources().getColor(R.color.colorResuelto))
            }

            "Cerradas" -> {
                binding.toolbar.setBackgroundColor(getResources().getColor(R.color.colorCerrado))
            }

        }
    }
}