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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAutobuses));
            this.tabPactualizarEliminar = new System.Windows.Forms.TabPage();
            this.tabPagregar = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPconsultar = new System.Windows.Forms.TabPage();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtIDAutobuses = new System.Windows.Forms.TextBox();
            this.IdAutobus = new System.Windows.Forms.Label();
            this.MostrarAutobuses = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPconsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarAutobuses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPactualizarEliminar
            // 
            this.tabPactualizarEliminar.Location = new System.Drawing.Point(4, 22);
            this.tabPactualizarEliminar.Name = "tabPactualizarEliminar";
            this.tabPactualizarEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPactualizarEliminar.Size = new System.Drawing.Size(840, 434);
            this.tabPactualizarEliminar.TabIndex = 1;
            this.tabPactualizarEliminar.Text = "Actualizar/Eliminar Autobuses";
            this.tabPactualizarEliminar.UseVisualStyleBackColor = true;
            // 
            // tabPagregar
            // 
            this.tabPagregar.Location = new System.Drawing.Point(4, 22);
            this.tabPagregar.Name = "tabPagregar";
            this.tabPagregar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagregar.Size = new System.Drawing.Size(840, 434);
            this.tabPagregar.TabIndex = 0;
            this.tabPagregar.Text = "Agregar Autobuses";
            this.tabPagregar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagregar);
            this.tabControl1.Controls.Add(this.tabPactualizarEliminar);
            this.tabControl1.Controls.Add(this.tabPconsultar);
            this.tabControl1.Location = new System.Drawing.Point(12, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(848, 460);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPconsultar
            // 
            this.tabPconsultar.Controls.Add(this.btnVerTodos);
            this.tabPconsultar.Controls.Add(this.btnConsultar);
            this.tabPconsultar.Controls.Add(this.txtIDAutobuses);
            this.tabPconsultar.Controls.Add(this.IdAutobus);
            this.tabPconsultar.Controls.Add(this.MostrarAutobuses);
            this.tabPconsultar.Location = new System.Drawing.Point(4, 22);
            this.tabPconsultar.Name = "tabPconsultar";
            this.tabPconsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPconsultar.Size = new System.Drawing.Size(840, 434);
            this.tabPconsultar.TabIndex = 2;
            this.tabPconsultar.Text = "Consultar Autobuses";
            this.tabPconsultar.UseVisualStyleBackColor = true;
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.Location = new System.Drawing.Point(589, 12);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(75, 23);
            this.btnVerTodos.TabIndex = 4;
            this.btnVerTodos.Text = "Ver Todos";
            this.btnVerTodos.UseVisualStyleBackColor = true;
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(460, 12);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtIDAutobuses
            // 
            this.txtIDAutobuses.Location = new System.Drawing.Point(100, 14);
            this.txtIDAutobuses.Name = "txtIDAutobuses";
            this.txtIDAutobuses.Size = new System.Drawing.Size(322, 20);
            this.txtIDAutobuses.TabIndex = 2;
            // 
            // IdAutobus
            // 
            this.IdAutobus.AutoSize = true;
            this.IdAutobus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdAutobus.Location = new System.Drawing.Point(6, 18);
            this.IdAutobus.Name = "IdAutobus";
            this.IdAutobus.Size = new System.Drawing.Size(88, 16);
            this.IdAutobus.TabIndex = 1;
            this.IdAutobus.Text = "ID Autobuses";
            // 
            // MostrarAutobuses
            // 
            this.MostrarAutobuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MostrarAutobuses.Location = new System.Drawing.Point(6, 50);
            this.MostrarAutobuses.Name = "MostrarAutobuses";
            this.MostrarAutobuses.Size = new System.Drawing.Size(828, 378);
            this.MostrarAutobuses.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormAutobuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 519);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAutobuses";
            this.Text = "FormAutobuses";
            this.tabControl1.ResumeLayout(false);
            this.tabPconsultar.ResumeLayout(false);
            this.tabPconsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarAutobuses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPactualizarEliminar;
        private System.Windows.Forms.TabPage tabPagregar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPconsultar;
        private System.Windows.Forms.Label IdAutobus;
        private System.Windows.Forms.DataGridView MostrarAutobuses;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtIDAutobuses;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}