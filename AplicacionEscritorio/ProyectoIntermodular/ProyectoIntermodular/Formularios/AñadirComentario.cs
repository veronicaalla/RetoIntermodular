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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoIntermodular.Formularios
{
    public partial class AñadirComentario : Form
    {
        ControladorPersonal controladorPersonal = new ControladorPersonal();

        private HttpClient client;
        private PerfilesResponse usuario; // Usuario actual
        private Incidencias incidencia; // ID de la incidencia asociada al comentario

        ComentarioRequest comentario = new ComentarioRequest();

        public AñadirComentario(PerfilesResponse usuario, Incidencias inc)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.usuario = usuario;
            this.incidencia = inc;
            client = new HttpClient();
        }
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
        public AñadirComentario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void tbxComentario_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (tbxComentario.Text == "Añadir Comentario")
            {
                tbxComentario.Text = "";
                tbxComentario.ForeColor = SystemColors.WindowText;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxComentario.Text))
            {
                tbxComentario.Text = "Añadir Comentario";
                tbxComentario.ForeColor = SystemColors.GrayText;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear el objeto ComentarioRequest con los datos necesarios
<<<<<<< Updated upstream
               
                comentario.fechahora = DateTime.Now; // Fecha y hora actual
                comentario.personal = await controladorPersonal.GetPersonalPorId(usuario.personal_id.ToString());
                comentario.texto = tbxComentario.Text;
                comentario.incidencia= incidencia; // ID de la incidencia
=======

                comentario.fechahora = DateTime.Now; // Fecha y hora actual
                comentario.personal = await controladorPersonal.GetPersonalPorId(usuario.personal_id.ToString());
                comentario.texto = tbxComentario.Text;
                comentario.incidencia = incidencia; // ID de la incidencia
>>>>>>> Stashed changes

                // Serializar el objeto ComentarioRequest a JSON
                string json = JsonConvert.SerializeObject(comentario);
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                // Enviar la solicitud POST al servidor para agregar el comentario
                HttpResponseMessage response = await client.PostAsync("http://localhost:8080/api/comentarios", content);
                response.EnsureSuccessStatusCode();

                MessageBox.Show("El comentario ha sido añadido con éxito.", "Comentario añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cerrar el formulario después de añadir el comentario
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante el proceso
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                string archivoSeleccionado = openFileDialog.FileName;
                lblArchivo.Text = archivoSeleccionado;
            }
        }

        private void lblArchivo_Click(object sender, EventArgs e)
        {

        }
    }
}
