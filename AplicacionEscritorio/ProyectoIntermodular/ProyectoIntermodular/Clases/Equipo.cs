using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntermodular.Clases
{
    public class Equipo
    {

        public int id { get; set; } 
        public TipoEquipo tipo_equipo { get; set; }  
        public DateTime fecha_adquisicion { get; set; }  
        public string etiqueta { get; set; }  
        public string marca { get; set; }  
        public string modelo { get; set; }  
        public string descripcion { get; set; }  
        public bool baja { get; set; } 
        public int aula_num { get; set; }  
        public int puesto { get; set; }  

        
        public Equipo()
        {
            
        }

        
        public Equipo(int id, TipoEquipo tipo_equipo, DateTime fecha_adquisicion, string etiqueta, string marca, string modelo, string descripcion, bool baja, int aula_num, int puesto)
        {
            this.id = id;
            this.tipo_equipo = tipo_equipo;
            this.fecha_adquisicion = fecha_adquisicion;
            this.etiqueta = etiqueta;
            this.marca = marca;
            this.modelo = modelo;
            this.descripcion = descripcion;
            this.baja = baja;
            this.aula_num = aula_num;
            this.puesto = puesto;
        }
    }

    public enum TipoEquipo
    {
        PC,
        PROYECTOR,
        IMPRESORA,
        PANTALLA,
        TECLADO,
        RATON,
        OTROS
    }
}
