package es.intermodular.equipo2.incidenciasies.recyclerIncidencias

import android.content.Intent
import android.util.Log
import android.view.View
import android.widget.Toast
import androidx.core.content.ContextCompat
import androidx.recyclerview.widget.RecyclerView
import es.intermodular.equipo2.incidenciasies.CrearModificarIncidencia.EditIncident
import es.intermodular.equipo2.incidenciasies.R
import es.intermodular.equipo2.incidenciasies.databinding.ItemIncidenciasBinding
import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse


class IncidenciaViewHolder(view: View) : RecyclerView.ViewHolder(view) {

    private val binding = ItemIncidenciasBinding.bind(view)

    fun bind(incidenciasResponse: IncidenciaResponse, onItemSelected: (String) -> Unit) {
        binding.txtFecha.text = incidenciasResponse.fechaCreacion.toString()
        binding.txtIncidenciaID.text = "Incidencia #${incidenciasResponse.idIncidencia}"

        binding.btnEstadoIncidencai.text = incidenciasResponse.estado
        //Modificamos el color
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

            "en proceso" -> binding.btnEstadoIncidencai.setBackgroundColor(
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
                Toast.makeText(it.context, "Editar incidecia ", Toast.LENGTH_SHORT).show()
                val intent = Intent(it.context, EditIncident::class.java)
                ////Para poder pasarle la pelicula, hemos puesto la clase Film como Serializable
                //            intent.putExtra(FilmEditActivity.EXTRA_EDIT_FILM, film)
                intent.putExtra(EditIncident.EXTRA_EDIT_INCIDENCIA, incidenciasResponse)
                Log.i("Paso de incidencia ", incidenciasResponse.toString())
                ContextCompat.startActivity(it.context, intent, null )
            }
        } else {
            binding.btnEditarIncidencias.setVisibility(View.INVISIBLE);
        }



        binding.txtTipoIncidencia.text =
            " ${incidenciasResponse.tipoIncidencia.tipo} ${incidenciasResponse.tipoIncidencia.subtipoNombre} ${incidenciasResponse.tipoIncidencia.subSubtipo}"

       // binding.root.setOnClickListener { onItemSelected(incidenciasResponse.idIncidencia) }
    }
}

