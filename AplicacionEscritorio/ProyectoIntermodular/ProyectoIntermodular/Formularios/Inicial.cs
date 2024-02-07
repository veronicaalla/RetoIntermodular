using ProyectoIntermodular.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntermodular
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
           Admin admin = new Admin();
            this.Hide();
            admin.Show();
        }
        private void Inicial_Load(object sender, EventArgs e)
        {

        }
    }
}
