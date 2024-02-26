namespace ProyectoIntermodular
{
    partial class Inicial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicial));
            this.btnIniciar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.tbxContra = new System.Windows.Forms.TextBox();
            this.btnContraVisible = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIniciar.Location = new System.Drawing.Point(215, 316);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(162, 42);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar sesión";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(242, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblNombre.Location = new System.Drawing.Point(116, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(325, 71);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "INCIDENCIAS";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(199, 218);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(189, 22);
            this.txbUsuario.TabIndex = 3;
            this.txbUsuario.TextChanged += new System.EventHandler(this.txbUsuario_TextChanged);
            // 
            // tbxContra
            // 
            this.tbxContra.Location = new System.Drawing.Point(199, 261);
            this.tbxContra.Name = "tbxContra";
            this.tbxContra.Size = new System.Drawing.Size(189, 22);
            this.tbxContra.TabIndex = 4;
            // 
            // btnContraVisible
            // 
            this.btnContraVisible.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnContraVisible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContraVisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContraVisible.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnContraVisible.Image = ((System.Drawing.Image)(resources.GetObject("btnContraVisible.Image")));
            this.btnContraVisible.Location = new System.Drawing.Point(394, 261);
            this.btnContraVisible.Name = "btnContraVisible";
            this.btnContraVisible.Size = new System.Drawing.Size(64, 22);
            this.btnContraVisible.TabIndex = 5;
            this.btnContraVisible.UseVisualStyleBackColor = false;
            this.btnContraVisible.Click += new System.EventHandler(this.btnContraVisible_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(458, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(597, 372);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnContraVisible);
            this.Controls.Add(this.tbxContra);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnIniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicial";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox tbxContra;
        private System.Windows.Forms.Button btnContraVisible;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

