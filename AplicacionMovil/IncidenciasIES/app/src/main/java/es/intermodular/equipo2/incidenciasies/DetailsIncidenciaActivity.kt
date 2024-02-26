package es.intermodular.equipo2.incidenciasies

import android.app.Activity
import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import android.widget.Toast
import androidx.core.content.ContextCompat
import es.intermodular.equipo2.incidenciasies.databinding.ActivityDetailsIncidenciaBinding
import es.intermodular.equipo2.incidenciasies.datos.Api
import es.intermodular.equipo2.incidenciasies.datos.ApiService
import es.intermodular.equipo2.incidenciasies.datos.RetrofitBuilder
import es.intermodular.equipo2.incidenciasies.modelo.ComentarioResponse
import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import javax.security.auth.callback.Callback
import retrofit2.Call
import retrofit2.Response
import retrofit2.Retrofit
import retrofit2.create


class DetailsIncidenciaActivity : AppCompatActivity() {

    private lateinit var binding: ActivityDetailsIncidenciaBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        //Inflamos la vista
        binding = ActivityDetailsIncidenciaBinding.inflate(layoutInflater)
        setContentView(binding.root)

        //NOTA:
        //Cuando obtenemos el estado de la incidencia, dependiendo de su ESTADO
        //el btn (no clicable) será de un color u otro
        //Recogemos la incidenica
        val incidencia = intent.getSerializableExtra("verIncidencia") as IncidenciaResponse
        Log.i("Paso de incidencia ", incidencia.toString())

        asignarValores(incidencia)
        colorBoton(incidencia.estado)


        //Recogemos los comentarios de la api
        obtenerComentariosApi(incidencia.idIncidencia)

        //Boton de enviar
        binding.imagenEnviarComentario.setOnClickListener {
            val comentario = binding.editTextNuevoComentario.text
            if (comentario.isNotEmpty()) {


            } else {
                Toast.makeText(this, "El comentario esta vacio", Toast.LENGTH_SHORT).show()
            }
        }
        binding.btnVolver.setOnClickListener {
            val intent = Intent()
            setResult(Activity.RESULT_OK, intent)
            finish()
        }


    }

    private fun obtenerComentariosApi(idIncidencia: Int) {

        var retrofit = RetrofitBuilder.build()
        CoroutineScope(Dispatchers.IO).launch {
            try {
                val myResponse = retrofit.create(ApiService::class.java)
                    .obtenerComentariosPorIncidencia(idIncidencia)

                myResponse?.let {
                    Log.i("Comentarios incidencia $idIncidencia", it.toString())

                    if (it.isExecuted) {

                    } else {
                        Log.e("Comentarios incidencia", "Error ")

                    }
                }
            } catch (e: Exception) {
                Log.e("Comentarios", "Error: ${e.message}")
            }
        }
    }

    private fun asignarValores(incidencia: IncidenciaResponse) {
        binding.txtTipoIncidencia.text = incidencia.tipo
        binding.txtfechaCreacion.text = incidencia.fechaCreacion.toString()
        binding.DescripcionIncidencia.text = incidencia.descripcion
        binding.EquipoIncidencia.text = incidencia.equipo.id.toString()
        binding.btnEstadoIncidencia.text = incidencia.estado
        binding.FechaCierreIncidencia.text = incidencia.fechaCierre.toString()
    }

    private fun colorBoton(estado: String) {
        when (estado) {
            "abierta" -> binding.btnEstadoIncidencia.setBackgroundColor(
                ContextCompat.getColor(
                    this, R.color.colorEnAbierto
                )
            )

            "asginada" -> binding.btnEstadoIncidencia.setBackgroundColor(
                ContextCompat.getColor(
                    this, R.color.colorAsignado
                )
            )

            "en_proceso" -> binding.btnEstadoIncidencia.setBackgroundColor(
                ContextCompat.getColor(
                    this, R.color.colorEnProceso
                )
            )

            "cerrada" -> binding.btnEstadoIncidencia.setBackgroundColor(
                ContextCompat.getColor(
                    this, R.color.colorCerrado
                )
            )

            "resuelta" -> binding.btnEstadoIncidencia.setBackgroundColor(
                ContextCompat.getColor(
                    this, R.color.colorResuelto
                )
            )

            else -> binding.btnEstadoIncidencia.setBackgroundColor(
                ContextCompat.getColor(
                    this, R.color.theme1
                )
            )
        }
    }


}