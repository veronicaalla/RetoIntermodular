using Newtonsoft.Json;
using ProyectoIntermodular.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntermodular.Controladores
{
    internal class ControladorInformes
    {
        private HttpClient client;

        public ControladorInformes()
        {
            client = new HttpClient();
        }
        public async Task GetExcel()
        {
            try
            {
                // Realizar la solicitud GET

                string url = "http://localhost:8080/api/incidencias/pdf";
                HttpResponseMessage respuesta = await client.GetAsync(url);

                // Verificar si la solicitud fue exitosa
                if (respuesta.IsSuccessStatusCode)
                {
                    // Guardar el contenido en un archivo directamente
                    using (var stream = await respuesta.Content.ReadAsStreamAsync())
                    using (var fileStream = System.IO.File.Create("E:\\Rutas\\incidencias.pdf"))
                    {
                        await stream.CopyToAsync(fileStream);
                    }

                    MessageBox.Show("Archivo Excel descargado y guardado en: E:\\Rutas", "Documento Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operación cancelada.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operación cancelada.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public async Task GetExcelTiempoAdmin()
        {
            try
            {
                // Realizar la solicitud GET

                string url = "http://localhost:8080/api/incidencias/pdfTiempoPorAdmin";
                HttpResponseMessage respuesta = await client.GetAsync(url);

                // Verificar si la solicitud fue exitosa
                if (respuesta.IsSuccessStatusCode)
                {
                    // Guardar el contenido en un archivo directamente
                    using (var stream = await respuesta.Content.ReadAsStreamAsync())
                    using (var fileStream = System.IO.File.Create("E:\\Rutas\\TiempoAdmin.pdf"))
                    {
                        await stream.CopyToAsync(fileStream);
                    }

                    MessageBox.Show("$Archivo Excel descargado y guardado en: E:\\Rutas", "Documento Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operación cancelada.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operación cancelada.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public async Task GetExcelTiempoTipo()
        {
            try
            {
                // Realizar la solicitud GET

                string url = "http://localhost:8080/api/incidencias/pdfTiempoMedioPorTipo";
                HttpResponseMessage respuesta = await client.GetAsync(url);

                // Verificar si la solicitud fue exitosa
                if (respuesta.IsSuccessStatusCode)
                {
                    // Guardar el contenido en un archivo directamente
                    using (var stream = await respuesta.Content.ReadAsStreamAsync())
                    using (var fileStream = System.IO.File.Create("E:\\Rutas\\TiempoMedioTipo.pdf"))
                    {
                        await stream.CopyToAsync(fileStream);
                    }

                    MessageBox.Show("Archivo Excel descargado y guardado en: E:\\Rutas", "Documento Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operación cancelada.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operación cancelada.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public async Task GetExcelTiempoIncidencia()
        {
            try
            {
                // Realizar la solicitud GET

                string url = "http://localhost:8080/api/incidencias/pdfTiempoIncidencia";
                HttpResponseMessage respuesta = await client.GetAsync(url);

                // Verificar si la solicitud fue exitosa
                if (respuesta.IsSuccessStatusCode)
                {
                    // Guardar el contenido en un archivo directamente
                    using (var stream = await respuesta.Content.ReadAsStreamAsync())
                    using (var fileStream = System.IO.File.Create("E:\\Rutas\\Tiempoincidencias.pdf"))
                    {
                        await stream.CopyToAsync(fileStream);
                    }

                    MessageBox.Show("Archivo Excel descargado y guardado en: E:\\Rutas", "Documento Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operación cancelada.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operación cancelada.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public async Task GetExcelEstadisticas()
        {
            try
            {
                // Realizar la solicitud GET

                string url = "http://localhost:8080/api/incidencias/pdfEstadisticas";
                HttpResponseMessage respuesta = await client.GetAsync(url);

                // Verificar si la solicitud fue exitosa
                if (respuesta.IsSuccessStatusCode)
                {
                    // Guardar el contenido en un archivo directamente
                    using (var stream = await respuesta.Content.ReadAsStreamAsync())
                    using (var fileStream = System.IO.File.Create("E:\\Rutas\\Estadisticas.pdf"))
                    {
                        await stream.CopyToAsync(fileStream);
                    }

                    MessageBox.Show("Archivo Excel descargado y guardado en: E:\\Rutas", "Documento Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operación cancelada.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operación cancelada.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public async Task GetExcelAdministrador(int id)
        {
            try
            {
                // Realizar la solicitud GET

                string url = "http://localhost:8080/api/incidencias/pdfAdministrador?idAdministrador="+id;
                HttpResponseMessage respuesta = await client.GetAsync(url);

                // Verificar si la solicitud fue exitosa
                if (respuesta.IsSuccessStatusCode)
                {
                    // Guardar el contenido en un archivo directamente
                    using (var stream = await respuesta.Content.ReadAsStreamAsync())
                    using (var fileStream = System.IO.File.Create("E:\\Rutas\\incidenciasAdministrador.pdf"))
                    {
                        await stream.CopyToAsync(fileStream);
                    }

                    MessageBox.Show("Archivo Excel descargado y guardado en: E:\\Rutas", "Documento Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operación cancelada.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operación cancelada.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public async Task GetExcelPorCreador(int id)
        {
            try
            {
                // Realizar la solicitud GET

                string url = "http://localhost:8080/api/incidencias/pdfAbiertasPorCreador?idCreador="+id;
                HttpResponseMessage respuesta = await client.GetAsync(url);

                // Verificar si la solicitud fue exitosa
                if (respuesta.IsSuccessStatusCode)
                {
                    // Guardar el contenido en un archivo directamente
                    using (var stream = await respuesta.Content.ReadAsStreamAsync())
                    using (var fileStream = System.IO.File.Create("E:\\Rutas\\incidenciasCreador.pdf"))
                    {
                        await stream.CopyToAsync(fileStream);
                    }
                    MessageBox.Show("Archivo Excel descargado y guardado en: E:\\Rutas", "Documento Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operación cancelada.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operación cancelada.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

