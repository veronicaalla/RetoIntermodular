﻿using ProyectoIntermodular.Clases;
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
                    row.Cells[2].Value = personal.dni;
                    row.Cells[3].Value = personal.direccion;
                    row.Cells[4].Value = personal.localidad;
                    row.Cells[5].Value = personal.cp;
                    row.Cells[6].Value = personal.tlf;
                    if (personal.activo == true) {row.Cells[7].Value = "SI";}
                    else { row.Cells[7].Value = "NO"; }
                    

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
            ModificarUsuario modificarUsuario = new ModificarUsuario();
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
    





