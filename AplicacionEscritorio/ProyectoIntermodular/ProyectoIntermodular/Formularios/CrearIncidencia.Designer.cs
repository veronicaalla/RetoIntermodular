namespace ProyectoIntermodular.Formularios
{
    partial class CrearIncidencia
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
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.comboBoxSubtipo = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaCierre = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.lblFechaCierre = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblSubtipo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblCreador = new System.Windows.Forms.Label();
            this.txtCreador = new System.Windows.Forms.TextBox();
            this.btnSubirArchivo = new System.Windows.Forms.Button();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.comboBoxResponsable = new System.Windows.Forms.ComboBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.comboBoxEquipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(111, 64);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTipo.TabIndex = 0;
            // 
            // comboBoxSubtipo
            // 
            this.comboBoxSubtipo.FormattingEnabled = true;
            this.comboBoxSubtipo.Location = new System.Drawing.Point(111, 94);
            this.comboBoxSubtipo.Name = "comboBoxSubtipo";
            this.comboBoxSubtipo.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSubtipo.TabIndex = 1;
            this.comboBoxSubtipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePickerFechaCreacion
            // 
            this.dateTimePickerFechaCreacion.Location = new System.Drawing.Point(386, 32);
            this.dateTimePickerFechaCreacion.MaxDate = new System.DateTime(2024, 2, 6, 0, 0, 0, 0);
            this.dateTimePickerFechaCreacion.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaCreacion.Name = "dateTimePickerFechaCreacion";
            this.dateTimePickerFechaCreacion.Size = new System.Drawing.Size(268, 22);
            this.dateTimePickerFechaCreacion.TabIndex = 2;
            this.dateTimePickerFechaCreacion.Value = new System.DateTime(2024, 2, 6, 0, 0, 0, 0);
            // 
            // dateTimePickerFechaCierre
            // 
            this.dateTimePickerFechaCierre.Location = new System.Drawing.Point(386, 64);
            this.dateTimePickerFechaCierre.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaCierre.MinDate = new System.DateTime(2024, 2, 6, 0, 0, 0, 0);
            this.dateTimePickerFechaCierre.Name = "dateTimePickerFechaCierre";
            this.dateTimePickerFechaCierre.Size = new System.Drawing.Size(268, 22);
            this.dateTimePickerFechaCierre.TabIndex = 3;
            this.dateTimePickerFechaCierre.Value = new System.DateTime(2024, 2, 6, 0, 0, 0, 0);
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Location = new System.Drawing.Point(261, 36);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(119, 16);
            this.lblFechaCreacion.TabIndex = 4;
            this.lblFechaCreacion.Text = "Fecha de creación";
            // 
            // lblFechaCierre
            // 
            this.lblFechaCierre.AutoSize = true;
            this.lblFechaCierre.Location = new System.Drawing.Point(261, 67);
            this.lblFechaCierre.Name = "lblFechaCierre";
            this.lblFechaCierre.Size = new System.Drawing.Size(101, 16);
            this.lblFechaCierre.TabIndex = 5;
            this.lblFechaCierre.Text = "Fecha de cierre";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(46, 67);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 16);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo";
            // 
            // lblSubtipo
            // 
            this.lblSubtipo.AutoSize = true;
            this.lblSubtipo.Location = new System.Drawing.Point(46, 97);
            this.lblSubtipo.Name = "lblSubtipo";
            this.lblSubtipo.Size = new System.Drawing.Size(53, 16);
            this.lblSubtipo.TabIndex = 7;
            this.lblSubtipo.Text = "Subtipo";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(264, 228);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(46, 129);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 16);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(111, 126);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEstado.TabIndex = 9;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(345, 228);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 11;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // lblCreador
            // 
            this.lblCreador.AutoSize = true;
            this.lblCreador.Location = new System.Drawing.Point(46, 39);
            this.lblCreador.Name = "lblCreador";
            this.lblCreador.Size = new System.Drawing.Size(56, 16);
            this.lblCreador.TabIndex = 12;
            this.lblCreador.Text = "Creador";
            // 
            // txtCreador
            // 
            this.txtCreador.Enabled = false;
            this.txtCreador.Location = new System.Drawing.Point(111, 33);
            this.txtCreador.Name = "txtCreador";
            this.txtCreador.Size = new System.Drawing.Size(121, 22);
            this.txtCreador.TabIndex = 13;
            this.txtCreador.Text = "Pepito";
            // 
            // btnSubirArchivo
            // 
            this.btnSubirArchivo.Location = new System.Drawing.Point(264, 95);
            this.btnSubirArchivo.Name = "btnSubirArchivo";
            this.btnSubirArchivo.Size = new System.Drawing.Size(102, 23);
            this.btnSubirArchivo.TabIndex = 14;
            this.btnSubirArchivo.Text = "Subir archivo";
            this.btnSubirArchivo.UseVisualStyleBackColor = true;
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(383, 98);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(235, 16);
            this.lblArchivo.TabIndex = 15;
            this.lblArchivo.Text = "No se ha seleccionado ningun archivo";
            this.lblArchivo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(261, 129);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(89, 16);
            this.lblResponsable.TabIndex = 17;
            this.lblResponsable.Text = "Responsable";
            // 
            // comboBoxResponsable
            // 
            this.comboBoxResponsable.FormattingEnabled = true;
            this.comboBoxResponsable.Location = new System.Drawing.Point(386, 126);
            this.comboBoxResponsable.Name = "comboBoxResponsable";
            this.comboBoxResponsable.Size = new System.Drawing.Size(121, 24);
            this.comboBoxResponsable.TabIndex = 16;
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(46, 163);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(50, 16);
            this.lblEquipo.TabIndex = 19;
            this.lblEquipo.Text = "Equipo";
            // 
            // comboBoxEquipo
            // 
            this.comboBoxEquipo.FormattingEnabled = true;
            this.comboBoxEquipo.Location = new System.Drawing.Point(111, 160);
            this.comboBoxEquipo.Name = "comboBoxEquipo";
            this.comboBoxEquipo.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEquipo.TabIndex = 18;
            // 
            // CrearIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(711, 268);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.comboBoxEquipo);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.comboBoxResponsable);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.btnSubirArchivo);
            this.Controls.Add(this.txtCreador);
            this.Controls.Add(this.lblCreador);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblSubtipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblFechaCierre);
            this.Controls.Add(this.lblFechaCreacion);
            this.Controls.Add(this.dateTimePickerFechaCierre);
            this.Controls.Add(this.dateTimePickerFechaCreacion);
            this.Controls.Add(this.comboBoxSubtipo);
            this.Controls.Add(this.comboBoxTipo);
            this.Name = "CrearIncidencia";
            this.Text = "CrearIncidencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.ComboBox comboBoxSubtipo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaCreacion;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaCierre;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.Label lblFechaCierre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblSubtipo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label lblCreador;
        private System.Windows.Forms.TextBox txtCreador;
        private System.Windows.Forms.Button btnSubirArchivo;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.ComboBox comboBoxResponsable;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.ComboBox comboBoxEquipo;
    }
}