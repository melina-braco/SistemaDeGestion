namespace Design_Dashboard_Modern
{
    partial class Formulario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.GananciasBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.HomeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ProveedoresBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ClientesBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.VentasBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.StockBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DocumentacionBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.RadioPanelChart = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Wrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.MenuTop.Controls.Add(this.pbMinimizar);
            this.MenuTop.Controls.Add(this.Salir);
            this.AnimacionSidebarBack.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1250, 44);
            this.MenuTop.TabIndex = 0;
            // 
            // pbMinimizar
            // 
            this.AnimacionSidebar.SetDecoration(this.pbMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.pbMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(1150, 10);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(32, 32);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizar.TabIndex = 4;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(1192, 10);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(32, 32);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 2;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SidebarWrapper.Controls.Add(this.Sidebar);
            this.AnimacionSidebarBack.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 44);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(298, 666);
            this.SidebarWrapper.TabIndex = 1;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.bunifuFlatButton1);
            this.Sidebar.Controls.Add(this.GananciasBtn);
            this.Sidebar.Controls.Add(this.HomeBtn);
            this.Sidebar.Controls.Add(this.ProveedoresBtn);
            this.Sidebar.Controls.Add(this.ClientesBtn);
            this.Sidebar.Controls.Add(this.VentasBtn);
            this.Sidebar.Controls.Add(this.StockBtn);
            this.Sidebar.Controls.Add(this.DocumentacionBtn);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.lblEmpresa);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.AnimacionSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Sidebar.Location = new System.Drawing.Point(23, 15);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(251, 628);
            this.Sidebar.TabIndex = 0;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "      TESORERIA";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(7, 441);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(232, 37);
            this.bunifuFlatButton1.TabIndex = 15;
            this.bunifuFlatButton1.Text = "      TESORERIA";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // GananciasBtn
            // 
            this.GananciasBtn.Activecolor = System.Drawing.Color.Transparent;
            this.GananciasBtn.BackColor = System.Drawing.Color.Transparent;
            this.GananciasBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GananciasBtn.BorderRadius = 0;
            this.GananciasBtn.ButtonText = "      GANANCIAS";
            this.GananciasBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.GananciasBtn, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.GananciasBtn, BunifuAnimatorNS.DecorationType.None);
            this.GananciasBtn.DisabledColor = System.Drawing.Color.Gray;
            this.GananciasBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.GananciasBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("GananciasBtn.Iconimage")));
            this.GananciasBtn.Iconimage_right = null;
            this.GananciasBtn.Iconimage_right_Selected = null;
            this.GananciasBtn.Iconimage_Selected = null;
            this.GananciasBtn.IconMarginLeft = 0;
            this.GananciasBtn.IconMarginRight = 0;
            this.GananciasBtn.IconRightVisible = true;
            this.GananciasBtn.IconRightZoom = 0D;
            this.GananciasBtn.IconVisible = true;
            this.GananciasBtn.IconZoom = 50D;
            this.GananciasBtn.IsTab = false;
            this.GananciasBtn.Location = new System.Drawing.Point(7, 386);
            this.GananciasBtn.Name = "GananciasBtn";
            this.GananciasBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.GananciasBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.GananciasBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.GananciasBtn.selected = false;
            this.GananciasBtn.Size = new System.Drawing.Size(232, 37);
            this.GananciasBtn.TabIndex = 14;
            this.GananciasBtn.Text = "      GANANCIAS";
            this.GananciasBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GananciasBtn.Textcolor = System.Drawing.Color.LightGray;
            this.GananciasBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.GananciasBtn.Click += new System.EventHandler(this.GananciasBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Activecolor = System.Drawing.Color.Transparent;
            this.HomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeBtn.BorderRadius = 0;
            this.HomeBtn.ButtonText = "      HOME";
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.HomeBtn, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.HomeBtn, BunifuAnimatorNS.DecorationType.None);
            this.HomeBtn.DisabledColor = System.Drawing.Color.Gray;
            this.HomeBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.HomeBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Iconimage")));
            this.HomeBtn.Iconimage_right = null;
            this.HomeBtn.Iconimage_right_Selected = null;
            this.HomeBtn.Iconimage_Selected = null;
            this.HomeBtn.IconMarginLeft = 0;
            this.HomeBtn.IconMarginRight = 0;
            this.HomeBtn.IconRightVisible = true;
            this.HomeBtn.IconRightZoom = 0D;
            this.HomeBtn.IconVisible = true;
            this.HomeBtn.IconZoom = 50D;
            this.HomeBtn.IsTab = false;
            this.HomeBtn.Location = new System.Drawing.Point(7, 100);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.HomeBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.HomeBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.HomeBtn.selected = false;
            this.HomeBtn.Size = new System.Drawing.Size(232, 37);
            this.HomeBtn.TabIndex = 11;
            this.HomeBtn.Text = "      HOME";
            this.HomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.Textcolor = System.Drawing.Color.LightGray;
            this.HomeBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // ProveedoresBtn
            // 
            this.ProveedoresBtn.Activecolor = System.Drawing.Color.Transparent;
            this.ProveedoresBtn.BackColor = System.Drawing.Color.Transparent;
            this.ProveedoresBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProveedoresBtn.BorderRadius = 0;
            this.ProveedoresBtn.ButtonText = "      PROVEEDORES";
            this.ProveedoresBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.ProveedoresBtn, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.ProveedoresBtn, BunifuAnimatorNS.DecorationType.None);
            this.ProveedoresBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ProveedoresBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ProveedoresBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("ProveedoresBtn.Iconimage")));
            this.ProveedoresBtn.Iconimage_right = null;
            this.ProveedoresBtn.Iconimage_right_Selected = null;
            this.ProveedoresBtn.Iconimage_Selected = null;
            this.ProveedoresBtn.IconMarginLeft = 0;
            this.ProveedoresBtn.IconMarginRight = 0;
            this.ProveedoresBtn.IconRightVisible = true;
            this.ProveedoresBtn.IconRightZoom = 0D;
            this.ProveedoresBtn.IconVisible = true;
            this.ProveedoresBtn.IconZoom = 50D;
            this.ProveedoresBtn.IsTab = false;
            this.ProveedoresBtn.Location = new System.Drawing.Point(7, 277);
            this.ProveedoresBtn.Name = "ProveedoresBtn";
            this.ProveedoresBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.ProveedoresBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.ProveedoresBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ProveedoresBtn.selected = false;
            this.ProveedoresBtn.Size = new System.Drawing.Size(232, 37);
            this.ProveedoresBtn.TabIndex = 13;
            this.ProveedoresBtn.Text = "      PROVEEDORES";
            this.ProveedoresBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProveedoresBtn.Textcolor = System.Drawing.Color.LightGray;
            this.ProveedoresBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ProveedoresBtn.Click += new System.EventHandler(this.ProveedoresBtn_Click);
            // 
            // ClientesBtn
            // 
            this.ClientesBtn.Activecolor = System.Drawing.Color.Transparent;
            this.ClientesBtn.BackColor = System.Drawing.Color.Transparent;
            this.ClientesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientesBtn.BorderRadius = 0;
            this.ClientesBtn.ButtonText = "      CLIENTES";
            this.ClientesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.ClientesBtn, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.ClientesBtn, BunifuAnimatorNS.DecorationType.None);
            this.ClientesBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ClientesBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ClientesBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("ClientesBtn.Iconimage")));
            this.ClientesBtn.Iconimage_right = null;
            this.ClientesBtn.Iconimage_right_Selected = null;
            this.ClientesBtn.Iconimage_Selected = null;
            this.ClientesBtn.IconMarginLeft = 0;
            this.ClientesBtn.IconMarginRight = 0;
            this.ClientesBtn.IconRightVisible = true;
            this.ClientesBtn.IconRightZoom = 0D;
            this.ClientesBtn.IconVisible = true;
            this.ClientesBtn.IconZoom = 50D;
            this.ClientesBtn.IsTab = false;
            this.ClientesBtn.Location = new System.Drawing.Point(7, 220);
            this.ClientesBtn.Name = "ClientesBtn";
            this.ClientesBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.ClientesBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.ClientesBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ClientesBtn.selected = false;
            this.ClientesBtn.Size = new System.Drawing.Size(232, 37);
            this.ClientesBtn.TabIndex = 12;
            this.ClientesBtn.Text = "      CLIENTES";
            this.ClientesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientesBtn.Textcolor = System.Drawing.Color.LightGray;
            this.ClientesBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ClientesBtn.Click += new System.EventHandler(this.ClientesBtn_Click);
            // 
            // VentasBtn
            // 
            this.VentasBtn.Activecolor = System.Drawing.Color.Transparent;
            this.VentasBtn.BackColor = System.Drawing.Color.Transparent;
            this.VentasBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VentasBtn.BorderRadius = 0;
            this.VentasBtn.ButtonText = "      VENTAS";
            this.VentasBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.VentasBtn, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.VentasBtn, BunifuAnimatorNS.DecorationType.None);
            this.VentasBtn.DisabledColor = System.Drawing.Color.Gray;
            this.VentasBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.VentasBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("VentasBtn.Iconimage")));
            this.VentasBtn.Iconimage_right = null;
            this.VentasBtn.Iconimage_right_Selected = null;
            this.VentasBtn.Iconimage_Selected = null;
            this.VentasBtn.IconMarginLeft = 0;
            this.VentasBtn.IconMarginRight = 0;
            this.VentasBtn.IconRightVisible = true;
            this.VentasBtn.IconRightZoom = 0D;
            this.VentasBtn.IconVisible = true;
            this.VentasBtn.IconZoom = 50D;
            this.VentasBtn.IsTab = false;
            this.VentasBtn.Location = new System.Drawing.Point(7, 331);
            this.VentasBtn.Name = "VentasBtn";
            this.VentasBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.VentasBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.VentasBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.VentasBtn.selected = false;
            this.VentasBtn.Size = new System.Drawing.Size(232, 37);
            this.VentasBtn.TabIndex = 10;
            this.VentasBtn.Text = "      VENTAS";
            this.VentasBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VentasBtn.Textcolor = System.Drawing.Color.LightGray;
            this.VentasBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.VentasBtn.Click += new System.EventHandler(this.VentasBtn_Click);
            // 
            // StockBtn
            // 
            this.StockBtn.Activecolor = System.Drawing.Color.Transparent;
            this.StockBtn.BackColor = System.Drawing.Color.Transparent;
            this.StockBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StockBtn.BorderRadius = 0;
            this.StockBtn.ButtonText = "      MERCADERIA";
            this.StockBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.StockBtn, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.StockBtn, BunifuAnimatorNS.DecorationType.None);
            this.StockBtn.DisabledColor = System.Drawing.Color.Gray;
            this.StockBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.StockBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("StockBtn.Iconimage")));
            this.StockBtn.Iconimage_right = null;
            this.StockBtn.Iconimage_right_Selected = null;
            this.StockBtn.Iconimage_Selected = null;
            this.StockBtn.IconMarginLeft = 0;
            this.StockBtn.IconMarginRight = 0;
            this.StockBtn.IconRightVisible = true;
            this.StockBtn.IconRightZoom = 0D;
            this.StockBtn.IconVisible = true;
            this.StockBtn.IconZoom = 50D;
            this.StockBtn.IsTab = false;
            this.StockBtn.Location = new System.Drawing.Point(7, 160);
            this.StockBtn.Name = "StockBtn";
            this.StockBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.StockBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.StockBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.StockBtn.selected = false;
            this.StockBtn.Size = new System.Drawing.Size(232, 37);
            this.StockBtn.TabIndex = 9;
            this.StockBtn.Text = "      MERCADERIA";
            this.StockBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StockBtn.Textcolor = System.Drawing.Color.LightGray;
            this.StockBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.StockBtn.Click += new System.EventHandler(this.StockBtn_Click);
            // 
            // DocumentacionBtn
            // 
            this.DocumentacionBtn.Activecolor = System.Drawing.Color.Transparent;
            this.DocumentacionBtn.BackColor = System.Drawing.Color.Transparent;
            this.DocumentacionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DocumentacionBtn.BorderRadius = 0;
            this.DocumentacionBtn.ButtonText = "      DOCUMENTACION";
            this.DocumentacionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.DocumentacionBtn, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.DocumentacionBtn, BunifuAnimatorNS.DecorationType.None);
            this.DocumentacionBtn.DisabledColor = System.Drawing.Color.Gray;
            this.DocumentacionBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.DocumentacionBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("DocumentacionBtn.Iconimage")));
            this.DocumentacionBtn.Iconimage_right = null;
            this.DocumentacionBtn.Iconimage_right_Selected = null;
            this.DocumentacionBtn.Iconimage_Selected = null;
            this.DocumentacionBtn.IconMarginLeft = 0;
            this.DocumentacionBtn.IconMarginRight = 0;
            this.DocumentacionBtn.IconRightVisible = true;
            this.DocumentacionBtn.IconRightZoom = 0D;
            this.DocumentacionBtn.IconVisible = true;
            this.DocumentacionBtn.IconZoom = 50D;
            this.DocumentacionBtn.IsTab = false;
            this.DocumentacionBtn.Location = new System.Drawing.Point(7, 499);
            this.DocumentacionBtn.Name = "DocumentacionBtn";
            this.DocumentacionBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.DocumentacionBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.DocumentacionBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.DocumentacionBtn.selected = false;
            this.DocumentacionBtn.Size = new System.Drawing.Size(232, 37);
            this.DocumentacionBtn.TabIndex = 8;
            this.DocumentacionBtn.Text = "      DOCUMENTACION";
            this.DocumentacionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DocumentacionBtn.Textcolor = System.Drawing.Color.LightGray;
            this.DocumentacionBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DocumentacionBtn.Click += new System.EventHandler(this.DocumentacionBtn_Click);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(0, 72);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(256, 10);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.lblEmpresa, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.lblEmpresa, BunifuAnimatorNS.DecorationType.None);
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.LightGray;
            this.lblEmpresa.Location = new System.Drawing.Point(59, 36);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(161, 18);
            this.lblEmpresa.TabIndex = 6;
            this.lblEmpresa.Text = "OVA.AMOBLAMIENTO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Wrapper.Controls.Add(this.pnlMain);
            this.AnimacionSidebarBack.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(298, 44);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(952, 666);
            this.Wrapper.TabIndex = 2;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.AnimacionSidebarBack.SetDecoration(this.pnlMain, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pnlMain, BunifuAnimatorNS.DecorationType.None);
            this.pnlMain.Location = new System.Drawing.Point(6, 15);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(920, 628);
            this.pnlMain.TabIndex = 0;
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this.Sidebar;
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimacionSidebar.Cursor = null;
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
            this.AnimacionSidebar.DefaultAnimation = animation3;
            this.AnimacionSidebar.TimeStep = 0.2F;
            // 
            // AnimacionSidebarBack
            // 
            this.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.Custom;
            this.AnimacionSidebarBack.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.AnimacionSidebarBack.DefaultAnimation = animation4;
            // 
            // RadioPanelChart
            // 
            this.RadioPanelChart.ElipseRadius = 7;
            this.RadioPanelChart.TargetControl = this;
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            // 
            // MoverDashboard
            // 
            this.MoverDashboard.Fixed = true;
            this.MoverDashboard.Horizontal = true;
            this.MoverDashboard.TargetControl = this.MenuTop;
            this.MoverDashboard.Vertical = true;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 710);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.MenuTop);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MenuTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Wrapper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Panel SidebarWrapper;
        private System.Windows.Forms.Panel Wrapper;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuFlatButton GananciasBtn;
        private Bunifu.Framework.UI.BunifuFlatButton ProveedoresBtn;
        private Bunifu.Framework.UI.BunifuFlatButton ClientesBtn;
        private Bunifu.Framework.UI.BunifuFlatButton HomeBtn;
        private Bunifu.Framework.UI.BunifuFlatButton VentasBtn;
        private Bunifu.Framework.UI.BunifuFlatButton StockBtn;
        private Bunifu.Framework.UI.BunifuFlatButton DocumentacionBtn;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarBack;
        private Bunifu.Framework.UI.BunifuElipse RadioPanelChart;
        private System.Windows.Forms.Timer Temporizador;
        private Bunifu.Framework.UI.BunifuDragControl MoverDashboard;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}

