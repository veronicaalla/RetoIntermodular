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
            this.checkBoxResponsable = new System.Windows.Forms.CheckBox();
            this.comboBoxEquipo = new System.Windows.Forms.ComboBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.btnAñadirArchivo = new System.Windows.Forms.Button();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cajaCreador = new System.Windows.Forms.TextBox();
            this.lblCreador = new System.Windows.Forms.Label();
            this.comboBoxSubtipo = new System.Windows.Forms.ComboBox();
            this.lblSubtipo = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAñadirTipo = new System.Windows.Forms.Button();
            this.btnAñadirSub = new System.Windows.Forms.Button();
            this.btnAñadirSubsubTipo = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBoxResponsable = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.SystemColors.HighlightText;
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
            this.btnVolver.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnVolver.Location = new System.Drawing.Point(736, 278);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(116, 23);
            this.btnVolver.TabIndex = 42;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // checkBoxResponsable
            // 
            this.checkBoxResponsable.AutoSize = true;
            this.checkBoxResponsable.Location = new System.Drawing.Point(612, 29);
            this.checkBoxResponsable.Name = "checkBoxResponsable";
            this.checkBoxResponsable.Size = new System.Drawing.Size(18, 17);
            this.checkBoxResponsable.TabIndex = 40;
            this.checkBoxResponsable.UseVisualStyleBackColor = true;
            this.checkBoxResponsable.CheckedChanged += new System.EventHandler(this.checkBoxResponsable_CheckedChanged);
            // 
            // comboBoxEquipo
            // 
            this.comboBoxEquipo.FormattingEnabled = true;
            this.comboBoxEquipo.Location = new System.Drawing.Point(161, 262);
            this.comboBoxEquipo.Name = "comboBoxEquipo";
            this.comboBoxEquipo.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEquipo.TabIndex = 39;
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(62, 265);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(50, 16);
            this.lblEquipo.TabIndex = 38;
            this.lblEquipo.Text = "Equipo";
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(632, 29);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(89, 16);
            this.lblResponsable.TabIndex = 36;
            this.lblResponsable.Text = "Responsable";
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(746, 72);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(177, 16);
            this.lblArchivo.TabIndex = 35;
            this.lblArchivo.Text = "No se añadió ningún archivo";
            // 
            // btnAñadirArchivo
            // 
            this.btnAñadirArchivo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAñadirArchivo.Location = new System.Drawing.Point(613, 69);
            this.btnAñadirArchivo.Name = "btnAñadirArchivo";
            this.btnAñadirArchivo.Size = new System.Drawing.Size(116, 23);
            this.btnAñadirArchivo.TabIndex = 34;
            this.btnAñadirArchivo.Text = "Añadir archivo";
            this.btnAñadirArchivo.UseVisualStyleBackColor = false;
            this.btnAñadirArchivo.Click += new System.EventHandler(this.btnAñadirArchivo_Click);
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(161, 186);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEstado.TabIndex = 33;
            this.comboBoxEstado.Text = "Abierta";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(62, 189);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Sub_Subtipo";
            // 
            // btnAñadirTipo
            // 
            this.btnAñadirTipo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAñadirTipo.Location = new System.Drawing.Point(302, 64);
            this.btnAñadirTipo.Name = "btnAñadirTipo";
            this.btnAñadirTipo.Size = new System.Drawing.Size(116, 23);
            this.btnAñadirTipo.TabIndex = 46;
            this.btnAñadirTipo.Text = "Añadir";
            this.btnAñadirTipo.UseVisualStyleBackColor = false;
            // 
            // btnAñadirSub
            // 
            this.btnAñadirSub.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAñadirSub.Location = new System.Drawing.Point(302, 106);
            this.btnAñadirSub.Name = "btnAñadirSub";
            this.btnAñadirSub.Size = new System.Drawing.Size(116, 23);
            this.btnAñadirSub.TabIndex = 47;
            this.btnAñadirSub.Text = "Añadir";
            this.btnAñadirSub.UseVisualStyleBackColor = false;
            // 
            // btnAñadirSubsubTipo
            // 
            this.btnAñadirSubsubTipo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAñadirSubsubTipo.Location = new System.Drawing.Point(302, 148);
            this.btnAñadirSubsubTipo.Name = "btnAñadirSubsubTipo";
            this.btnAñadirSubsubTipo.Size = new System.Drawing.Size(116, 23);
            this.btnAñadirSubsubTipo.TabIndex = 48;
            this.btnAñadirSubsubTipo.Text = "Añadir";
            this.btnAñadirSubsubTipo.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(404, 265);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Puesto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Aula";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(161, 226);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 52;
            // 
            // comboBoxResponsable
            // 
            this.comboBoxResponsable.Enabled = false;
            this.comboBoxResponsable.FormattingEnabled = true;
            this.comboBoxResponsable.Location = new System.Drawing.Point(749, 26);
            this.comboBoxResponsable.Name = "comboBoxResponsable";
            this.comboBoxResponsable.Size = new System.Drawing.Size(121, 24);
            this.comboBoxResponsable.TabIndex = 37;
            this.comboBoxResponsable.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // CrearIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1031, 333);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAñadirSubsubTipo);
            this.Controls.Add(this.btnAñadirSub);
            this.Controls.Add(this.btnAñadirTipo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnVolver);
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
        private System.Windows.Forms.CheckBox checkBoxResponsable;
        private System.Windows.Forms.ComboBox comboBoxEquipo;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.Button btnAñadirArchivo;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox cajaCreador;
        private System.Windows.Forms.Label lblCreador;
        private System.Windows.Forms.ComboBox comboBoxSubtipo;
        private System.Windows.Forms.Label lblSubtipo;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAñadirTipo;
        private System.Windows.Forms.Button btnAñadirSub;
        private System.Windows.Forms.Button btnAñadirSubsubTipo;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBoxResponsable;
    }
}