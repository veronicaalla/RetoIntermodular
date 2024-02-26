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
            dgvPerfiles.AutoGenerateColumns = false;
            
            DataGridViewTextBoxColumn nombreColumna = new DataGridViewTextBoxColumn();
            nombreColumna.HeaderText = "Nombre"; // Puedes personalizar el nombre aquí
            nombreColumna.DataPropertyName = "nombre"; // Debe coincidir con el nombre de la propiedad en tu clase Persona
            dgvPerfiles.Columns.Add(nombreColumna);
            
            nombreColumna = new DataGridViewTextBoxColumn();
            nombreColumna.HeaderText = "Primer Apellido"; // Puedes personalizar el nombre aquí
            nombreColumna.DataPropertyName = "apellido1"; // Debe coincidir con el nombre de la propiedad en tu clase Persona
            dgvPerfiles.Columns.Add(nombreColumna);

            nombreColumna = new DataGridViewTextBoxColumn();
            nombreColumna.HeaderText = "Segundo Apellido"; // Puedes personalizar el nombre aquí
            nombreColumna.DataPropertyName = "apellido2"; // Debe coincidir con el nombre de la propiedad en tu clase Persona
            dgvPerfiles.Columns.Add(nombreColumna);

            nombreColumna = new DataGridViewTextBoxColumn();
            nombreColumna.HeaderText = "DNI"; // Puedes personalizar el nombre aquí
            nombreColumna.DataPropertyName = "dni"; // Debe coincidir con el nombre de la propiedad en tu clase Persona
            dgvPerfiles.Columns.Add(nombreColumna);

            nombreColumna = new DataGridViewTextBoxColumn();
            nombreColumna.HeaderText = "Direccion"; // Puedes personalizar el nombre aquí
            nombreColumna.DataPropertyName = "direccion"; // Debe coincidir con el nombre de la propiedad en tu clase Persona
            dgvPerfiles.Columns.Add(nombreColumna);

            nombreColumna = new DataGridViewTextBoxColumn();
            nombreColumna.HeaderText = "Localidad"; // Puedes personalizar el nombre aquí
            nombreColumna.DataPropertyName = "localidad"; // Debe coincidir con el nombre de la propiedad en tu clase Persona
            dgvPerfiles.Columns.Add(nombreColumna);

            nombreColumna = new DataGridViewTextBoxColumn();
            nombreColumna.HeaderText = "Telefono"; // Puedes personalizar el nombre aquí
            nombreColumna.DataPropertyName = "tlf"; // Debe coincidir con el nombre de la propiedad en tu clase Persona
           
            nombreColumna = new DataGridViewTextBoxColumn();
            nombreColumna.HeaderText = "Activo"; // Puedes personalizar el nombre aquí
            nombreColumna.DataPropertyName = "activo"; // Debe coincidir con el nombre de la propiedad en tu clase Persona
            
            nombreColumna = new DataGridViewTextBoxColumn();
            nombreColumna.HeaderText = "Departamentos"; // Puedes personalizar el nombre aquí
            nombreColumna.DataPropertyName = "NombreDepartamento"; // Debe coincidir con el nombre de la propiedad en tu clase Persona

            dgvPerfiles.Columns.Add(nombreColumna);
            
            lista = await controladorPersonal.GetPersonal();
            dgvPerfiles.DataSource = lista;
            
        }
        private void dgvPerfiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegurarse de que el clic se realiza en una celda válida y no en el encabezado
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener el objeto seleccionado
                usuarioTocable = (Personal)dgvPerfiles.Rows[e.RowIndex].DataBoundItem;

                // Hacer algo con el objeto seleccionado, por ejemplo, mostrar sus detalles
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
                usuarioTocable = (Personal)dgvPerfiles.SelectedRows[0].DataBoundItem;
                ModificarUsuario modificarUsu = new ModificarUsuario(usuarioTocable);
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
    





