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
    public partial class ModificarIncidencia : Form
    {
        private String numeroInci;
        private ControladorComentarios controladorComentarios;
        private List<Comentarios> lista;
        private Comentarios coment;
        public ModificarIncidencia(String numero,String tipo,String subtipo,String fechaCreacion,String fechaCierre,String profesor)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            gbxEdit.Enabled = false;
           
            this.numeroInci = numero;
            cmxTipo.Text = tipo;
            cmxSub.Text = subtipo;
            dateTimePicker1.Text = fechaCreacion;
            dateTimePicker2.Text = fechaCierre;
            cmxProfesor.Text=profesor;

            controladorComentarios = new ControladorComentarios();
            coment = new Comentarios();
            GetIncidencias();
        }

        private async void GetIncidencias()
        {
            lista = await controladorComentarios.GetComentarios();

            if (lista != null)
            {
                foreach (var comentario in lista)
                {
                    if (comentario.incidencia.num.Equals(numeroInci))
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridView1);

                        row.Cells[0].Value = comentario.personal.nombre;
                        row.Cells[1].Value = comentario.texto;
                        row.Cells[2].Value = comentario.fechahora;

                        dataGridView1.Rows.Add(row);
                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnComentar_Click(object sender, EventArgs e)
        {
            AñadirComentario childForm = new AñadirComentario();



            childForm.ShowDialog();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            this.Close();
            principal.Show();
        }

        private void cbxEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEditar.Checked)
            {
                gbxEdit.Enabled = true;
            }
            else
            {
                gbxEdit.Enabled = false;
            }
        }
    }
}
