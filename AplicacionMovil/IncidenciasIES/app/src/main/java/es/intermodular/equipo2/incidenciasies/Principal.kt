package es.intermodular.equipo2.incidenciasies

import android.content.Intent
import android.content.res.Configuration
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.ImageView
import android.widget.PopupMenu
import androidx.appcompat.app.AlertDialog
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import es.intermodular.equipo2.incidenciasies.CrearModificarIncidencia.SelectTypeIncidents
import es.intermodular.equipo2.incidenciasies.databinding.ActivityPrincipalBinding
import es.intermodular.equipo2.incidenciasies.modelo.Incidencia
import es.intermodular.equipo2.incidenciasies.recyclerIncidencias.IncidenciaAdapter
import java.util.Date
import java.util.Locale

class Principal : AppCompatActivity() {

    private lateinit var binding: ActivityPrincipalBinding
    var recyclerView: RecyclerView? = null


    var adapter: RecyclerView.Adapter<*>? = null
    var layoutManager: RecyclerView.LayoutManager? = null
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        //Inflamos la vista
        binding = ActivityPrincipalBinding.inflate(layoutInflater)
        setContentView(binding.root)

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

        //Damos funcionalidad a los botones del ToolBar
        binding.menuNotificaciones.setOnClickListener {
            val intent = Intent(this, NotificationsActivity::class.java)
            startActivity(intent)
        }

        val menuAjustes = findViewById<ImageView>(R.id.menuAjustes)

        // Configurar el OnClickListener para el ícono de ajustes
        menuAjustes.setOnClickListener { view ->
            // Crear un objeto PopupMenu asociado con el ícono de ajustes
            val popupMenu = PopupMenu(this@Principal, view)

            // Inflar el menú desde el archivo XML
            popupMenu.menuInflater.inflate(R.menu.menu_settings, popupMenu.menu)

            // Configurar el Listener para manejar las acciones del menú
            popupMenu.setOnMenuItemClickListener { item ->
                when (item.itemId) {
                    R.id.action_help -> {
                        // Lógica para el elemento "Ayuda"
                        mostrarLayoutAyuda()
                        true
                    }

                    R.id.action_about -> {
                        // Lógica para el elemento "Acerca de"
                        mostrarLayoutAcercaDe()
                        true
                    }

                    else -> false
                }
            }

            // Mostrar el menú desplegable
            popupMenu.show()
        }
    }

    private fun mostrarLayoutAyuda() {
        // Inflar el layout activity_about.xml
        val helpView = layoutInflater.inflate(R.layout.activity_help, null)

        // Configurar el contenido de la vista

        // Añadir la vista a tu layout principal
        setContentView(helpView)
    }

    private fun mostrarLayoutAcercaDe() {
        // Inflar el layout activity_about.xml
        val aboutView = layoutInflater.inflate(R.layout.activity_about, null)

        // Configurar el contenido de la vista

        // Añadir la vista a tu layout principal
        setContentView(aboutView)
    }

}