﻿namespace ProyectoIntermodular.Formularios
{
    partial class Incidencia
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
            this.cbxEditar = new System.Windows.Forms.CheckBox();
            this.gbxEdit = new System.Windows.Forms.GroupBox();
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnComentar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1075, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbxEditar
            // 
            this.cbxEditar.AutoSize = true;
            this.cbxEditar.Location = new System.Drawing.Point(12, 29);
            this.cbxEditar.Name = "cbxEditar";
            this.cbxEditar.Size = new System.Drawing.Size(64, 20);
            this.cbxEditar.TabIndex = 1;
            this.cbxEditar.Text = "Editar";
            this.cbxEditar.UseVisualStyleBackColor = true;
            // 
            // gbxEdit
            // 
            this.gbxEdit.Controls.Add(this.button1);
            this.gbxEdit.Controls.Add(this.btnConfirm);
            this.gbxEdit.Controls.Add(this.cmxSub);
            this.gbxEdit.Controls.Add(this.cmxProfesor);
            this.gbxEdit.Controls.Add(this.cbxSub);
            this.gbxEdit.Controls.Add(this.cbxProfesor);
            this.gbxEdit.Controls.Add(this.label1);
            this.gbxEdit.Controls.Add(this.cbxAula);
            this.gbxEdit.Controls.Add(this.lblDesde);
            this.gbxEdit.Controls.Add(this.cmxAula);
            this.gbxEdit.Controls.Add(this.dateTimePicker2);
            this.gbxEdit.Controls.Add(this.cbxEstado);
            this.gbxEdit.Controls.Add(this.dateTimePicker1);
            this.gbxEdit.Controls.Add(this.cmxEstado);
            this.gbxEdit.Controls.Add(this.cbxFecha);
            this.gbxEdit.Controls.Add(this.cbxTipo);
            this.gbxEdit.Controls.Add(this.cmxTipo);
            this.gbxEdit.Location = new System.Drawing.Point(82, 29);
            this.gbxEdit.Name = "gbxEdit";
            this.gbxEdit.Size = new System.Drawing.Size(1005, 162);
            this.gbxEdit.TabIndex = 2;
            this.gbxEdit.TabStop = false;
            this.gbxEdit.Text = "Grupo de edición";
            this.gbxEdit.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmxSub
            // 
            this.cmxSub.FormattingEnabled = true;
            this.cmxSub.Location = new System.Drawing.Point(275, 125);
            this.cmxSub.Name = "cmxSub";
            this.cmxSub.Size = new System.Drawing.Size(183, 24);
            this.cmxSub.TabIndex = 37;
            this.cmxSub.Text = "Subtipo";
            // 
            // cbxSub
            // 
            this.cbxSub.AutoSize = true;
            this.cbxSub.Location = new System.Drawing.Point(241, 129);
            this.cbxSub.Name = "cbxSub";
            this.cbxSub.Size = new System.Drawing.Size(18, 17);
            this.cbxSub.TabIndex = 36;
            this.cbxSub.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(674, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(674, 39);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(51, 16);
            this.lblDesde.TabIndex = 34;
            this.lblDesde.Text = "Desde:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(753, 35);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(753, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // cbxFecha
            // 
            this.cbxFecha.AutoSize = true;
            this.cbxFecha.Location = new System.Drawing.Point(571, 37);
            this.cbxFecha.Name = "cbxFecha";
            this.cbxFecha.Size = new System.Drawing.Size(74, 20);
            this.cbxFecha.TabIndex = 31;
            this.cbxFecha.Text = "Fechas";
            this.cbxFecha.UseVisualStyleBackColor = true;
            // 
            // cmxTipo
            // 
            this.cmxTipo.FormattingEnabled = true;
            this.cmxTipo.Location = new System.Drawing.Point(275, 75);
            this.cmxTipo.Name = "cmxTipo";
            this.cmxTipo.Size = new System.Drawing.Size(183, 24);
            this.cmxTipo.TabIndex = 30;
            this.cmxTipo.Text = "Tipo";
            // 
            // cbxTipo
            // 
            this.cbxTipo.AutoSize = true;
            this.cbxTipo.Location = new System.Drawing.Point(241, 79);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(18, 17);
            this.cbxTipo.TabIndex = 29;
            this.cbxTipo.UseVisualStyleBackColor = true;
            // 
            // cmxEstado
            // 
            this.cmxEstado.FormattingEnabled = true;
            this.cmxEstado.Location = new System.Drawing.Point(45, 125);
            this.cmxEstado.Name = "cmxEstado";
            this.cmxEstado.Size = new System.Drawing.Size(183, 24);
            this.cmxEstado.TabIndex = 28;
            this.cmxEstado.Text = "Estado";
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(11, 129);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(18, 17);
            this.cbxEstado.TabIndex = 27;
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // cmxAula
            // 
            this.cmxAula.FormattingEnabled = true;
            this.cmxAula.Location = new System.Drawing.Point(45, 75);
            this.cmxAula.Name = "cmxAula";
            this.cmxAula.Size = new System.Drawing.Size(183, 24);
            this.cmxAula.TabIndex = 26;
            this.cmxAula.Text = "Aula";
            // 
            // cbxAula
            // 
            this.cbxAula.AutoSize = true;
            this.cbxAula.Location = new System.Drawing.Point(11, 79);
            this.cbxAula.Name = "cbxAula";
            this.cbxAula.Size = new System.Drawing.Size(18, 17);
            this.cbxAula.TabIndex = 25;
            this.cbxAula.UseVisualStyleBackColor = true;
            // 
            // cmxProfesor
            // 
            this.cmxProfesor.FormattingEnabled = true;
            this.cmxProfesor.Location = new System.Drawing.Point(45, 30);
            this.cmxProfesor.Name = "cmxProfesor";
            this.cmxProfesor.Size = new System.Drawing.Size(413, 24);
            this.cmxProfesor.TabIndex = 24;
            this.cmxProfesor.Text = "Profesor";
            // 
            // cbxProfesor
            // 
            this.cbxProfesor.AutoSize = true;
            this.cbxProfesor.Location = new System.Drawing.Point(11, 34);
            this.cbxProfesor.Name = "cbxProfesor";
            this.cbxProfesor.Size = new System.Drawing.Size(18, 17);
            this.cbxProfesor.TabIndex = 23;
            this.cbxProfesor.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(870, 125);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(83, 27);
            this.btnConfirm.TabIndex = 38;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnComentar
            // 
            this.btnComentar.Location = new System.Drawing.Point(976, 505);
            this.btnComentar.Name = "btnComentar";
            this.btnComentar.Size = new System.Drawing.Size(111, 50);
            this.btnComentar.TabIndex = 39;
            this.btnComentar.Text = "Añadir comentario";
            this.btnComentar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(835, 505);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 50);
            this.btnSalir.TabIndex = 40;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(768, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 27);
            this.button1.TabIndex = 39;
            this.button1.Text = "Asignar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Incidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 567);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnComentar);
            this.Controls.Add(this.gbxEdit);
            this.Controls.Add(this.cbxEditar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Incidencia";
            this.Text = "Incidencia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxEdit.ResumeLayout(false);
            this.gbxEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox cbxEditar;
        private System.Windows.Forms.GroupBox gbxEdit;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox cmxSub;
        private System.Windows.Forms.ComboBox cmxProfesor;
        private System.Windows.Forms.CheckBox cbxSub;
        private System.Windows.Forms.CheckBox cbxProfesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxAula;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.ComboBox cmxAula;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmxEstado;
        private System.Windows.Forms.CheckBox cbxFecha;
        private System.Windows.Forms.CheckBox cbxTipo;
        private System.Windows.Forms.ComboBox cmxTipo;
        private System.Windows.Forms.Button btnComentar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button button1;
    }
}