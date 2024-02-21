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
        public int cod { get; set; }  
        public string nombre { get; set; }  
        public bool activo { get; set; }  
        public int jefdep_id { get; set; }  

        
        public Departamentos()
        {
            
        }

        
        public Departamentos(int id, int cod, string nombre, bool activo, int jefdep_id)
        {
            this.int_ = id;
            this.cod = cod;
            this.nombre = nombre;
            this.activo = activo;
            this.jefdep_id = jefdep_id;
        }
    }
}
