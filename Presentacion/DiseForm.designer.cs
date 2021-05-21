namespace Presentacion
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
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiseForm));
            this.ManuTop = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.dashboard = new System.Windows.Forms.Label();
            this.MenuSidebar = new System.Windows.Forms.PictureBox();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.PanelUsuario = new System.Windows.Forms.Panel();
            this.EliminarCuenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Usuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ConfigurarPerfil = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Ganancias = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Proveedor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Clientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Compras = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Ventas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Poductos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dashboard1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.Grupo6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Wrapper = new System.Windows.Forms.Panel();
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
            this.Sidebar.Controls.Add(this.PanelUsuario);
            this.Sidebar.Controls.Add(this.Ganancias);
            this.Sidebar.Controls.Add(this.Proveedor);
            this.Sidebar.Controls.Add(this.Clientes);
            this.Sidebar.Controls.Add(this.Compras);
            this.Sidebar.Controls.Add(this.Ventas);
            this.Sidebar.Controls.Add(this.Poductos);
            this.Sidebar.Controls.Add(this.dashboard1);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.Grupo6);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.AnimaacionSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Sidebar.Location = new System.Drawing.Point(4, 19);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(240, 800);
            this.Sidebar.TabIndex = 0;
            // 
            // PanelUsuario
            // 
            this.PanelUsuario.BackColor = System.Drawing.Color.Transparent;
            this.PanelUsuario.Controls.Add(this.EliminarCuenta);
            this.PanelUsuario.Controls.Add(this.Usuario);
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
            // Usuario
            // 
            this.Usuario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Usuario.BackColor = System.Drawing.Color.Transparent;
            this.Usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Usuario.BorderRadius = 7;
            this.Usuario.ButtonText = "        Usuario";
            this.Usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimaacionSidebarBack.SetDecoration(this.Usuario, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Usuario, BunifuAnimatorNS.DecorationType.None);
            this.Usuario.DisabledColor = System.Drawing.Color.Gray;
            this.Usuario.Iconcolor = System.Drawing.Color.Transparent;
            this.Usuario.Iconimage = ((System.Drawing.Image)(resources.GetObject("Usuario.Iconimage")));
            this.Usuario.Iconimage_right = null;
            this.Usuario.Iconimage_right_Selected = null;
            this.Usuario.Iconimage_Selected = null;
            this.Usuario.IconMarginLeft = 0;
            this.Usuario.IconMarginRight = 0;
            this.Usuario.IconRightVisible = true;
            this.Usuario.IconRightZoom = 0D;
            this.Usuario.IconVisible = true;
            this.Usuario.IconZoom = 50D;
            this.Usuario.IsTab = false;
            this.Usuario.Location = new System.Drawing.Point(7, 3);
            this.Usuario.Name = "Usuario";
            this.Usuario.Normalcolor = System.Drawing.Color.Transparent;
            this.Usuario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Usuario.OnHoverTextColor = System.Drawing.Color.White;
            this.Usuario.selected = false;
            this.Usuario.Size = new System.Drawing.Size(207, 45);
            this.Usuario.TabIndex = 0;
            this.Usuario.Text = "        Usuario";
            this.Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Usuario.Textcolor = System.Drawing.Color.White;
            this.Usuario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Click += new System.EventHandler(this.Usuario_Click);
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
            // Ganancias
            // 
            this.Ganancias.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Ganancias.BackColor = System.Drawing.Color.Transparent;
            this.Ganancias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ganancias.BorderRadius = 7;
            this.Ganancias.ButtonText = "        Ganancias";
            this.Ganancias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimaacionSidebarBack.SetDecoration(this.Ganancias, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Ganancias, BunifuAnimatorNS.DecorationType.None);
            this.Ganancias.DisabledColor = System.Drawing.Color.Gray;
            this.Ganancias.Iconcolor = System.Drawing.Color.Transparent;
            this.Ganancias.Iconimage = ((System.Drawing.Image)(resources.GetObject("Ganancias.Iconimage")));
            this.Ganancias.Iconimage_right = null;
            this.Ganancias.Iconimage_right_Selected = null;
            this.Ganancias.Iconimage_Selected = null;
            this.Ganancias.IconMarginLeft = 0;
            this.Ganancias.IconMarginRight = 0;
            this.Ganancias.IconRightVisible = true;
            this.Ganancias.IconRightZoom = 0D;
            this.Ganancias.IconVisible = true;
            this.Ganancias.IconZoom = 50D;
            this.Ganancias.IsTab = false;
            this.Ganancias.Location = new System.Drawing.Point(13, 514);
            this.Ganancias.Name = "Ganancias";
            this.Ganancias.Normalcolor = System.Drawing.Color.Transparent;
            this.Ganancias.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Ganancias.OnHoverTextColor = System.Drawing.Color.White;
            this.Ganancias.selected = false;
            this.Ganancias.Size = new System.Drawing.Size(210, 42);
            this.Ganancias.TabIndex = 8;
            this.Ganancias.Text = "        Ganancias";
            this.Ganancias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ganancias.Textcolor = System.Drawing.Color.White;
            this.Ganancias.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Proveedor
            // 
            this.Proveedor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Proveedor.BackColor = System.Drawing.Color.Transparent;
            this.Proveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Proveedor.BorderRadius = 7;
            this.Proveedor.ButtonText = "        Proveedor";
            this.Proveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimaacionSidebarBack.SetDecoration(this.Proveedor, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Proveedor, BunifuAnimatorNS.DecorationType.None);
            this.Proveedor.DisabledColor = System.Drawing.Color.Gray;
            this.Proveedor.Iconcolor = System.Drawing.Color.Transparent;
            this.Proveedor.Iconimage = ((System.Drawing.Image)(resources.GetObject("Proveedor.Iconimage")));
            this.Proveedor.Iconimage_right = null;
            this.Proveedor.Iconimage_right_Selected = null;
            this.Proveedor.Iconimage_Selected = null;
            this.Proveedor.IconMarginLeft = 0;
            this.Proveedor.IconMarginRight = 0;
            this.Proveedor.IconRightVisible = true;
            this.Proveedor.IconRightZoom = 0D;
            this.Proveedor.IconVisible = true;
            this.Proveedor.IconZoom = 50D;
            this.Proveedor.IsTab = false;
            this.Proveedor.Location = new System.Drawing.Point(13, 435);
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Normalcolor = System.Drawing.Color.Transparent;
            this.Proveedor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Proveedor.OnHoverTextColor = System.Drawing.Color.White;
            this.Proveedor.selected = false;
            this.Proveedor.Size = new System.Drawing.Size(210, 51);
            this.Proveedor.TabIndex = 7;
            this.Proveedor.Text = "        Proveedor";
            this.Proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Proveedor.Textcolor = System.Drawing.Color.White;
            this.Proveedor.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Clientes
            // 
            this.Clientes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Clientes.BackColor = System.Drawing.Color.Transparent;
            this.Clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Clientes.BorderRadius = 7;
            this.Clientes.ButtonText = "        Clientes";
            this.Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimaacionSidebarBack.SetDecoration(this.Clientes, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Clientes, BunifuAnimatorNS.DecorationType.None);
            this.Clientes.DisabledColor = System.Drawing.Color.Gray;
            this.Clientes.Iconcolor = System.Drawing.Color.Transparent;
            this.Clientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("Clientes.Iconimage")));
            this.Clientes.Iconimage_right = null;
            this.Clientes.Iconimage_right_Selected = null;
            this.Clientes.Iconimage_Selected = null;
            this.Clientes.IconMarginLeft = 0;
            this.Clientes.IconMarginRight = 0;
            this.Clientes.IconRightVisible = true;
            this.Clientes.IconRightZoom = 0D;
            this.Clientes.IconVisible = true;
            this.Clientes.IconZoom = 50D;
            this.Clientes.IsTab = false;
            this.Clientes.Location = new System.Drawing.Point(10, 365);
            this.Clientes.Name = "Clientes";
            this.Clientes.Normalcolor = System.Drawing.Color.Transparent;
            this.Clientes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Clientes.OnHoverTextColor = System.Drawing.Color.White;
            this.Clientes.selected = false;
            this.Clientes.Size = new System.Drawing.Size(213, 51);
            this.Clientes.TabIndex = 6;
            this.Clientes.Text = "        Clientes";
            this.Clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clientes.Textcolor = System.Drawing.Color.White;
            this.Clientes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Compras
            // 
            this.Compras.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Compras.BackColor = System.Drawing.Color.Transparent;
            this.Compras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Compras.BorderRadius = 7;
            this.Compras.ButtonText = "        Compras";
            this.Compras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimaacionSidebarBack.SetDecoration(this.Compras, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Compras, BunifuAnimatorNS.DecorationType.None);
            this.Compras.DisabledColor = System.Drawing.Color.Gray;
            this.Compras.Iconcolor = System.Drawing.Color.Transparent;
            this.Compras.Iconimage = ((System.Drawing.Image)(resources.GetObject("Compras.Iconimage")));
            this.Compras.Iconimage_right = null;
            this.Compras.Iconimage_right_Selected = null;
            this.Compras.Iconimage_Selected = null;
            this.Compras.IconMarginLeft = 0;
            this.Compras.IconMarginRight = 0;
            this.Compras.IconRightVisible = true;
            this.Compras.IconRightZoom = 0D;
            this.Compras.IconVisible = true;
            this.Compras.IconZoom = 50D;
            this.Compras.IsTab = false;
            this.Compras.Location = new System.Drawing.Point(13, 295);
            this.Compras.Name = "Compras";
            this.Compras.Normalcolor = System.Drawing.Color.Transparent;
            this.Compras.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Compras.OnHoverTextColor = System.Drawing.Color.White;
            this.Compras.selected = false;
            this.Compras.Size = new System.Drawing.Size(210, 51);
            this.Compras.TabIndex = 5;
            this.Compras.Text = "        Compras";
            this.Compras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Compras.Textcolor = System.Drawing.Color.White;
            this.Compras.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Ventas
            // 
            this.Ventas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Ventas.BackColor = System.Drawing.Color.Transparent;
            this.Ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ventas.BorderRadius = 7;
            this.Ventas.ButtonText = "        Ventas";
            this.Ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimaacionSidebarBack.SetDecoration(this.Ventas, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Ventas, BunifuAnimatorNS.DecorationType.None);
            this.Ventas.DisabledColor = System.Drawing.Color.Gray;
            this.Ventas.Iconcolor = System.Drawing.Color.Transparent;
            this.Ventas.Iconimage = ((System.Drawing.Image)(resources.GetObject("Ventas.Iconimage")));
            this.Ventas.Iconimage_right = null;
            this.Ventas.Iconimage_right_Selected = null;
            this.Ventas.Iconimage_Selected = null;
            this.Ventas.IconMarginLeft = 0;
            this.Ventas.IconMarginRight = 0;
            this.Ventas.IconRightVisible = true;
            this.Ventas.IconRightZoom = 0D;
            this.Ventas.IconVisible = true;
            this.Ventas.IconZoom = 50D;
            this.Ventas.IsTab = false;
            this.Ventas.Location = new System.Drawing.Point(13, 225);
            this.Ventas.Name = "Ventas";
            this.Ventas.Normalcolor = System.Drawing.Color.Transparent;
            this.Ventas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Ventas.OnHoverTextColor = System.Drawing.Color.White;
            this.Ventas.selected = false;
            this.Ventas.Size = new System.Drawing.Size(210, 51);
            this.Ventas.TabIndex = 4;
            this.Ventas.Text = "        Ventas";
            this.Ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ventas.Textcolor = System.Drawing.Color.White;
            this.Ventas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Poductos
            // 
            this.Poductos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Poductos.BackColor = System.Drawing.Color.Transparent;
            this.Poductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Poductos.BorderRadius = 7;
            this.Poductos.ButtonText = "        Poductos";
            this.Poductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimaacionSidebarBack.SetDecoration(this.Poductos, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Poductos, BunifuAnimatorNS.DecorationType.None);
            this.Poductos.DisabledColor = System.Drawing.Color.Gray;
            this.Poductos.Iconcolor = System.Drawing.Color.Transparent;
            this.Poductos.Iconimage = ((System.Drawing.Image)(resources.GetObject("Poductos.Iconimage")));
            this.Poductos.Iconimage_right = null;
            this.Poductos.Iconimage_right_Selected = null;
            this.Poductos.Iconimage_Selected = null;
            this.Poductos.IconMarginLeft = 0;
            this.Poductos.IconMarginRight = 0;
            this.Poductos.IconRightVisible = true;
            this.Poductos.IconRightZoom = 0D;
            this.Poductos.IconVisible = true;
            this.Poductos.IconZoom = 50D;
            this.Poductos.IsTab = false;
            this.Poductos.Location = new System.Drawing.Point(10, 155);
            this.Poductos.Name = "Poductos";
            this.Poductos.Normalcolor = System.Drawing.Color.Transparent;
            this.Poductos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Poductos.OnHoverTextColor = System.Drawing.Color.White;
            this.Poductos.selected = false;
            this.Poductos.Size = new System.Drawing.Size(213, 51);
            this.Poductos.TabIndex = 3;
            this.Poductos.Text = "        Poductos";
            this.Poductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Poductos.Textcolor = System.Drawing.Color.White;
            this.Poductos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AnimaacionSidebarBack.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(250, 78);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(950, 822);
            this.Wrapper.TabIndex = 1;
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
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 1;
            animation4.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 2F;
            animation4.TransparencyCoeff = 0F;
            this.AnimacionSidebar.DefaultAnimation = animation4;
            // 
            // AnimaacionSidebarBack
            // 
            this.AnimaacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimaacionSidebarBack.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.AnimaacionSidebarBack.DefaultAnimation = animation3;
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
            this.Controls.Add(this.Wrapper);
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
        private System.Windows.Forms.Panel Wrapper;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuFlatButton Ganancias;
        private Bunifu.Framework.UI.BunifuFlatButton Proveedor;
        private Bunifu.Framework.UI.BunifuFlatButton Clientes;
        private Bunifu.Framework.UI.BunifuFlatButton Compras;
        private Bunifu.Framework.UI.BunifuFlatButton Ventas;
        private Bunifu.Framework.UI.BunifuFlatButton Poductos;
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
        private Bunifu.Framework.UI.BunifuFlatButton Usuario;
        private System.Windows.Forms.Timer ColapzarUsuario;
        private System.Windows.Forms.Panel PanelUsuario;
    }
}