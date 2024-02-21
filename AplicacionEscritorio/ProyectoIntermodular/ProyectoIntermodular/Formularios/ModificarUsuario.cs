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
    public partial class ModificarUsuario : Form
    {
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
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            SeleccionarUsuario se =new SeleccionarUsuario();
            this.Hide();
            se.Show();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El usuario ha sido modificado correctamente.", "Usuario modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
