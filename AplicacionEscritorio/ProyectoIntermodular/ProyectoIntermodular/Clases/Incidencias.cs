﻿using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProyectoIntermodular.Clases
{
    public class Incidencias
    {

        
        public int num { get; set; }
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
        [JsonConverter(typeof(StringEnumConverter))]
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
        public TimeSpan? tiempo_dec { get; set; }
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes


    public Incidencias()
        {
            
        }

<<<<<<< Updated upstream
        
=======

>>>>>>> Stashed changes
        public Incidencias(int num, string tipo, IncidenciasSubtipos subtipo_id, DateTime fecha_creacion, DateTime? fecha_cierre, string descripcion, EstadoIncidencia estado, string adjunto_url, Personal creador_id, Personal responsable_id, Equipo equipo_id, TimeSpan? tiempo_dec)
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
            this.tiempo_dec = tiempo_dec;
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
        EN_PROCESO,
        ENVIADA_A_INFORTEC,
        RESUELTA,
        CERRADA
    }
    public class IncidenciasRequest
    {

        public string tipo { get; set; }

        public IncidenciasSubtipos incidenciasSubtipo { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string descripcion { get; set; }
        public EstadoIncidencia estado { get; set; }
        public string adjuntoUrl { get; set; }
        public Personal creador { get; set; }
        public Equipo equipo { get; set; }
    }
}

