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
    public partial class CrearDepartamento : Form
    {
        public CrearDepartamento()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void lblDominio_Click(object sender, EventArgs e)
        {

        }

        private void cajaContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void cajaEducantabria_TextChanged(object sender, EventArgs e)
        {

        }

        private void cajaDominio_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPerfil_Click(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void lblEducantabria_Click(object sender, EventArgs e)
        {

        }

        private void comboPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El departamento ha sido creado con éxito.", "Departamento creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            SeleccionarDepartamentos seleccionarDepartamentos=new SeleccionarDepartamentos();
            this.Hide();
            seleccionarDepartamentos.Show();
        }

        private void lblCod_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxActivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
