using Newtonsoft.Json;
using ProyectoIntermodular.Clases;
using ProyectoIntermodular.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntermodular.Controladores
{
    internal class ControladorIncidencias
    {

        private HttpClient client;

        public ControladorIncidencias()
        {
            client = new HttpClient();
        }

        public async Task<List<Incidencias>> GetIncidencias()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost:8080/api/incidencias");
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();

                List<Incidencias> incidencias = JsonConvert.DeserializeObject<List<Incidencias>>(responseJson);
                return incidencias;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}

