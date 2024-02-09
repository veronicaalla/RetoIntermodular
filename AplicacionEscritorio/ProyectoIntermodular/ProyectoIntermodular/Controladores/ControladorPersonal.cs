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

        public async Task<Personal> GetPersonal()
        {
            try
            {
                Personal personal = new Personal();
                HttpResponseMessage response = await
                    client.GetAsync("http://localhost:8080/api/personal");
                response.EnsureSuccessStatusCode();

                string responseJson=await response.Content.ReadAsStringAsync();

                personal=JsonConvert.DeserializeObject<Personal>
                    (responseJson);
                return personal;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
