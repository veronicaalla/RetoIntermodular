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
        public Principal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearIncidencia crearIncidencia = new CrearIncidencia();
            this.Hide();
            crearIncidencia.Show();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Incidencia incidencia = new Incidencia();
            this.Hide();
            incidencia.Show();
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
    }
}
