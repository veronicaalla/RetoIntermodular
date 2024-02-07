package es.intermodular.equipo2.incidenciasies

import android.content.Intent
import android.content.res.Configuration
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import androidx.recyclerview.widget.RecyclerView
import es.intermodular.equipo2.incidenciasies.CrearModificarIncidencia.SelectTypeIncidents
import es.intermodular.equipo2.incidenciasies.databinding.ActivityPrincipalBinding
import java.util.Locale

class Principal : AppCompatActivity() {

    private lateinit var binding: ActivityPrincipalBinding
    var recyclerView: RecyclerView? = null
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        //Inflamos la vista
        binding = ActivityPrincipalBinding.inflate(layoutInflater)
        setContentView(binding.root)

        fun changeLanguage(view: View) {
            // Cambiar el idioma de la aplicación aquí
            // Por ejemplo, para cambiar al inglés:
            val locale = Locale("en")
            Locale.setDefault(locale)
            val config = Configuration()
            config.locale = locale
            baseContext.resources.updateConfiguration(config, baseContext.resources.displayMetrics)

            // Reiniciar la actividad para aplicar el cambio de idioma
            recreate()
        }

        //We give functionality to the buttons
        binding.btnAbiertas.setOnClickListener {
            val intent = Intent(this, SpecificListIncidents::class.java)
            //We pass the type of incident
            intent.putExtra("EXTRA_TYPE_INCIDENTS", "Abiertas")
            //We pass a certain list
            //La lista la conseguimos con un método de la api
            startActivity(intent)
        }

        binding.btnAsignadas.setOnClickListener {
            val intent = Intent(this, SpecificListIncidents::class.java)
            //We pass the type of incident
            intent.putExtra("EXTRA_TYPE_INCIDENTS", "Asignadas")
            //We pass a certain list

            startActivity(intent)
        }

        binding.btnEnProceso.setOnClickListener {
            val intent = Intent(this, SpecificListIncidents::class.java)
            //We pass the type of incident
            intent.putExtra("EXTRA_TYPE_INCIDENTS", "En Proceso")
            //We pass a certain list

            startActivity(intent)
        }

        binding.btnResueltas.setOnClickListener {
            val intent = Intent(this, SpecificListIncidents::class.java)
            //We pass the type of incident
            intent.putExtra("EXTRA_TYPE_INCIDENTS", "Resueltas")
            //We pass a certain list

            startActivity(intent)
        }

        binding.btnCerradas.setOnClickListener {
            val intent = Intent(this, SpecificListIncidents::class.java)
            //We pass the type of incident
            intent.putExtra("EXTRA_TYPE_INCIDENTS", "Cerradas")
            //We pass a certain list

            startActivity(intent)
        }

        //Damos funcionalidad al boton de añadir
        binding.btnAddIncidencias.setOnClickListener {
            val intent = Intent(this, SelectTypeIncidents::class.java)
            startActivity(intent)
        }
    }
}