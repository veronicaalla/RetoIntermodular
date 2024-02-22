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
    internal class ControladorPersonal
    {
        private HttpClient client;

        public ControladorPersonal()
        {
            client=new HttpClient();
        }

        public async Task<List<Personal>> GetPersonal()
        {
            
                HttpResponseMessage response = await client.GetAsync("http://localhost:8080/api/personal");
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();

                List<Personal> personas = JsonConvert.DeserializeObject<List<Personal>>(responseJson);
                return personas;
            
        }
        public async Task<bool> AgregarPerfil(Perfiles perfil)
        {
            try
            {
                // Crear un objeto con los datos de la nueva incidencia

                // Convertir a formato JSON
                string jsonData = JsonConvert.SerializeObject(perfil);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // Realizar la solicitud POST
                HttpResponseMessage response = await client.PostAsync("http://localhost:8080/api/perfiles", content);
                response.EnsureSuccessStatusCode();

                // La incidencia se agregó correctamente
                return true;
            }
            catch (Exception)
            {
                // Hubo un error al agregar la incidencia
                return false;
            }
        }
        public async Task<bool> AgregarUser(PersonalRequest personal)
        {
            try
            {
                // Crear un objeto con los datos de la nueva incidencia

                // Convertir a formato JSON
                string jsonData = JsonConvert.SerializeObject(personal);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // Realizar la solicitud POST
                HttpResponseMessage response = await client.PostAsync("http://localhost:8080/api/personal", content);
                response.EnsureSuccessStatusCode();

                // La incidencia se agregó correctamente
                return true;
            }
            catch (Exception)
            {
                // Hubo un error al agregar la incidencia
                return false;
            }
        }
    }
}
