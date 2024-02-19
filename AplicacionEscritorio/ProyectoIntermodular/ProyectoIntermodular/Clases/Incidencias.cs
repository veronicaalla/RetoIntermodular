using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntermodular.Clases
{
    public class Incidencias
    {

        
        public int num { get; set; }
        public TipoIncidencia tipo { get; set; }
        public int subtipo_id { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime? fechaCierre { get; set; }
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
            this.fechaCreacion = fecha_creacion;
            this.fechaCierre = fecha_cierre;
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
        EQUIPOS,
        CUENTAS,
        WIFI,
        INTERNET,
        SOFTWARE

    }

    public enum EstadoIncidencia
    {
        ABIERTA,
        ASIGNADA,
        ENPROCESO,
        ENVIADA_INFORTEC,
        RESUELTA,
        CERRADA
    }
}

