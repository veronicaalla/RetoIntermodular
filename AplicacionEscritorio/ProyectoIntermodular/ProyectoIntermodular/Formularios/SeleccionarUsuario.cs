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
    public partial class SeleccionarUsuario : Form
    {
        public SeleccionarUsuario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ControlUsuarios controlUsuarios = new ControlUsuarios();
            this.Hide();
            controlUsuarios.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarUsuario modificarUsuario   = new ModificarUsuario();
            this.Hide();
            modificarUsuario.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarUsuario eliminarUsuario = new EliminarUsuario();
            this.Hide();
            eliminarUsuario.Show();
        }
    }
}
