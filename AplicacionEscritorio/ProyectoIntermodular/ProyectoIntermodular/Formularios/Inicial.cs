﻿using ProyectoIntermodular.Formularios;
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
            this.StartPosition = FormStartPosition.CenterScreen;
            pictureBox1.Enabled = false;
            pictureBox1.Hide();
            
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pictureBox1.Enabled = true;
            await Task.Delay(3000);
            Admin admin = new Admin();
            this.Hide();
            admin.Show();
        }
        private void Inicial_Load(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
