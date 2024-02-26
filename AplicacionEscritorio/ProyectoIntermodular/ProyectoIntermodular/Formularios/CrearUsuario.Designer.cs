namespace ProyectoIntermodular.Formularios
{
    partial class CrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearUsuario));
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cajaNombre = new System.Windows.Forms.TextBox();
            this.cajaApellido1 = new System.Windows.Forms.TextBox();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.cajaApellido2 = new System.Windows.Forms.TextBox();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.cajaDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.cajaTlfn = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.cajaCP = new System.Windows.Forms.TextBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.cajaLocalidad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.cajaDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.checkBoxActivo = new System.Windows.Forms.CheckBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.comboBoxDepartamento = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolver.Location = new System.Drawing.Point(195, 263);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(90, 30);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSiguiente.Location = new System.Drawing.Point(304, 263);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(90, 30);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(25, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // cajaNombre
            // 
            this.cajaNombre.Location = new System.Drawing.Point(148, 32);
            this.cajaNombre.Name = "cajaNombre";
            this.cajaNombre.Size = new System.Drawing.Size(121, 22);
            this.cajaNombre.TabIndex = 3;
            // 
            // cajaApellido1
            // 
            this.cajaApellido1.Location = new System.Drawing.Point(148, 67);
            this.cajaApellido1.Name = "cajaApellido1";
            this.cajaApellido1.Size = new System.Drawing.Size(121, 22);
            this.cajaApellido1.TabIndex = 5;
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido1.Location = new System.Drawing.Point(25, 69);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(89, 15);
            this.lblApellido1.TabIndex = 4;
            this.lblApellido1.Text = "Primer apellido";
            // 
            // cajaApellido2
            // 
            this.cajaApellido2.Location = new System.Drawing.Point(148, 104);
            this.cajaApellido2.Name = "cajaApellido2";
            this.cajaApellido2.Size = new System.Drawing.Size(121, 22);
            this.cajaApellido2.TabIndex = 7;
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido2.Location = new System.Drawing.Point(25, 106);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(102, 15);
            this.lblApellido2.TabIndex = 6;
            this.lblApellido2.Text = "Segundo apellido";
            // 
            // cajaDNI
            // 
            this.cajaDNI.Location = new System.Drawing.Point(148, 141);
            this.cajaDNI.Name = "cajaDNI";
            this.cajaDNI.Size = new System.Drawing.Size(121, 22);
            this.cajaDNI.TabIndex = 9;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(25, 143);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(27, 15);
            this.lblDNI.TabIndex = 8;
            this.lblDNI.Text = "DNI";
            // 
            // cajaTlfn
            // 
            this.cajaTlfn.Location = new System.Drawing.Point(444, 141);
            this.cajaTlfn.Name = "cajaTlfn";
            this.cajaTlfn.Size = new System.Drawing.Size(121, 22);
            this.cajaTlfn.TabIndex = 17;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(321, 143);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(54, 15);
            this.lblTelefono.TabIndex = 16;
            this.lblTelefono.Text = "Teléfono";
            // 
            // cajaCP
            // 
            this.cajaCP.Location = new System.Drawing.Point(444, 104);
            this.cajaCP.Name = "cajaCP";
            this.cajaCP.Size = new System.Drawing.Size(76, 22);
            this.cajaCP.TabIndex = 15;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.Location = new System.Drawing.Point(321, 106);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(22, 15);
            this.lblCP.TabIndex = 14;
            this.lblCP.Text = "CP";
            // 
            // cajaLocalidad
            // 
            this.cajaLocalidad.Location = new System.Drawing.Point(444, 67);
            this.cajaLocalidad.Name = "cajaLocalidad";
            this.cajaLocalidad.Size = new System.Drawing.Size(121, 22);
            this.cajaLocalidad.TabIndex = 13;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(321, 67);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(58, 15);
            this.lblLocalidad.TabIndex = 12;
            this.lblLocalidad.Text = "Localidad";
            // 
            // cajaDireccion
            // 
            this.cajaDireccion.Location = new System.Drawing.Point(444, 32);
            this.cajaDireccion.Name = "cajaDireccion";
            this.cajaDireccion.Size = new System.Drawing.Size(121, 22);
            this.cajaDireccion.TabIndex = 11;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(321, 34);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 15);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Dirección";
            // 
            // checkBoxActivo
            // 
            this.checkBoxActivo.AutoSize = true;
            this.checkBoxActivo.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActivo.Location = new System.Drawing.Point(324, 183);
            this.checkBoxActivo.Name = "checkBoxActivo";
            this.checkBoxActivo.Size = new System.Drawing.Size(61, 19);
            this.checkBoxActivo.TabIndex = 18;
            this.checkBoxActivo.Text = "Activo";
            this.checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(24, 184);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(82, 15);
            this.lblDepartamento.TabIndex = 19;
            this.lblDepartamento.Text = "Departamento";
            // 
            // comboBoxDepartamento
            // 
            this.comboBoxDepartamento.FormattingEnabled = true;
            this.comboBoxDepartamento.Location = new System.Drawing.Point(148, 181);
            this.comboBoxDepartamento.Name = "comboBoxDepartamento";
            this.comboBoxDepartamento.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDepartamento.TabIndex = 20;
            this.comboBoxDepartamento.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartamento_SelectedIndexChanged);
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(598, 329);
            this.Controls.Add(this.comboBoxDepartamento);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.checkBoxActivo);
            this.Controls.Add(this.cajaTlfn);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.cajaCP);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.cajaLocalidad);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.cajaDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.cajaDNI);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.cajaApellido2);
            this.Controls.Add(this.lblApellido2);
            this.Controls.Add(this.cajaApellido1);
            this.Controls.Add(this.lblApellido1);
            this.Controls.Add(this.cajaNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnVolver);
            this.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearUsuario";
            this.Text = "CrearUsuario";
            this.Load += new System.EventHandler(this.CrearUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox cajaNombre;
        private System.Windows.Forms.TextBox cajaApellido1;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.TextBox cajaApellido2;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.TextBox cajaDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox cajaTlfn;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox cajaCP;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.TextBox cajaLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox cajaDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.CheckBox checkBoxActivo;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.ComboBox comboBoxDepartamento;
    }
}