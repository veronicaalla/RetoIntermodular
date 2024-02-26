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

        public async Task<bool> AgregarDepartamento(DepartementoRequest departamento)
        {
            try
            {
                // Crear un objeto con los datos de la nueva incidencia

                // Convertir a formato JSON
                string jsonData = JsonConvert.SerializeObject(departamento);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // Realizar la solicitud POST
                HttpResponseMessage response = await client.PostAsync("http://localhost:8080/api/departamentos", content);
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

        public async Task<bool> ActualizarDepartamento(Departamentos departamento)
        {
            try
            {
                // Serializa el objeto comentario a formato JSON
                string comentarioJson = JsonConvert.SerializeObject(departamento);

                // Crea un contenido de tipo JSON a partir del objeto serializado
                StringContent content = new StringContent(comentarioJson, Encoding.UTF8, "application/json");

                // Realiza una solicitud HTTP PUT a la API para actualizar el comentario
                HttpResponseMessage response = await client.PutAsync($"http://localhost:8080/api/departamentos/{departamento.int_}", content);

                // Verifica si la solicitud fue exitosa
                response.EnsureSuccessStatusCode();

                // Retorna true si la solicitud fue exitosa
                return true;
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir durante la solicitud HTTP
                Console.WriteLine("Error al actualizar el comentario: " + ex.Message);
                return false;
            }
        }
    }
}
