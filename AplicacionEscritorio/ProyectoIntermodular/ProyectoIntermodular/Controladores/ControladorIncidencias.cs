using Newtonsoft.Json;
using ProyectoIntermodular.Clases;
using ProyectoIntermodular.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<List<Incidencias>> GetTiposIncidencia()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost:8080/api/incidencias/tipo/{tipo}");
                response.EnsureSuccessStatusCode();

            string responseJson = await response.Content.ReadAsStringAsync();

            List<Incidencias> incidencias = JsonConvert.DeserializeObject<List<Incidencias>>(responseJson);
            return incidencias;
        }
        catch (Exception)
        {
            return null;
        }
}*/


        
        public async Task<bool> AgregarIncidencia(IncidenciasRequest incidencia)
        {
            try
            {
                // Crear un objeto con los datos de la nueva incidencia

                // Convertir a formato JSON
                string jsonData = JsonConvert.SerializeObject(incidencia);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // Realizar la solicitud POST
                HttpResponseMessage response = await client.PostAsync("http://localhost:8080/api/incidencias", content);
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

        public async Task<bool> ActualizarIncidencia(int id, Incidencias incidencia)
        {
            try
            {
                // Convertir el objeto incidencia a formato JSON
                string jsonData = JsonConvert.SerializeObject(incidencia);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // Realizar la solicitud PUT
                HttpResponseMessage response = await client.PutAsync($"http://localhost:8080/api/incidencias/{id}", content);
                response.EnsureSuccessStatusCode();

                // La incidencia se actualizó correctamente
                return true;
            }
            catch (Exception)
            {
                // Hubo un error al actualizar la incidencia
                return false;
            }
        }
        

        public async Task<Incidencias> ObtenerIncidenciaPorId(int id)
        {
            try
            {
                // Formar la URL con el ID de la incidencia
                string url = $"http://localhost:8080/api/incidencias/{id}";

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();

                Incidencias incidencia = JsonConvert.DeserializeObject<Incidencias>(responseJson);
                return incidencia;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}

