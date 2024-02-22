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
        public ModificarUsuario(String nombre,String primerApellido,String segundoApellido,String dni,String departamento,String direccion,String localidad,String cp,String telefono,String activo)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cajaNombre.Text = nombre;
            cajaApellido1.Text = primerApellido;
            cajaApellido2.Text = segundoApellido;
            cajaDNI.Text = dni;
            comboBoxDepartamento.Text = departamento;
            cajaDireccion.Text = direccion;
            cajaLocalidad.Text = localidad;
            cajaCP.Text = cp;
            cajaTlfn.Text = telefono;
            if (activo.Equals("SI"))
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
            int id = 3; 

            Departamentos departamento = new Departamentos(); 
            Personal persona = new Personal(id, cajaNombre.Text, cajaApellido1.Text, cajaApellido2.Text, cajaDireccion.Text, cajaLocalidad.Text, cajaCP.Text, cajaTlfn.Text, cajaDNI.Text, activo, departamento);

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
    }
}
