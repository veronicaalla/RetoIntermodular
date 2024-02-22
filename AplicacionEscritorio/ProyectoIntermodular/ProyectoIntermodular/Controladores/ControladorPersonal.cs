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

        public async Task<bool> ActualizarPersonal(Personal personal)
        {
            try
            {
                // Serializar el objeto Personal a JSON
                string personalJson = JsonConvert.SerializeObject(personal);

                // Crear una solicitud HTTP PUT con los datos actualizados
                HttpResponseMessage response = await client.PutAsync("http://localhost:8080/api/personal/{id}", 
                                                               new StringContent(personalJson, Encoding.UTF8, "application/json"));

                // Verificar si la solicitud fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    // Manejar errores de la solicitud
                    Console.WriteLine("Error al actualizar el personal. Código de estado HTTP: " + response.StatusCode);
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones
                Console.WriteLine("Error al actualizar el personal: " + ex.Message);
                return false;
            }
        }

        public async Task<bool> EliminarPersonal(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync("http://localhost:8080/api/personal/borrar-usuario/{id}");

                // Verificar si la solicitud fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    // Manejar errores de la solicitud
                    Console.WriteLine("Error al eliminar el usuario. Código de estado HTTP: " + response.StatusCode);
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones
                Console.WriteLine("Error al eliminar el usuario: " + ex.Message);
                return false;
            }
        }
    }
}
