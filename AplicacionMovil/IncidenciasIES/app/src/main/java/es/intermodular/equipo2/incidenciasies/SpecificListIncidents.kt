package es.intermodular.equipo2.incidenciasies

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import es.intermodular.equipo2.incidenciasies.databinding.ActivitySpecificListIncidentsBinding
import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse
import es.intermodular.equipo2.incidenciasies.recyclerIncidencias.IncidenciaAdapter

class SpecificListIncidents : AppCompatActivity() {

    private lateinit var binding: ActivitySpecificListIncidentsBinding
    private lateinit var adapter: IncidenciaAdapter

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        // Inflar la vista
        binding = ActivitySpecificListIncidentsBinding.inflate(layoutInflater)
        setContentView(binding.root)

        // Recogemos el valor del Intent que se ha pasado
        val typeOfIncidents = intent.extras?.getString("EXTRA_TYPE_INCIDENTS").orEmpty()

        binding.tituloIncidencias.text = "Incidencias $typeOfIncidents"

        binding.menuAtras.setOnClickListener {
            finish()
        }

        // Configurar el RecyclerView
        adapter = IncidenciaAdapter { incidenciaId ->
            startActivity(
                Intent(
                    this,
                    DetailsIncidenciaActivity::class.java
                )
            )
        }
        binding.rvIncidenciasEspecificas.layoutManager = LinearLayoutManager(this)
        binding.rvIncidenciasEspecificas.adapter = adapter

        // Obtener la lista de incidencias del Intent
        val incidencias = intent.getSerializableExtra("EXTRA_INCIDENCIAS") as Array<IncidenciaResponse>

        // Actualizar el adaptador con la lista de incidencias
        adapter.updateIncidencias(incidencias.toList())

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