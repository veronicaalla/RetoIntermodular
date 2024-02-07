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
        public Admin()
        {
            InitializeComponent();
        }

        private void btnIncidencias_Click(object sender, EventArgs e)
        {
            Incidencia incidencia = new Incidencia();
            this.Hide();
            incidencia.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ControlUsuarios controlUsuarios = new ControlUsuarios();
            this.Hide();
            controlUsuarios.Show();
        }
    }
}
