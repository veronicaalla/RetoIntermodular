using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntermodular.Clases
{
    internal class Incidencias
    {

        
        public int num { get; set; }
        public TipoIncidencia tipo { get; set; }
        public int subtipo_id { get; set; }
        public DateTime fecha_creacion { get; set; }
        public DateTime? fecha_cierre { get; set; }
        public string descripcion { get; set; }
        public EstadoIncidencia estado { get; set; }
        public string adjunto_url { get; set; }
        public int creador_id { get; set; }
        public int responsable_id { get; set; }
        public int equipo_id { get; set; }

        
        public Incidencias()
        {
            
        }

        
        public Incidencias(int num, TipoIncidencia tipo, int subtipo_id, DateTime fecha_creacion, DateTime? fecha_cierre, string descripcion, EstadoIncidencia estado, string adjunto_url, int creador_id, int responsable_id, int equipo_id)
        {
            this.num = num;
            this.tipo = tipo;
            this.subtipo_id = subtipo_id;
            this.fecha_creacion = fecha_creacion;
            this.fecha_cierre = fecha_cierre;
            this.descripcion = descripcion;
            this.estado = estado;
            this.adjunto_url = adjunto_url;
            this.creador_id = creador_id;
            this.responsable_id = responsable_id;
            this.equipo_id = equipo_id;
        }
    }

    public enum TipoIncidencia
    {
        Tipo1,
        Tipo2,
        Tipo3
    }

    public enum EstadoIncidencia
    {
        Abierta,
        EnProceso,
        Cerrada
    }
}

