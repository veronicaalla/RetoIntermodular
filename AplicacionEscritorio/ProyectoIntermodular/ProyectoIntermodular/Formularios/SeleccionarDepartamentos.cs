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
    public partial class SeleccionarDepartamentos : Form
    {
        private ControladorDepartamentos controladorDepartamentos;
        private List<Departamento> lista;
        private Departamento dep;
        
        public SeleccionarDepartamentos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            controladorDepartamentos = new ControladorDepartamentos();
            dep = new Departamento();
            GetDepartamentos();
        }

        private async void GetDepartamentos()
        {
            lista = await controladorDepartamentos.GetDepartamentos();

            if (lista != null)
            {
                foreach (var departamento in lista)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvDepartamentos);

                    row.Cells[0].Value = departamento.cod;
                    row.Cells[1].Value = departamento.nombre;
                    if (departamento.activo == true) { row.Cells[2].Value = "SI"; }
                    else { row.Cells[2].Value = "NO"; }
                    row.Cells[3].Value = departamento.personal;
                 

                    dgvDepartamentos.Rows.Add(row);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (dgvDepartamentos.SelectedRows.Count > 0)
            {
                String codigo = dgvDepartamentos.CurrentRow.Cells[0].Value.ToString();
                String nombre = dgvDepartamentos.CurrentRow.Cells[1].Value != null ? dgvDepartamentos.CurrentRow.Cells[1].Value.ToString() : string.Empty;
                String activo = dgvDepartamentos.CurrentRow.Cells[2].Value != null ? dgvDepartamentos.CurrentRow.Cells[2].Value.ToString() : string.Empty;
                String jefeDep = dgvDepartamentos.CurrentRow.Cells[3].Value != null ? dgvDepartamentos.CurrentRow.Cells[3].Value.ToString() : string.Empty;
                
                ModificarDepartamento modificar = new ModificarDepartamento(codigo,nombre,activo,jefeDep);
                this.Hide();
                modificar.Show();


            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario");
            }
            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearDepartamento crearDepartamento = new CrearDepartamento();
            this.Hide();
            crearDepartamento.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ControlUsuarios controlUsuarios=new ControlUsuarios();
            this.Hide();
            controlUsuarios.Show();
        }
    }
}
