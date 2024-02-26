namespace ProyectoIntermodular.Formularios
{
    partial class CrearPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearPerfil));
            this.comboPerfil = new System.Windows.Forms.ComboBox();
            this.cajaContra = new System.Windows.Forms.TextBox();
            this.cajaEducantabria = new System.Windows.Forms.TextBox();
            this.cajaDominio = new System.Windows.Forms.TextBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblEducantabria = new System.Windows.Forms.Label();
            this.lblDominio = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboPerfil
            // 
            this.comboPerfil.FormattingEnabled = true;
            this.comboPerfil.Location = new System.Drawing.Point(119, 134);
            this.comboPerfil.Name = "comboPerfil";
            this.comboPerfil.Size = new System.Drawing.Size(121, 24);
            this.comboPerfil.TabIndex = 20;
            this.comboPerfil.SelectedIndexChanged += new System.EventHandler(this.comboPerfil_SelectedIndexChanged);
            // 
            // cajaContra
            // 
            this.cajaContra.Location = new System.Drawing.Point(119, 97);
            this.cajaContra.Name = "cajaContra";
            this.cajaContra.Size = new System.Drawing.Size(121, 22);
            this.cajaContra.TabIndex = 19;
            this.cajaContra.TextChanged += new System.EventHandler(this.cajaContra_TextChanged);
            // 
            // cajaEducantabria
            // 
            this.cajaEducantabria.Location = new System.Drawing.Point(119, 56);
            this.cajaEducantabria.Name = "cajaEducantabria";
            this.cajaEducantabria.Size = new System.Drawing.Size(121, 22);
            this.cajaEducantabria.TabIndex = 18;
            this.cajaEducantabria.TextChanged += new System.EventHandler(this.cajaEducantabria_TextChanged);
            // 
            // cajaDominio
            // 
            this.cajaDominio.Location = new System.Drawing.Point(119, 16);
            this.cajaDominio.Name = "cajaDominio";
            this.cajaDominio.Size = new System.Drawing.Size(121, 22);
            this.cajaDominio.TabIndex = 17;
            this.cajaDominio.TextChanged += new System.EventHandler(this.cajaDominio_TextChanged);
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblPerfil.Location = new System.Drawing.Point(12, 137);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(35, 15);
            this.lblPerfil.TabIndex = 16;
            this.lblPerfil.Text = "Perfil";
            this.lblPerfil.Click += new System.EventHandler(this.lblPerfil_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblContraseña.Location = new System.Drawing.Point(12, 99);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(66, 15);
            this.lblContraseña.TabIndex = 15;
            this.lblContraseña.Text = "Contraseña";
            this.lblContraseña.Click += new System.EventHandler(this.lblContraseña_Click);
            // 
            // lblEducantabria
            // 
            this.lblEducantabria.AutoSize = true;
            this.lblEducantabria.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEducantabria.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblEducantabria.Location = new System.Drawing.Point(12, 58);
            this.lblEducantabria.Name = "lblEducantabria";
            this.lblEducantabria.Size = new System.Drawing.Size(75, 15);
            this.lblEducantabria.TabIndex = 14;
            this.lblEducantabria.Text = "Educantabria";
            this.lblEducantabria.Click += new System.EventHandler(this.lblEducantabria_Click);
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDominio.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblDominio.Location = new System.Drawing.Point(12, 19);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(50, 15);
            this.lblDominio.TabIndex = 13;
            this.lblDominio.Text = "Dominio";
            this.lblDominio.Click += new System.EventHandler(this.lblDominio_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrear.Location = new System.Drawing.Point(156, 190);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 29);
            this.btnCrear.TabIndex = 12;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_ClickAsync);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolver.Location = new System.Drawing.Point(63, 190);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 29);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // CrearPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(315, 231);
            this.Controls.Add(this.comboPerfil);
            this.Controls.Add(this.cajaContra);
            this.Controls.Add(this.cajaEducantabria);
            this.Controls.Add(this.cajaDominio);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblEducantabria);
            this.Controls.Add(this.lblDominio);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearPerfil";
            this.Text = "CrearPerfil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboPerfil;
        private System.Windows.Forms.TextBox cajaContra;
        private System.Windows.Forms.TextBox cajaEducantabria;
        private System.Windows.Forms.TextBox cajaDominio;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblEducantabria;
        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnVolver;
    }
}