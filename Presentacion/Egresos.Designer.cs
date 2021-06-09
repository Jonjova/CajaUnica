namespace Presentacion
{
    partial class Egresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Egresos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtUsuarioCrea = new System.Windows.Forms.ComboBox();
            this.txtIdAutobuses = new System.Windows.Forms.ComboBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.txtNombreEgresos = new System.Windows.Forms.TextBox();
            this.txtPagoGastos = new System.Windows.Forms.TextBox();
            this.txtidegresos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.UsuarioCrea = new System.Windows.Forms.ComboBox();
            this.Observacion = new System.Windows.Forms.TextBox();
            this.NombreEgresos = new System.Windows.Forms.TextBox();
            this.pagosGastos = new System.Windows.Forms.TextBox();
            this.idAutobuses = new System.Windows.Forms.ComboBox();
            this.idEgresos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnObtener = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.MostrarEgresos = new System.Windows.Forms.DataGridView();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.btnEgresosID = new System.Windows.Forms.Button();
            this.EgresosID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarEgresos)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(6, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(875, 606);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.txtUsuarioCrea);
            this.tabPage1.Controls.Add(this.txtIdAutobuses);
            this.tabPage1.Controls.Add(this.txtObservacion);
            this.tabPage1.Controls.Add(this.txtNombreEgresos);
            this.tabPage1.Controls.Add(this.txtPagoGastos);
            this.tabPage1.Controls.Add(this.txtidegresos);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(867, 573);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(469, 450);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 34);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtUsuarioCrea
            // 
            this.txtUsuarioCrea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioCrea.FormattingEnabled = true;
            this.txtUsuarioCrea.Location = new System.Drawing.Point(302, 366);
            this.txtUsuarioCrea.Name = "txtUsuarioCrea";
            this.txtUsuarioCrea.Size = new System.Drawing.Size(418, 28);
            this.txtUsuarioCrea.TabIndex = 12;
            // 
            // txtIdAutobuses
            // 
            this.txtIdAutobuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAutobuses.FormattingEnabled = true;
            this.txtIdAutobuses.Location = new System.Drawing.Point(302, 95);
            this.txtIdAutobuses.Name = "txtIdAutobuses";
            this.txtIdAutobuses.Size = new System.Drawing.Size(418, 28);
            this.txtIdAutobuses.TabIndex = 11;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(302, 305);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(418, 26);
            this.txtObservacion.TabIndex = 10;
            // 
            // txtNombreEgresos
            // 
            this.txtNombreEgresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEgresos.Location = new System.Drawing.Point(302, 245);
            this.txtNombreEgresos.Name = "txtNombreEgresos";
            this.txtNombreEgresos.Size = new System.Drawing.Size(418, 26);
            this.txtNombreEgresos.TabIndex = 9;
            // 
            // txtPagoGastos
            // 
            this.txtPagoGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoGastos.Location = new System.Drawing.Point(302, 172);
            this.txtPagoGastos.Name = "txtPagoGastos";
            this.txtPagoGastos.Size = new System.Drawing.Size(418, 26);
            this.txtPagoGastos.TabIndex = 8;
            // 
            // txtidegresos
            // 
            this.txtidegresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidegresos.Location = new System.Drawing.Point(302, 37);
            this.txtidegresos.Name = "txtidegresos";
            this.txtidegresos.Size = new System.Drawing.Size(418, 26);
            this.txtidegresos.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(135, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Usuario Crea";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre egreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Observacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pagos Gastos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Autobuses";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id egresos";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.UsuarioCrea);
            this.tabPage2.Controls.Add(this.Observacion);
            this.tabPage2.Controls.Add(this.NombreEgresos);
            this.tabPage2.Controls.Add(this.pagosGastos);
            this.tabPage2.Controls.Add(this.idAutobuses);
            this.tabPage2.Controls.Add(this.idEgresos);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.btnEliminar);
            this.tabPage2.Controls.Add(this.btnActualizar);
            this.tabPage2.Controls.Add(this.btnObtener);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(867, 544);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar/ Eliminar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UsuarioCrea
            // 
            this.UsuarioCrea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioCrea.FormattingEnabled = true;
            this.UsuarioCrea.Location = new System.Drawing.Point(288, 420);
            this.UsuarioCrea.Name = "UsuarioCrea";
            this.UsuarioCrea.Size = new System.Drawing.Size(418, 28);
            this.UsuarioCrea.TabIndex = 51;
            // 
            // Observacion
            // 
            this.Observacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Observacion.Location = new System.Drawing.Point(288, 358);
            this.Observacion.Name = "Observacion";
            this.Observacion.Size = new System.Drawing.Size(418, 26);
            this.Observacion.TabIndex = 50;
            // 
            // NombreEgresos
            // 
            this.NombreEgresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreEgresos.Location = new System.Drawing.Point(288, 290);
            this.NombreEgresos.Name = "NombreEgresos";
            this.NombreEgresos.Size = new System.Drawing.Size(418, 26);
            this.NombreEgresos.TabIndex = 49;
            // 
            // pagosGastos
            // 
            this.pagosGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagosGastos.Location = new System.Drawing.Point(288, 222);
            this.pagosGastos.Name = "pagosGastos";
            this.pagosGastos.Size = new System.Drawing.Size(418, 26);
            this.pagosGastos.TabIndex = 48;
            // 
            // idAutobuses
            // 
            this.idAutobuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idAutobuses.FormattingEnabled = true;
            this.idAutobuses.Location = new System.Drawing.Point(288, 140);
            this.idAutobuses.Name = "idAutobuses";
            this.idAutobuses.Size = new System.Drawing.Size(418, 28);
            this.idAutobuses.TabIndex = 47;
            // 
            // idEgresos
            // 
            this.idEgresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idEgresos.Location = new System.Drawing.Point(288, 22);
            this.idEgresos.Name = "idEgresos";
            this.idEgresos.Size = new System.Drawing.Size(418, 26);
            this.idEgresos.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(148, 428);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 20);
            this.label13.TabIndex = 45;
            this.label13.Text = "Usuario Crea";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(148, 358);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 20);
            this.label12.TabIndex = 44;
            this.label12.Text = "Observacion";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Brown;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.Snow;
            this.btnEliminar.Location = new System.Drawing.Point(614, 485);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 31);
            this.btnEliminar.TabIndex = 43;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.Snow;
            this.btnActualizar.Location = new System.Drawing.Point(288, 485);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(96, 31);
            this.btnActualizar.TabIndex = 42;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnObtener
            // 
            this.btnObtener.BackColor = System.Drawing.Color.SlateGray;
            this.btnObtener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObtener.ForeColor = System.Drawing.Color.Snow;
            this.btnObtener.Location = new System.Drawing.Point(454, 80);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(97, 32);
            this.btnObtener.TabIndex = 41;
            this.btnObtener.Text = "Consultar";
            this.btnObtener.UseVisualStyleBackColor = false;
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(148, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Nombre egreso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(148, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Pagos Gastos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(153, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Id Autobuses";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(153, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Id egresos";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.MostrarEgresos);
            this.tabPage3.Controls.Add(this.btnVerTodos);
            this.tabPage3.Controls.Add(this.btnEgresosID);
            this.tabPage3.Controls.Add(this.EgresosID);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(867, 544);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mostrar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MostrarEgresos
            // 
            this.MostrarEgresos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.MostrarEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MostrarEgresos.Location = new System.Drawing.Point(3, 57);
            this.MostrarEgresos.Name = "MostrarEgresos";
            this.MostrarEgresos.Size = new System.Drawing.Size(861, 488);
            this.MostrarEgresos.TabIndex = 4;
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.BackColor = System.Drawing.Color.ForestGreen;
            this.btnVerTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerTodos.Location = new System.Drawing.Point(662, 22);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(115, 29);
            this.btnVerTodos.TabIndex = 3;
            this.btnVerTodos.Text = "Ver Todos";
            this.btnVerTodos.UseVisualStyleBackColor = false;
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // btnEgresosID
            // 
            this.btnEgresosID.BackColor = System.Drawing.Color.SlateGray;
            this.btnEgresosID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEgresosID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEgresosID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEgresosID.Location = new System.Drawing.Point(547, 22);
            this.btnEgresosID.Name = "btnEgresosID";
            this.btnEgresosID.Size = new System.Drawing.Size(91, 29);
            this.btnEgresosID.TabIndex = 2;
            this.btnEgresosID.Text = "Consultar";
            this.btnEgresosID.UseVisualStyleBackColor = false;
            this.btnEgresosID.Click += new System.EventHandler(this.btnEgresosID_Click);
            // 
            // EgresosID
            // 
            this.EgresosID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EgresosID.Location = new System.Drawing.Point(163, 22);
            this.EgresosID.Name = "EgresosID";
            this.EgresosID.Size = new System.Drawing.Size(350, 26);
            this.EgresosID.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Id egresos";
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar.BackColor = System.Drawing.Color.DarkGray;
            this.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(828, 12);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(30, 30);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrar.TabIndex = 14;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Egresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 650);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Egresos";
            this.Text = "Egresos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarEgresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox txtUsuarioCrea;
        private System.Windows.Forms.ComboBox txtIdAutobuses;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.TextBox txtNombreEgresos;
        private System.Windows.Forms.TextBox txtPagoGastos;
        private System.Windows.Forms.TextBox txtidegresos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Button btnEgresosID;
        private System.Windows.Forms.TextBox EgresosID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView MostrarEgresos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnObtener;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox idEgresos;
        private System.Windows.Forms.ComboBox UsuarioCrea;
        private System.Windows.Forms.TextBox Observacion;
        private System.Windows.Forms.TextBox NombreEgresos;
        private System.Windows.Forms.TextBox pagosGastos;
        private System.Windows.Forms.ComboBox idAutobuses;
        private System.Windows.Forms.PictureBox Cerrar;
    }
}