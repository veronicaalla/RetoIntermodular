package es.intermodular.equipo2.incidenciasies

import android.app.Activity
import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import es.intermodular.equipo2.incidenciasies.databinding.ActivityDetailsIncidenciaBinding

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
        val incidencia = intent.getSerializableExtra("verIncidencia")
        Log.i("Paso de incidencia ", incidencia.toString())

        // Configuramos el onClickListener para el botón "Volver"
        binding.btnVolver.setOnClickListener {
            val intent = Intent()
            setResult(Activity.RESULT_OK, intent)
            finish()
        }
    }
}