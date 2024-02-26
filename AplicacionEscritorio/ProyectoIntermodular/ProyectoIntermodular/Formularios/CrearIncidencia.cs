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
    public partial class CrearIncidencia : Form
    {
        ControladorPersonal controladorPersonal = new ControladorPersonal();
        ControladorTipos controladortipos = new ControladorTipos();
        ControladorIncidencias controladorInc = new ControladorIncidencias();
        ControladorAula controladorAula = new ControladorAula();
        PerfilesResponse creador = new PerfilesResponse();

        bool creado = false;
        string archivoSeleccionado;

        List<IncidenciasSubtipos> listaTipos = new List<IncidenciasSubtipos>();
        List<string> listaSubtipos = new List<string>();
        List<string> listaSub_subtipos = new List<string>();
        List<Aulas> listaAulas = new List<Aulas>();

        ControladorDepartamentos controladorDepartamento = new ControladorDepartamentos();
        private Incidencias incidencia = new Incidencias();
        public CrearIncidencia(Principal principal)
        {
            creador = principal.usuario;

            InitializeComponent();
            cajaCreador.Text = creador.educantabria;
            this.StartPosition = FormStartPosition.CenterScreen;

            CargarComboBox();
        }
        private async void CargarComboBox()
        {
            // Obtener la lista de personas
            List<PerfilesResponse> listaPersonal = await controladorPersonal.GetPerfiles();
            List<PerfilesResponse> listaAdmin = new List<PerfilesResponse>();

            //foreach (PerfilesResponse personal in listaPersonal)
            //{
            //    if (personal.perfil.Equals("administrador"))
            //    {
            //        listaAdmin.Add(personal);
            //    }
            //}
            //if (listaPersonal != null)
            //{
            //    // Configurar el ComboBox para mostrar el nombre de cada persona
            //    comboBoxResponsable.DisplayMember = "educantabria";

            //    // Asignar la lista de personas como la fuente de datos del ComboBox
            //    comboBoxResponsable.DataSource = listaAdmin;
            //}
            //else
            //{
            //    MessageBox.Show("Error al cargar la lista de personas.");
            //}

            listaTipos = await controladortipos.GetIncidenciasSubtipos();
            if (listaTipos != null)
            {
                // Configurar el ComboBox para mostrar el nombre de cada persona
                comboBoxTipo.DisplayMember = "tipo";

                // Asignar la lista de personas como la fuente de datos del ComboBox
                comboBoxTipo.DataSource = listaTipos;
            }
            else
            {
                MessageBox.Show("Error al cargar la lista de personas.");
            }
        }

        //private void checkBoxResponsable_CheckedChanged(object sender, EventArgs e)
        //{
        //    comboBoxResponsable.Enabled = true;
        //    if (!checkBoxResponsable.Checked)
        //    {
        //        comboBoxResponsable.Enabled = false;
        //    }
        //}

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            IncidenciasRequest inc = new IncidenciasRequest();
            inc.fechaCreacion = DateTime.Now;
            inc.estado = EstadoIncidencia.ABIERTA;
            inc.descripcion = cajaDesc.Text;
            inc.tipo = comboBoxTipo.Text;
            inc.subtipo = comboBoxSubtipo.Text;
            inc.sub_subtipo = comboBoxSubsubTipo.Text;
            inc.creador = creador;
            inc.adjuntoUrl = archivoSeleccionado;
            inc.equipo = CajaEquipo.Text;

            creado = await controladorInc.AgregarIncidencia(inc);
            if (creado)
            {
                MessageBox.Show("La incidencia ha sido creada con éxito.", "Incidencia creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            this.Close();
            principal.Show();
        }

        private void btnAñadirArchivo_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();


            openFileDialog.Title = "Seleccionar archivo";
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            openFileDialog.Multiselect = false;


            DialogResult result = openFileDialog.ShowDialog();


            if (result == DialogResult.OK)
            {

                archivoSeleccionado = openFileDialog.FileName;
                lblArchivo.Text = archivoSeleccionado;
            }
        }

        private async void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            IncidenciasSubtipos tipo = comboBoxTipo.SelectedItem as IncidenciasSubtipos;

            listaSubtipos = await controladortipos.GetSubtipos(tipo.tipo.ToString());

            if (listaSubtipos != null)
            {
                // Configurar el ComboBox para mostrar el nombre de cada persona
                comboBoxSubtipo.DisplayMember = "subtipoNombre";

                // Asignar la lista de personas como la fuente de datos del ComboBox
                comboBoxSubtipo.DataSource = listaSubtipos;
            }
            else
            {
                MessageBox.Show("Error al cargar la lista de personas.");
            }

        }

        private async void comboBoxSubtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string subtipo = comboBoxSubtipo.SelectedValue.ToString();

            listaSub_subtipos = await controladortipos.GetSub_Subtipos(subtipo);

            if (listaSub_subtipos != null)
            {
                // Configurar el ComboBox para mostrar el nombre de cada persona
                comboBoxSubsubTipo.DisplayMember = "sub_subtipo";

                // Asignar la lista de personas como la fuente de datos del ComboBox
                comboBoxSubsubTipo.DataSource = listaSub_subtipos;
            }
            else
            {
                MessageBox.Show("Error al cargar la lista de personas.");
            }
        }
    }
}
    