package es.intermodular.equipo2.incidenciasies.recyclerNotificaciones

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import es.intermodular.equipo2.incidenciasies.R
import es.intermodular.equipo2.incidenciasies.modelo.IncidenciaResponse
import es.intermodular.equipo2.incidenciasies.modelo.NotificacionResponse
import es.intermodular.equipo2.incidenciasies.recyclerIncidencias.IncidenciaViewHolder


class NotificacionAdapter(
    var listaNotificaciones: List<NotificacionResponse> = emptyList(),
    private val onItemSelect: (String) -> Unit
) : RecyclerView.Adapter<NotificacionViewHolder>() {

    fun updateNotificaciones(list: List<NotificacionResponse>) {
        listaNotificaciones = list
        notifyDataSetChanged()
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): NotificacionViewHolder {
        return NotificacionViewHolder(
            LayoutInflater.from(parent.context).inflate(R.layout.item_notificaciones, parent, false)
        )
    }

    override fun onBindViewHolder(holder: NotificacionViewHolder, position: Int) {
       // holder.bind(listaNotificaciones[position], onItemSelect)
    }

    override fun getItemCount() = listaNotificaciones.size
}





