using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntermodular.Clases
{
    public class Perfiles
    {

        public int personal_id { get; set; }  
        public string dominio { get; set; }  
        public string educantabria { get; set; }  
        public char password { get; set; }  
        public PerfilEnum perfil { get; set; }  

        
        public Perfiles()
        {
            
        }
        public Perfiles(PerfilEnum perfil)
        {
            this.perfil = perfil; 
        }


        public Perfiles(int personal_id, string dominio, string educantabria, char password, PerfilEnum perfil)
        {
            this.personal_id = personal_id;
            this.dominio = dominio;
            this.educantabria = educantabria;
            this.password = password;
            this.perfil = perfil;
        }
    }

  
    public enum PerfilEnum
    {
        ADMIN,
        PROFESOR
    }
}

