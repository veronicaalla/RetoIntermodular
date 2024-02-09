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
    public partial class ControlUsuarios : Form
    {
        public ControlUsuarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //Admin admin = new Admin();
            this.Hide();
            //admin.Show();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearUsuario crearUsuario = new CrearUsuario();
            this.Hide();
            crearUsuario.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarUsuario eliminarUsuario= new EliminarUsuario();
            this.Hide();
            eliminarUsuario.Show();
        }

        private void ControlUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SeleccionarUsuario seleccionar=new SeleccionarUsuario();
            this.Hide();
            seleccionar.Show();
        }
    }
}
