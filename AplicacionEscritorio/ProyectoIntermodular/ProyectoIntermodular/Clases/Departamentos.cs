using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntermodular.Clases
{
    public class Departamentos
    {

        public int int_ { get; set; }  
        public string cod { get; set; }  
        public string nombre { get; set; }  
        public bool activo { get; set; }  
        public string personal { get; set; }  

        
        public Departamentos()
        {
            
        }

        
        public Departamentos(int id, string cod, string nombre, bool activo, string jefdep_id)
        {
            this.int_ = id;
            this.cod = cod;
            this.nombre = nombre;
            this.activo = activo;
            this.personal = jefdep_id;
        }
    }
}
