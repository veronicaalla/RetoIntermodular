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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.Show();
        }
    }
}
