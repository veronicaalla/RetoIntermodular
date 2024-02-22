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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntermodular
{
    public partial class Principal : Form
    {

        private ControladorIncidencias controladorIncidencias;
        private List<Incidencias> lista;
        private Incidencias inci;
        


        public Principal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Perfiles perfiles = new Perfiles(PerfilEnum.ADMIN);

            if (perfiles.perfil==PerfilEnum.ADMIN)
            {
                btnVolver.Show();
                btnSalir.Hide();
            }
            else
            {
                btnVolver.Hide();
                btnSalir.Show();
            }

            controladorIncidencias = new ControladorIncidencias();
            inci = new Incidencias();
            GetIncidencias();
        }

        private async void GetIncidencias()
        {
            lista = await controladorIncidencias.GetIncidencias();

            if (lista != null)
            {
                foreach (var incidencia in lista) 
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);

                    row.Cells[0].Value = incidencia.num;
                    row.Cells[1].Value = incidencia.tipo;
                    row.Cells[2].Value = incidencia.incidenciasSubtipo.subtipoNombre; 
                    row.Cells[3].Value = incidencia.fechaCreacion;
                    row.Cells[4].Value = incidencia.fechaCierre;
                    row.Cells[5].Value = incidencia.descripcion;
                    row.Cells[6].Value = incidencia.estado;
                    row.Cells[7].Value = incidencia.adjuntoUrl;
                    row.Cells[8].Value = incidencia.creador.nombre;
                    row.Cells[9].Value = incidencia.responsable.nombre;
                    row.Cells[10].Value = incidencia.equipo.tipoEquipo;

                   

                    dataGridView1.Rows.Add(row);
                }
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearIncidencia crearIncidencia = new CrearIncidencia();
            this.Hide();
            crearIncidencia.Show();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                String numero = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                String tipo = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                String subtipo = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                String fechaCreacion = dataGridView1.CurrentRow.Cells[3].Value != null ? dataGridView1.CurrentRow.Cells[3].Value.ToString() : string.Empty;
                String fechaCierre = dataGridView1.CurrentRow.Cells[4].Value != null ? dataGridView1.CurrentRow.Cells[4].Value.ToString() : string.Empty;
                String profesor = dataGridView1.CurrentRow.Cells[8].Value != null ? dataGridView1.CurrentRow.Cells[8].Value.ToString() : string.Empty;

                ModificarIncidencia modificarInci = new ModificarIncidencia(numero,tipo,subtipo,fechaCreacion,fechaCierre,profesor);
                this.Hide();
                modificarInci.Show();


            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario");
            }
            
        }

        private void btnEli_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Comprobar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                // Si el usuario elige "Sí", realizar la acción de eliminación
                // Agrega aquí tu lógica de eliminación
                MessageBox.Show("Inciencia eliminada exitosamente.", "Incidencia eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Si el usuario elige "No" o cierra el cuadro de mensaje, cancelar la acción
                MessageBox.Show("Operación cancelada.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Inicial inicial=new Inicial();
            Admin admin = new Admin(inicial);
            this.Hide();
            admin.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxProfesor_CheckedChanged(object sender, EventArgs e)
        {
            cmxProfesor.Enabled = true;
            if (!cbxProfesor.Checked)
            {
                cmxProfesor.Enabled = false;
            }
        }

        private void cbxAula_CheckedChanged(object sender, EventArgs e)
        {
            cmxAula.Enabled = true;
            if (!cbxAula.Checked)
            {
                cmxAula.Enabled = false;
            }
        }

        private void cbxTipo_CheckedChanged(object sender, EventArgs e)
        {
            cmxTipo.Enabled = true;
            if (!cbxTipo.Checked)
            {
                cmxTipo.Enabled = false;
            }
        }

        private void cbxEstado_CheckedChanged(object sender, EventArgs e)
        {
            cmxEstado.Enabled = true;
            if (!cbxEstado.Checked)
            {
                cmxEstado.Enabled = false;
            }
        }

        private void cbxSub_CheckedChanged(object sender, EventArgs e)
        {
            cmxSub.Enabled = true;
            if (!cbxSub.Checked)
            {
                cmxSub.Enabled = false;
            }
        }

        private void cbxFecha_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            if (!cbxFecha.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }
    }
}
