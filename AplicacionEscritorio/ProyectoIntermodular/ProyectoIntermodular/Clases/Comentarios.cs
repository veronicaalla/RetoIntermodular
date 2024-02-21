﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntermodular.Clases
{
    public class Comentarios
    {

        
        public int id { get; set; }  
        public string texto { get; set; }  
        public DateTime fechahora { get; set; }  
        public int incidencia_num { get; set; } 
        public int personal_id { get; set; }  
        public string adjunto_url { get; set; }  

        
        public Comentarios()
        {
            
        }

        
        public Comentarios(int id, string texto, DateTime fechahora, int incidencia_num, int personal_id, string adjunto_url)
        {
            this.id = id;
            this.texto = texto;
            this.fechahora = fechahora;
            this.incidencia_num = incidencia_num;
            this.personal_id = personal_id;
            this.adjunto_url = adjunto_url;
        }
    }
}