using Newtonsoft.Json;
using ProyectoIntermodular.Clases;
using ProyectoIntermodular.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntermodular.Formularios
{
    public partial class CrearIncidencia : Form
    {
        ControladorPersonal controladorPersonal = new ControladorPersonal();
        ControladorTipos controladortipos = new ControladorTipos();
        ControladorIncidencias controladorInc = new ControladorIncidencias();
        ControladorAula controladorAula = new ControladorAula();
        PerfilesResponse creador = new PerfilesResponse();

        private HttpClient client;

        bool creado = false;
        string archivoSeleccionado;

        List<IncidenciasSubtipos> listaTipos = new List<IncidenciasSubtipos>();
        List<string> listaSubtipos = new List<string>();
        List<string> listaSub_subtipos = new List<string>();

        ControladorDepartamentos controladorDepartamento = new ControladorDepartamentos();
        private Incidencias incidencia = new Incidencias();
        public CrearIncidencia(Principal principal)
        {
            creador = principal.usuario;
            client = new HttpClient();
            InitializeComponent();
            cajaCreador.Text = creador.educantabria;
            this.StartPosition = FormStartPosition.CenterScreen;

            CargarComboBox();
        }
        private async void CargarComboBox()
        {
            // Obtener la lista de personas
            List<PerfilesResponse> listaPersonal = await controladorPersonal.GetPerfiles();
            List<PerfilesResponse> listaAdmin = new List<PerfilesResponse>();

            //foreach (PerfilesResponse personal in listaPersonal)
            //{
            //    if (personal.perfil.Equals("administrador"))
            //    {
            //        listaAdmin.Add(personal);
            //    }
            //}
            //if (listaPersonal != null)
            //{
            //    // Configurar el ComboBox para mostrar el nombre de cada persona
            //    comboBoxResponsable.DisplayMember = "educantabria";

            //    // Asignar la lista de personas como la fuente de datos del ComboBox
            //    comboBoxResponsable.DataSource = listaAdmin;
            //}
            //else
            //{
            //    MessageBox.Show("Error al cargar la lista de personas.");
            //}

            listaTipos = await controladortipos.GetIncidenciasSubtipos();
            if (listaTipos != null)
            {
                // Configurar el ComboBox para mostrar el nombre de cada persona
                comboBoxTipo.DisplayMember = "tipo";

                // Asignar la lista de personas como la fuente de datos del ComboBox
                comboBoxTipo.DataSource = listaTipos;
            }
            else
            {
                MessageBox.Show("Error al cargar la lista de personas.");
            }
        }

        //private void checkBoxResponsable_CheckedChanged(object sender, EventArgs e)
        //{
        //    comboBoxResponsable.Enabled = true;
        //    if (!checkBoxResponsable.Checked)
        //    {
        //        comboBoxResponsable.Enabled = false;
        //    }
        //}

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la ID del subtipo mediante la API
                IncidenciasSubtipos tipo = (IncidenciasSubtipos)comboBoxTipo.SelectedItem;
                IncidenciasSubtipos subtipoId = await ObtenerIdPorTipoSubtipoYSubsubtipo(tipo.tipo, comboBoxSubtipo.Text, cajaSub_sub.Text);

                if (subtipoId != null)
                {
                    // Crear el objeto IncidenciasRequest con los datos necesarios
                    IncidenciasRequest inc = new IncidenciasRequest();
                    inc.fechaCreacion = DateTime.Now;
                    inc.estado = EstadoIncidencia.ABIERTA;
                    inc.descripcion = cajaDesc.Text;
                    inc.tipo = comboBoxTipo.Text;
                    inc.subtipo = subtipoId.sub_subtipo; // Asignar la ID del subtipo obtenida

                    // Obtener el equipo por etiqueta
                    Equipo equipo = await ObtenerEquipoPorEtiqueta(CajaEquipo.Text);

                    if (equipo != null)
                    {
                        // Asignar el equipo obtenido al objeto IncidenciasRequest
                        inc.equipo = equipo.tipoEquipo;

                        // Obtener el perfil de usuario (Personal) por su ID
                        int creadorId = creador.personal_id; // Suponiendo que tienes el ID del creador
                        Personal personal = await ObtenerPersonalPorId(creadorId);

                        if (personal != null)
                        {
                            // Asignar el perfil de usuario al creador de la incidencia
                            inc.creador = personal;

                            // Enviar la solicitud al servidor para agregar la incidencia
                            bool creado = await controladorInc.AgregarIncidencia(inc);

                            if (creado)
                            {
                                MessageBox.Show("La incidencia ha sido creada con éxito.", "Incidencia creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Hubo un error al crear la incidencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se pudo obtener la información del creador de la incidencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No pudimos obtener la información del equipo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la ID del subtipo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante el proceso
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<IncidenciasSubtipos> ObtenerIdPorTipoSubtipoYSubsubtipo(string tipo, string subtipo, string subsubtipo)
        {
            try
            {
                string url;
                if (subsubtipo.Equals(""))
                {
                    url = $"http://localhost:8080/api/incidencias-subtipos/id-objeto?tipo={tipo}&subtipo={subtipo}";
                }
                else
                {
                    // Construir la URL de la solicitud GET
                    url = $"http://localhost:8080/api/incidencias-subtipos/id-objeto?tipo={tipo}&subtipo={subtipo}&subsubtipo={subsubtipo}";
                }
                // Realizar la solicitud GET a la API
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    // Leer la respuesta JSON
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    // Deserializar la respuesta JSON para obtener la ID
                    IncidenciasSubtipos id = JsonConvert.DeserializeObject<IncidenciasSubtipos>(jsonResponse);
                    return id;
                }
                else
                {
                    // Manejar el caso en que la solicitud no fue exitosa
                    Console.WriteLine("No se pudo obtener el ID del subtipo de incidencia.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante el proceso
                Console.WriteLine($"Se produjo un error al obtener el ID del subtipo de incidencia: {ex.Message}");
                return null;
            }
        }




        private async Task<Personal> ObtenerPersonalPorId(int id)
        {
            try
            {
                // Construir la URL con el ID del perfil de usuario
                string url = $"http://localhost:8080/api/personal/{id}";

                // Realizar una solicitud HTTP GET al servidor para obtener los detalles del perfil de usuario
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                // Verificar si la solicitud fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    // Deserializar la respuesta JSON en un objeto Personal
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    Personal personal = JsonConvert.DeserializeObject<Personal>(jsonResponse);

                    // Devolver el objeto Personal
                    return personal;
                }
                else
                {
                    // Si la solicitud no fue exitosa, mostrar un mensaje de error
                    Console.WriteLine("No se pudo obtener la información del perfil de usuario.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la solicitud
                Console.WriteLine($"Se produjo un error al obtener los detalles del perfil de usuario: {ex.Message}");
                return null;
            }
        }

        private async Task<Equipo> ObtenerEquipoPorEtiqueta(string etiqueta)
        {
            try
            {
                // Construir la URL con el parámetro de etiqueta
                string url = $"http://localhost:8080/api/equipos/etiqueta?etiqueta={etiqueta}";

                // Realizar una solicitud HTTP GET al servidor para obtener los detalles del equipo
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                // Verificar si la solicitud fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    // Deserializar la respuesta JSON en un objeto Equipo
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    Equipo equipo = JsonConvert.DeserializeObject<Equipo>(jsonResponse);

                    // Devolver el objeto Equipo
                    return equipo;
                }
                else
                {
                    // Si la solicitud no fue exitosa, mostrar un mensaje de error
                    Console.WriteLine("No se pudo obtener la información del equipo.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la solicitud
                Console.WriteLine($"Se produjo un error al obtener los detalles del equipo: {ex.Message}");
                return null;
            }
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            this.Close();
            principal.Show();
        }

        private void btnAñadirArchivo_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();


            openFileDialog.Title = "Seleccionar archivo";
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            openFileDialog.Multiselect = false;


            DialogResult result = openFileDialog.ShowDialog();


            if (result == DialogResult.OK)
            {

                archivoSeleccionado = openFileDialog.FileName;
                lblArchivo.Text = archivoSeleccionado;
            }
        }

        private async void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            IncidenciasSubtipos tipo = comboBoxTipo.SelectedItem as IncidenciasSubtipos;

            listaSubtipos = await controladortipos.GetSubtipos(tipo.tipo.ToString());

            if (listaSubtipos != null)
            {
                // Configurar el ComboBox para mostrar el nombre de cada persona
                comboBoxSubtipo.DisplayMember = "subtipoNombre";

                // Asignar la lista de personas como la fuente de datos del ComboBox
                comboBoxSubtipo.DataSource = listaSubtipos;
            }
            else
            {
                MessageBox.Show("Error al cargar la lista de personas.");
            }

        }

        private async void comboBoxSubtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string subtipo = comboBoxSubtipo.SelectedValue.ToString();

            listaSub_subtipos = await controladortipos.GetSub_Subtipos(subtipo);

            if (listaSub_subtipos != null)
            {
                // Configurar el ComboBox para mostrar el nombre de cada persona
                //comboBoxSubsubTipo.DisplayMember = "sub_subtipo";

                // Asignar la lista de personas como la fuente de datos del ComboBox
                //comboBoxSubsubTipo.DataSource = listaSub_subtipos;
            }
            else
            {
                MessageBox.Show("Error al cargar la lista de personas.");
            }
        }
    }
}
    