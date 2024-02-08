using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntermodular.Clases
{
    internal class Departamentos
    {

        public int id { get; set; }  
        public char cod { get; set; }  
        public string nombre { get; set; }  
        public bool activo { get; set; }  
        public int jefdep_id { get; set; }  

        
        public Departamentos()
        {
            
        }

        
        public Departamentos(int id, char cod, string nombre, bool activo, int jefdep_id)
        {
            this.id = id;
            this.cod = cod;
            this.nombre = nombre;
            this.activo = activo;
            this.jefdep_id = jefdep_id;
        }
    }
}
