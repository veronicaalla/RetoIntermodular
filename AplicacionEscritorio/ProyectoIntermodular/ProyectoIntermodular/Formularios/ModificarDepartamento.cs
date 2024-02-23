using ProyectoIntermodular.Clases;
using ProyectoIntermodular.Controladores;
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
        int departamentoId;
        ControladorPersonal controladorPersonal=new ControladorPersonal();  
        ControladorDepartamentos controladorDepartamentos=new ControladorDepartamentos();
        public ModificarDepartamento(int id,String codigo,String nombre,String activo,Personal jefeDep)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            departamentoId = id;
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
            CargarComboBox();
            
        }

        private async void CargarComboBox()
        {
            // Obtener la lista de personas
            List<Personal> listaPersonal = await controladorPersonal.GetPersonal();

            if (listaPersonal != null)
            {
                // Configurar el ComboBox para mostrar el nombre de cada persona
                comboJefe.DisplayMember = "nombre";

                // Asignar la lista de personas como la fuente de datos del ComboBox
                comboJefe.DataSource = listaPersonal;
            }
            else
            {
                MessageBox.Show("Error al cargar la lista de personas.");
            }
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
                // Obtener los valores seleccionados en los controles del formulario
                string codigo = cajaCodigo.Text;
                string nombre = cajaNombre.Text;
                bool activo = checkBoxActivo.Checked;
                Personal jefeSeleccionado = (Personal)comboJefe.SelectedItem;
            

                // Verificar que se haya seleccionado un jefe de departamento
                if (jefeSeleccionado != null)
                {
                    // Crear un nuevo objeto Departamentos con los datos obtenidos
                    Departamentos departamentoModificado = new Departamentos(departamentoId,codigo, nombre, activo, jefeSeleccionado.id);

                    try
                    {
                    // Intentar actualizar el departamento llamando al método ActualizarDepartamento
                    bool actualizacionExitosa = await controladorDepartamentos.ActualizarDepartamento(departamentoModificado);

                        if (actualizacionExitosa)
                        {
                            MessageBox.Show("Departamento actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el departamento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier excepción que ocurra durante la actualización del departamento
                        MessageBox.Show("Error al actualizar el departamento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un jefe de departamento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnVolver_Click(object sender, EventArgs e)
        {
            SeleccionarDepartamentos seleccionarDepartamentos=new SeleccionarDepartamentos();
            this.Hide();
            seleccionarDepartamentos.Show();
        }
    }
}
