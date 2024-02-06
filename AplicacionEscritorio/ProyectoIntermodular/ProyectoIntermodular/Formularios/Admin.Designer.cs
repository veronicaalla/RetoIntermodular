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
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnIncidencias = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(38, 37);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(134, 29);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // btnIncidencias
            // 
            this.btnIncidencias.Location = new System.Drawing.Point(111, 146);
            this.btnIncidencias.Name = "btnIncidencias";
            this.btnIncidencias.Size = new System.Drawing.Size(106, 23);
            this.btnIncidencias.TabIndex = 1;
            this.btnIncidencias.Text = "Incidencias";
            this.btnIncidencias.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(235, 146);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(106, 23);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(432, 224);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnIncidencias);
            this.Controls.Add(this.lblBienvenido);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnIncidencias;
        private System.Windows.Forms.Button btnUsuarios;
    }
}