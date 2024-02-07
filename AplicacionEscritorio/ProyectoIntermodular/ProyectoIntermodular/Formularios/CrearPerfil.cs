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
    public partial class CrearPerfil : Form
    {
        public CrearPerfil()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            CrearUsuario crearUsuario = new CrearUsuario();
            this.Hide();
            crearUsuario.Show();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El usuario ha sido creado con éxito.", "Usuario creado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
