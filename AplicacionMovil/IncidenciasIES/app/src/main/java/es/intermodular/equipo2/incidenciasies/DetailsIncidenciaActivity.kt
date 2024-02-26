package es.intermodular.equipo2.incidenciasies

import android.app.Activity
import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import androidx.core.content.ContextCompat
import es.intermodular.equipo2.incidenciasies.databinding.ActivityDetailsIncidenciaBinding
import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse

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

        binding.btnVolver.setOnClickListener {
            val intent = Intent()
            setResult(Activity.RESULT_OK, intent)
            finish()
        }


        asignarValores(incidencia)
        when (incidencia.estado) {
            "abierta" -> binding.btnEstadoIncidencia.setBackgroundColor(
                ContextCompat.getColor(
                    this,
                    R.color.colorEnAbierto
                )
            )

            "asginada" -> binding.btnEstadoIncidencia.setBackgroundColor(
                ContextCompat.getColor(
                    this,
                    R.color.colorAsignado
                )
            )

            "en_proceso" -> binding.btnEstadoIncidencia.setBackgroundColor(
                ContextCompat.getColor(
                    this,
                    R.color.colorEnProceso
                )
            )

            "cerrada" -> binding.btnEstadoIncidencia.setBackgroundColor(
                ContextCompat.getColor(
                    this,
                    R.color.colorCerrado
                )
            )

            "resuelta" -> binding.btnEstadoIncidencia.setBackgroundColor(
                ContextCompat.getColor(
                    this,
                    R.color.colorResuelto
                )
            )

            else -> binding.btnEstadoIncidencia.setBackgroundColor(
                ContextCompat.getColor(
                    this,
                    R.color.theme1
                )
            )
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


}