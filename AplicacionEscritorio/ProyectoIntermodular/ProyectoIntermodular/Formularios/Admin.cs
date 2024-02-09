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
        public Admin(Inicial inicial)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        
            lblPrueba.Text = inicial.admin.perfil.ToString();
        }

      

        private void btnIncidencias_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
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
