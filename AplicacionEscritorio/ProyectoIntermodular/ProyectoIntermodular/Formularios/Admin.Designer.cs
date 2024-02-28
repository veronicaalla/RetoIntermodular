namespace ProyectoIntermodular.Formularios
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnIncidencias = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.lblPrueba = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblBienvenido.Location = new System.Drawing.Point(12, 43);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(186, 48);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido";
            this.lblBienvenido.UseMnemonic = false;
            // 
            // btnIncidencias
            // 
            this.btnIncidencias.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnIncidencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncidencias.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncidencias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIncidencias.Location = new System.Drawing.Point(152, 156);
            this.btnIncidencias.Name = "btnIncidencias";
            this.btnIncidencias.Size = new System.Drawing.Size(95, 32);
            this.btnIncidencias.TabIndex = 1;
            this.btnIncidencias.Text = "Incidencias";
            this.btnIncidencias.UseVisualStyleBackColor = false;
            this.btnIncidencias.Click += new System.EventHandler(this.btnIncidencias_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUsuarios.Location = new System.Drawing.Point(311, 156);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(95, 32);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // lblPrueba
            // 
            this.lblPrueba.AutoSize = true;
            this.lblPrueba.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrueba.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblPrueba.Location = new System.Drawing.Point(194, 43);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(137, 48);
            this.lblPrueba.TabIndex = 3;
            this.lblPrueba.Text = "Usuario";
            this.lblPrueba.UseMnemonic = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(581, 234);
            this.Controls.Add(this.lblPrueba);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnIncidencias);
            this.Controls.Add(this.lblBienvenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnIncidencias;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Label lblPrueba;
    }
}