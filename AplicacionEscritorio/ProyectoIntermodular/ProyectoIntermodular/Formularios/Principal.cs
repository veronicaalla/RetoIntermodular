using ProyectoIntermodular.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntermodular
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearIncidencia crearIncidencia = new CrearIncidencia();
            this.Hide();
            crearIncidencia.Show();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Incidencia incidencia = new Incidencia();
            this.Hide();
            incidencia.Show();
        }
    }
}
