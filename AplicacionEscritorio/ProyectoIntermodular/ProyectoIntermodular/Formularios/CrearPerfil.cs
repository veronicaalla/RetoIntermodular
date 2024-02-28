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
        PerfilesResponse nuevoPerfil = new PerfilesResponse();
        ControladorPersonal controladorPersonal = new ControladorPersonal();
        bool creado=false;
        int idPersonal;
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
            comboPerfil.Items.Add(PerfilEnum.otros);
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

            if (comboPerfil.Text.Equals(PerfilEnum.administrador.ToString())){nuevoPerfil.perfil = PerfilEnum.administrador;} 
            
            else if (comboPerfil.Text.Equals(PerfilEnum.profesor.ToString())) {nuevoPerfil.perfil = PerfilEnum.profesor;}

            else { nuevoPerfil.perfil = PerfilEnum.otros; }

            nuevoPerfil.personal_id = await controladorPersonal.GetUltimoPerfil();

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
            string valor = comboPerfil.Text;
        }
    }
}
