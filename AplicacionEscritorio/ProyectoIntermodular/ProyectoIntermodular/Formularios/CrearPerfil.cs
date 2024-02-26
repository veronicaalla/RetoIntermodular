using ProyectoIntermodular.Clases;
using ProyectoIntermodular.Controladores;
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
    public partial class CrearPerfil : Form
    {
        CrearUsuario crear;
        Perfiles nuevoPerfil = new Perfiles();
        ControladorPersonal controladorPersonal = new ControladorPersonal();
        bool creado=false;
        public CrearPerfil(CrearUsuario crear)
        {
            this.crear = crear;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CargarComboBox();
        }
        private void CargarComboBox()
        {
            comboPerfil.Items.Add(PerfilEnum.administrador);
            comboPerfil.Items.Add(PerfilEnum.profesor);
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            CrearUsuario crearUsuario = new CrearUsuario();
            this.Hide();
            crearUsuario.Show();
        }

        private async void btnCrear_ClickAsync(object sender, EventArgs e)
        {
            nuevoPerfil.educantabria = cajaEducantabria.Text;
            nuevoPerfil.password = cajaContra.Text;
            nuevoPerfil.dominio = cajaDominio.Text;

            creado = await controladorPersonal.AgregarPerfil(nuevoPerfil);
            if (creado)
            {
                MessageBox.Show("El usuario ha sido creado con éxito.", "Usuario creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            Admin admin = new Admin();
            admin.Show();
            this.Close();

        }

        private void cajaContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void cajaEducantabria_TextChanged(object sender, EventArgs e)
        {

        }

        private void cajaDominio_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPerfil_Click(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void lblEducantabria_Click(object sender, EventArgs e)
        {

        }

        private void lblDominio_Click(object sender, EventArgs e)
        {

        }

        private void comboPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
