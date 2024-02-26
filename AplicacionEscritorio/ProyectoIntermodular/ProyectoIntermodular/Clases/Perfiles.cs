using ProyectoIntermodular.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntermodular.Clases
{
    public class Perfiles
    {

        public Personal personal { get; set; }  
        public string dominio { get; set; }  
        public string educantabria { get; set; }  
        public string password { get; set; }  
        public PerfilEnum perfil { get; set; }  

        
        public Perfiles()
        {
            
        }
        public Perfiles(PerfilEnum perfil)
        {
            this.perfil = perfil; 
        }


        public Perfiles(Personal personal_id, string dominio, string educantabria, string password, PerfilEnum perfil)
        {
            this.personal = personal_id;
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
public class PerfilesResponse
{

    public int personal { get; set; }
    public string dominio { get; set; }
    public string educantabria { get; set; }
    public string password { get; set; }
    public string perfil { get; set; }
}

