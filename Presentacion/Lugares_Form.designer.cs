namespace Presentacion
{
    partial class Lugares_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lugares_Form));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.comboUsuario = new System.Windows.Forms.ComboBox();
            this.comboDepartamento = new System.Windows.Forms.ComboBox();
            this.comboNombre = new System.Windows.Forms.TextBox();
            this.IDLugar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtpFechaCrea = new System.Windows.Forms.DateTimePicker();
            this.cbxUsuarioCrea = new System.Windows.Forms.ComboBox();
            this.cbxDepartamento = new System.Windows.Forms.ComboBox();
            this.txtNombreLugar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdLugar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnObtener = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtIdLugares = new System.Windows.Forms.TextBox();
            this.IdAutobus = new System.Windows.Forms.Label();
            this.MostrarAutobuses = new System.Windows.Forms.DataGridView();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarAutobuses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(851, 630);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.fecha);
            this.tabPage1.Controls.Add(this.comboUsuario);
            this.tabPage1.Controls.Add(this.comboDepartamento);
            this.tabPage1.Controls.Add(this.comboNombre);
            this.tabPage1.Controls.Add(this.IDLugar);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(843, 597);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(325, 500);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(185, 40);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(409, 411);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(303, 26);
            this.fecha.TabIndex = 9;
            // 
            // comboUsuario
            // 
            this.comboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUsuario.FormattingEnabled = true;
            this.comboUsuario.Location = new System.Drawing.Point(409, 334);
            this.comboUsuario.Name = "comboUsuario";
            this.comboUsuario.Size = new System.Drawing.Size(303, 28);
            this.comboUsuario.TabIndex = 8;
            // 
            // comboDepartamento
            // 
            this.comboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDepartamento.FormattingEnabled = true;
            this.comboDepartamento.Location = new System.Drawing.Point(409, 260);
            this.comboDepartamento.Name = "comboDepartamento";
            this.comboDepartamento.Size = new System.Drawing.Size(303, 28);
            this.comboDepartamento.TabIndex = 7;
            // 
            // comboNombre
            // 
            this.comboNombre.Location = new System.Drawing.Point(409, 194);
            this.comboNombre.Name = "comboNombre";
            this.comboNombre.Size = new System.Drawing.Size(303, 26);
            this.comboNombre.TabIndex = 6;
            // 
            // IDLugar
            // 
            this.IDLugar.Location = new System.Drawing.Point(409, 128);
            this.IDLugar.Name = "IDLugar";
            this.IDLugar.Size = new System.Drawing.Size(303, 26);
            this.IDLugar.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Creación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario Creación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleccione Departamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Lugar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Lugar:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtpFechaCrea);
            this.tabPage2.Controls.Add(this.cbxUsuarioCrea);
            this.tabPage2.Controls.Add(this.cbxDepartamento);
            this.tabPage2.Controls.Add(this.txtNombreLugar);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtIdLugar);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnEliminar);
            this.tabPage2.Controls.Add(this.btnActualizar);
            this.tabPage2.Controls.Add(this.btnObtener);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(843, 597);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar/Eliminar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtpFechaCrea
            // 
            this.dtpFechaCrea.Location = new System.Drawing.Point(332, 364);
            this.dtpFechaCrea.Name = "dtpFechaCrea";
            this.dtpFechaCrea.Size = new System.Drawing.Size(303, 26);
            this.dtpFechaCrea.TabIndex = 53;
            // 
            // cbxUsuarioCrea
            // 
            this.cbxUsuarioCrea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUsuarioCrea.FormattingEnabled = true;
            this.cbxUsuarioCrea.Location = new System.Drawing.Point(332, 284);
            this.cbxUsuarioCrea.Name = "cbxUsuarioCrea";
            this.cbxUsuarioCrea.Size = new System.Drawing.Size(303, 28);
            this.cbxUsuarioCrea.TabIndex = 52;
            // 
            // cbxDepartamento
            // 
            this.cbxDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartamento.FormattingEnabled = true;
            this.cbxDepartamento.Location = new System.Drawing.Point(332, 214);
            this.cbxDepartamento.Name = "cbxDepartamento";
            this.cbxDepartamento.Size = new System.Drawing.Size(303, 28);
            this.cbxDepartamento.TabIndex = 51;
            // 
            // txtNombreLugar
            // 
            this.txtNombreLugar.Location = new System.Drawing.Point(332, 140);
            this.txtNombreLugar.Name = "txtNombreLugar";
            this.txtNombreLugar.Size = new System.Drawing.Size(303, 26);
            this.txtNombreLugar.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(107, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 49;
            this.label10.Text = "Fecha Creación:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(107, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "Usuario Creación:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Seleccione Departamento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Nombre Lugar:";
            // 
            // txtIdLugar
            // 
            this.txtIdLugar.Location = new System.Drawing.Point(266, 55);
            this.txtIdLugar.Name = "txtIdLugar";
            this.txtIdLugar.Size = new System.Drawing.Size(303, 26);
            this.txtIdLugar.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Id Lugar:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.Snow;
            this.btnEliminar.Location = new System.Drawing.Point(429, 470);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 37);
            this.btnEliminar.TabIndex = 43;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.Snow;
            this.btnActualizar.Location = new System.Drawing.Point(221, 470);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(160, 37);
            this.btnActualizar.TabIndex = 42;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnObtener
            // 
            this.btnObtener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnObtener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObtener.ForeColor = System.Drawing.Color.Snow;
            this.btnObtener.Location = new System.Drawing.Point(611, 50);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(148, 37);
            this.btnObtener.TabIndex = 41;
            this.btnObtener.Text = "Consultar";
            this.btnObtener.UseVisualStyleBackColor = false;
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnVerTodos);
            this.tabPage3.Controls.Add(this.btnConsultar);
            this.tabPage3.Controls.Add(this.txtIdLugares);
            this.tabPage3.Controls.Add(this.IdAutobus);
            this.tabPage3.Controls.Add(this.MostrarAutobuses);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(843, 597);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mostrar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnVerTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodos.ForeColor = System.Drawing.Color.Snow;
            this.btnVerTodos.Location = new System.Drawing.Point(638, 14);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(143, 34);
            this.btnVerTodos.TabIndex = 5;
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
            this.btnConsultar.Location = new System.Drawing.Point(467, 14);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(143, 34);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtIdLugares
            // 
            this.txtIdLugares.Location = new System.Drawing.Point(140, 12);
            this.txtIdLugares.Name = "txtIdLugares";
            this.txtIdLugares.Size = new System.Drawing.Size(297, 26);
            this.txtIdLugares.TabIndex = 3;
            // 
            // IdAutobus
            // 
            this.IdAutobus.AutoSize = true;
            this.IdAutobus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdAutobus.Location = new System.Drawing.Point(33, 18);
            this.IdAutobus.Name = "IdAutobus";
            this.IdAutobus.Size = new System.Drawing.Size(88, 20);
            this.IdAutobus.TabIndex = 2;
            this.IdAutobus.Text = "ID Lugares";
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
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MostrarAutobuses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.MostrarAutobuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MostrarAutobuses.DefaultCellStyle = dataGridViewCellStyle32;
            this.MostrarAutobuses.EnableHeadersVisualStyles = false;
            this.MostrarAutobuses.Location = new System.Drawing.Point(3, 56);
            this.MostrarAutobuses.Name = "MostrarAutobuses";
            this.MostrarAutobuses.RowHeadersVisible = false;
            this.MostrarAutobuses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Black;
            this.MostrarAutobuses.RowsDefaultCellStyle = dataGridViewCellStyle33;
            this.MostrarAutobuses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MostrarAutobuses.Size = new System.Drawing.Size(840, 509);
            this.MostrarAutobuses.TabIndex = 1;
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar.BackColor = System.Drawing.Color.DarkGray;
            this.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(829, 12);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(30, 30);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrar.TabIndex = 13;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(302, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(223, 31);
            this.label11.TabIndex = 14;
            this.label11.Text = "Ingresar Registro";
            // 
            // Lugares_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 656);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lugares_Form";
            this.Text = "Lugares_Form";
            this.Load += new System.EventHandler(this.Lugares_Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarAutobuses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.ComboBox comboUsuario;
        private System.Windows.Forms.ComboBox comboDepartamento;
        private System.Windows.Forms.TextBox comboNombre;
        private System.Windows.Forms.TextBox IDLugar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnObtener;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView MostrarAutobuses;
        private System.Windows.Forms.Label IdAutobus;
        private System.Windows.Forms.TextBox txtIdLugares;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaCrea;
        private System.Windows.Forms.ComboBox cbxUsuarioCrea;
        private System.Windows.Forms.ComboBox cbxDepartamento;
        private System.Windows.Forms.TextBox txtNombreLugar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdLugar;
        private System.Windows.Forms.Label label11;
    }
}