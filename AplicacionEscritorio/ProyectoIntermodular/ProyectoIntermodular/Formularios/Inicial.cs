using ProyectoIntermodular.Clases;
using ProyectoIntermodular.Controladores;
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

        private ControladorPersonal controladorPersonal;
        private List<PerfilesResponse> lista;

        public PerfilesResponse usuario = new PerfilesResponse();
        private bool contraseñaVisible = false;
        public Inicial()
        {
            InitializeComponent();
            CargarTextBox();
            this.StartPosition = FormStartPosition.CenterScreen;
            pictureBox1.Enabled = false;
            pictureBox1.Hide();
            controladorPersonal = new ControladorPersonal();
            GetPersonal();

        }
        private async void GetPersonal()
        {
            lista = await controladorPersonal.GetPerfiles();
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {

            pictureBox1.Show();
            pictureBox1.Enabled = true;

            string nombreUsuario = txbUsuario.Text;
            string contraseña = tbxContra.Text;

            // Verificar si el usuario existe y la contraseña es correcta
            usuario = lista.Find(u => u.educantabria == nombreUsuario && u.password == contraseña);
            await Task.Delay(3000);

            

            if (usuario.perfil.ToString().Equals("administrador"))
            {
                Admin admin = new Admin(this);
                this.Hide();
                admin.Show();
            }
            else if (usuario.perfil.ToString().Equals("profesor"))
            {
                Principal princi = new Principal(this);
                this.Hide();
                princi.Show();
            }
        }

        private void Inicial_Load(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void txbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void CargarTextBox()
        {
            txbUsuario.Enter += TextBox_Enter;
            txbUsuario.Leave += TextBox_Leave;

            tbxContra.Enter += TextBox_Enter;
            tbxContra.Leave += TextBox_Leave;

            tbxContra.UseSystemPasswordChar = true;
            tbxContra.Text = "Contraseña";
            tbxContra.ForeColor = System.Drawing.SystemColors.GrayText;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            // Evento Enter - Se ejecuta cuando el usuario hace clic en el TextBox
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Usuario" || textBox.Text == "Contraseña")
            {
                textBox.Text = ""; // Borra el texto predeterminado
                textBox.ForeColor = System.Drawing.SystemColors.WindowText; // Cambia el color del texto a negro

                // Configuración específica para TextBox de contraseña
                if (textBox == tbxContra)
                {
                    tbxContra.UseSystemPasswordChar = true; // Oculta el texto de la contraseña
                }
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            // Evento Leave - Se ejecuta cuando el TextBox pierde el foco
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = (textBox == txbUsuario) ? "Usuario" : "Contraseña"; // Restaura el texto predeterminado
                textBox.ForeColor = System.Drawing.SystemColors.GrayText; // Cambia el color del texto a gris

                // Configuración específica para TextBox de contraseña
                if (textBox == tbxContra)
                {
                    tbxContra.UseSystemPasswordChar = false; // Muestra el texto de la contraseña
                }
            }
        }

        private void btnContraVisible_Click(object sender, EventArgs e)
        {
            // Alternar la visibilidad de la contraseña
            contraseñaVisible = !contraseñaVisible;

            // Actualizar la propiedad UseSystemPasswordChar del TextBox de contraseña
            tbxContra.UseSystemPasswordChar = !contraseñaVisible;
        }
    }
}
