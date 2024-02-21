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
    public partial class ModificarIncidencia : Form
    {
        public ModificarIncidencia()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnComentar_Click(object sender, EventArgs e)
        {
            AñadirComentario childForm = new AñadirComentario();



            childForm.ShowDialog();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            this.Close();
            principal.Show();
        }
    }
}
