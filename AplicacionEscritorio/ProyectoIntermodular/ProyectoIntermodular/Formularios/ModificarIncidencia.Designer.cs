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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxTiempo = new System.Windows.Forms.TextBox();
            this.cmxProfesor = new System.Windows.Forms.ComboBox();
            this.cbxProfesor = new System.Windows.Forms.CheckBox();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.cmxEstado = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(62, 177);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(626, 221);
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
            this.Comentario.Width = 500;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 225;
            // 
            // cbxEditar
            // 
            this.cbxEditar.AutoSize = true;
            this.cbxEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxEditar.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEditar.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.cbxEditar.Location = new System.Drawing.Point(62, 14);
            this.cbxEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxEditar.Name = "cbxEditar";
            this.cbxEditar.Size = new System.Drawing.Size(52, 18);
            this.cbxEditar.TabIndex = 1;
            this.cbxEditar.Text = "Editar";
            this.cbxEditar.UseVisualStyleBackColor = true;
            this.cbxEditar.CheckedChanged += new System.EventHandler(this.cbxEditar_CheckedChanged);
            // 
            // gbxEdit
            // 
            this.gbxEdit.Controls.Add(this.checkBox1);
            this.gbxEdit.Controls.Add(this.textBoxTiempo);
            this.gbxEdit.Controls.Add(this.cmxProfesor);
            this.gbxEdit.Controls.Add(this.cbxProfesor);
            this.gbxEdit.Controls.Add(this.cbxEstado);
            this.gbxEdit.Controls.Add(this.cmxEstado);
            this.gbxEdit.Controls.Add(this.btnConfirmar);
            this.gbxEdit.Location = new System.Drawing.Point(62, 35);
            this.gbxEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxEdit.Name = "gbxEdit";
            this.gbxEdit.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxEdit.Size = new System.Drawing.Size(626, 132);
            this.gbxEdit.TabIndex = 2;
            this.gbxEdit.TabStop = false;
            this.gbxEdit.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(353, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 17);
            this.checkBox1.TabIndex = 47;
            this.checkBox1.Text = "Tiempo dedicado";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBoxTiempo
            // 
            this.textBoxTiempo.Enabled = false;
            this.textBoxTiempo.Location = new System.Drawing.Point(467, 18);
            this.textBoxTiempo.Name = "textBoxTiempo";
            this.textBoxTiempo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTiempo.TabIndex = 46;
            // 
            // cmxProfesor
            // 
            this.cmxProfesor.Enabled = false;
            this.cmxProfesor.FormattingEnabled = true;
            this.cmxProfesor.Location = new System.Drawing.Point(36, 16);
            this.cmxProfesor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmxProfesor.Name = "cmxProfesor";
            this.cmxProfesor.Size = new System.Drawing.Size(311, 21);
            this.cmxProfesor.TabIndex = 43;
            this.cmxProfesor.Text = "Profesor";
            // 
            // cbxProfesor
            // 
            this.cbxProfesor.AutoSize = true;
            this.cbxProfesor.Location = new System.Drawing.Point(10, 20);
            this.cbxProfesor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxProfesor.Name = "cbxProfesor";
            this.cbxProfesor.Size = new System.Drawing.Size(15, 14);
            this.cbxProfesor.TabIndex = 42;
            this.cbxProfesor.UseVisualStyleBackColor = true;
            this.cbxProfesor.CheckedChanged += new System.EventHandler(this.cbxProfesor_CheckedChanged);
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(10, 55);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(15, 14);
            this.cbxEstado.TabIndex = 44;
            this.cbxEstado.UseVisualStyleBackColor = true;
            this.cbxEstado.CheckedChanged += new System.EventHandler(this.cbxEstado_CheckedChanged);
            // 
            // cmxEstado
            // 
            this.cmxEstado.Enabled = false;
            this.cmxEstado.FormattingEnabled = true;
            this.cmxEstado.Location = new System.Drawing.Point(36, 52);
            this.cmxEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmxEstado.Name = "cmxEstado";
            this.cmxEstado.Size = new System.Drawing.Size(138, 21);
            this.cmxEstado.TabIndex = 45;
            this.cmxEstado.Text = "Estado";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmar.Location = new System.Drawing.Point(536, 97);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(62, 22);
            this.btnConfirmar.TabIndex = 38;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click_1);
            // 
            // btnComentar
            // 
            this.btnComentar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnComentar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComentar.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComentar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnComentar.Location = new System.Drawing.Point(604, 422);
            this.btnComentar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnComentar.Name = "btnComentar";
            this.btnComentar.Size = new System.Drawing.Size(83, 41);
            this.btnComentar.TabIndex = 39;
            this.btnComentar.Text = "Añadir comentario";
            this.btnComentar.UseVisualStyleBackColor = false;
            this.btnComentar.Click += new System.EventHandler(this.btnComentar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(498, 422);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(710, 474);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnComentar);
            this.Controls.Add(this.gbxEdit);
            this.Controls.Add(this.cbxEditar);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btnComentar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxTiempo;
        private System.Windows.Forms.ComboBox cmxProfesor;
        private System.Windows.Forms.CheckBox cbxProfesor;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.ComboBox cmxEstado;
    }
}