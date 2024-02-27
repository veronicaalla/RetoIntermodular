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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adjunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnEli = new System.Windows.Forms.Button();
            this.gbxCriterios = new System.Windows.Forms.GroupBox();
            this.cmxTipo = new System.Windows.Forms.ComboBox();
            this.cbxTipo = new System.Windows.Forms.CheckBox();
            this.cmxEstado = new System.Windows.Forms.ComboBox();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.cmxResponsable = new System.Windows.Forms.ComboBox();
            this.cbxResponsable = new System.Windows.Forms.CheckBox();
            this.cmxProfesor = new System.Windows.Forms.ComboBox();
            this.cbxProfesor = new System.Windows.Forms.CheckBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInci = new System.Windows.Forms.Button();
            this.btnTiempoAdmin = new System.Windows.Forms.Button();
            this.btnTiempoInci = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnTiempoTipo = new System.Windows.Forms.Button();
            this.btnCreador = new System.Windows.Forms.Button();
            this.comboAdmin = new System.Windows.Forms.ComboBox();
            this.ç = new System.Windows.Forms.CheckBox();
            this.comboCreaInforme = new System.Windows.Forms.ComboBox();
            this.checkCreador = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxCriterios.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Tipo,
            this.Subtipo,
            this.FechaCreacion,
            this.FechaCierre,
            this.Descripcion,
            this.Estado,
            this.Adjunto,
            this.Creador,
            this.Responsable,
            this.Equipo});
            this.dataGridView1.Location = new System.Drawing.Point(12, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(922, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // Num
            // 
            this.Num.HeaderText = "Numero";
            this.Num.MinimumWidth = 6;
            this.Num.Name = "Num";
            this.Num.Width = 125;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 125;
            // 
            // Subtipo
            // 
            this.Subtipo.HeaderText = "Subtipo";
            this.Subtipo.MinimumWidth = 6;
            this.Subtipo.Name = "Subtipo";
            this.Subtipo.Width = 125;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.HeaderText = "Fecha de creación";
            this.FechaCreacion.MinimumWidth = 6;
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.Width = 125;
            // 
            // FechaCierre
            // 
            this.FechaCierre.HeaderText = "Fecha de cierre";
            this.FechaCierre.MinimumWidth = 6;
            this.FechaCierre.Name = "FechaCierre";
            this.FechaCierre.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // Adjunto
            // 
            this.Adjunto.HeaderText = "Adjunto";
            this.Adjunto.MinimumWidth = 6;
            this.Adjunto.Name = "Adjunto";
            this.Adjunto.Width = 125;
            // 
            // Creador
            // 
            this.Creador.HeaderText = "Creador";
            this.Creador.MinimumWidth = 6;
            this.Creador.Name = "Creador";
            this.Creador.Width = 125;
            // 
            // Responsable
            // 
            this.Responsable.HeaderText = "Responsable";
            this.Responsable.MinimumWidth = 6;
            this.Responsable.Name = "Responsable";
            this.Responsable.Width = 125;
            // 
            // Equipo
            // 
            this.Equipo.HeaderText = "Equipo";
            this.Equipo.MinimumWidth = 6;
            this.Equipo.Name = "Equipo";
            this.Equipo.Width = 125;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeleccionar.Location = new System.Drawing.Point(12, 502);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(116, 41);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrear.Location = new System.Drawing.Point(841, 502);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(93, 41);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnEli
            // 
            this.btnEli.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEli.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEli.Location = new System.Drawing.Point(732, 502);
            this.btnEli.Name = "btnEli";
            this.btnEli.Size = new System.Drawing.Size(93, 41);
            this.btnEli.TabIndex = 4;
            this.btnEli.Text = "Eliminar";
            this.btnEli.UseVisualStyleBackColor = false;
            this.btnEli.Click += new System.EventHandler(this.btnEli_Click);
            // 
            // gbxCriterios
            // 
            this.gbxCriterios.Controls.Add(this.cmxTipo);
            this.gbxCriterios.Controls.Add(this.cbxTipo);
            this.gbxCriterios.Controls.Add(this.cmxEstado);
            this.gbxCriterios.Controls.Add(this.cbxEstado);
            this.gbxCriterios.Controls.Add(this.cmxResponsable);
            this.gbxCriterios.Controls.Add(this.cbxResponsable);
            this.gbxCriterios.Controls.Add(this.cmxProfesor);
            this.gbxCriterios.Controls.Add(this.cbxProfesor);
            this.gbxCriterios.Controls.Add(this.btnLimpiar);
            this.gbxCriterios.Controls.Add(this.btnBuscar);
            this.gbxCriterios.Location = new System.Drawing.Point(12, 13);
            this.gbxCriterios.Name = "gbxCriterios";
            this.gbxCriterios.Size = new System.Drawing.Size(922, 167);
            this.gbxCriterios.TabIndex = 5;
            this.gbxCriterios.TabStop = false;
            // 
            // cmxTipo
            // 
            this.cmxTipo.Enabled = false;
            this.cmxTipo.FormattingEnabled = true;
            this.cmxTipo.Location = new System.Drawing.Point(284, 71);
            this.cmxTipo.Name = "cmxTipo";
            this.cmxTipo.Size = new System.Drawing.Size(183, 24);
            this.cmxTipo.TabIndex = 15;
            this.cmxTipo.Text = "Tipo";
            // 
            // cbxTipo
            // 
            this.cbxTipo.AutoSize = true;
            this.cbxTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxTipo.Location = new System.Drawing.Point(250, 75);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(18, 17);
            this.cbxTipo.TabIndex = 14;
            this.cbxTipo.UseVisualStyleBackColor = true;
            this.cbxTipo.CheckedChanged += new System.EventHandler(this.cbxTipo_CheckedChanged);
            // 
            // cmxEstado
            // 
            this.cmxEstado.Enabled = false;
            this.cmxEstado.FormattingEnabled = true;
            this.cmxEstado.Location = new System.Drawing.Point(54, 124);
            this.cmxEstado.Name = "cmxEstado";
            this.cmxEstado.Size = new System.Drawing.Size(183, 24);
            this.cmxEstado.TabIndex = 13;
            this.cmxEstado.Text = "Estado";
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxEstado.Location = new System.Drawing.Point(20, 128);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(18, 17);
            this.cbxEstado.TabIndex = 12;
            this.cbxEstado.UseVisualStyleBackColor = true;
            this.cbxEstado.CheckedChanged += new System.EventHandler(this.cbxEstado_CheckedChanged);
            // 
            // cmxResponsable
            // 
            this.cmxResponsable.Enabled = false;
            this.cmxResponsable.FormattingEnabled = true;
            this.cmxResponsable.Location = new System.Drawing.Point(54, 74);
            this.cmxResponsable.Name = "cmxResponsable";
            this.cmxResponsable.Size = new System.Drawing.Size(183, 24);
            this.cmxResponsable.TabIndex = 11;
            this.cmxResponsable.Text = "Responsable";
            // 
            // cbxResponsable
            // 
            this.cbxResponsable.AutoSize = true;
            this.cbxResponsable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxResponsable.Location = new System.Drawing.Point(20, 78);
            this.cbxResponsable.Name = "cbxResponsable";
            this.cbxResponsable.Size = new System.Drawing.Size(18, 17);
            this.cbxResponsable.TabIndex = 10;
            this.cbxResponsable.UseVisualStyleBackColor = true;
            this.cbxResponsable.CheckedChanged += new System.EventHandler(this.cbxAula_CheckedChanged);
            // 
            // cmxProfesor
            // 
            this.cmxProfesor.Enabled = false;
            this.cmxProfesor.FormattingEnabled = true;
            this.cmxProfesor.Location = new System.Drawing.Point(54, 29);
            this.cmxProfesor.Name = "cmxProfesor";
            this.cmxProfesor.Size = new System.Drawing.Size(413, 24);
            this.cmxProfesor.TabIndex = 9;
            this.cmxProfesor.Text = "Creador";
            // 
            // cbxProfesor
            // 
            this.cbxProfesor.AutoSize = true;
            this.cbxProfesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxProfesor.Location = new System.Drawing.Point(20, 33);
            this.cbxProfesor.Name = "cbxProfesor";
            this.cbxProfesor.Size = new System.Drawing.Size(18, 17);
            this.cbxProfesor.TabIndex = 8;
            this.cbxProfesor.UseVisualStyleBackColor = true;
            this.cbxProfesor.CheckedChanged += new System.EventHandler(this.cbxProfesor_CheckedChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Location = new System.Drawing.Point(746, 124);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(67, 27);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(829, 124);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 27);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolver.Location = new System.Drawing.Point(148, 502);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(116, 41);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_2);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboCreaInforme);
            this.groupBox1.Controls.Add(this.checkCreador);
            this.groupBox1.Controls.Add(this.comboAdmin);
            this.groupBox1.Controls.Add(this.ç);
            this.groupBox1.Controls.Add(this.btnCreador);
            this.groupBox1.Controls.Add(this.btnTiempoTipo);
            this.groupBox1.Controls.Add(this.btnAdmin);
            this.groupBox1.Controls.Add(this.btnStats);
            this.groupBox1.Controls.Add(this.btnTiempoInci);
            this.groupBox1.Controls.Add(this.btnTiempoAdmin);
            this.groupBox1.Controls.Add(this.btnInci);
            this.groupBox1.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox1.Location = new System.Drawing.Point(952, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 453);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informes";
            // 
            // btnInci
            // 
            this.btnInci.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnInci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInci.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInci.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInci.Location = new System.Drawing.Point(6, 29);
            this.btnInci.Name = "btnInci";
            this.btnInci.Size = new System.Drawing.Size(188, 41);
            this.btnInci.TabIndex = 8;
            this.btnInci.Text = "Incidencias";
            this.btnInci.UseVisualStyleBackColor = false;
            this.btnInci.Click += new System.EventHandler(this.btnInci_Click);
            // 
            // btnTiempoAdmin
            // 
            this.btnTiempoAdmin.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnTiempoAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTiempoAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiempoAdmin.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiempoAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTiempoAdmin.Location = new System.Drawing.Point(6, 79);
            this.btnTiempoAdmin.Name = "btnTiempoAdmin";
            this.btnTiempoAdmin.Size = new System.Drawing.Size(188, 41);
            this.btnTiempoAdmin.TabIndex = 9;
            this.btnTiempoAdmin.Text = "Tiempo por Admin";
            this.btnTiempoAdmin.UseVisualStyleBackColor = false;
            this.btnTiempoAdmin.Click += new System.EventHandler(this.btnTiempoAdmin_Click);
            // 
            // btnTiempoInci
            // 
            this.btnTiempoInci.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnTiempoInci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTiempoInci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiempoInci.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiempoInci.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTiempoInci.Location = new System.Drawing.Point(6, 176);
            this.btnTiempoInci.Name = "btnTiempoInci";
            this.btnTiempoInci.Size = new System.Drawing.Size(188, 41);
            this.btnTiempoInci.TabIndex = 10;
            this.btnTiempoInci.Text = "Tiempo Incidencia";
            this.btnTiempoInci.UseVisualStyleBackColor = false;
            this.btnTiempoInci.Click += new System.EventHandler(this.btnTiempoInci_Click);
            // 
            // btnStats
            // 
            this.btnStats.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStats.Location = new System.Drawing.Point(6, 225);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(188, 41);
            this.btnStats.TabIndex = 11;
            this.btnStats.Text = "Estadísticas";
            this.btnStats.UseVisualStyleBackColor = false;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdmin.Location = new System.Drawing.Point(8, 309);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(186, 41);
            this.btnAdmin.TabIndex = 13;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnTiempoTipo
            // 
            this.btnTiempoTipo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnTiempoTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTiempoTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiempoTipo.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiempoTipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTiempoTipo.Location = new System.Drawing.Point(6, 127);
            this.btnTiempoTipo.Name = "btnTiempoTipo";
            this.btnTiempoTipo.Size = new System.Drawing.Size(188, 41);
            this.btnTiempoTipo.TabIndex = 14;
            this.btnTiempoTipo.Text = "Tiempo por Tipo";
            this.btnTiempoTipo.UseVisualStyleBackColor = false;
            this.btnTiempoTipo.Click += new System.EventHandler(this.btnTiempoTipo_Click);
            // 
            // btnCreador
            // 
            this.btnCreador.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCreador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreador.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreador.Location = new System.Drawing.Point(8, 399);
            this.btnCreador.Name = "btnCreador";
            this.btnCreador.Size = new System.Drawing.Size(186, 41);
            this.btnCreador.TabIndex = 15;
            this.btnCreador.Text = "Creador";
            this.btnCreador.UseVisualStyleBackColor = false;
            this.btnCreador.Click += new System.EventHandler(this.btnCreador_Click);
            // 
            // comboAdmin
            // 
            this.comboAdmin.Enabled = false;
            this.comboAdmin.FormattingEnabled = true;
            this.comboAdmin.Location = new System.Drawing.Point(42, 277);
            this.comboAdmin.Name = "comboAdmin";
            this.comboAdmin.Size = new System.Drawing.Size(140, 23);
            this.comboAdmin.TabIndex = 17;
            this.comboAdmin.Text = "Creador";
            // 
            // ç
            // 
            this.ç.AutoSize = true;
            this.ç.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ç.Location = new System.Drawing.Point(8, 278);
            this.ç.Name = "ç";
            this.ç.Size = new System.Drawing.Size(18, 17);
            this.ç.TabIndex = 16;
            this.ç.UseVisualStyleBackColor = true;
            this.ç.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboCreaInforme
            // 
            this.comboCreaInforme.Enabled = false;
            this.comboCreaInforme.FormattingEnabled = true;
            this.comboCreaInforme.Location = new System.Drawing.Point(42, 365);
            this.comboCreaInforme.Name = "comboCreaInforme";
            this.comboCreaInforme.Size = new System.Drawing.Size(140, 23);
            this.comboCreaInforme.TabIndex = 19;
            this.comboCreaInforme.Text = "Creador";
            // 
            // checkCreador
            // 
            this.checkCreador.AutoSize = true;
            this.checkCreador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkCreador.Location = new System.Drawing.Point(8, 366);
            this.checkCreador.Name = "checkCreador";
            this.checkCreador.Size = new System.Drawing.Size(18, 17);
            this.checkCreador.TabIndex = 18;
            this.checkCreador.UseVisualStyleBackColor = true;
            this.checkCreador.CheckedChanged += new System.EventHandler(this.checkCreador_CheckedChanged);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1164, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbxCriterios);
            this.Controls.Add(this.btnEli);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxCriterios.ResumeLayout(false);
            this.gbxCriterios.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        private void InitializeComponentProfesor()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnEli = new System.Windows.Forms.Button();
            this.gbxCriterios = new System.Windows.Forms.GroupBox();
            this.cmxTipo = new System.Windows.Forms.ComboBox();
            this.cbxTipo = new System.Windows.Forms.CheckBox();
            this.cmxEstado = new System.Windows.Forms.ComboBox();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.cmxResponsable = new System.Windows.Forms.ComboBox();
            this.cbxResponsable = new System.Windows.Forms.CheckBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
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
            this.btnSeleccionar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSeleccionar.Location = new System.Drawing.Point(12, 512);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(116, 41);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCrear.Location = new System.Drawing.Point(923, 512);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(93, 41);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnEli
            // 
            this.btnEli.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnEli.Location = new System.Drawing.Point(814, 512);
            this.btnEli.Name = "btnEli";
            this.btnEli.Size = new System.Drawing.Size(93, 41);
            this.btnEli.TabIndex = 4;
            this.btnEli.Text = "Eliminar";
            this.btnEli.UseVisualStyleBackColor = false;
            this.btnEli.Click += new System.EventHandler(this.btnEli_Click);
            // 
            // gbxCriterios
            // 
            
            
            this.gbxCriterios.Controls.Add(this.cmxTipo);
            this.gbxCriterios.Controls.Add(this.cbxTipo);
            this.gbxCriterios.Controls.Add(this.cmxEstado);
            this.gbxCriterios.Controls.Add(this.cbxEstado);
            this.gbxCriterios.Controls.Add(this.cmxResponsable);
            this.gbxCriterios.Controls.Add(this.cbxResponsable);
            this.gbxCriterios.Controls.Add(this.btnLimpiar);
            this.gbxCriterios.Controls.Add(this.btnBuscar);
            this.gbxCriterios.Location = new System.Drawing.Point(12, 23);
            this.gbxCriterios.Name = "gbxCriterios";
            this.gbxCriterios.Size = new System.Drawing.Size(1004, 167);
            this.gbxCriterios.TabIndex = 5;
            this.gbxCriterios.TabStop = false;
            this.gbxCriterios.Text = "Criterios";
            // 
            
            // 
            
            // 
            // cmxTipo
            // 
            this.cmxTipo.Enabled = false;
            this.cmxTipo.FormattingEnabled = true;
            this.cmxTipo.Location = new System.Drawing.Point(271, 38);
            this.cmxTipo.Name = "cmxTipo";
            this.cmxTipo.Size = new System.Drawing.Size(183, 24);
            this.cmxTipo.TabIndex = 15;
            this.cmxTipo.Text = "Tipo";
            // 
            // cbxTipo
            // 
            this.cbxTipo.AutoSize = true;
            this.cbxTipo.Location = new System.Drawing.Point(237, 42);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(18, 17);
            this.cbxTipo.TabIndex = 14;
            this.cbxTipo.UseVisualStyleBackColor = true;
            this.cbxTipo.CheckedChanged += new System.EventHandler(this.cbxTipo_CheckedChanged);
            // 
            // cmxEstado
            // 
            this.cmxEstado.Enabled = false;
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
            this.cbxEstado.CheckedChanged += new System.EventHandler(this.cbxEstado_CheckedChanged);
            // 
            // cmxAula
            // 
            this.cmxResponsable.Enabled = false;
            this.cmxResponsable.FormattingEnabled = true;
            this.cmxResponsable.Location = new System.Drawing.Point(41, 38);
            this.cmxResponsable.Name = "cmxAula";
            this.cmxResponsable.Size = new System.Drawing.Size(183, 24);
            this.cmxResponsable.TabIndex = 11;
            this.cmxResponsable.Text = "Aula";
            // 
            // cbxAula
            // 
            this.cbxResponsable.AutoSize = true;
            this.cbxResponsable.Location = new System.Drawing.Point(7, 42);
            this.cbxResponsable.Name = "cbxAula";
            this.cbxResponsable.Size = new System.Drawing.Size(18, 17);
            this.cbxResponsable.TabIndex = 10;
            this.cbxResponsable.UseVisualStyleBackColor = true;
            this.cbxResponsable.CheckedChanged += new System.EventHandler(this.cbxAula_CheckedChanged);
            // 
            // button2
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnLimpiar.Location = new System.Drawing.Point(828, 124);
            this.btnLimpiar.Name = "button2";
            this.btnLimpiar.Size = new System.Drawing.Size(67, 27);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscar.Location = new System.Drawing.Point(911, 124);
            this.btnBuscar.Name = "button1";
            this.btnBuscar.Size = new System.Drawing.Size(67, 27);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnVolver.Location = new System.Drawing.Point(134, 512);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(93, 41);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
           
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1028, 565);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbxCriterios);
            this.Controls.Add(this.btnEli);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmxProfesor;
        private System.Windows.Forms.CheckBox cbxProfesor;
        private System.Windows.Forms.ComboBox cmxTipo;
        private System.Windows.Forms.CheckBox cbxTipo;
        private System.Windows.Forms.ComboBox cmxEstado;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.ComboBox cmxResponsable;
        private System.Windows.Forms.CheckBox cbxResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adjunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboCreaInforme;
        private System.Windows.Forms.CheckBox checkCreador;
        private System.Windows.Forms.ComboBox comboAdmin;
        private System.Windows.Forms.CheckBox ç;
        private System.Windows.Forms.Button btnCreador;
        private System.Windows.Forms.Button btnTiempoTipo;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnTiempoInci;
        private System.Windows.Forms.Button btnTiempoAdmin;
        private System.Windows.Forms.Button btnInci;
    }
}