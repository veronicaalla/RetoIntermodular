namespace ProyectoIntermodular.Formularios
{
    partial class ModificarIncidencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarIncidencia));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxEditar = new System.Windows.Forms.CheckBox();
            this.gbxEdit = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.cmxProfesor = new System.Windows.Forms.ComboBox();
            this.cbxProfesor = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmxEstado = new System.Windows.Forms.ComboBox();
            this.cbxFecha = new System.Windows.Forms.CheckBox();
            this.btnComentar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.Comentario,
            this.Fecha});
            this.dataGridView1.Location = new System.Drawing.Point(9, 166);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(806, 221);
            this.dataGridView1.TabIndex = 0;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            this.Usuario.Width = 125;
            // 
            // Comentario
            // 
            this.Comentario.HeaderText = "Comentario";
            this.Comentario.MinimumWidth = 6;
            this.Comentario.Name = "Comentario";
            this.Comentario.Width = 750;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 150;
            // 
            // cbxEditar
            // 
            this.cbxEditar.AutoSize = true;
            this.cbxEditar.Location = new System.Drawing.Point(9, 24);
            this.cbxEditar.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEditar.Name = "cbxEditar";
            this.cbxEditar.Size = new System.Drawing.Size(53, 17);
            this.cbxEditar.TabIndex = 1;
            this.cbxEditar.Text = "Editar";
            this.cbxEditar.UseVisualStyleBackColor = true;
            this.cbxEditar.CheckedChanged += new System.EventHandler(this.cbxEditar_CheckedChanged);
            // 
            // gbxEdit
            // 
            this.gbxEdit.Controls.Add(this.btnConfirmar);
            this.gbxEdit.Controls.Add(this.cmxProfesor);
            this.gbxEdit.Controls.Add(this.cbxProfesor);
            this.gbxEdit.Controls.Add(this.label1);
            this.gbxEdit.Controls.Add(this.cbxEstado);
            this.gbxEdit.Controls.Add(this.dateTimePicker1);
            this.gbxEdit.Controls.Add(this.cmxEstado);
            this.gbxEdit.Controls.Add(this.cbxFecha);
            this.gbxEdit.Location = new System.Drawing.Point(62, 24);
            this.gbxEdit.Margin = new System.Windows.Forms.Padding(2);
            this.gbxEdit.Name = "gbxEdit";
            this.gbxEdit.Padding = new System.Windows.Forms.Padding(2);
            this.gbxEdit.Size = new System.Drawing.Size(754, 132);
            this.gbxEdit.TabIndex = 2;
            this.gbxEdit.TabStop = false;
            this.gbxEdit.Text = "Grupo de edición";
            this.gbxEdit.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnConfirmar.Location = new System.Drawing.Point(652, 102);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(62, 22);
            this.btnConfirmar.TabIndex = 38;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // cmxProfesor
            // 
            this.cmxProfesor.FormattingEnabled = true;
            this.cmxProfesor.Location = new System.Drawing.Point(34, 30);
            this.cmxProfesor.Margin = new System.Windows.Forms.Padding(2);
            this.cmxProfesor.Name = "cmxProfesor";
            this.cmxProfesor.Size = new System.Drawing.Size(311, 21);
            this.cmxProfesor.TabIndex = 24;
            this.cmxProfesor.Text = "Profesor";
            this.cmxProfesor.SelectedIndexChanged += new System.EventHandler(this.cmxProfesor_SelectedIndexChanged);
            // 
            // cbxProfesor
            // 
            this.cbxProfesor.AutoSize = true;
            this.cbxProfesor.Location = new System.Drawing.Point(8, 34);
            this.cbxProfesor.Margin = new System.Windows.Forms.Padding(2);
            this.cbxProfesor.Name = "cbxProfesor";
            this.cbxProfesor.Size = new System.Drawing.Size(15, 14);
            this.cbxProfesor.TabIndex = 23;
            this.cbxProfesor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Cierre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(8, 69);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(15, 14);
            this.cbxEstado.TabIndex = 27;
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(563, 28);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 32;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cmxEstado
            // 
            this.cmxEstado.FormattingEnabled = true;
            this.cmxEstado.Location = new System.Drawing.Point(34, 66);
            this.cmxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cmxEstado.Name = "cmxEstado";
            this.cmxEstado.Size = new System.Drawing.Size(138, 21);
            this.cmxEstado.TabIndex = 28;
            this.cmxEstado.Text = "Estado";
            this.cmxEstado.SelectedIndexChanged += new System.EventHandler(this.cmxEstado_SelectedIndexChanged);
            // 
            // cbxFecha
            // 
            this.cbxFecha.AutoSize = true;
            this.cbxFecha.Location = new System.Drawing.Point(428, 30);
            this.cbxFecha.Margin = new System.Windows.Forms.Padding(2);
            this.cbxFecha.Name = "cbxFecha";
            this.cbxFecha.Size = new System.Drawing.Size(61, 17);
            this.cbxFecha.TabIndex = 31;
            this.cbxFecha.Text = "Fechas";
            this.cbxFecha.UseVisualStyleBackColor = true;
            // 
            // btnComentar
            // 
            this.btnComentar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnComentar.Location = new System.Drawing.Point(732, 410);
            this.btnComentar.Margin = new System.Windows.Forms.Padding(2);
            this.btnComentar.Name = "btnComentar";
            this.btnComentar.Size = new System.Drawing.Size(83, 41);
            this.btnComentar.TabIndex = 39;
            this.btnComentar.Text = "Añadir comentario";
            this.btnComentar.UseVisualStyleBackColor = false;
            this.btnComentar.Click += new System.EventHandler(this.btnComentar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSalir.Location = new System.Drawing.Point(626, 410);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(83, 41);
            this.btnSalir.TabIndex = 40;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ModificarIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(824, 461);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnComentar);
            this.Controls.Add(this.gbxEdit);
            this.Controls.Add(this.cbxEditar);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModificarIncidencia";
            this.Text = "Incidencia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxEdit.ResumeLayout(false);
            this.gbxEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox cbxEditar;
        private System.Windows.Forms.GroupBox gbxEdit;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ComboBox cmxProfesor;
        private System.Windows.Forms.CheckBox cbxProfesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmxEstado;
        private System.Windows.Forms.CheckBox cbxFecha;
        private System.Windows.Forms.Button btnComentar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}