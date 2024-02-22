using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntermodular.Clases
{
    public class IncidenciasSubtipos
    {

       
        public int id { get; set; }  
        public TipoIncidencia tipo { get; set; }  
        public string subtipoNombre { get; set; }  
        public string sub_subtipo { get; set; } 

        
        public IncidenciasSubtipos()
        {
            
        }

        
        public IncidenciasSubtipos(int id, TipoIncidencia tipo, string subtipo_nombre, string sub_subtipo)
        {
            this.id = id;
            this.tipo = tipo;
            this.subtipoNombre = subtipo_nombre;
            this.sub_subtipo = sub_subtipo;
        }
    }
}

