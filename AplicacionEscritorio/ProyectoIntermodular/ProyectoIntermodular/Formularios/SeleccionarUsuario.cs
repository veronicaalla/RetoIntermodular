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
        public Personal usuarioTocable;
        public SeleccionarUsuario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            controladorPersonal = new ControladorPersonal();
            person = new Personal();
            GetPersonal();
        }

        private async void GetPersonal()
        {
            lista = await controladorPersonal.GetPersonal();

            if (lista != null)
            {
                foreach (var personal in lista)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvPerfiles);

                    row.Cells[0].Value = personal.nombre;
                    row.Cells[1].Value = personal.apellido1;
                    row.Cells[2].Value = personal.apellido2;
                    row.Cells[3].Value = personal.dni;
                    row.Cells[4].Value = personal.direccion;
                    row.Cells[5].Value = personal.localidad;
                    row.Cells[6].Value = personal.cp;
                    row.Cells[7].Value = personal.tlf;
                    if (personal.activo == true) {row.Cells[8].Value = "SI";}
                    else { row.Cells[8].Value = "NO"; }
                    row.Cells[9].Value = personal.departamento.int_;


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
            if (dgvPerfiles.SelectedRows.Count > 0)
            {
                String nombreUsuario = dgvPerfiles.CurrentRow.Cells[0].Value.ToString();
                String primerApellido = dgvPerfiles.CurrentRow.Cells[1].Value != null ? dgvPerfiles.CurrentRow.Cells[1].Value.ToString() : string.Empty;
                String segundoApellido = dgvPerfiles.CurrentRow.Cells[2].Value != null ? dgvPerfiles.CurrentRow.Cells[2].Value.ToString() : string.Empty;
                String dni = dgvPerfiles.CurrentRow.Cells[3].Value != null ? dgvPerfiles.CurrentRow.Cells[3].Value.ToString() : string.Empty;
                String direccion = dgvPerfiles.CurrentRow.Cells[4].Value != null ? dgvPerfiles.CurrentRow.Cells[4].Value.ToString() : string.Empty;
                String localidad = dgvPerfiles.CurrentRow.Cells[5].Value != null ? dgvPerfiles.CurrentRow.Cells[5].Value.ToString() : string.Empty;
                String cp = dgvPerfiles.CurrentRow.Cells[6].Value != null ? dgvPerfiles.CurrentRow.Cells[6].Value.ToString() : string.Empty;
                String telefono = dgvPerfiles.CurrentRow.Cells[7].Value != null ? dgvPerfiles.CurrentRow.Cells[7].Value.ToString() : string.Empty;
                String activo = dgvPerfiles.CurrentRow.Cells[8].Value != null ? dgvPerfiles.CurrentRow.Cells[8].Value.ToString() : string.Empty;
                String departamento = dgvPerfiles.CurrentRow.Cells[9].Value != null ? dgvPerfiles.CurrentRow.Cells[9].Value.ToString() : string.Empty;
                ModificarUsuario modificarUsu = new ModificarUsuario(nombreUsuario,primerApellido,segundoApellido,dni,departamento,direccion,localidad,cp,telefono,activo);
                this.Hide();
                modificarUsu.Show();


            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvPerfiles.SelectedRows.Count > 0)
            {
                String nombreUsuario = dgvPerfiles.CurrentRow.Cells["Nombre"].Value.ToString();
                EliminarUsuario eliminarUsuario = new EliminarUsuario(nombreUsuario);
                this.Hide();
                eliminarUsuario.Show();

                
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario");
            }
            
        }
    }
}
    





