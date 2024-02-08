using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntermodular.Clases
{
    internal class Aulas
    {

        public int num { get; set; }  
        public string codigo { get; set; }  
        public string descripcion { get; set; }  
        public int planta { get; set; }  

        
        public Aulas()
        {
            
        }

        
        public Aulas(int num, string codigo, string descripcion, int planta)
        {
            this.num = num;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.planta = planta;
        }
    }
}
