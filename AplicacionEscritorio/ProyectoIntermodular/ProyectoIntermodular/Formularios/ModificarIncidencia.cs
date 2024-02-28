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
        ControladorPersonal controladorPersonal = new ControladorPersonal();
        ControladorIncidencias controladorIncidencias = new ControladorIncidencias();

        PerfilesResponse usuario;
        Personal personal;

        private Incidencias inc;
        private String numeroInci;
        private ControladorComentarios controladorComentarios;
        private List<Comentarios> lista;
        private Comentarios coment;
        private HttpClient client;
        public ModificarIncidencia(String numero, String tipo, String subtipo, String fechaCreacion, String fechaCierre, String profesor, string estado, PerfilesResponse usuario, Incidencias inc)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            gbxEdit.Enabled = false;
            this.usuario = usuario;

            this.numeroInci = numero;

            cmxProfesor.Text = profesor;
            cmxEstado.Text = estado;

            controladorComentarios = new ControladorComentarios();
            coment = new Comentarios();
            GetComentarios();

            this.inc = inc;

            CargarComboBoxes();
        }

        private async void CargarComboBoxes()
        {
            try
            {
                await CargarComboBoxProfesores();

                await CargarComboBoxEstado();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los ComboBoxes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarComboBoxProfesores()
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
                        cmxProfesor.Items.Add(responsable.nombre + " " + responsable.apellido1 + " " + responsable.apellido2);
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

        private async Task CargarComboBoxEstado()
        {
            try
            {
                // Aquí puedes implementar la lógica para cargar el ComboBox relacionado con el estado de la incidencia
                // Por ejemplo:
                List<string> estados = new List<string> { "ABIERTA", "ASIGNADA", "EN_PROCESO", "ENVIADA_A_INFORTEC", "RESUELTA", "CERRADA" };
                cmxEstado.Items.Clear();
                cmxEstado.Items.AddRange(estados.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el ComboBox de estados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            AñadirComentario childForm = new AñadirComentario(usuario, inc);



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

        private void cmxProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private async Task<List<Personal>> ObtenerResponsables()
        {
            try
            {
                // Obtener la lista de responsables (personal) desde el controladorPersonal
                List<Personal> responsables = await controladorPersonal.GetPersonal();

                // Verificar si la lista es válida
                if (responsables != null)
                {
                    // Devolver la lista de responsables
                    return responsables;
                }
                else
                {
                    // Si la lista es nula, mostrar un mensaje de error
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Crear objeto IncidenciasRequest con los datos del formulario

            if (!inc.estado.ToString().Equals("CERRADA"))
            {
                if (cmxEstado.SelectedItem.ToString().Equals("CERRADA"))
                {
                    inc.fechaCierre = DateTime.Now;
                }
            }

            string nombreCompleto = cmxProfesor.SelectedItem.ToString();


            string[] partesNombre = nombreCompleto.Split(' ');


            if (partesNombre.Length >= 3)
            {
                string nombre = partesNombre[0];
                string apellido1 = partesNombre[1];
                string apellido2 = partesNombre[2];

                personal = await controladorPersonal.GetPersonalPorNombre_Apellido1_Apellido2(nombre, apellido1, apellido2);

                inc.responsable = personal;
            }

            if (textBoxTiempo.Enabled)
            {
                TimeSpan tiempoDec = TimeSpan.Parse(textBoxTiempo.Text);
                inc.tiempo_dec = tiempoDec;
            }

            if (Enum.TryParse<EstadoIncidencia>(cmxEstado.SelectedItem.ToString(), out EstadoIncidencia estado))
            {
                inc.estado = estado;
            }
            else
            {
                // Manejar el caso en el que no se puede convertir el valor seleccionado a EstadoIncidencia
                MessageBox.Show("Error al convertir el estado de la incidencia.");
            }

            // Intentar agregar la incidencia utilizando el controlador de incidencias
            bool agregadaExitosamente = await controladorIncidencias.ActualizarIncidencia(Convert.ToInt32(inc.num), inc);

            // Verificar si la incidencia se agregó exitosamente
            if (agregadaExitosamente)
            {
                MessageBox.Show("La incidencia se creó exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Puedes realizar alguna otra acción aquí si es necesario
            }
            else
            {
                MessageBox.Show("Hubo un error al crear la incidencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxTiempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxTiempo.Enabled = true;
            }
            else
            {
                textBoxTiempo.Enabled = false;
            }
        }

        private void cbxProfesor_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxProfesor.Checked)
            {
                cmxProfesor.Enabled = true;
            }
            else
            {
                cmxProfesor.Enabled = false;
            }
        }

        private void cbxEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEstado.Checked)
            {
                cmxEstado.Enabled = true;
            }
            else
            {
                cmxEstado.Enabled = false;
            }
        }

        private async void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            if (!inc.estado.ToString().Equals("CERRADA"))
            {
                if (cmxEstado.SelectedItem.ToString().Equals("CERRADA"))
                {
                    inc.fechaCierre = DateTime.Now;
                }
            }

            string nombreCompleto = cmxProfesor.SelectedItem.ToString();


            string[] partesNombre = nombreCompleto.Split(' ');


            if (partesNombre.Length >= 3)
            {
                string nombre = partesNombre[0];
                string apellido1 = partesNombre[1];
                string apellido2 = partesNombre[2];

                personal = await controladorPersonal.GetPersonalPorNombre_Apellido1_Apellido2(nombre, apellido1, apellido2);

                inc.responsable = personal;
            }

            if (textBoxTiempo.Enabled)
            {
                TimeSpan tiempoDec = TimeSpan.Parse(textBoxTiempo.Text);
                inc.tiempo_dec = tiempoDec;
            }

            if (Enum.TryParse<EstadoIncidencia>(cmxEstado.SelectedItem.ToString(), out EstadoIncidencia estado))
            {
                inc.estado = estado;
            }
            else
            {
                // Manejar el caso en el que no se puede convertir el valor seleccionado a EstadoIncidencia
                MessageBox.Show("Error al convertir el estado de la incidencia.");
            }

            // Intentar agregar la incidencia utilizando el controlador de incidencias
            bool agregadaExitosamente = await controladorIncidencias.ActualizarIncidencia(Convert.ToInt32(inc.num), inc);

            // Verificar si la incidencia se agregó exitosamente
            if (agregadaExitosamente)
            {
                MessageBox.Show("La incidencia se creó exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Puedes realizar alguna otra acción aquí si es necesario
            }
            else
            {
                MessageBox.Show("Hubo un error al crear la incidencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
