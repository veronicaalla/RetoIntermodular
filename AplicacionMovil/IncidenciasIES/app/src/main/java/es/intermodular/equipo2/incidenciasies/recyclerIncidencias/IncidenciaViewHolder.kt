package es.intermodular.equipo2.incidenciasies.recyclerIncidencias

import android.view.View
import androidx.recyclerview.widget.RecyclerView
import es.intermodular.equipo2.incidenciasies.R
import es.intermodular.equipo2.incidenciasies.databinding.ItemIncidenciasBinding
import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse

class IncidenciaViewHolder(view: View) : RecyclerView.ViewHolder(view) {

    private val binding = ItemIncidenciasBinding.bind(view)

    fun bind(incidenciasResponse: IncidenciaResponse, onItemSelected: (String) -> Unit) {
        binding.txtFecha.text = incidenciasResponse.fechaCreacion.toString()
        binding.txtIncidenciaID.text= "Incidencia #${incidenciasResponse.idIncidencia}"

        binding.btnEstadoIncidencai.text = incidenciasResponse.estado
        //Modificamos el color

        binding.txtTipoIncidencia.text = " ${incidenciasResponse.tipoIncidencia.tipo} ${incidenciasResponse.tipoIncidencia.subtipoNombre} ${incidenciasResponse.tipoIncidencia.subSubtipo}"
    //binding.root.setOnClickListener { onItemSelected(incidenciasResponse.idIncidencia) }
    }
}

