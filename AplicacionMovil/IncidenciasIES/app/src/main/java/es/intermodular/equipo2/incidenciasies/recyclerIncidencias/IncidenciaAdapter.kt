package es.intermodular.equipo2.incidenciasies.recyclerIncidencias

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import es.intermodular.equipo2.incidenciasies.R
import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse

class IncidenciaAdapter(
    var incidencias: List<IncidenciaResponse> = emptyList(),
    private val onItemSelect: (IncidenciaResponse) -> Unit
) : RecyclerView.Adapter<IncidenciaViewHolder>() {

    fun updateIncidencias(list: List<IncidenciaResponse>) {
        incidencias = list
        notifyDataSetChanged()
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): IncidenciaViewHolder {
        return IncidenciaViewHolder(
            LayoutInflater.from(parent.context).inflate(R.layout.item_incidencias, parent, false)
        )
    }

    override fun onBindViewHolder(holder: IncidenciaViewHolder, position: Int) {
        holder.bind(incidencias[position], onItemSelect)
    }

    override fun getItemCount() = incidencias.size
}