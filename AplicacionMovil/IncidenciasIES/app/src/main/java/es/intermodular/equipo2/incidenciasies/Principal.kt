package es.intermodular.equipo2.incidenciasies

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.ImageView
import android.widget.LinearLayout
import android.widget.PopupMenu
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import es.intermodular.equipo2.incidenciasies.CrearModificarIncidencia.SelectTypeIncidents
import es.intermodular.equipo2.incidenciasies.databinding.ActivityPrincipalBinding
import es.intermodular.equipo2.incidenciasies.datos.IncidenciaApiService
import es.intermodular.equipo2.incidenciasies.datos.RetrofitBuilder
import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse
import es.intermodular.equipo2.incidenciasies.recyclerIncidencias.IncidenciaAdapter
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import okhttp3.Dispatcher
import retrofit2.Response
import retrofit2.Retrofit

class Principal : AppCompatActivity() {

    private lateinit var binding: ActivityPrincipalBinding
    private lateinit var retrofit: Retrofit
    var adapter: RecyclerView.Adapter<*>? = null

    var recyclerView: RecyclerView? = null
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

        initUI()


    }

    private fun initUI() {
        //Damos valor al recycler view
        retrofit = RetrofitBuilder.build()
        adapter = IncidenciaAdapter { incidenciaId ->
            startActivity(
                Intent(
                    this,
                    DetailsIncidenciaActivity::class.java
                )
            )
        }
        binding.rvIncidencias.layoutManager = LinearLayoutManager(this)
        binding.rvIncidencias.adapter = adapter

        //Mostramos los items

    }

    private fun mostrarLayoutAyuda() {
        // Inflar el layout activity_help.xml
        val helpView = layoutInflater.inflate(R.layout.activity_help, null)

        // Encontrar el botón de retroceso en el layout inflado
        val menuAtras = helpView.findViewById<ImageView>(R.id.menuAtras)

        // Configurar el OnClickListener para el botón de retroceso
        menuAtras.setOnClickListener {
            // Crear un intent para iniciar la actividad Principal
            val intent = Intent(this, Principal::class.java)
            // Iniciar la actividad Principal
            startActivity(intent)
            // Cerrar la actividad actual si es necesario
            finish()
        }

        // Añadir la vista a tu layout principal
        CoroutineScope(Dispatchers.IO).launch {
            val myResponse: List<IncidenciaResponse> =
                retrofit.create(IncidenciaApiService::class.java).getIncidencias()

            //if (myResponse.isSu)
        }
    }

    private fun mostrarLayoutAcercaDe() {
        // Inflar el layout activity_about.xml
        val aboutView = layoutInflater.inflate(R.layout.activity_about, null)

        // Encontrar el botón de retroceso en el layout inflado
        val menuAtras = aboutView.findViewById<ImageView>(R.id.menuAtras)

        // Configurar el OnClickListener para el botón de retroceso
        menuAtras.setOnClickListener {
            // Crear un intent para iniciar la actividad Principal
            val intent = Intent(this, Principal::class.java)
            // Iniciar la actividad Principal
            startActivity(intent)
            // Cerrar la actividad actual si es necesario
            finish()
        }

        // Añadir la vista a tu layout principal
        setContentView(aboutView)


    }

}