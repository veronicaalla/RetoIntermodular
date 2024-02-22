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
    public partial class CrearUsuario : Form
    {
        bool creado = false;
        public PersonalRequest nuevoUser = new PersonalRequest();
        ControladorDepartamentos controladorDepartamento = new ControladorDepartamentos();
        ControladorPersonal controladorPersonal = new ControladorPersonal();
        public CrearUsuario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CargarComboBox();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ControlUsuarios controlUsuarios = new ControlUsuarios();
            this.Hide();
            controlUsuarios.Show(); 
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {

        }
        private async void CargarComboBox()
        {
            List<Departamentos> listaDepartamentos = await controladorDepartamento.GetDepartamentos();

            if (listaDepartamentos != null)
            {
                // Configurar el ComboBox
                comboBoxDepartamento.DisplayMember = "nombre"; // Propiedad que se mostrará en el ComboBox

                // Asignar la lista de incidencias al ComboBox
                comboBoxDepartamento.DataSource = listaDepartamentos;
            }
            else
            {
                MessageBox.Show("Error al cargar las incidencias.");
            }
        }

        private async void btnSiguiente_Click(object sender, EventArgs e)
        {
            nuevoUser.nombre = cajaNombre.Text.ToString();
            nuevoUser.apellido1 = cajaApellido1.Text;
            nuevoUser.apellido2 = cajaApellido2.Text;
            nuevoUser.tlf = cajaTlfn.Text;
            nuevoUser.cp = cajaCP.Text;
            nuevoUser.direccion = cajaDireccion.Text;
            nuevoUser.departamento = (Departamentos)comboBoxDepartamento.SelectedItem;
            nuevoUser.dni = cajaDNI.Text;
            nuevoUser.localidad = cajaLocalidad.Text;
            nuevoUser.activo = true;

            creado = await controladorPersonal.AgregarUser(nuevoUser);
            if (creado)
            {
                MessageBox.Show("El usuario ha sido creado con éxito.", "Usuario creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CrearPerfil crearPerfil = new CrearPerfil(this);
            this.Hide();
            crearPerfil.Show();
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            ControlUsuarios controlUsuarios = new ControlUsuarios();
            this.Hide();
            controlUsuarios.Show();
        }
    }
}
