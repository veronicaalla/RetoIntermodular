package es.intermodular.equipo2.incidenciasies

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import es.intermodular.equipo2.incidenciasies.databinding.ActivityPrincipalBinding

class Principal : AppCompatActivity() {

    private lateinit var binding : ActivityPrincipalBinding
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        //Inflamos la vista
        binding = ActivityPrincipalBinding.inflate(layoutInflater)
        setContentView(binding.root)
    }
}