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
import es.intermodular.equipo2.incidenciasies.DetailsIncidenciaActivity.Companion.EXTRA_ID
import es.intermodular.equipo2.incidenciasies.databinding.ActivityPrincipalBinding
import es.intermodular.equipo2.incidenciasies.datos.ApiService
import es.intermodular.equipo2.incidenciasies.datos.RetrofitBuilder
import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse
import es.intermodular.equipo2.incidenciasies.recyclerIncidencias.IncidenciaAdapter
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import retrofit2.Retrofit


class Principal : AppCompatActivity() {

    private lateinit var binding: ActivityPrincipalBinding
    private lateinit var retrofit: Retrofit
    private lateinit var adapter: IncidenciaAdapter

    private  var idUsuarioPrueba:Int =0
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        //Inflamos la vista
        binding = ActivityPrincipalBinding.inflate(layoutInflater)
        setContentView(binding.root)

        isOnline(this)

        //recuperamos el id del usuario que se ha pasado anteriormente, mediante un Intent
         idUsuarioPrueba = intent.getIntExtra("ID_PERFIL_EXTRA", -1)

        //region FUNCINALIDAD BOTONES
        //Boton de añadir
        binding.btnAddIncidencias.setOnClickListener {
            val intent = Intent(this, SelectTypeIncidents::class.java)
            startActivity(intent)
        }

        //Botones del ToolBar --> Apartado de notificaciones
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
        //adapter = IncidenciaAdapter { idIncidencia ->  navigateToDetail(idIncidencia) }

        binding.rvIncidencias.layoutManager = LinearLayoutManager(this)
        binding.rvIncidencias.adapter = adapter

        //Mostramos los items
        obtenerIncidencias(idUsuarioPrueba)
    }

    private fun navigateToDetail(incidenciaResponse: IncidenciaResponse) {
        val intent = Intent(this, DetailsIncidenciaActivity::class.java)
        intent.putExtra(EXTRA_ID, incidenciaResponse.idIncidencia)
        intent.putExtra("incidencia", incidenciaResponse)
        startActivity(intent)
    }

    private fun obtenerIncidencias(idUsuarioPrueba: Int) {
        CoroutineScope(Dispatchers.IO).launch {
            try {
                val myResponse = retrofit.create(ApiService::class.java)
                    .getIncidenciasUsuario(idUsuarioPrueba)

                myResponse?.let {
                    Log.i("Incidecias usuario", it.toString())

                    if (it.isSuccessful) {
                        Log.i("Incidecias usuario", "Funciona")
                        val response: List<IncidenciaResponse>? = it.body()
                        response?.let { res ->
                            runOnUiThread {
                                adapter.updateIncidencias(res)

                                // Actualizar el texto de los botones
                                funcionalidadBotones(res)
                            }
                        }
                    } else {
                        Log.e("Incidencias", "Error al obtener las incidencias")
                    }
                }
            } catch (e: Exception) {
                Log.e("Incidencias", "Error: ${e.message}")
            }
        }
    }

    private fun funcionalidadBotones(response: List<IncidenciaResponse>) {
        // Establecer el texto del botón "btnIncidenciasTotales" con el número total de incidencias
        binding.btnIncidenciasTotales.text = "${response.size} Incidencias"

        // Agrupar las incidencias por estado
        val estados = response.groupBy { it.estado }

        // Obtener la lista de incidencias en cada estado o una lista vacía si no hay incidencias en ese estado
        val incidenciasAbiertasFuncionalidad = estados["abierta"] ?: emptyList()
        val incidenciasCerradasFuncionalidad = estados["cerrada"] ?: emptyList()
        val incidenciasAsignadasFuncionalidad = estados["asignada"] ?: emptyList()
        val incidenciasEnProcesoFuncionalidad = estados["en proceso"] ?: emptyList()
        val incidenciasResueltasFuncionalidad = estados["resuelta"] ?: emptyList()

        // Establecer el texto de los botones con la cantidad de incidencias en cada estado
        binding.btnAbiertas.text = "${incidenciasAbiertasFuncionalidad.size} Abiertas"
        binding.btnAsignadas.text = "${incidenciasAsignadasFuncionalidad.size} Asignadas"
        binding.btnEnProceso.text = "${incidenciasEnProcesoFuncionalidad.size} En Proceso"
        binding.btnResueltas.text = "${incidenciasResueltasFuncionalidad.size} Resueltas"
        binding.btnCerradas.text = "${incidenciasCerradasFuncionalidad.size} Cerradas"

        // Configurar el OnClickListener para cada botón
        binding.btnAbiertas.setOnClickListener {
            val intent = Intent(this, SpecificListIncidents::class.java)
            intent.putExtra("EXTRA_TYPE_INCIDENTS", "Abiertas")
            intent.putExtra("EXTRA_INCIDENCIAS", incidenciasAbiertasFuncionalidad.toTypedArray())
            startActivity(intent)
        }
        binding.btnAsignadas.setOnClickListener {
            val intent = Intent(this, SpecificListIncidents::class.java)
            intent.putExtra("EXTRA_TYPE_INCIDENTS", "Asignadas")
            intent.putExtra("EXTRA_INCIDENCIAS", incidenciasAsignadasFuncionalidad.toTypedArray())
            startActivity(intent)
        }
        binding.btnEnProceso.setOnClickListener {
            val intent = Intent(this, SpecificListIncidents::class.java)
            intent.putExtra("EXTRA_TYPE_INCIDENTS", "En proceso")
            intent.putExtra("EXTRA_INCIDENCIAS", incidenciasEnProcesoFuncionalidad.toTypedArray())
            startActivity(intent)
        }
        binding.btnResueltas.setOnClickListener {
            val intent = Intent(this, SpecificListIncidents::class.java)
            intent.putExtra("EXTRA_TYPE_INCIDENTS", "Resueltas")
            intent.putExtra("EXTRA_INCIDENCIAS", incidenciasResueltasFuncionalidad.toTypedArray())
            startActivity(intent)
        }
        binding.btnCerradas.setOnClickListener {
            val intent = Intent(this, SpecificListIncidents::class.java)
            intent.putExtra("EXTRA_TYPE_INCIDENTS", "Cerradas")
            intent.putExtra("EXTRA_INCIDENCIAS", incidenciasCerradasFuncionalidad.toTypedArray())
            startActivity(intent)
        }
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