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
    public partial class CrearDepartamento : Form
    {
        bool creado = false;
        public DepartementoRequest nuevoDepartamento = new DepartementoRequest();
        ControladorDepartamentos controladorDepartamento = new ControladorDepartamentos();
        ControladorPersonal controladorPersonal=new ControladorPersonal();
        public CrearDepartamento()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CargarComboBox();
        }

        private async void CargarComboBox()
        {
            List<Personal> listaPersonal = await controladorPersonal.GetPersonal();

            if (listaPersonal != null)
            {
                // Configurar el ComboBox
                comboJefe.DisplayMember = "nombre"; // Propiedad que se mostrará en el ComboBox

                // Asignar la lista de incidencias al ComboBox
                comboJefe.DataSource = listaPersonal;
            }
            else
            {
                MessageBox.Show("Error al cargar los jefes de departamento.");
            }
        }
       
        private async void btnCrear_Click(object sender, EventArgs e)
        {

            nuevoDepartamento.cod = cajaCodigo.Text.ToString();
            nuevoDepartamento.nombre = cajaNombre.Text;
            Personal selct = (Personal)comboJefe.SelectedItem;
            nuevoDepartamento.personal = selct.id;
            nuevoDepartamento.activo = true;

            creado = await controladorDepartamento.AgregarDepartamento(nuevoDepartamento);
            if (creado)
            {
                MessageBox.Show("El departamento ha sido creado con éxito.", "Departamento creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al crear el departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
