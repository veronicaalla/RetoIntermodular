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
    public partial class ModificarUsuario : Form
    {
        public ModificarUsuario()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            SeleccionarUsuario se =new SeleccionarUsuario();
            this.Hide();
            se.Show();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El usuario ha sido modificado correctamente.", "Usuario modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
