namespace ProyectoIntermodular.Formularios
{
    partial class AñadirComentario
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
            this.tbxComentario = new System.Windows.Forms.TextBox();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.btnAñadirArchivo = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxComentario
            // 
            this.tbxComentario.Location = new System.Drawing.Point(12, 22);
            this.tbxComentario.Multiline = true;
            this.tbxComentario.Name = "tbxComentario";
            this.tbxComentario.Size = new System.Drawing.Size(631, 132);
            this.tbxComentario.TabIndex = 0;
            this.tbxComentario.TextChanged += new System.EventHandler(this.tbxComentario_TextChanged);
            this.tbxComentario.Enter += new System.EventHandler(this.TextBox_Enter);
            this.tbxComentario.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(145, 175);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(177, 16);
            this.lblArchivo.TabIndex = 37;
            this.lblArchivo.Text = "No se añadió ningún archivo";
            // 
            // btnAñadirArchivo
            // 
            this.btnAñadirArchivo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAñadirArchivo.Location = new System.Drawing.Point(12, 172);
            this.btnAñadirArchivo.Name = "btnAñadirArchivo";
            this.btnAñadirArchivo.Size = new System.Drawing.Size(116, 23);
            this.btnAñadirArchivo.TabIndex = 36;
            this.btnAñadirArchivo.Text = "Añadir archivo";
            this.btnAñadirArchivo.UseVisualStyleBackColor = false;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(553, 246);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 38;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(448, 246);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 39;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // AñadirComentario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 293);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.btnAñadirArchivo);
            this.Controls.Add(this.tbxComentario);
            this.Name = "AñadirComentario";
            this.Text = "AñadirComentario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxComentario;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.Button btnAñadirArchivo;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnVolver;
    }
}