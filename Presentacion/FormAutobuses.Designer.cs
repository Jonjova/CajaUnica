namespace Presentacion
{
    partial class FormAutobuses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAutobuses));
            this.tabPconsultar = new System.Windows.Forms.TabPage();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtIDAutobuses = new System.Windows.Forms.TextBox();
            this.IdAutobus = new System.Windows.Forms.Label();
            this.MostrarAutobuses = new System.Windows.Forms.DataGridView();
            this.tabPactualizarEliminar = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnObtener = new System.Windows.Forms.Button();
            this.NumAsientos = new System.Windows.Forms.NumericUpDown();
            this.AnioFabrica = new System.Windows.Forms.DateTimePicker();
            this.Fechacrea = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.ComboBox();
            this.Empresario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Modelo = new System.Windows.Forms.TextBox();
            this.marca = new System.Windows.Forms.TextBox();
            this.NumeroMarc = new System.Windows.Forms.TextBox();
            this.txtIDAutobus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPagregar = new System.Windows.Forms.TabPage();
            this.lblIdval = new System.Windows.Forms.Label();
            this.txtNumAsientos = new System.Windows.Forms.NumericUpDown();
            this.dtpAnioFabrica = new System.Windows.Forms.DateTimePicker();
            this.dtpFechacrea = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDUsuario = new System.Windows.Forms.ComboBox();
            this.txtIdEmpresario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmpresario = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtNumPlaca = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblAnioFabricacion = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblNumAsientos = new System.Windows.Forms.Label();
            this.lblNumPlaca = new System.Windows.Forms.Label();
            this.lbldAutubus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPconsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarAutobuses)).BeginInit();
            this.tabPactualizarEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAsientos)).BeginInit();
            this.tabPagregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumAsientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPconsultar
            // 
            this.tabPconsultar.Controls.Add(this.btnVerTodos);
            this.tabPconsultar.Controls.Add(this.btnConsultar);
            this.tabPconsultar.Controls.Add(this.txtIDAutobuses);
            this.tabPconsultar.Controls.Add(this.IdAutobus);
            this.tabPconsultar.Controls.Add(this.MostrarAutobuses);
            this.tabPconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPconsultar.Location = new System.Drawing.Point(4, 29);
            this.tabPconsultar.Name = "tabPconsultar";
            this.tabPconsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPconsultar.Size = new System.Drawing.Size(924, 715);
            this.tabPconsultar.TabIndex = 2;
            this.tabPconsultar.Text = "Consultar Autobuses";
            this.tabPconsultar.UseVisualStyleBackColor = true;
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnVerTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodos.ForeColor = System.Drawing.Color.Snow;
            this.btnVerTodos.Location = new System.Drawing.Point(698, 11);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(143, 34);
            this.btnVerTodos.TabIndex = 4;
            this.btnVerTodos.Text = "Consultar Todos";
            this.btnVerTodos.UseVisualStyleBackColor = false;
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.Snow;
            this.btnConsultar.Location = new System.Drawing.Point(520, 10);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(143, 34);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtIDAutobuses
            // 
            this.txtIDAutobuses.Location = new System.Drawing.Point(119, 14);
            this.txtIDAutobuses.Name = "txtIDAutobuses";
            this.txtIDAutobuses.Size = new System.Drawing.Size(354, 26);
            this.txtIDAutobuses.TabIndex = 2;
            // 
            // IdAutobus
            // 
            this.IdAutobus.AutoSize = true;
            this.IdAutobus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdAutobus.Location = new System.Drawing.Point(6, 18);
            this.IdAutobus.Name = "IdAutobus";
            this.IdAutobus.Size = new System.Drawing.Size(107, 20);
            this.IdAutobus.TabIndex = 1;
            this.IdAutobus.Text = "ID Autobuses";
            // 
            // MostrarAutobuses
            // 
            this.MostrarAutobuses.AllowUserToAddRows = false;
            this.MostrarAutobuses.AllowUserToDeleteRows = false;
            this.MostrarAutobuses.AllowUserToResizeColumns = false;
            this.MostrarAutobuses.AllowUserToResizeRows = false;
            this.MostrarAutobuses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MostrarAutobuses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MostrarAutobuses.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.MostrarAutobuses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MostrarAutobuses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MostrarAutobuses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.MostrarAutobuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MostrarAutobuses.DefaultCellStyle = dataGridViewCellStyle11;
            this.MostrarAutobuses.EnableHeadersVisualStyles = false;
            this.MostrarAutobuses.Location = new System.Drawing.Point(3, 51);
            this.MostrarAutobuses.Name = "MostrarAutobuses";
            this.MostrarAutobuses.RowHeadersVisible = false;
            this.MostrarAutobuses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.MostrarAutobuses.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.MostrarAutobuses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MostrarAutobuses.Size = new System.Drawing.Size(918, 668);
            this.MostrarAutobuses.TabIndex = 0;
            // 
            // tabPactualizarEliminar
            // 
            this.tabPactualizarEliminar.Controls.Add(this.label12);
            this.tabPactualizarEliminar.Controls.Add(this.btnEliminar);
            this.tabPactualizarEliminar.Controls.Add(this.btnActualizar);
            this.tabPactualizarEliminar.Controls.Add(this.btnObtener);
            this.tabPactualizarEliminar.Controls.Add(this.NumAsientos);
            this.tabPactualizarEliminar.Controls.Add(this.AnioFabrica);
            this.tabPactualizarEliminar.Controls.Add(this.Fechacrea);
            this.tabPactualizarEliminar.Controls.Add(this.label3);
            this.tabPactualizarEliminar.Controls.Add(this.Usuario);
            this.tabPactualizarEliminar.Controls.Add(this.Empresario);
            this.tabPactualizarEliminar.Controls.Add(this.label4);
            this.tabPactualizarEliminar.Controls.Add(this.label5);
            this.tabPactualizarEliminar.Controls.Add(this.Modelo);
            this.tabPactualizarEliminar.Controls.Add(this.marca);
            this.tabPactualizarEliminar.Controls.Add(this.NumeroMarc);
            this.tabPactualizarEliminar.Controls.Add(this.txtIDAutobus);
            this.tabPactualizarEliminar.Controls.Add(this.label6);
            this.tabPactualizarEliminar.Controls.Add(this.label7);
            this.tabPactualizarEliminar.Controls.Add(this.label8);
            this.tabPactualizarEliminar.Controls.Add(this.label9);
            this.tabPactualizarEliminar.Controls.Add(this.label10);
            this.tabPactualizarEliminar.Controls.Add(this.label11);
            this.tabPactualizarEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPactualizarEliminar.Location = new System.Drawing.Point(4, 29);
            this.tabPactualizarEliminar.Name = "tabPactualizarEliminar";
            this.tabPactualizarEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPactualizarEliminar.Size = new System.Drawing.Size(924, 715);
            this.tabPactualizarEliminar.TabIndex = 1;
            this.tabPactualizarEliminar.Text = "Actualizar/Eliminar Autobuses";
            this.tabPactualizarEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.Snow;
            this.btnEliminar.Location = new System.Drawing.Point(533, 652);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(148, 37);
            this.btnEliminar.TabIndex = 42;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.Snow;
            this.btnActualizar.Location = new System.Drawing.Point(333, 652);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(148, 37);
            this.btnActualizar.TabIndex = 41;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnObtener
            // 
            this.btnObtener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnObtener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObtener.ForeColor = System.Drawing.Color.Snow;
            this.btnObtener.Location = new System.Drawing.Point(708, 136);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(148, 37);
            this.btnObtener.TabIndex = 40;
            this.btnObtener.Text = "Consultar";
            this.btnObtener.UseVisualStyleBackColor = false;
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // NumAsientos
            // 
            this.NumAsientos.Location = new System.Drawing.Point(441, 279);
            this.NumAsientos.Name = "NumAsientos";
            this.NumAsientos.Size = new System.Drawing.Size(322, 26);
            this.NumAsientos.TabIndex = 39;
            // 
            // AnioFabrica
            // 
            this.AnioFabrica.Location = new System.Drawing.Point(441, 437);
            this.AnioFabrica.Name = "AnioFabrica";
            this.AnioFabrica.Size = new System.Drawing.Size(322, 26);
            this.AnioFabrica.TabIndex = 38;
            // 
            // Fechacrea
            // 
            this.Fechacrea.Location = new System.Drawing.Point(441, 593);
            this.Fechacrea.Name = "Fechacrea";
            this.Fechacrea.Size = new System.Drawing.Size(322, 26);
            this.Fechacrea.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 598);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Fecha Creación:";
            // 
            // Usuario
            // 
            this.Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Usuario.FormattingEnabled = true;
            this.Usuario.Location = new System.Drawing.Point(441, 544);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(322, 28);
            this.Usuario.Sorted = true;
            this.Usuario.TabIndex = 35;
            // 
            // Empresario
            // 
            this.Empresario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Empresario.FormattingEnabled = true;
            this.Empresario.Location = new System.Drawing.Point(441, 490);
            this.Empresario.Name = "Empresario";
            this.Empresario.Size = new System.Drawing.Size(322, 28);
            this.Empresario.Sorted = true;
            this.Empresario.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 547);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Seleccione Empresario:";
            // 
            // Modelo
            // 
            this.Modelo.Location = new System.Drawing.Point(441, 382);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(322, 26);
            this.Modelo.TabIndex = 31;
            // 
            // marca
            // 
            this.marca.Location = new System.Drawing.Point(441, 328);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(322, 26);
            this.marca.TabIndex = 30;
            // 
            // NumeroMarc
            // 
            this.NumeroMarc.Location = new System.Drawing.Point(441, 233);
            this.NumeroMarc.Name = "NumeroMarc";
            this.NumeroMarc.Size = new System.Drawing.Size(322, 26);
            this.NumeroMarc.TabIndex = 29;
            // 
            // txtIDAutobus
            // 
            this.txtIDAutobus.Location = new System.Drawing.Point(333, 140);
            this.txtIDAutobus.Name = "txtIDAutobus";
            this.txtIDAutobus.Size = new System.Drawing.Size(322, 26);
            this.txtIDAutobus.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(215, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Año de fabricación:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(218, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Modelo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(218, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Marca:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(218, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Numero de Asientos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(223, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Numero de  placa:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(184, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Id Autobus:";
            // 
            // tabPagregar
            // 
            this.tabPagregar.Controls.Add(this.label14);
            this.tabPagregar.Controls.Add(this.lblIdval);
            this.tabPagregar.Controls.Add(this.txtNumAsientos);
            this.tabPagregar.Controls.Add(this.dtpAnioFabrica);
            this.tabPagregar.Controls.Add(this.dtpFechacrea);
            this.tabPagregar.Controls.Add(this.label2);
            this.tabPagregar.Controls.Add(this.txtIDUsuario);
            this.tabPagregar.Controls.Add(this.txtIdEmpresario);
            this.tabPagregar.Controls.Add(this.label1);
            this.tabPagregar.Controls.Add(this.lblEmpresario);
            this.tabPagregar.Controls.Add(this.btnGuardar);
            this.tabPagregar.Controls.Add(this.txtModelo);
            this.tabPagregar.Controls.Add(this.txtMarca);
            this.tabPagregar.Controls.Add(this.txtNumPlaca);
            this.tabPagregar.Controls.Add(this.txtID);
            this.tabPagregar.Controls.Add(this.lblAnioFabricacion);
            this.tabPagregar.Controls.Add(this.lblModelo);
            this.tabPagregar.Controls.Add(this.lblMarca);
            this.tabPagregar.Controls.Add(this.lblNumAsientos);
            this.tabPagregar.Controls.Add(this.lblNumPlaca);
            this.tabPagregar.Controls.Add(this.lbldAutubus);
            this.tabPagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagregar.Location = new System.Drawing.Point(4, 29);
            this.tabPagregar.Name = "tabPagregar";
            this.tabPagregar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagregar.Size = new System.Drawing.Size(924, 715);
            this.tabPagregar.TabIndex = 0;
            this.tabPagregar.Text = "Agregar Autobuses";
            this.tabPagregar.UseVisualStyleBackColor = true;
            this.tabPagregar.Click += new System.EventHandler(this.tabPagregar_Click);
            // 
            // lblIdval
            // 
            this.lblIdval.AutoSize = true;
            this.lblIdval.ForeColor = System.Drawing.Color.Maroon;
            this.lblIdval.Location = new System.Drawing.Point(712, 66);
            this.lblIdval.Name = "lblIdval";
            this.lblIdval.Size = new System.Drawing.Size(0, 20);
            this.lblIdval.TabIndex = 22;
            this.lblIdval.Visible = false;
            // 
            // txtNumAsientos
            // 
            this.txtNumAsientos.Location = new System.Drawing.Point(439, 246);
            this.txtNumAsientos.Name = "txtNumAsientos";
            this.txtNumAsientos.Size = new System.Drawing.Size(322, 26);
            this.txtNumAsientos.TabIndex = 21;
            // 
            // dtpAnioFabrica
            // 
            this.dtpAnioFabrica.CustomFormat = "";
            this.dtpAnioFabrica.Location = new System.Drawing.Point(439, 404);
            this.dtpAnioFabrica.Name = "dtpAnioFabrica";
            this.dtpAnioFabrica.Size = new System.Drawing.Size(322, 26);
            this.dtpAnioFabrica.TabIndex = 20;
            this.dtpAnioFabrica.Value = new System.DateTime(2021, 6, 2, 12, 11, 9, 0);
            // 
            // dtpFechacrea
            // 
            this.dtpFechacrea.CustomFormat = "";
            this.dtpFechacrea.Location = new System.Drawing.Point(439, 576);
            this.dtpFechacrea.Name = "dtpFechacrea";
            this.dtpFechacrea.Size = new System.Drawing.Size(322, 26);
            this.dtpFechacrea.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 582);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fecha Creación:";
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtIDUsuario.FormattingEnabled = true;
            this.txtIDUsuario.Location = new System.Drawing.Point(439, 522);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(322, 28);
            this.txtIDUsuario.Sorted = true;
            this.txtIDUsuario.TabIndex = 16;
            // 
            // txtIdEmpresario
            // 
            this.txtIdEmpresario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtIdEmpresario.FormattingEnabled = true;
            this.txtIdEmpresario.Location = new System.Drawing.Point(439, 462);
            this.txtIdEmpresario.Name = "txtIdEmpresario";
            this.txtIdEmpresario.Size = new System.Drawing.Size(322, 28);
            this.txtIdEmpresario.Sorted = true;
            this.txtIdEmpresario.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Usuario:";
            // 
            // lblEmpresario
            // 
            this.lblEmpresario.AutoSize = true;
            this.lblEmpresario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresario.Location = new System.Drawing.Point(181, 470);
            this.lblEmpresario.Name = "lblEmpresario";
            this.lblEmpresario.Size = new System.Drawing.Size(94, 20);
            this.lblEmpresario.TabIndex = 13;
            this.lblEmpresario.Text = "Empresario:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(360, 632);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(185, 40);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(439, 350);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(322, 26);
            this.txtModelo.TabIndex = 10;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(439, 300);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(322, 26);
            this.txtMarca.TabIndex = 9;
            // 
            // txtNumPlaca
            // 
            this.txtNumPlaca.Location = new System.Drawing.Point(439, 205);
            this.txtNumPlaca.Name = "txtNumPlaca";
            this.txtNumPlaca.Size = new System.Drawing.Size(322, 26);
            this.txtNumPlaca.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(439, 138);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(322, 26);
            this.txtID.TabIndex = 6;
            // 
            // lblAnioFabricacion
            // 
            this.lblAnioFabricacion.AutoSize = true;
            this.lblAnioFabricacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioFabricacion.Location = new System.Drawing.Point(181, 410);
            this.lblAnioFabricacion.Name = "lblAnioFabricacion";
            this.lblAnioFabricacion.Size = new System.Drawing.Size(145, 20);
            this.lblAnioFabricacion.TabIndex = 5;
            this.lblAnioFabricacion.Text = "Año de fabricación:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(184, 356);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(65, 20);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(184, 306);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(57, 20);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca:";
            // 
            // lblNumAsientos
            // 
            this.lblNumAsientos.AutoSize = true;
            this.lblNumAsientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumAsientos.Location = new System.Drawing.Point(181, 248);
            this.lblNumAsientos.Name = "lblNumAsientos";
            this.lblNumAsientos.Size = new System.Drawing.Size(157, 20);
            this.lblNumAsientos.TabIndex = 2;
            this.lblNumAsientos.Text = "Numero de Asientos:";
            // 
            // lblNumPlaca
            // 
            this.lblNumPlaca.AutoSize = true;
            this.lblNumPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPlaca.Location = new System.Drawing.Point(181, 208);
            this.lblNumPlaca.Name = "lblNumPlaca";
            this.lblNumPlaca.Size = new System.Drawing.Size(137, 20);
            this.lblNumPlaca.TabIndex = 1;
            this.lblNumPlaca.Text = "Numero de  placa:";
            // 
            // lbldAutubus
            // 
            this.lbldAutubus.AutoSize = true;
            this.lbldAutubus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldAutubus.Location = new System.Drawing.Point(184, 141);
            this.lbldAutubus.Name = "lbldAutubus";
            this.lbldAutubus.Size = new System.Drawing.Size(91, 20);
            this.lbldAutubus.TabIndex = 0;
            this.lbldAutubus.Text = "Id Autobus:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(867, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPagregar);
            this.tabControl1.Controls.Add(this.tabPactualizarEliminar);
            this.tabControl1.Controls.Add(this.tabPconsultar);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(5, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(932, 748);
            this.tabControl1.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(322, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(223, 31);
            this.label14.TabIndex = 23;
            this.label14.Text = "Ingresar Registro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(327, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(298, 31);
            this.label12.TabIndex = 43;
            this.label12.Text = "Mantenimiento Autobus";
            // 
            // FormAutobuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 810);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAutobuses";
            this.Text = "FormAutobuses";
            this.Load += new System.EventHandler(this.FormAutobuses_Load);
            this.tabPconsultar.ResumeLayout(false);
            this.tabPconsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarAutobuses)).EndInit();
            this.tabPactualizarEliminar.ResumeLayout(false);
            this.tabPactualizarEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAsientos)).EndInit();
            this.tabPagregar.ResumeLayout(false);
            this.tabPagregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumAsientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.TabPage tabPconsultar;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtIDAutobuses;
        private System.Windows.Forms.Label IdAutobus;
        private System.Windows.Forms.DataGridView MostrarAutobuses;
        private System.Windows.Forms.TabPage tabPactualizarEliminar;
        private System.Windows.Forms.TabPage tabPagregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown txtNumAsientos;
        private System.Windows.Forms.DateTimePicker dtpAnioFabrica;
        private System.Windows.Forms.DateTimePicker dtpFechacrea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtIDUsuario;
        private System.Windows.Forms.ComboBox txtIdEmpresario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmpresario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtNumPlaca;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblAnioFabricacion;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblNumAsientos;
        private System.Windows.Forms.Label lblNumPlaca;
        private System.Windows.Forms.Label lbldAutubus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.NumericUpDown NumAsientos;
        private System.Windows.Forms.DateTimePicker AnioFabrica;
        private System.Windows.Forms.DateTimePicker Fechacrea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Usuario;
        private System.Windows.Forms.ComboBox Empresario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Modelo;
        private System.Windows.Forms.TextBox marca;
        private System.Windows.Forms.TextBox NumeroMarc;
        private System.Windows.Forms.TextBox txtIDAutobus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnObtener;
        private System.Windows.Forms.Label lblIdval;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
    }
}