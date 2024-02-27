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
    public partial class Admin : Form
    {
        public PerfilesResponse usuario=new PerfilesResponse();
        public Admin(Inicial inicial)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            usuario=inicial.usuario;

            if (usuario.educantabria != null) {
                lblPrueba.Text = inicial.usuario.educantabria.ToString();
            }
            else
            {
                lblPrueba.Text = "";
            }
        }

        public Admin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnIncidencias_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal(this);
            this.Hide();
            principal.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ControlUsuarios controlUsuarios = new ControlUsuarios();
            this.Hide();
            controlUsuarios.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
