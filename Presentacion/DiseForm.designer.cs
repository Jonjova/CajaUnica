﻿namespace Presentacion
{
    partial class DiseForm
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiseForm));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.ManuTop = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.dashboard = new System.Windows.Forms.Label();
            this.MenuSidebar = new System.Windows.Forms.PictureBox();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.cerrarSesion = new System.Windows.Forms.Button();
            this.PanelUsuario = new System.Windows.Forms.Panel();
            this.EliminarCuenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUsuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ConfigurarPerfil = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReportes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLugares = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAutobuses = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmpresarios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMotoristas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnViajes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dashboard1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.Grupo6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimaacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.MoverDhasboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ColapzarUsuario = new System.Windows.Forms.Timer(this.components);
            this.ManuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.PanelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ManuTop
            // 
            this.ManuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ManuTop.Controls.Add(this.lblNombre);
            this.ManuTop.Controls.Add(this.lblCargo);
            this.ManuTop.Controls.Add(this.Restaurar);
            this.ManuTop.Controls.Add(this.Minimizar);
            this.ManuTop.Controls.Add(this.maximizar);
            this.ManuTop.Controls.Add(this.Cerrar);
            this.ManuTop.Controls.Add(this.dashboard);
            this.ManuTop.Controls.Add(this.MenuSidebar);
            this.AnimaacionSidebarBack.SetDecoration(this.ManuTop, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.ManuTop, BunifuAnimatorNS.DecorationType.None);
            this.ManuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManuTop.Location = new System.Drawing.Point(0, 0);
            this.ManuTop.Name = "ManuTop";
            this.ManuTop.Size = new System.Drawing.Size(1200, 78);
            this.ManuTop.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.lblNombre, BunifuAnimatorNS.DecorationType.None);
            this.AnimaacionSidebarBack.SetDecoration(this.lblNombre, BunifuAnimatorNS.DecorationType.None);
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(258, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 17);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.lblCargo, BunifuAnimatorNS.DecorationType.None);
            this.AnimaacionSidebarBack.SetDecoration(this.lblCargo, BunifuAnimatorNS.DecorationType.None);
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.White;
            this.lblCargo.Location = new System.Drawing.Point(258, 47);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(50, 17);
            this.lblCargo.TabIndex = 15;
            this.lblCargo.Text = "Cargo";
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.AnimaacionSidebarBack.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(1106, 21);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(30, 30);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 5;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimaacionSidebarBack.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(1070, 21);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 4;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.maximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimaacionSidebarBack.SetDecoration(this.maximizar, BunifuAnimatorNS.DecorationType.None);
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(1106, 21);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(30, 30);
            this.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maximizar.TabIndex = 3;
            this.maximizar.TabStop = false;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Cerrar, BunifuAnimatorNS.DecorationType.None);
            this.AnimaacionSidebarBack.SetDecoration(this.Cerrar, BunifuAnimatorNS.DecorationType.None);
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(1142, 21);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(30, 30);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrar.TabIndex = 2;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // dashboard
            // 
            this.dashboard.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.dashboard, BunifuAnimatorNS.DecorationType.None);
            this.AnimaacionSidebarBack.SetDecoration(this.dashboard, BunifuAnimatorNS.DecorationType.None);
            this.dashboard.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.White;
            this.dashboard.Location = new System.Drawing.Point(70, 21);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(112, 20);
            this.dashboard.TabIndex = 1;
            this.dashboard.Text = "DASHBOARD";
            // 
            // MenuSidebar
            // 
            this.AnimacionSidebar.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimaacionSidebarBack.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.MenuSidebar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSidebar.Image")));
            this.MenuSidebar.Location = new System.Drawing.Point(24, 21);
            this.MenuSidebar.Name = "MenuSidebar";
            this.MenuSidebar.Size = new System.Drawing.Size(30, 30);
            this.MenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuSidebar.TabIndex = 0;
            this.MenuSidebar.TabStop = false;
            this.MenuSidebar.Click += new System.EventHandler(this.MenuSidebar_Click);
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SidebarWrapper.Controls.Add(this.Sidebar);
            this.AnimaacionSidebarBack.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 78);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(250, 822);
            this.SidebarWrapper.TabIndex = 1;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.cerrarSesion);
            this.Sidebar.Controls.Add(this.PanelUsuario);
            this.Sidebar.Controls.Add(this.btnReportes);
            this.Sidebar.Controls.Add(this.btnLugares);
            this.Sidebar.Controls.Add(this.btnAutobuses);
            this.Sidebar.Controls.Add(this.btnEmpresarios);
            this.Sidebar.Controls.Add(this.btnMotoristas);
            this.Sidebar.Controls.Add(this.btnViajes);
            this.Sidebar.Controls.Add(this.dashboard1);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.Grupo6);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.AnimaacionSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.SteelBlue;
            this.Sidebar.GradientBottomRight = System.Drawing.Color.SteelBlue;
            this.Sidebar.GradientTopLeft = System.Drawing.Color.SteelBlue;
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Sidebar.Location = new System.Drawing.Point(4, 3);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(240, 816);
            this.Sidebar.TabIndex = 0;
            // 
            // cerrarSesion
            // 
            this.AnimacionSidebar.SetDecoration(this.cerrarSesion, BunifuAnimatorNS.DecorationType.None);
            this.AnimaacionSidebarBack.SetDecoration(this.cerrarSesion, BunifuAnimatorNS.DecorationType.None);
            this.cerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesion.ForeColor = System.Drawing.Color.Transparent;
            this.cerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("cerrarSesion.Image")));
            this.cerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cerrarSesion.Location = new System.Drawing.Point(6, 660);
            this.cerrarSesion.Name = "cerrarSesion";
            this.cerrarSesion.Size = new System.Drawing.Size(231, 40);
            this.cerrarSesion.TabIndex = 19;
            this.cerrarSesion.Text = "Cerrar Sesion";
            this.cerrarSesion.UseVisualStyleBackColor = true;
            this.cerrarSesion.Click += new System.EventHandler(this.cerrarSesion_Click);
            // 
            // PanelUsuario
            // 
            this.PanelUsuario.BackColor = System.Drawing.Color.Transparent;
            this.PanelUsuario.Controls.Add(this.EliminarCuenta);
            this.PanelUsuario.Controls.Add(this.btnUsuario);
            this.PanelUsuario.Controls.Add(this.ConfigurarPerfil);
            this.AnimaacionSidebarBack.SetDecoration(this.PanelUsuario, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.PanelUsuario, BunifuAnimatorNS.DecorationType.None);
            this.PanelUsuario.Location = new System.Drawing.Point(13, 581);
            this.PanelUsuario.Name = "PanelUsuario";
            this.PanelUsuario.Size = new System.Drawing.Size(221, 51);
            this.PanelUsuario.TabIndex = 2;
            // 
            // EliminarCuenta
            // 
            this.EliminarCuenta.Activecolor = System.Drawing.Color.Transparent;
            this.EliminarCuenta.BackColor = System.Drawing.Color.Transparent;
            this.EliminarCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EliminarCuenta.BorderRadius = 0;
            this.EliminarCuenta.ButtonText = "        Eliminar Cuenta";
            this.EliminarCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimaacionSidebarBack.SetDecoration(this.EliminarCuenta, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.EliminarCuenta, BunifuAnimatorNS.DecorationType.None);
            this.EliminarCuenta.DisabledColor = System.Drawing.Color.Gray;
            this.EliminarCuenta.Iconcolor = System.Drawing.Color.Transparent;
            this.EliminarCuenta.Iconimage = ((System.Drawing.Image)(resources.GetObject("EliminarCuenta.Iconimage")));
            this.EliminarCuenta.Iconimage_right = null;
            this.EliminarCuenta.Iconimage_right_Selected = null;
            this.EliminarCuenta.Iconimage_Selected = null;
            this.EliminarCuenta.IconMarginLeft = 0;
            this.EliminarCuenta.IconMarginRight = 0;
            this.EliminarCuenta.IconRightVisible = true;
            this.EliminarCuenta.IconRightZoom = 0D;
            this.EliminarCuenta.IconVisible = true;
            this.EliminarCuenta.IconZoom = 45D;
            this.EliminarCuenta.IsTab = false;
            this.EliminarCuenta.Location = new System.Drawing.Point(8, 111);
            this.EliminarCuenta.Name = "EliminarCuenta";
            this.EliminarCuenta.Normalcolor = System.Drawing.Color.Transparent;
            this.EliminarCuenta.OnHovercolor = System.Drawing.Color.Transparent;
            this.EliminarCuenta.OnHoverTextColor = System.Drawing.Color.White;
            this.EliminarCuenta.selected = false;
            this.EliminarCuenta.Size = new System.Drawing.Size(210, 51);
            this.EliminarCuenta.TabIndex = 4;
            this.EliminarCuenta.Text = "        Eliminar Cuenta";
            this.EliminarCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarCuenta.Textcolor = System.Drawing.Color.White;
            this.EliminarCuenta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnUsuario
            // 
            this.btnUsuario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuario.BorderRadius = 7;
            this.btnUsuario.ButtonText = "        Usuario";
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimaacionSidebarBack.SetDecoration(this.btnUsuario, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnUsuario, BunifuAnimatorNS.DecorationType.None);
            this.btnUsuario.DisabledColor = System.Drawing.Color.Gray;
            this.btnUsuario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUsuario.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Iconimage")));
            this.btnUsuario.Iconimage_right = null;
            this.btnUsuario.Iconimage_right_Selected = null;
            this.btnUsuario.Iconimage_Selected = null;
            this.btnUsuario.IconMarginLeft = 0;
            this.btnUsuario.IconMarginRight = 0;
            this.btnUsuario.IconRightVisible = true;
            this.btnUsuario.IconRightZoom = 0D;
            this.btnUsuario.IconVisible = true;
            this.btnUsuario.IconZoom = 50D;
            this.btnUsuario.IsTab = false;
            this.btnUsuario.Location = new System.Drawing.Point(8, 3);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Normalcolor = System.Drawing.Color.Transparent;
            this.btnUsuario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnUsuario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUsuario.selected = false;
            this.btnUsuario.Size = new System.Drawing.Size(207, 45);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.Text = "        Usuario";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Textcolor = System.Drawing.Color.White;
            this.btnUsuario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.Click += new System.EventHandler(this.Usuario_Click);
            // 
            // ConfigurarPerfil
            // 
            this.ConfigurarPerfil.Activecolor = System.Drawing.Color.Transparent;
            this.ConfigurarPerfil.BackColor = System.Drawing.Color.Transparent;
            this.ConfigurarPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConfigurarPerfil.BorderRadius = 0;
            this.ConfigurarPerfil.ButtonText = "        Configurar Perfil";
            this.ConfigurarPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimaacionSidebarBack.SetDecoration(this.ConfigurarPerfil, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.ConfigurarPerfil, BunifuAnimatorNS.DecorationType.None);
            this.ConfigurarPerfil.DisabledColor = System.Drawing.Color.Gray;
            this.ConfigurarPerfil.Iconcolor = System.Drawing.Color.Transparent;
            this.ConfigurarPerfil.Iconimage = ((System.Drawing.Image)(resources.GetObject("ConfigurarPerfil.Iconimage")));
            this.ConfigurarPerfil.Iconimage_right = null;
            this.ConfigurarPerfil.Iconimage_right_Selected = null;
            this.ConfigurarPerfil.Iconimage_Selected = null;
            this.ConfigurarPerfil.IconMarginLeft = 0;
            this.ConfigurarPerfil.IconMarginRight = 0;
            this.ConfigurarPerfil.IconRightVisible = true;
            this.ConfigurarPerfil.IconRightZoom = 0D;
            this.ConfigurarPerfil.IconVisible = true;
            this.ConfigurarPerfil.IconZoom = 45D;
            this.ConfigurarPerfil.IsTab = false;
            this.ConfigurarPerfil.Location = new System.Drawing.Point(8, 54);
            this.ConfigurarPerfil.Name = "ConfigurarPerfil";
            this.ConfigurarPerfil.Normalcolor = System.Drawing.Color.Transparent;
            this.ConfigurarPerfil.OnHovercolor = System.Drawing.Color.Transparent;
            this.ConfigurarPerfil.OnHoverTextColor = System.Drawing.Color.White;
            this.ConfigurarPerfil.selected = false;
            this.ConfigurarPerfil.Size = new System.Drawing.Size(210, 51);
            this.ConfigurarPerfil.TabIndex = 3;
            this.ConfigurarPerfil.Text = "        Configurar Perfil";
            this.ConfigurarPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConfigurarPerfil.Textcolor = System.Drawing.Color.White;
            this.ConfigurarPerfil.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnReportes
            // 
            this.btnReportes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReportes.BorderRadius = 7;
            this.btnReportes.ButtonText = "        Reportes";
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimaacionSidebarBack.SetDecoration(this.btnReportes, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnReportes, BunifuAnimatorNS.DecorationType.None);
            this.btnReportes.DisabledColor = System.Drawing.Color.Gray;
            this.btnReportes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReportes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReportes.Iconimage")));
            this.btnReportes.Iconimage_right = null;
            this.btnReportes.Iconimage_right_Selected = null;
            this.btnReportes.Iconimage_Selected = null;
            this.btnReportes.IconMarginLeft = 0;
            this.btnReportes.IconMarginRight = 0;
            this.btnReportes.IconRightVisible = true;
            this.btnReportes.IconRightZoom = 0D;
            this.btnReportes.IconVisible = true;
            this.btnReportes.IconZoom = 50D;
            this.btnReportes.IsTab = false;
            this.btnReportes.Location = new System.Drawing.Point(13, 514);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnReportes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnReportes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReportes.selected = false;
            this.btnReportes.Size = new System.Drawing.Size(210, 42);
            this.btnReportes.TabIndex = 8;
            this.btnReportes.Text = "        Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Textcolor = System.Drawing.Color.White;
            this.btnReportes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnLugares
            // 
            this.btnLugares.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnLugares.BackColor = System.Drawing.Color.Transparent;
            this.btnLugares.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLugares.BorderRadius = 7;
            this.btnLugares.ButtonText = "        Lugares";
            this.btnLugares.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimaacionSidebarBack.SetDecoration(this.btnLugares, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnLugares, BunifuAnimatorNS.DecorationType.None);
            this.btnLugares.DisabledColor = System.Drawing.Color.Gray;
            this.btnLugares.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLugares.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLugares.Iconimage")));
            this.btnLugares.Iconimage_right = null;
            this.btnLugares.Iconimage_right_Selected = null;
            this.btnLugares.Iconimage_Selected = null;
            this.btnLugares.IconMarginLeft = 0;
            this.btnLugares.IconMarginRight = 0;
            this.btnLugares.IconRightVisible = true;
            this.btnLugares.IconRightZoom = 0D;
            this.btnLugares.IconVisible = true;
            this.btnLugares.IconZoom = 50D;
            this.btnLugares.IsTab = false;
            this.btnLugares.Location = new System.Drawing.Point(13, 435);
            this.btnLugares.Name = "btnLugares";
            this.btnLugares.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLugares.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnLugares.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLugares.selected = false;
            this.btnLugares.Size = new System.Drawing.Size(210, 51);
            this.btnLugares.TabIndex = 7;
            this.btnLugares.Text = "        Lugares";
            this.btnLugares.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLugares.Textcolor = System.Drawing.Color.White;
            this.btnLugares.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAutobuses
            // 
            this.btnAutobuses.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnAutobuses.BackColor = System.Drawing.Color.Transparent;
            this.btnAutobuses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAutobuses.BorderRadius = 7;
            this.btnAutobuses.ButtonText = "        Autobuses";
            this.btnAutobuses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimaacionSidebarBack.SetDecoration(this.btnAutobuses, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnAutobuses, BunifuAnimatorNS.DecorationType.None);
            this.btnAutobuses.DisabledColor = System.Drawing.Color.Gray;
            this.btnAutobuses.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAutobuses.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAutobuses.Iconimage")));
            this.btnAutobuses.Iconimage_right = null;
            this.btnAutobuses.Iconimage_right_Selected = null;
            this.btnAutobuses.Iconimage_Selected = null;
            this.btnAutobuses.IconMarginLeft = 0;
            this.btnAutobuses.IconMarginRight = 0;
            this.btnAutobuses.IconRightVisible = true;
            this.btnAutobuses.IconRightZoom = 0D;
            this.btnAutobuses.IconVisible = true;
            this.btnAutobuses.IconZoom = 50D;
            this.btnAutobuses.IsTab = false;
            this.btnAutobuses.Location = new System.Drawing.Point(10, 365);
            this.btnAutobuses.Name = "btnAutobuses";
            this.btnAutobuses.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAutobuses.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnAutobuses.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAutobuses.selected = false;
            this.btnAutobuses.Size = new System.Drawing.Size(213, 51);
            this.btnAutobuses.TabIndex = 6;
            this.btnAutobuses.Text = "        Autobuses";
            this.btnAutobuses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutobuses.Textcolor = System.Drawing.Color.White;
            this.btnAutobuses.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutobuses.Click += new System.EventHandler(this.btnAutobuses_Click);
            // 
            // btnEmpresarios
            // 
            this.btnEmpresarios.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnEmpresarios.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpresarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpresarios.BorderRadius = 7;
            this.btnEmpresarios.ButtonText = "        Empresarios";
            this.btnEmpresarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimaacionSidebarBack.SetDecoration(this.btnEmpresarios, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnEmpresarios, BunifuAnimatorNS.DecorationType.None);
            this.btnEmpresarios.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmpresarios.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmpresarios.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEmpresarios.Iconimage")));
            this.btnEmpresarios.Iconimage_right = null;
            this.btnEmpresarios.Iconimage_right_Selected = null;
            this.btnEmpresarios.Iconimage_Selected = null;
            this.btnEmpresarios.IconMarginLeft = 0;
            this.btnEmpresarios.IconMarginRight = 0;
            this.btnEmpresarios.IconRightVisible = true;
            this.btnEmpresarios.IconRightZoom = 0D;
            this.btnEmpresarios.IconVisible = true;
            this.btnEmpresarios.IconZoom = 50D;
            this.btnEmpresarios.IsTab = false;
            this.btnEmpresarios.Location = new System.Drawing.Point(13, 295);
            this.btnEmpresarios.Name = "btnEmpresarios";
            this.btnEmpresarios.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEmpresarios.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnEmpresarios.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmpresarios.selected = false;
            this.btnEmpresarios.Size = new System.Drawing.Size(210, 51);
            this.btnEmpresarios.TabIndex = 5;
            this.btnEmpresarios.Text = "        Empresarios";
            this.btnEmpresarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpresarios.Textcolor = System.Drawing.Color.White;
            this.btnEmpresarios.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresarios.Click += new System.EventHandler(this.btnEmpresarios_Click);
            // 
            // btnMotoristas
            // 
            this.btnMotoristas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnMotoristas.BackColor = System.Drawing.Color.Transparent;
            this.btnMotoristas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMotoristas.BorderRadius = 7;
            this.btnMotoristas.ButtonText = "        Motoristas";
            this.btnMotoristas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimaacionSidebarBack.SetDecoration(this.btnMotoristas, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnMotoristas, BunifuAnimatorNS.DecorationType.None);
            this.btnMotoristas.DisabledColor = System.Drawing.Color.Gray;
            this.btnMotoristas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMotoristas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMotoristas.Iconimage")));
            this.btnMotoristas.Iconimage_right = null;
            this.btnMotoristas.Iconimage_right_Selected = null;
            this.btnMotoristas.Iconimage_Selected = null;
            this.btnMotoristas.IconMarginLeft = 0;
            this.btnMotoristas.IconMarginRight = 0;
            this.btnMotoristas.IconRightVisible = true;
            this.btnMotoristas.IconRightZoom = 0D;
            this.btnMotoristas.IconVisible = true;
            this.btnMotoristas.IconZoom = 50D;
            this.btnMotoristas.IsTab = false;
            this.btnMotoristas.Location = new System.Drawing.Point(13, 225);
            this.btnMotoristas.Name = "btnMotoristas";
            this.btnMotoristas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMotoristas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnMotoristas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMotoristas.selected = false;
            this.btnMotoristas.Size = new System.Drawing.Size(210, 51);
            this.btnMotoristas.TabIndex = 4;
            this.btnMotoristas.Text = "        Motoristas";
            this.btnMotoristas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMotoristas.Textcolor = System.Drawing.Color.White;
            this.btnMotoristas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnViajes
            // 
            this.btnViajes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnViajes.BackColor = System.Drawing.Color.Transparent;
            this.btnViajes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViajes.BorderRadius = 7;
            this.btnViajes.ButtonText = "        Viajes";
            this.btnViajes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimaacionSidebarBack.SetDecoration(this.btnViajes, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnViajes, BunifuAnimatorNS.DecorationType.None);
            this.btnViajes.DisabledColor = System.Drawing.Color.Gray;
            this.btnViajes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnViajes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnViajes.Iconimage")));
            this.btnViajes.Iconimage_right = null;
            this.btnViajes.Iconimage_right_Selected = null;
            this.btnViajes.Iconimage_Selected = null;
            this.btnViajes.IconMarginLeft = 0;
            this.btnViajes.IconMarginRight = 0;
            this.btnViajes.IconRightVisible = true;
            this.btnViajes.IconRightZoom = 0D;
            this.btnViajes.IconVisible = true;
            this.btnViajes.IconZoom = 50D;
            this.btnViajes.IsTab = false;
            this.btnViajes.Location = new System.Drawing.Point(10, 155);
            this.btnViajes.Name = "btnViajes";
            this.btnViajes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnViajes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnViajes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnViajes.selected = false;
            this.btnViajes.Size = new System.Drawing.Size(213, 51);
            this.btnViajes.TabIndex = 3;
            this.btnViajes.Text = "        Viajes";
            this.btnViajes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViajes.Textcolor = System.Drawing.Color.White;
            this.btnViajes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dashboard1
            // 
            this.dashboard1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.dashboard1.BackColor = System.Drawing.Color.Transparent;
            this.dashboard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboard1.BorderRadius = 7;
            this.dashboard1.ButtonText = "        Dashboard";
            this.dashboard1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimaacionSidebarBack.SetDecoration(this.dashboard1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.dashboard1, BunifuAnimatorNS.DecorationType.None);
            this.dashboard1.DisabledColor = System.Drawing.Color.Gray;
            this.dashboard1.Iconcolor = System.Drawing.Color.Transparent;
            this.dashboard1.Iconimage = ((System.Drawing.Image)(resources.GetObject("dashboard1.Iconimage")));
            this.dashboard1.Iconimage_right = null;
            this.dashboard1.Iconimage_right_Selected = null;
            this.dashboard1.Iconimage_Selected = null;
            this.dashboard1.IconMarginLeft = 0;
            this.dashboard1.IconMarginRight = 0;
            this.dashboard1.IconRightVisible = true;
            this.dashboard1.IconRightZoom = 0D;
            this.dashboard1.IconVisible = true;
            this.dashboard1.IconZoom = 50D;
            this.dashboard1.IsTab = false;
            this.dashboard1.Location = new System.Drawing.Point(13, 85);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Normalcolor = System.Drawing.Color.Transparent;
            this.dashboard1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.dashboard1.OnHoverTextColor = System.Drawing.Color.White;
            this.dashboard1.selected = false;
            this.dashboard1.Size = new System.Drawing.Size(207, 51);
            this.dashboard1.TabIndex = 0;
            this.dashboard1.Text = "        Dashboard";
            this.dashboard1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard1.Textcolor = System.Drawing.Color.White;
            this.dashboard1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimaacionSidebarBack.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(3, 49);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(230, 10);
            this.LineaSidebar.TabIndex = 0;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // Grupo6
            // 
            this.Grupo6.AutoSize = true;
            this.Grupo6.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.Grupo6, BunifuAnimatorNS.DecorationType.None);
            this.AnimaacionSidebarBack.SetDecoration(this.Grupo6, BunifuAnimatorNS.DecorationType.None);
            this.Grupo6.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo6.ForeColor = System.Drawing.Color.White;
            this.Grupo6.Location = new System.Drawing.Point(66, 13);
            this.Grupo6.Name = "Grupo6";
            this.Grupo6.Size = new System.Drawing.Size(73, 20);
            this.Grupo6.TabIndex = 2;
            this.Grupo6.Text = "Grupo 6";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimaacionSidebarBack.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AnimaacionSidebarBack.SetDecoration(this.panelContenedor, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.panelContenedor, BunifuAnimatorNS.DecorationType.None);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 78);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(950, 822);
            this.panelContenedor.TabIndex = 1;
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this.Sidebar;
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimacionSidebar.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.AnimacionSidebar.DefaultAnimation = animation1;
            // 
            // AnimaacionSidebarBack
            // 
            this.AnimaacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimaacionSidebarBack.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.AnimaacionSidebarBack.DefaultAnimation = animation2;
            // 
            // MoverDhasboard
            // 
            this.MoverDhasboard.Fixed = true;
            this.MoverDhasboard.Horizontal = true;
            this.MoverDhasboard.TargetControl = this.ManuTop;
            this.MoverDhasboard.Vertical = true;
            // 
            // ColapzarUsuario
            // 
            this.ColapzarUsuario.Interval = 10;
            this.ColapzarUsuario.Tick += new System.EventHandler(this.ColapzarUsuario_Tick);
            // 
            // DiseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.ManuTop);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimaacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiseForm";
            this.ManuTop.ResumeLayout(false);
            this.ManuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            this.PanelUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ManuTop;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox maximizar;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.Label dashboard;
        private System.Windows.Forms.PictureBox MenuSidebar;
        private System.Windows.Forms.Panel SidebarWrapper;
        private System.Windows.Forms.Panel panelContenedor;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuFlatButton btnLugares;
        private Bunifu.Framework.UI.BunifuFlatButton btnAutobuses;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmpresarios;
        private Bunifu.Framework.UI.BunifuFlatButton btnMotoristas;
        private Bunifu.Framework.UI.BunifuFlatButton btnViajes;
        private Bunifu.Framework.UI.BunifuFlatButton dashboard1;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Label Grupo6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimaacionSidebarBack;
        private Bunifu.Framework.UI.BunifuDragControl MoverDhasboard;
        private Bunifu.Framework.UI.BunifuFlatButton EliminarCuenta;
        private Bunifu.Framework.UI.BunifuFlatButton ConfigurarPerfil;
        private Bunifu.Framework.UI.BunifuFlatButton btnUsuario;
        private System.Windows.Forms.Timer ColapzarUsuario;
        private System.Windows.Forms.Panel PanelUsuario;
        private Bunifu.Framework.UI.BunifuFlatButton btnReportes;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button cerrarSesion;
    }
}