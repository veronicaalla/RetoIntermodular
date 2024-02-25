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
    internal class ControladorTipos
    {
        private HttpClient client;
        public ControladorTipos()
        {
            client = new HttpClient();
        }
        public async Task<List<IncidenciasSubtipos>> GetIncidenciasSubtipos()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost:8080/api/incidencias-subtipos");
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();

                List<IncidenciasSubtipos> subtipos = JsonConvert.DeserializeObject<List<IncidenciasSubtipos>>(responseJson);
                return subtipos;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<string>> GetSubtipos(String equipo)
        {

            try
            {
                HttpResponseMessage response = await client.GetAsync($"http://localhost:8080/api/incidencias-subtipos/subtipos?tipo={equipo}");
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();

                List<string> subtipos = JsonConvert.DeserializeObject<List<string>>(responseJson);
                return subtipos;
            }
            catch (HttpRequestException ex)
            {
                // Maneja las excepciones específicas de las solicitudes HTTP
                Console.WriteLine("Error al enviar la solicitud HTTP: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                // Maneja cualquier otra excepción que pueda ocurrir
                Console.WriteLine("Error al procesar la respuesta: " + ex.Message);
                return null;
            }
        }
        public async Task<List<string>> GetSub_Subtipos(String subtipo)
        {

            try
            {
                HttpResponseMessage response = await client.GetAsync($"http://localhost:8080/api/incidencias-subtipos/subsubtipos?subtipo={subtipo}");
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();

                List<string> sub_subtipos = JsonConvert.DeserializeObject<List<string>>(responseJson);
                return sub_subtipos;
            }
            catch (HttpRequestException ex)
            {
                // Maneja las excepciones específicas de las solicitudes HTTP
                Console.WriteLine("Error al enviar la solicitud HTTP: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                // Maneja cualquier otra excepción que pueda ocurrir
                Console.WriteLine("Error al procesar la respuesta: " + ex.Message);
                return null;
            }
        }
    }
}
