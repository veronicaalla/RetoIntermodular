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
        public IncidenciasSubtipos incidenciasSubtipo { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime? fechaCierre { get; set; }
        public string descripcion { get; set; }
        public EstadoIncidencia estado { get; set; }
        public string adjuntoUrl { get; set; }
        public Personal creador { get; set; }
        public Personal responsable { get; set; }
        public Equipo equipo { get; set; }




        public Incidencias()
        {
            
        }

        
        public Incidencias(int num, TipoIncidencia tipo, IncidenciasSubtipos subtipo_id, DateTime fecha_creacion, DateTime? fecha_cierre, string descripcion, EstadoIncidencia estado, string adjunto_url, Personal creador_id, Personal responsable_id, Equipo equipo_id)
        {
            this.num = num;
            this.tipo = tipo;
            this.incidenciasSubtipo = subtipo_id;
            this.fechaCreacion = fecha_creacion;
            this.fechaCierre = fecha_cierre;
            this.descripcion = descripcion;
            this.estado = estado;
            this.adjuntoUrl = adjunto_url;
            this.creador = creador_id;
            this.responsable = responsable_id;
            this.equipo = equipo_id;
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

