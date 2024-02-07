namespace ProyectoIntermodular.Formularios
{
    partial class EliminarUsuario
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
            this.cajaUsuario = new System.Windows.Forms.TextBox();
            this.cajaContraseña = new System.Windows.Forms.TextBox();
            this.cajaAdmin = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cajaUsuario
            // 
            this.cajaUsuario.Enabled = false;
            this.cajaUsuario.Location = new System.Drawing.Point(172, 42);
            this.cajaUsuario.Name = "cajaUsuario";
            this.cajaUsuario.Size = new System.Drawing.Size(100, 22);
            this.cajaUsuario.TabIndex = 0;
            this.cajaUsuario.Text = "Usuario";
            // 
            // cajaContraseña
            // 
            this.cajaContraseña.Location = new System.Drawing.Point(172, 98);
            this.cajaContraseña.Name = "cajaContraseña";
            this.cajaContraseña.Size = new System.Drawing.Size(100, 22);
            this.cajaContraseña.TabIndex = 1;
            // 
            // cajaAdmin
            // 
            this.cajaAdmin.Enabled = false;
            this.cajaAdmin.Location = new System.Drawing.Point(172, 70);
            this.cajaAdmin.Name = "cajaAdmin";
            this.cajaAdmin.Size = new System.Drawing.Size(100, 22);
            this.cajaAdmin.TabIndex = 2;
            this.cajaAdmin.Text = "Nombre";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(65, 44);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(65, 72);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(45, 16);
            this.lblAdmin.TabIndex = 4;
            this.lblAdmin.Text = "Admin";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(65, 100);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(76, 16);
            this.lblContraseña.TabIndex = 5;
            this.lblContraseña.Text = "Contraseña";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnVolver.Location = new System.Drawing.Point(85, 156);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 28);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnEliminar.Location = new System.Drawing.Point(177, 156);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 28);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // EliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(345, 218);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.cajaAdmin);
            this.Controls.Add(this.cajaContraseña);
            this.Controls.Add(this.cajaUsuario);
            this.Name = "EliminarUsuario";
            this.Text = "EliminarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cajaUsuario;
        private System.Windows.Forms.TextBox cajaContraseña;
        private System.Windows.Forms.TextBox cajaAdmin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEliminar;
    }
}