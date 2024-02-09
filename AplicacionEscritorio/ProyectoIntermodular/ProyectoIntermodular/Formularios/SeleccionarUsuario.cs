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
    public partial class SeleccionarUsuario : Form
    {
        private ControladorPersonal controladorPersonal;
        private List<Personal> lista;
        private Personal person;
        public SeleccionarUsuario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            controladorPersonal= new ControladorPersonal(); 
            person = new Personal();
            GetPersonal();
        }

        private async void GetPersonal()
        {
            person = await controladorPersonal.GetPersonal();

            if (person != null)
            {
                foreach(var personal in lista)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvPerfiles);

                    row.Cells[0].Value = person.nombre;
                    row.Cells[1].Value = person.apellido1;
                    row.Cells[2].Value = person.dni;
                    row.Cells[3].Value = person.direccion;

                    dgvPerfiles.Rows.Add(row);
                }
            }
        }

            private void btnVolver_Click(object sender, EventArgs e)
        {
            ControlUsuarios controlUsuarios = new ControlUsuarios();
            this.Hide();
            controlUsuarios.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarUsuario modificarUsuario   = new ModificarUsuario();
            this.Hide();
            modificarUsuario.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarUsuario eliminarUsuario = new EliminarUsuario();
            this.Hide();
            eliminarUsuario.Show();
        }
    }
}
