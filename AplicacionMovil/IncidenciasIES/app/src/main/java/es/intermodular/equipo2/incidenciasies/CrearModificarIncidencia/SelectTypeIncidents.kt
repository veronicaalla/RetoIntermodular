package es.intermodular.equipo2.incidenciasies.CrearModificarIncidencia

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.AdapterView
import android.widget.ArrayAdapter
import android.widget.Toast
import es.intermodular.equipo2.incidenciasies.R
import es.intermodular.equipo2.incidenciasies.databinding.ActivitySelectTypeIncidentsBinding

class SelectTypeIncidents : AppCompatActivity() {

    private lateinit var binding: ActivitySelectTypeIncidentsBinding
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        //Inflamos la vista
        binding = ActivitySelectTypeIncidentsBinding.inflate(layoutInflater)
        setContentView(binding.root)

        //En la inicializacion, no se debe ver
        val spinnerSubSub = binding.spinnerSubSubTipo
        spinnerSubSub.visibility = View.GONE
        binding.txtSubSubTipo.visibility = View.GONE


        var TipoDeIncidenciaSeleccionada: String //EN el almacenaremos una cad con el texto total
        val spinnerTipoIncidencia = binding.spinnerTipoIncidencia

        spinnerTipoIncidencia.onItemSelectedListener = object : AdapterView.OnItemSelectedListener {
            override fun onItemSelected(
                parent: AdapterView<*>, view: View,
                position: Int, id: Long
            ) {
                // Aquí puedes realizar las modificaciones que necesites
                // Por ejemplo, puedes obtener el valor seleccionado con:
                val selectedValue = parent.getItemAtPosition(position)
                // Luego, puedes realizar las modificaciones que necesites con el valor seleccionado
                actualizacionSubSpinners(selectedValue)
            }

            override fun onNothingSelected(parent: AdapterView<*>) {
                // Este método se llama cuando no se selecciona ningún elemento del Spinner
                // Aquí puedes realizar las modificaciones que necesites en caso de que no se seleccione ningún elemento
            }
        }

        var spinnerSub = binding.spinnerSubtipo
        spinnerSub.onItemSelectedListener = object : AdapterView.OnItemSelectedListener {
            override fun onItemSelected(
                parent: AdapterView<*>, view: View,
                position: Int, id: Long
            ) {
                // Aquí puedes realizar las modificaciones que necesites
                // Por ejemplo, puedes obtener el valor seleccionado con:
                val selectedValue = parent.getItemAtPosition(position)
                // Luego, puedes realizar las modificaciones que necesites con el valor seleccionado
                actualizacionSubSub(selectedValue)
            }

            override fun onNothingSelected(parent: AdapterView<*>) {
                // Este método se llama cuando no se selecciona ningún elemento del Spinner
                // Aquí puedes realizar las modificaciones que necesites en caso de que no se seleccione ningún elemento
            }
        }

    }

    fun actualizacionSubSub(selectedValue: Any) {
        if (selectedValue.equals("PC")) {

            binding.spinnerSubSubTipo.visibility = View.VISIBLE
            binding.txtSubSubTipo.visibility = View.VISIBLE

            val adapter = ArrayAdapter<CharSequence>(
                this,
                android.R.layout.simple_spinner_item,
                resources.getStringArray(R.array.IncidenciaEquiposPc)
            )
            binding.spinnerSubSubTipo.adapter = adapter

        }else if (selectedValue.equals("ALTAVOZ")) {

            binding.spinnerSubSubTipo.visibility = View.VISIBLE
            binding.txtSubSubTipo.visibility = View.VISIBLE

            val adapter = ArrayAdapter<CharSequence>(
                this,
                android.R.layout.simple_spinner_item,
                resources.getStringArray(R.array.IncidenciaEquiposPortatil)
            )

            binding.spinnerSubSubTipo.adapter = adapter

        }else{
            binding.spinnerSubSubTipo.visibility = View.GONE
            binding.txtSubSubTipo.visibility = View.GONE
        }

    }


    fun actualizacionSubSpinners(selectedValue: Any) {
        if (selectedValue.equals("EQUIPOS")) {

            val adapter = ArrayAdapter<CharSequence>(
                this,
                android.R.layout.simple_spinner_item,
                resources.getStringArray(R.array.IncidenciaEquipos)
            )

            binding.spinnerSubtipo.adapter = adapter
        }

        if (selectedValue.equals("CUENTAS")) {
            val adapter = ArrayAdapter<CharSequence>(
                this,
                android.R.layout.simple_spinner_item,
                resources.getStringArray(R.array.IncidenciaCuentas)
            )

            binding.spinnerSubtipo.adapter = adapter
        }

        if (selectedValue.equals("WIFI")) {
            val adapter = ArrayAdapter<CharSequence>(
                this,
                android.R.layout.simple_spinner_item,
                resources.getStringArray(R.array.IncidenciaWIFI)
            )

            binding.spinnerSubtipo.adapter = adapter
        }

        if (selectedValue.equals("INTERNET")) {
            val adapter = ArrayAdapter<CharSequence>(
                this,
                android.R.layout.simple_spinner_item,
                resources.getStringArray(R.array.IncidenciaInternet)
            )

            binding.spinnerSubtipo.adapter = adapter
        }
    }
}

