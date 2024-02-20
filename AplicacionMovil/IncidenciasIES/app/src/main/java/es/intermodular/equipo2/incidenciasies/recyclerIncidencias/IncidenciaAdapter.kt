package es.intermodular.equipo2.incidenciasies.recyclerIncidencias

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import es.intermodular.equipo2.incidenciasies.R
import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse

class IncidenciaAdapter(
    var listaIncidencias: List<IncidenciaResponse> = emptyList(),
    private val onItemSelect: (String) -> Unit
) : RecyclerView.Adapter<IncidenciaViewHolder>() {

    fun updateIncidencias(list: List<IncidenciaResponse>) {
        listaIncidencias = list
        notifyDataSetChanged()
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): IncidenciaViewHolder {
        return IncidenciaViewHolder(
            LayoutInflater.from(parent.context).inflate(R.layout.item_incidencias, parent, false)
        )
    }

    override fun onBindViewHolder(holder: IncidenciaViewHolder, position: Int) {
        holder.bind(listaIncidencias[position], onItemSelect)
    }

    override fun getItemCount() = listaIncidencias.size
}



