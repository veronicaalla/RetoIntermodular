using ProyectoIntermodular.Clases;
using ProyectoIntermodular.Controladores;
using System;
using System.Collections;
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
    public partial class ModificarUsuario : Form
    {
        private ControladorPersonal controladorPersonal;
        bool creado = false;
        public PersonalRequest nuevoUser = new PersonalRequest();
        Personal usu = new Personal();
        ControladorDepartamentos controladorDepartamento = new ControladorDepartamentos();
        
        public ModificarUsuario(Personal usuarioTocable)
        {
            InitializeComponent();
            usu = usuarioTocable;
            this.StartPosition = FormStartPosition.CenterScreen;
            cajaNombre.Text = usu.nombre;
            cajaApellido1.Text = usu.apellido1;
            cajaApellido2.Text = usu.apellido2;
            cajaDNI.Text = usu.dni; 
            CargarComboBox();
            cajaDireccion.Text = usu.direccion;
            cajaLocalidad.Text = usu.localidad;
            cajaCP.Text = usu.cp;
            cajaTlfn.Text = usu.tlf;
            if (usu.activo.Equals("SI"))
            {
                checkBoxActivo.Checked = true;
            }
            else
            {
                checkBoxActivo.Checked = false;
            }

            controladorPersonal = new ControladorPersonal();
            

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            SeleccionarUsuario se =new SeleccionarUsuario();
            this.Hide();
            se.Show();
        }

        private async void btnFinalizar_Click(object sender, EventArgs e)
        {
            bool activo = false;
            if (checkBoxActivo.Checked)
            {
                activo = true;
            }

            Departamentos departamento = (Departamentos) comboBoxDepartamento.SelectedItem; 
            Personal persona = new Personal(usu.id, cajaNombre.Text, cajaApellido1.Text, cajaApellido2.Text, cajaDireccion.Text, cajaLocalidad.Text, cajaCP.Text, cajaTlfn.Text, cajaDNI.Text, activo, departamento);

            // Espera a que se complete la actualización del personal
            bool actualizacionExitosa = await controladorPersonal.ActualizarPersonal(persona);

            if (actualizacionExitosa)
            {
                MessageBox.Show("El usuario ha sido modificado correctamente.", "Usuario modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al modificar el usuario. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                
                // Buscar el departamento que quieres seleccionar
                Departamentos departamentoSeleccionado = listaDepartamentos.FirstOrDefault(d => d.int_ == usu.Departamento.int_);

                // Seleccionar el departamento encontrado
                if (departamentoSeleccionado != null)
                {
                    comboBoxDepartamento.SelectedItem = departamentoSeleccionado;
                }
            }
            else
            {
                MessageBox.Show("Error al cargar las incidencias.");
            }
            
        }

        private void comboBoxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
