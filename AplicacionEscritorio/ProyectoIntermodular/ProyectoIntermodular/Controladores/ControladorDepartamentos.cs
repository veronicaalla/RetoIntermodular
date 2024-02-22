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
    internal class ControladorDepartamentos
    {

        private HttpClient client;

        public ControladorDepartamentos()
        {
            client = new HttpClient();
        }
        public async Task<List<Departamentos>> GetDepartamentos()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost:8080/api/departamentos");
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();

                List<Departamentos> departamentos = JsonConvert.DeserializeObject<List<Departamentos>>(responseJson);
                return departamentos;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
