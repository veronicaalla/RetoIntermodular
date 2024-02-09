using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoIntermodular.Formularios
{
    public partial class AñadirComentario : Form
    {
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

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
