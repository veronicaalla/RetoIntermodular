namespace ProyectoIntermodular.Formularios
{
    partial class CrearDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearDepartamento));
            this.comboJefe = new System.Windows.Forms.ComboBox();
            this.cajaEducantabria = new System.Windows.Forms.TextBox();
            this.cajaDominio = new System.Windows.Forms.TextBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.checkBoxActivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboJefe
            // 
            this.comboJefe.FormattingEnabled = true;
            this.comboJefe.Location = new System.Drawing.Point(177, 107);
            this.comboJefe.Name = "comboJefe";
            this.comboJefe.Size = new System.Drawing.Size(121, 24);
            this.comboJefe.TabIndex = 30;
            this.comboJefe.SelectedIndexChanged += new System.EventHandler(this.comboPerfil_SelectedIndexChanged);
            // 
            // cajaEducantabria
            // 
            this.cajaEducantabria.Location = new System.Drawing.Point(177, 66);
            this.cajaEducantabria.Name = "cajaEducantabria";
            this.cajaEducantabria.Size = new System.Drawing.Size(121, 22);
            this.cajaEducantabria.TabIndex = 28;
            this.cajaEducantabria.TextChanged += new System.EventHandler(this.cajaEducantabria_TextChanged);
            // 
            // cajaDominio
            // 
            this.cajaDominio.Location = new System.Drawing.Point(177, 26);
            this.cajaDominio.Name = "cajaDominio";
            this.cajaDominio.Size = new System.Drawing.Size(121, 22);
            this.cajaDominio.TabIndex = 27;
            this.cajaDominio.TextChanged += new System.EventHandler(this.cajaDominio_TextChanged);
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(32, 110);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(139, 16);
            this.lblPerfil.TabIndex = 26;
            this.lblPerfil.Text = "Jefe de departamento";
            this.lblPerfil.Click += new System.EventHandler(this.lblPerfil_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblEducantabria_Click);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(32, 29);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(51, 16);
            this.lblCod.TabIndex = 23;
            this.lblCod.Text = "Código";
            this.lblCod.Click += new System.EventHandler(this.lblCod_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCrear.Location = new System.Drawing.Point(176, 200);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 29);
            this.btnCrear.TabIndex = 22;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnVolver.Location = new System.Drawing.Point(83, 200);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 29);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // checkBoxActivo
            // 
            this.checkBoxActivo.AutoSize = true;
            this.checkBoxActivo.Location = new System.Drawing.Point(35, 148);
            this.checkBoxActivo.Name = "checkBoxActivo";
            this.checkBoxActivo.Size = new System.Drawing.Size(66, 20);
            this.checkBoxActivo.TabIndex = 31;
            this.checkBoxActivo.Text = "Activo";
            this.checkBoxActivo.UseVisualStyleBackColor = true;
            this.checkBoxActivo.CheckedChanged += new System.EventHandler(this.checkBoxActivo_CheckedChanged);
            // 
            // CrearDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(333, 257);
            this.Controls.Add(this.checkBoxActivo);
            this.Controls.Add(this.comboJefe);
            this.Controls.Add(this.cajaEducantabria);
            this.Controls.Add(this.cajaDominio);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearDepartamento";
            this.Text = "CrearDepartamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboJefe;
        private System.Windows.Forms.TextBox cajaEducantabria;
        private System.Windows.Forms.TextBox cajaDominio;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.CheckBox checkBoxActivo;
    }
}