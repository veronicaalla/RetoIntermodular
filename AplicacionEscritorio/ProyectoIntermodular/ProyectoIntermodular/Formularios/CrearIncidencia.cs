using ProyectoIntermodular.Clases;
using ProyectoIntermodular.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntermodular.Formularios
{
    public partial class CrearIncidencia : Form
    {
        ControladorDepartamentos controladorDepartamento = new ControladorDepartamentos();
        private Incidencias incidencia = new Incidencias();
        public CrearIncidencia()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void checkBoxResponsable_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxResponsable.Enabled = true;
            if (!checkBoxResponsable.Checked)
            {
                comboBoxResponsable.Enabled = false;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La incidencia ha sido creada con éxito.", "Incidencia creada", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                
                string archivoSeleccionado = openFileDialog.FileName;
                lblArchivo.Text = archivoSeleccionado;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    