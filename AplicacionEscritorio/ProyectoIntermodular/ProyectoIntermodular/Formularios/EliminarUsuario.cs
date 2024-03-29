﻿using System;
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
    public partial class EliminarUsuario : Form
    {
        public EliminarUsuario(String usuario)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cajaUsuario.Text = usuario;
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            SeleccionarUsuario controlUsuarios = new SeleccionarUsuario();
            this.Hide();
            controlUsuarios.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Comprobar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                // Si el usuario elige "Sí", realizar la acción de eliminación
                // Agrega aquí tu lógica de eliminación
                MessageBox.Show("Usuario eliminado exitosamente.", "Usuario eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Si el usuario elige "No" o cierra el cuadro de mensaje, cancelar la acción
                MessageBox.Show("Operación cancelada.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
