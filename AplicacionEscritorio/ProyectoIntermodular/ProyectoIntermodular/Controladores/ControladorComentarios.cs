using Newtonsoft.Json;
using ProyectoIntermodular.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntermodular.Controladores
{
    internal class ControladorComentarios
    {
        

            private HttpClient client;

            public ControladorComentarios()
            {
                client = new HttpClient();
            }

            public async Task<List<Comentarios>> GetComentarios()
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("http://localhost:8080/api/comentarios");
                    response.EnsureSuccessStatusCode();

                    string responseJson = await response.Content.ReadAsStringAsync();

                    List<Comentarios> coment = JsonConvert.DeserializeObject<List<Comentarios>>(responseJson);
                    return coment;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }


