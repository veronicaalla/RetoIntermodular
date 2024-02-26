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
    public partial class ModificarIncidencia : Form
    {
        private String numeroInci;
        private ControladorComentarios controladorComentarios;
        private List<Comentarios> lista;
        private Comentarios coment;
        public ModificarIncidencia(String numero,String tipo,String subtipo,String fechaCreacion,String fechaCierre,String profesor,string estado, PerfilesResponse usuario)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            gbxEdit.Enabled = false;
           
            this.numeroInci = numero;
            cmxTipo.Text = tipo;
            cmxSub.Text = subtipo;
            dateTimePicker1.Text = fechaCreacion;
            dateTimePicker2.Text = fechaCierre;
            cmxProfesor.Text=profesor;
            cmxEstado.Text = estado;

            controladorComentarios = new ControladorComentarios();
            coment = new Comentarios();
            GetComentarios();
        }

        private async void GetComentarios()
        {
            lista = await controladorComentarios.GetComentariosIncidencia(numeroInci);

            if (lista != null)
            {
                foreach (var comentario in lista)
                {
                   
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridView1);

                        row.Cells[0].Value = comentario.personal.nombre;
                        row.Cells[1].Value = comentario.texto;
                        row.Cells[2].Value = comentario.fechahora;

                        dataGridView1.Rows.Add(row);
                    }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnComentar_Click(object sender, EventArgs e)
        {
            AñadirComentario childForm = new AñadirComentario();



            childForm.ShowDialog();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            this.Close();
            principal.Show();
        }

        private void cbxEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEditar.Checked)
            {
                gbxEdit.Enabled = true;
            }
            else
            {
                gbxEdit.Enabled = false;
            }
        }

        private void cmxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmxSub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void cmxProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Obtener la lista de responsables (personal) disponibles
                List<Personal> listaResponsables = await ObtenerResponsables();

                // Verificar si la lista es válida
                if (listaResponsables != null)
                {
                    // Limpiar el ComboBox antes de agregar los nuevos elementos
                    cmxProfesor.Items.Clear();

                    // Agregar los nombres de los responsables al ComboBox
                    foreach (var responsable in listaResponsables)
                    {
                        cmxProfesor.Items.Add(responsable.nombre);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la lista de responsables.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de responsables: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<List<Personal>> ObtenerResponsables()
        {
            try
            {
                // Realizar una solicitud HTTP GET al servidor para obtener la lista de responsables (personal)
                HttpResponseMessage response = await client.GetAsync("http://localhost:8080/api/personal");
                response.EnsureSuccessStatusCode();

                // Verificar si la solicitud fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    // Deserializar la respuesta JSON en una lista de objetos Personal
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    List<Personal> responsables = JsonConvert.DeserializeObject<List<Personal>>(jsonResponse);

                    // Devolver la lista de responsables
                    return responsables;
                }
                else
                {
                    // Si la solicitud no fue exitosa, mostrar un mensaje de error
                    Console.WriteLine("No se pudo obtener la lista de responsables.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la solicitud
                Console.WriteLine($"Se produjo un error al obtener la lista de responsables: {ex.Message}");
                return null;
            }
        }


    }
}
