using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntermodular.Clases
{
    internal class Perfiles
    {

        public int personal_id { get; set; }  
        public string dominio { get; set; }  
        public string educantabria { get; set; }  
        public char password { get; set; }  
        public PerfilEnum perfil { get; set; }  
    }

  
    public enum PerfilEnum
    {
        ADMIN,
        PROFESOR
        
    }
}

