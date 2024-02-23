using ProyectoIntermodular.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntermodular.Formularios
{
    public partial class ModificarDepartamento : Form
    {
        public ModificarDepartamento(String codigo,String nombre,String activo,String jefeDep)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            cajaCodigo.Text = codigo;
            cajaNombre.Text = nombre;
            if (activo.Equals("SI"))
            {
                checkBoxActivo.Checked = true;
            }
            else
            {
                checkBoxActivo.Checked = false;
            }
            comboJefe.Text = jefeDep;
            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El departamento ha sido modificado correctamente.", "Departamento modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            SeleccionarDepartamentos seleccionarDepartamentos=new SeleccionarDepartamentos();
            this.Hide();
            seleccionarDepartamentos.Show();
        }
    }
}
