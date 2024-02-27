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
        public string tipo { get; set; }
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

        
        public Incidencias(int num, string tipo, IncidenciasSubtipos subtipo_id, DateTime fecha_creacion, DateTime? fecha_cierre, string descripcion, EstadoIncidencia estado, string adjunto_url, Personal creador_id, Personal responsable_id, Equipo equipo_id)
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

    public enum Tipo_Incidencias
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
    public class IncidenciasRequest
    {

        public string tipo { get; set; }

        public string subtipo { get; set; }
        public string sub_subtipo { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string descripcion { get; set; }
        public EstadoIncidencia estado { get; set; }
        public string adjuntoUrl { get; set; }
        public Personal creador { get; set; }
        public string equipo { get; set; }
    }

    public class IncidenciasBusqueda
    {
        public int creador { get; set; }
        public int responsable { get; set; }
        public string tipo { get; set; }
        public string estado { get; set; }
        public string fechaCreacion { get; set; }
       
    }


}

