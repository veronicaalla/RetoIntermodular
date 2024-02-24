package es.intermodular.equipo2.incidenciasies.recyclerIncidencias

import android.content.Intent
import android.util.Log
import android.view.View
import android.widget.LinearLayout
import android.widget.Toast
import androidx.core.content.ContextCompat
import androidx.recyclerview.widget.RecyclerView
import com.google.android.material.dialog.MaterialAlertDialogBuilder
import es.intermodular.equipo2.incidenciasies.CrearModificarIncidencia.EditIncident
import es.intermodular.equipo2.incidenciasies.R
import es.intermodular.equipo2.incidenciasies.databinding.ItemIncidenciasBinding
import es.intermodular.equipo2.incidenciasies.datos.Api
import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse
import retrofit2.Call
import retrofit2.Callback
import retrofit2.Response


class IncidenciaViewHolder(view: View) : RecyclerView.ViewHolder(view) {

    private val binding = ItemIncidenciasBinding.bind(view)

    fun bind(
        incidenciasResponse: IncidenciaResponse,
        onItemSelected: (IncidenciaResponse) -> Unit
    ) {
        binding.txtFecha.text = incidenciasResponse.fechaCreacion.toString()
        binding.txtIncidenciaID.text = "Incidencia #${incidenciasResponse.idIncidencia}"

        binding.btnEstadoIncidencai.text = incidenciasResponse.estado
        //Modificamos el color
        //Lo tipos de valores son --> ENUM('abierta', 'asignada', 'en_proceso', 'enviada_a_Infortec', 'resuelta', 'cerrada')
        when (incidenciasResponse.estado) {
            "abierta" -> binding.btnEstadoIncidencai.setBackgroundColor(
                ContextCompat.getColor(
                    itemView.context,
                    R.color.colorEnAbierto
                )
            )

            "asignada" -> binding.btnEstadoIncidencai.setBackgroundColor(
                ContextCompat.getColor(
                    itemView.context,
                    R.color.colorAsignado
                )
            )

            "en_proceso" -> binding.btnEstadoIncidencai.setBackgroundColor(
                ContextCompat.getColor(
                    itemView.context,
                    R.color.colorEnProceso
                )
            )

            "resuelta" -> binding.btnEstadoIncidencai.setBackgroundColor(
                ContextCompat.getColor(
                    itemView.context,
                    R.color.colorResuelto
                )
            )

            "cerrada" -> binding.btnEstadoIncidencai.setBackgroundColor(
                ContextCompat.getColor(
                    itemView.context,
                    R.color.colorCerrado
                )
            )
        }

        if (incidenciasResponse.estado.contains("abierta") || incidenciasResponse.estado.contains("asignada")) {
            Log.i("Tipo incidencia ", incidenciasResponse.estado)
            binding.btnEditarIncidencias.setOnClickListener {
                val intent = Intent(it.context, EditIncident::class.java)
                ////Para poder pasarle la incidencia, debido a que hemos puesto la clase Incidencia como Serializable
                Log.i("Paso de incidencia ", incidenciasResponse.toString())
                intent.putExtra(EditIncident.EXTRA_EDIT_INCIDENCIA, incidenciasResponse)
                intent.putExtra("incidencia", 1)
                ContextCompat.startActivity(it.context, intent, null)
            }

            binding.btnEliminarIncidencia.setOnClickListener {
                Toast.makeText(it.context, "Eliminar incidencia ", Toast.LENGTH_SHORT).show()
                //Comprobamos si el usuario de verdad desea eliminar la incidencia
                eliminarIncidencia(incidenciasResponse)
            }
        } else {
            binding.btnEditarIncidencias.setVisibility(View.INVISIBLE);
            binding.btnEliminarIncidencia.setVisibility(View.INVISIBLE)
        }



        binding.txtTipoIncidencia.text =
            " ${incidenciasResponse.tipoIncidencia.tipo} ${incidenciasResponse.tipoIncidencia.subtipoNombre} ${incidenciasResponse.tipoIncidencia.subSubtipo}"

        binding.root.setOnClickListener { onItemSelected(incidenciasResponse) }
    }

    private fun eliminarIncidencia(incidenciasResponse: IncidenciaResponse) {

        // Creamos la ventana emergente
        val dialog = MaterialAlertDialogBuilder(itemView.context)
            .setTitle("Eliminar")
            .setMessage("¿Estas seguro de que desea eliminar la incidencia?")

            // Acción que se realiza al dar "Añadir"
            .setPositiveButton("SI") { _, _ ->

                Log.i("Incidencia para elliminar", incidenciasResponse.toString())
                Api.retrofitService.borrarIncidencia(incidenciasResponse.idIncidencia)
                    .enqueue(object : Callback<IncidenciaResponse> {
                        override fun onResponse(
                            call: Call<IncidenciaResponse>,
                            response: Response<IncidenciaResponse>
                        ) {
                            if (response.isSuccessful) {
                                val myResponse = response.body()
                                Log.i("Incidencia eliminada ", myResponse.toString())
                            } else {
                                Log.i("No se ha podido eliminar", )
                            }
                        }

                        override fun onFailure(call: Call<IncidenciaResponse>, t: Throwable) {
                            Log.i("Eror en la solicitud", t.message.toString())
                        }
                    })
            }
            .setNegativeButton("NO", null)
            .create()
        dialog.show()
    }
}


