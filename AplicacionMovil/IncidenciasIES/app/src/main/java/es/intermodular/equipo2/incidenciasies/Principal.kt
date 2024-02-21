package es.intermodular.equipo2.incidenciasies

import android.content.Context
import android.content.Intent
import android.net.ConnectivityManager
import android.os.Bundle
import android.util.Log
import android.widget.ImageView
import android.widget.PopupMenu
import androidx.appcompat.app.AppCompatActivity
import androidx.recyclerview.widget.LinearLayoutManager
import es.intermodular.equipo2.incidenciasies.CrearModificarIncidencia.SelectTypeIncidents
import es.intermodular.equipo2.incidenciasies.databinding.ActivityPrincipalBinding
import es.intermodular.equipo2.incidenciasies.datos.IncidenciaApiService
import es.intermodular.equipo2.incidenciasies.datos.RetrofitBuilder
import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse
import es.intermodular.equipo2.incidenciasies.recyclerIncidencias.IncidenciaAdapter
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import retrofit2.Response
import retrofit2.Retrofit


class Principal : AppCompatActivity() {

    private lateinit var binding: ActivityPrincipalBinding
    private lateinit var retrofit: Retrofit
    private lateinit var adapter: IncidenciaAdapter

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        //Inflamos la vista
        binding = ActivityPrincipalBinding.inflate(layoutInflater)
        setContentView(binding.root)

        isOnline(this)


        //region Damos funcionalidad a los botones
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

        //endregion


        //region Damos funcionalidad al menu
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

        //endregion


        retrofit = RetrofitBuilder.build()
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
        val idUsuarioPrueba: Int = 1;
        obtenerIncidencias(idUsuarioPrueba)
    }

    private fun obtenerIncidencias(idUsuarioPrueba: Int) {
        CoroutineScope(Dispatchers.IO).launch {
            try {
                val myResponse: Response<List<IncidenciaResponse>> =
                    retrofit.create(IncidenciaApiService::class.java)
                        .getIncidenciasUsuario(idUsuarioPrueba)

                if (myResponse != null) {
                    Log.i("Incidecias usuario", myResponse.toString())
                }

                if (myResponse.isSuccessful) {
                    Log.i("Incidecias usuario", "Funciona")
                    val response: List<IncidenciaResponse>? = myResponse.body()
                    if (response != null) {
                        runOnUiThread {
                            adapter.updateIncidencias(response)
                            funcionalidadBotones(response)
                        }
                    }
                } else {
                    Log.e("Incidencias", "Error al obtener las incidencias")
                }
            } catch (e: Exception) {
                Log.e("Incidencias", "Error: ${e.message}")
            }
        }
    }

    private fun funcionalidadBotones(response: List<IncidenciaResponse>) {
        binding.btnIncidenciasTotales.text = "${response.size} Incidencias"

        var incidenciasAbiertas: MutableList<IncidenciaResponse> =
            mutableListOf<IncidenciaResponse>()
        var incidenciasAsignadas: MutableList<IncidenciaResponse> =
            mutableListOf<IncidenciaResponse>()
        var incidenciasEnProceso: MutableList<IncidenciaResponse> =
            mutableListOf<IncidenciaResponse>()
        var incidenciasResueltas: MutableList<IncidenciaResponse> =
            mutableListOf<IncidenciaResponse>()
        var incidenciasCerradas: MutableList<IncidenciaResponse> =
            mutableListOf<IncidenciaResponse>()

        for (i in response) {
            when (i.tipo) {
                "abierta" -> incidenciasAbiertas.add(i)
                "asignadas" -> incidenciasAsignadas.add(i)
                "en proceso" -> incidenciasEnProceso.add(i)
                "resueltas" -> incidenciasResueltas.add(i)
                "cerradas" -> incidenciasCerradas.add(i)
            }
        }

        //region Le asignamos el texto correspondiente a los botones
        binding.btnAbiertas.text = "${incidenciasAbiertas.size} Abiertas"
        binding.btnAsignadas.text = "${incidenciasAsignadas.size} Asignadas"
        binding.btnEnProceso.text = "${incidenciasEnProceso.size} En proceso"
        binding.btnResueltas.text = "${incidenciasResueltas.size} Resueltas"
        binding.btnCerradas.text = "${incidenciasCerradas.size} Cerradas"
        //enregion

        //region Le damos la funcionalidad al boton

        //endregion

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
        setContentView(helpView)
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

    fun isOnline(context: Context): Boolean {
        val connectivityManager =
            context.getSystemService(CONNECTIVITY_SERVICE) as ConnectivityManager
        val networkInfo = connectivityManager.activeNetworkInfo
        return networkInfo != null && networkInfo.isAvailable && networkInfo.isConnected
    }

}