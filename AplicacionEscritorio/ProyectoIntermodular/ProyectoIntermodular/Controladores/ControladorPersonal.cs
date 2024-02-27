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
    public async Task<List<PerfilesResponse>> GetPerfiles()
    {

        HttpResponseMessage response = await client.GetAsync("http://localhost:8080/api/perfiles");
        response.EnsureSuccessStatusCode();

        string responseJson = await response.Content.ReadAsStringAsync();

        List<PerfilesResponse> personas = JsonConvert.DeserializeObject<List<PerfilesResponse>>(responseJson);
        return personas;

    }

    public async Task<int> GetUltimoPerfil()
    {

        HttpResponseMessage response = await client.GetAsync("http://localhost:8080/api/personal/ultimo-id");
        response.EnsureSuccessStatusCode();

        string responseJson = await response.Content.ReadAsStringAsync();

        int id = JsonConvert.DeserializeObject<int>(responseJson);
        return id;

    }

    public async Task<Personal> GetPersonalPorId(String id)
    {

        try
        {
            HttpResponseMessage response = await client.GetAsync($"http://localhost:8080/api/personal/{id}");
            response.EnsureSuccessStatusCode();

            string responseJson = await response.Content.ReadAsStringAsync();

            Personal persona = JsonConvert.DeserializeObject<Personal>(responseJson);
            return persona;
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


    public async Task<bool> AgregarPerfil(PerfilesResponse perfil)
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
    public async Task<bool> ActualizarPersonal(Personal personal)
    {
        try
        {
            int idPersonal = personal.id;
            // Serializar el objeto Personal a JSON
            string personalJson = JsonConvert.SerializeObject(personal);

            string url = $"http://localhost:8080/api/personal/{idPersonal}";

            // Crear una solicitud HTTP PUT con los datos actualizados
            HttpResponseMessage response = await client.PutAsync(url,
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
        public async Task<Personal> GetPersonalPorNombre_Apellido1_Apellido2(string nombre, string apellido1, string apellido2)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"http://localhost:8080/api/personal/objeto?nombre={nombre}&apellido1={apellido1}&apellido2={apellido2}");
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();

                Personal personal = JsonConvert.DeserializeObject<Personal>(responseJson);
                return personal;
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
}
