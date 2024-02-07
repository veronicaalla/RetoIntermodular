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
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.checkBoxFechaCierre = new System.Windows.Forms.CheckBox();
            this.checkBoxResponsable = new System.Windows.Forms.CheckBox();
            this.comboBoxEquipo = new System.Windows.Forms.ComboBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.comboBoxResponsable = new System.Windows.Forms.ComboBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.btnAñadirArchivo = new System.Windows.Forms.Button();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cajaCreador = new System.Windows.Forms.TextBox();
            this.lblCreador = new System.Windows.Forms.Label();
            this.lblFechaCierre = new System.Windows.Forms.Label();
            this.dateFechaCierre = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.dateFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSubtipo = new System.Windows.Forms.ComboBox();
            this.lblSubtipo = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCrear.Location = new System.Drawing.Point(643, 280);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(116, 23);
            this.btnCrear.TabIndex = 43;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnVolver.Location = new System.Drawing.Point(506, 280);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(116, 23);
            this.btnVolver.TabIndex = 42;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // checkBoxFechaCierre
            // 
            this.checkBoxFechaCierre.AutoSize = true;
            this.checkBoxFechaCierre.Location = new System.Drawing.Point(308, 67);
            this.checkBoxFechaCierre.Name = "checkBoxFechaCierre";
            this.checkBoxFechaCierre.Size = new System.Drawing.Size(18, 17);
            this.checkBoxFechaCierre.TabIndex = 41;
            this.checkBoxFechaCierre.UseVisualStyleBackColor = true;
            this.checkBoxFechaCierre.CheckedChanged += new System.EventHandler(this.checkBoxFechaCierre_CheckedChanged);
            // 
            // checkBoxResponsable
            // 
            this.checkBoxResponsable.AutoSize = true;
            this.checkBoxResponsable.Location = new System.Drawing.Point(42, 190);
            this.checkBoxResponsable.Name = "checkBoxResponsable";
            this.checkBoxResponsable.Size = new System.Drawing.Size(18, 17);
            this.checkBoxResponsable.TabIndex = 40;
            this.checkBoxResponsable.UseVisualStyleBackColor = true;
            this.checkBoxResponsable.CheckedChanged += new System.EventHandler(this.checkBoxResponsable_CheckedChanged);
            // 
            // comboBoxEquipo
            // 
            this.comboBoxEquipo.FormattingEnabled = true;
            this.comboBoxEquipo.Location = new System.Drawing.Point(161, 226);
            this.comboBoxEquipo.Name = "comboBoxEquipo";
            this.comboBoxEquipo.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEquipo.TabIndex = 39;
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(62, 229);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(50, 16);
            this.lblEquipo.TabIndex = 38;
            this.lblEquipo.Text = "Equipo";
            // 
            // comboBoxResponsable
            // 
            this.comboBoxResponsable.Enabled = false;
            this.comboBoxResponsable.FormattingEnabled = true;
            this.comboBoxResponsable.Location = new System.Drawing.Point(161, 187);
            this.comboBoxResponsable.Name = "comboBoxResponsable";
            this.comboBoxResponsable.Size = new System.Drawing.Size(121, 24);
            this.comboBoxResponsable.TabIndex = 37;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(62, 190);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(89, 16);
            this.lblResponsable.TabIndex = 36;
            this.lblResponsable.Text = "Responsable";
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(465, 106);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(177, 16);
            this.lblArchivo.TabIndex = 35;
            this.lblArchivo.Text = "No se añadió ningún archivo";
            // 
            // btnAñadirArchivo
            // 
            this.btnAñadirArchivo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAñadirArchivo.Location = new System.Drawing.Point(332, 103);
            this.btnAñadirArchivo.Name = "btnAñadirArchivo";
            this.btnAñadirArchivo.Size = new System.Drawing.Size(116, 23);
            this.btnAñadirArchivo.TabIndex = 34;
            this.btnAñadirArchivo.Text = "Añadir archivo";
            this.btnAñadirArchivo.UseVisualStyleBackColor = false;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(161, 146);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEstado.TabIndex = 33;
            this.comboBoxEstado.Text = "Abierta";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(62, 149);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 16);
            this.lblEstado.TabIndex = 32;
            this.lblEstado.Text = "Estado";
            // 
            // cajaCreador
            // 
            this.cajaCreador.Enabled = false;
            this.cajaCreador.Location = new System.Drawing.Point(161, 29);
            this.cajaCreador.Name = "cajaCreador";
            this.cajaCreador.Size = new System.Drawing.Size(121, 22);
            this.cajaCreador.TabIndex = 31;
            this.cajaCreador.Text = "Pepito";
            // 
            // lblCreador
            // 
            this.lblCreador.AutoSize = true;
            this.lblCreador.Location = new System.Drawing.Point(62, 29);
            this.lblCreador.Name = "lblCreador";
            this.lblCreador.Size = new System.Drawing.Size(56, 16);
            this.lblCreador.TabIndex = 30;
            this.lblCreador.Text = "Creador";
            // 
            // lblFechaCierre
            // 
            this.lblFechaCierre.AutoSize = true;
            this.lblFechaCierre.Location = new System.Drawing.Point(329, 68);
            this.lblFechaCierre.Name = "lblFechaCierre";
            this.lblFechaCierre.Size = new System.Drawing.Size(101, 16);
            this.lblFechaCierre.TabIndex = 29;
            this.lblFechaCierre.Text = "Fecha de cierre";
            // 
            // dateFechaCierre
            // 
            this.dateFechaCierre.Enabled = false;
            this.dateFechaCierre.Location = new System.Drawing.Point(468, 68);
            this.dateFechaCierre.MinDate = new System.DateTime(2024, 2, 7, 0, 0, 0, 0);
            this.dateFechaCierre.Name = "dateFechaCierre";
            this.dateFechaCierre.Size = new System.Drawing.Size(265, 22);
            this.dateFechaCierre.TabIndex = 28;
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Location = new System.Drawing.Point(329, 29);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(119, 16);
            this.lblFechaCreacion.TabIndex = 27;
            this.lblFechaCreacion.Text = "Fecha de creación";
            // 
            // dateFechaCreacion
            // 
            this.dateFechaCreacion.Location = new System.Drawing.Point(468, 29);
            this.dateFechaCreacion.MaxDate = new System.DateTime(2024, 2, 7, 0, 0, 0, 0);
            this.dateFechaCreacion.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateFechaCreacion.Name = "dateFechaCreacion";
            this.dateFechaCreacion.Size = new System.Drawing.Size(265, 22);
            this.dateFechaCreacion.TabIndex = 26;
            this.dateFechaCreacion.Value = new System.DateTime(2024, 2, 7, 0, 0, 0, 0);
            // 
            // comboBoxSubtipo
            // 
            this.comboBoxSubtipo.FormattingEnabled = true;
            this.comboBoxSubtipo.Location = new System.Drawing.Point(161, 103);
            this.comboBoxSubtipo.Name = "comboBoxSubtipo";
            this.comboBoxSubtipo.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSubtipo.TabIndex = 25;
            // 
            // lblSubtipo
            // 
            this.lblSubtipo.AutoSize = true;
            this.lblSubtipo.Location = new System.Drawing.Point(62, 106);
            this.lblSubtipo.Name = "lblSubtipo";
            this.lblSubtipo.Size = new System.Drawing.Size(53, 16);
            this.lblSubtipo.TabIndex = 24;
            this.lblSubtipo.Text = "Subtipo";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(161, 64);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTipo.TabIndex = 23;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(62, 67);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 16);
            this.lblTipo.TabIndex = 22;
            this.lblTipo.Text = "Tipo";
            // 
            // CrearIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 333);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.checkBoxFechaCierre);
            this.Controls.Add(this.checkBoxResponsable);
            this.Controls.Add(this.comboBoxEquipo);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.comboBoxResponsable);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.btnAñadirArchivo);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cajaCreador);
            this.Controls.Add(this.lblCreador);
            this.Controls.Add(this.lblFechaCierre);
            this.Controls.Add(this.dateFechaCierre);
            this.Controls.Add(this.lblFechaCreacion);
            this.Controls.Add(this.dateFechaCreacion);
            this.Controls.Add(this.comboBoxSubtipo);
            this.Controls.Add(this.lblSubtipo);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.lblTipo);
            this.Name = "CrearIncidencia";
            this.Text = "CrearIncidencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.CheckBox checkBoxFechaCierre;
        private System.Windows.Forms.CheckBox checkBoxResponsable;
        private System.Windows.Forms.ComboBox comboBoxEquipo;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.ComboBox comboBoxResponsable;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.Button btnAñadirArchivo;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox cajaCreador;
        private System.Windows.Forms.Label lblCreador;
        private System.Windows.Forms.Label lblFechaCierre;
        private System.Windows.Forms.DateTimePicker dateFechaCierre;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.DateTimePicker dateFechaCreacion;
        private System.Windows.Forms.ComboBox comboBoxSubtipo;
        private System.Windows.Forms.Label lblSubtipo;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label lblTipo;
    }
}