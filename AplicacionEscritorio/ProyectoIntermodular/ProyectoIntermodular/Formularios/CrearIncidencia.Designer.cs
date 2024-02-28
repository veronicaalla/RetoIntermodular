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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearIncidencia));
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.btnAñadirArchivo = new System.Windows.Forms.Button();
            this.cajaCreador = new System.Windows.Forms.TextBox();
            this.lblCreador = new System.Windows.Forms.Label();
            this.comboBoxSubtipo = new System.Windows.Forms.ComboBox();
            this.lblSubtipo = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CajaEquipo = new System.Windows.Forms.TextBox();
            this.cajaDesc = new System.Windows.Forms.TextBox();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.cajaSub_sub = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrear.Location = new System.Drawing.Point(873, 278);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(116, 23);
            this.btnCrear.TabIndex = 43;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolver.Location = new System.Drawing.Point(736, 278);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(116, 23);
            this.btnVolver.TabIndex = 42;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipo.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblEquipo.Location = new System.Drawing.Point(62, 196);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(50, 16);
            this.lblEquipo.TabIndex = 38;
            this.lblEquipo.Text = "Equipo";
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivo.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblArchivo.Location = new System.Drawing.Point(763, 28);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(177, 16);
            this.lblArchivo.TabIndex = 35;
            this.lblArchivo.Text = "No se añadió ningún archivo";
            // 
            // btnAñadirArchivo
            // 
            this.btnAñadirArchivo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAñadirArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirArchivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAñadirArchivo.Location = new System.Drawing.Point(632, 28);
            this.btnAñadirArchivo.Name = "btnAñadirArchivo";
            this.btnAñadirArchivo.Size = new System.Drawing.Size(116, 23);
            this.btnAñadirArchivo.TabIndex = 34;
            this.btnAñadirArchivo.Text = "Añadir archivo";
            this.btnAñadirArchivo.UseVisualStyleBackColor = false;
            this.btnAñadirArchivo.Click += new System.EventHandler(this.btnAñadirArchivo_Click);
            // 
            // cajaCreador
            // 
            this.cajaCreador.Enabled = false;
            this.cajaCreador.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaCreador.Location = new System.Drawing.Point(161, 29);
            this.cajaCreador.Name = "cajaCreador";
            this.cajaCreador.Size = new System.Drawing.Size(222, 22);
            this.cajaCreador.TabIndex = 31;
            this.cajaCreador.Text = "Pepito";
            // 
            // lblCreador
            // 
            this.lblCreador.AutoSize = true;
            this.lblCreador.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreador.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblCreador.Location = new System.Drawing.Point(62, 29);
            this.lblCreador.Name = "lblCreador";
            this.lblCreador.Size = new System.Drawing.Size(56, 16);
            this.lblCreador.TabIndex = 30;
            this.lblCreador.Text = "Creador";
            // 
            // comboBoxSubtipo
            // 
            this.comboBoxSubtipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubtipo.FormattingEnabled = true;
            this.comboBoxSubtipo.Location = new System.Drawing.Point(161, 103);
            this.comboBoxSubtipo.Name = "comboBoxSubtipo";
            this.comboBoxSubtipo.Size = new System.Drawing.Size(222, 24);
            this.comboBoxSubtipo.TabIndex = 25;
            this.comboBoxSubtipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubtipo_SelectedIndexChanged);
            // 
            // lblSubtipo
            // 
            this.lblSubtipo.AutoSize = true;
            this.lblSubtipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtipo.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblSubtipo.Location = new System.Drawing.Point(62, 106);
            this.lblSubtipo.Name = "lblSubtipo";
            this.lblSubtipo.Size = new System.Drawing.Size(53, 16);
            this.lblSubtipo.TabIndex = 24;
            this.lblSubtipo.Text = "Subtipo";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(161, 64);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(222, 24);
            this.comboBoxTipo.TabIndex = 23;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipo_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblTipo.Location = new System.Drawing.Point(62, 67);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 16);
            this.lblTipo.TabIndex = 22;
            this.lblTipo.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(62, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Sub_Subtipo";
            // 
            // CajaEquipo
            // 
            this.CajaEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaEquipo.Location = new System.Drawing.Point(161, 190);
            this.CajaEquipo.Name = "CajaEquipo";
            this.CajaEquipo.Size = new System.Drawing.Size(222, 22);
            this.CajaEquipo.TabIndex = 49;
            // 
            // cajaDesc
            // 
            this.cajaDesc.Location = new System.Drawing.Point(632, 67);
            this.cajaDesc.Multiline = true;
            this.cajaDesc.Name = "cajaDesc";
            this.cajaDesc.Size = new System.Drawing.Size(357, 145);
            this.cajaDesc.TabIndex = 51;
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrip.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblDescrip.Location = new System.Drawing.Point(533, 73);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(79, 16);
            this.lblDescrip.TabIndex = 50;
            this.lblDescrip.Text = "Descripcion";
            // 
            // cajaSub_sub
            // 
            this.cajaSub_sub.Location = new System.Drawing.Point(161, 150);
            this.cajaSub_sub.Name = "cajaSub_sub";
            this.cajaSub_sub.Size = new System.Drawing.Size(222, 22);
            this.cajaSub_sub.TabIndex = 52;
            // 
            // CrearIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1031, 333);
            this.Controls.Add(this.cajaSub_sub);
            this.Controls.Add(this.cajaDesc);
            this.Controls.Add(this.lblDescrip);
            this.Controls.Add(this.CajaEquipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.btnAñadirArchivo);
            this.Controls.Add(this.cajaCreador);
            this.Controls.Add(this.lblCreador);
            this.Controls.Add(this.comboBoxSubtipo);
            this.Controls.Add(this.lblSubtipo);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.lblTipo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearIncidencia";
            this.Text = "CrearIncidencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.Button btnAñadirArchivo;
        private System.Windows.Forms.TextBox cajaCreador;
        private System.Windows.Forms.Label lblCreador;
        private System.Windows.Forms.ComboBox comboBoxSubtipo;
        private System.Windows.Forms.Label lblSubtipo;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CajaEquipo;
        private System.Windows.Forms.TextBox cajaDesc;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.TextBox cajaSub_sub;
    }
}