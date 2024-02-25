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
    internal class ControladorAula
    {
        private HttpClient client;

        public ControladorAula()
        {
            client = new HttpClient();
        }
        public async Task<List<Aulas>> GetAulas()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost:8080/api/aula");
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();

                List<Aulas> aula = JsonConvert.DeserializeObject<List<Aulas>>(responseJson);
                return aula;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
