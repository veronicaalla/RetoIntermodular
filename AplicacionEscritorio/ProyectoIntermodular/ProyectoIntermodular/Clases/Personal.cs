using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntermodular.Clases
{
    internal class Personal
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string direccion { get; set; }
        public string localidad { get; set; }
        public string cp { get; set; }
        public string tlf { get; set; }
        public bool activo { get; set; }
        public int departamento_id { get; set; }

        
        public Personal()
        {
           
        }

        public Personal(int id, string nombre, string apellido1, string apellido2, string direccion, string localidad, string cp, string tlf, bool activo, int departamento_id)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.direccion = direccion;
            this.localidad = localidad;
            this.cp = cp;
            this.tlf = tlf;
            this.activo = activo;
            this.departamento_id = departamento_id;
        }


    }
}
