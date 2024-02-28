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
        public string tipoEquipo { get; set; }
        public DateTime fecha_adquisicion { get; set; }
        public string etiqueta { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string descripcion { get; set; }
        public string baja { get; set; }
        public Aulas aula { get; set; }
        public int puesto { get; set; }


        public Equipo()
        {

        }


        public Equipo(int id, string tipo_equipo, DateTime fecha_adquisicion, string etiqueta, string marca, string modelo, string descripcion, string baja, Aulas aula_num, int puesto)
        {
            this.id = id;
            this.tipoEquipo = tipo_equipo;
            this.fecha_adquisicion = fecha_adquisicion;
            this.etiqueta = etiqueta;
            this.marca = marca;
            this.modelo = modelo;
            this.descripcion = descripcion;
            this.baja = baja;
            this.aula = aula_num;
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
