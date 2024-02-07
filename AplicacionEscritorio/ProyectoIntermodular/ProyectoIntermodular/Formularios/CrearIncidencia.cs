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
    public partial class CrearIncidencia : Form
    {
        public CrearIncidencia()
        {
            InitializeComponent();
        }

        private void checkBoxResponsable_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxResponsable.Enabled = true;
            if (!checkBoxResponsable.Checked)
            {
                comboBoxResponsable.Enabled = false;
            }
        }

        private void checkBoxFechaCierre_CheckedChanged(object sender, EventArgs e)
        {
            dateFechaCierre.Enabled = true;
            if (!checkBoxFechaCierre.Checked)
            {
                dateFechaCierre.Enabled = false;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            this.Close();
            principal.Show();
        }
    }
}
