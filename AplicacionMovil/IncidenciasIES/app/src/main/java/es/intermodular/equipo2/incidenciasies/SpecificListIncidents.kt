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
    }
}