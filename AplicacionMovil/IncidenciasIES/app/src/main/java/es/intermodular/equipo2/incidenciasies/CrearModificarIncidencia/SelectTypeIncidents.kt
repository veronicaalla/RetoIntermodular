package es.intermodular.equipo2.incidenciasies.CrearModificarIncidencia

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import es.intermodular.equipo2.incidenciasies.R
import es.intermodular.equipo2.incidenciasies.databinding.ActivityEditIncidentBinding
import es.intermodular.equipo2.incidenciasies.databinding.ActivitySelectTypeIncidentsBinding

class SelectTypeIncidents : AppCompatActivity() {

    private lateinit var binding: ActivitySelectTypeIncidentsBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        //Inflamos la vista
        binding = ActivitySelectTypeIncidentsBinding.inflate(layoutInflater)
        setContentView(binding.root)




    }
}