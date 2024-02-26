using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntermodular.Clases
{
    public class Personal
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string direccion { get; set; }
        public string localidad { get; set; }
        public string cp { get; set; }
        public string tlf { get; set; }
        public string dni { get; set; }
        public bool activo { get; set; }
        public Departamentos Departamento { get; set; }

        public string NombreDepartamento => Departamento?.nombre;

        public Personal()
        {

        }

        public Personal(int id, string nombre, string apellido1, string apellido2, string direccion, string localidad, string cp, string tlf, string dni, bool activo, Departamentos departamento_id)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.direccion = direccion;
            this.localidad = localidad;
            this.cp = cp;
            this.tlf = tlf;
            this.dni = dni;
            this.activo = activo;
            this.Departamento = departamento_id;
        }
    }
    public class PersonalRequest
    {
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string direccion { get; set; }
        public string localidad { get; set; }
        public string cp { get; set; }
        public string tlf { get; set; }
        public string dni { get; set; }
        public bool activo { get; set; }
        public Departamentos departamento { get; set; }

    }
}
