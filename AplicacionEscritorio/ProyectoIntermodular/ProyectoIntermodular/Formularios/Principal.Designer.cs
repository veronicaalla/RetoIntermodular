namespace ProyectoIntermodular
{
    partial class Principal
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnEli = new System.Windows.Forms.Button();
            this.gbxCriterios = new System.Windows.Forms.GroupBox();
            this.cmxSub = new System.Windows.Forms.ComboBox();
            this.cbxSub = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbxFecha = new System.Windows.Forms.CheckBox();
            this.cmxTipo = new System.Windows.Forms.ComboBox();
            this.cbxTipo = new System.Windows.Forms.CheckBox();
            this.cmxEstado = new System.Windows.Forms.ComboBox();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.cmxAula = new System.Windows.Forms.ComboBox();
            this.cbxAula = new System.Windows.Forms.CheckBox();
            this.cmxProfesor = new System.Windows.Forms.ComboBox();
            this.cbxProfesor = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxCriterios.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(12, 512);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(93, 41);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(923, 512);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(93, 41);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnEli
            // 
            this.btnEli.Location = new System.Drawing.Point(814, 512);
            this.btnEli.Name = "btnEli";
            this.btnEli.Size = new System.Drawing.Size(93, 41);
            this.btnEli.TabIndex = 4;
            this.btnEli.Text = "Eliminar";
            this.btnEli.UseVisualStyleBackColor = true;
            // 
            // gbxCriterios
            // 
            this.gbxCriterios.Controls.Add(this.cmxSub);
            this.gbxCriterios.Controls.Add(this.cbxSub);
            this.gbxCriterios.Controls.Add(this.label1);
            this.gbxCriterios.Controls.Add(this.lblDesde);
            this.gbxCriterios.Controls.Add(this.dateTimePicker2);
            this.gbxCriterios.Controls.Add(this.dateTimePicker1);
            this.gbxCriterios.Controls.Add(this.cbxFecha);
            this.gbxCriterios.Controls.Add(this.cmxTipo);
            this.gbxCriterios.Controls.Add(this.cbxTipo);
            this.gbxCriterios.Controls.Add(this.cmxEstado);
            this.gbxCriterios.Controls.Add(this.cbxEstado);
            this.gbxCriterios.Controls.Add(this.cmxAula);
            this.gbxCriterios.Controls.Add(this.cbxAula);
            this.gbxCriterios.Controls.Add(this.cmxProfesor);
            this.gbxCriterios.Controls.Add(this.cbxProfesor);
            this.gbxCriterios.Controls.Add(this.button2);
            this.gbxCriterios.Controls.Add(this.button1);
            this.gbxCriterios.Location = new System.Drawing.Point(12, 23);
            this.gbxCriterios.Name = "gbxCriterios";
            this.gbxCriterios.Size = new System.Drawing.Size(1004, 167);
            this.gbxCriterios.TabIndex = 5;
            this.gbxCriterios.TabStop = false;
            this.gbxCriterios.Text = "Criterios";
            // 
            // cmxSub
            // 
            this.cmxSub.FormattingEnabled = true;
            this.cmxSub.Location = new System.Drawing.Point(271, 124);
            this.cmxSub.Name = "cmxSub";
            this.cmxSub.Size = new System.Drawing.Size(183, 24);
            this.cmxSub.TabIndex = 22;
            this.cmxSub.Text = "Subtipo";
            // 
            // cbxSub
            // 
            this.cbxSub.AutoSize = true;
            this.cbxSub.Location = new System.Drawing.Point(237, 128);
            this.cbxSub.Name = "cbxSub";
            this.cbxSub.Size = new System.Drawing.Size(18, 17);
            this.cbxSub.TabIndex = 21;
            this.cbxSub.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(670, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(670, 38);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(51, 16);
            this.lblDesde.TabIndex = 19;
            this.lblDesde.Text = "Desde:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(749, 34);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(749, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // cbxFecha
            // 
            this.cbxFecha.AutoSize = true;
            this.cbxFecha.Location = new System.Drawing.Point(567, 36);
            this.cbxFecha.Name = "cbxFecha";
            this.cbxFecha.Size = new System.Drawing.Size(74, 20);
            this.cbxFecha.TabIndex = 16;
            this.cbxFecha.Text = "Fechas";
            this.cbxFecha.UseVisualStyleBackColor = true;
            // 
            // cmxTipo
            // 
            this.cmxTipo.FormattingEnabled = true;
            this.cmxTipo.Location = new System.Drawing.Point(271, 74);
            this.cmxTipo.Name = "cmxTipo";
            this.cmxTipo.Size = new System.Drawing.Size(183, 24);
            this.cmxTipo.TabIndex = 15;
            this.cmxTipo.Text = "Tipo";
            // 
            // cbxTipo
            // 
            this.cbxTipo.AutoSize = true;
            this.cbxTipo.Location = new System.Drawing.Point(237, 78);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(18, 17);
            this.cbxTipo.TabIndex = 14;
            this.cbxTipo.UseVisualStyleBackColor = true;
            // 
            // cmxEstado
            // 
            this.cmxEstado.FormattingEnabled = true;
            this.cmxEstado.Location = new System.Drawing.Point(41, 124);
            this.cmxEstado.Name = "cmxEstado";
            this.cmxEstado.Size = new System.Drawing.Size(183, 24);
            this.cmxEstado.TabIndex = 13;
            this.cmxEstado.Text = "Estado";
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(7, 128);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(18, 17);
            this.cbxEstado.TabIndex = 12;
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // cmxAula
            // 
            this.cmxAula.FormattingEnabled = true;
            this.cmxAula.Location = new System.Drawing.Point(41, 74);
            this.cmxAula.Name = "cmxAula";
            this.cmxAula.Size = new System.Drawing.Size(183, 24);
            this.cmxAula.TabIndex = 11;
            this.cmxAula.Text = "Aula";
            // 
            // cbxAula
            // 
            this.cbxAula.AutoSize = true;
            this.cbxAula.Location = new System.Drawing.Point(7, 78);
            this.cbxAula.Name = "cbxAula";
            this.cbxAula.Size = new System.Drawing.Size(18, 17);
            this.cbxAula.TabIndex = 10;
            this.cbxAula.UseVisualStyleBackColor = true;
            // 
            // cmxProfesor
            // 
            this.cmxProfesor.FormattingEnabled = true;
            this.cmxProfesor.Location = new System.Drawing.Point(41, 29);
            this.cmxProfesor.Name = "cmxProfesor";
            this.cmxProfesor.Size = new System.Drawing.Size(413, 24);
            this.cmxProfesor.TabIndex = 9;
            this.cmxProfesor.Text = "Profesor";
            // 
            // cbxProfesor
            // 
            this.cbxProfesor.AutoSize = true;
            this.cbxProfesor.Location = new System.Drawing.Point(7, 33);
            this.cbxProfesor.Name = "cbxProfesor";
            this.cbxProfesor.Size = new System.Drawing.Size(18, 17);
            this.cbxProfesor.TabIndex = 8;
            this.cbxProfesor.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(828, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(911, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 565);
            this.Controls.Add(this.gbxCriterios);
            this.Controls.Add(this.btnEli);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Principal";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxCriterios.ResumeLayout(false);
            this.gbxCriterios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnEli;
        private System.Windows.Forms.GroupBox gbxCriterios;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmxProfesor;
        private System.Windows.Forms.CheckBox cbxProfesor;
        private System.Windows.Forms.ComboBox cmxTipo;
        private System.Windows.Forms.CheckBox cbxTipo;
        private System.Windows.Forms.ComboBox cmxEstado;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.ComboBox cmxAula;
        private System.Windows.Forms.CheckBox cbxAula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox cbxFecha;
        private System.Windows.Forms.ComboBox cmxSub;
        private System.Windows.Forms.CheckBox cbxSub;
    }
}