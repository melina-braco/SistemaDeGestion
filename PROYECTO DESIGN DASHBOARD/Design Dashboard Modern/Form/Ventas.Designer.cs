namespace Design_Dashboard_Modern
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMercaderia = new System.Windows.Forms.Panel();
            this.pbIngresar = new System.Windows.Forms.PictureBox();
            this.pbExcel = new System.Windows.Forms.PictureBox();
            this.pbConsulta = new System.Windows.Forms.PictureBox();
            this.pnlAgregar = new System.Windows.Forms.Panel();
            this.pnlAgregarItems = new System.Windows.Forms.Panel();
            this.pbAgregarItemsVenta = new System.Windows.Forms.PictureBox();
            this.tbPrecioU = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.NumericUpDown();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dateFEgresoVta = new System.Windows.Forms.DateTimePicker();
            this.lblSeleccionarArtEditar = new System.Windows.Forms.Label();
            this.cbClienteVta = new System.Windows.Forms.ComboBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.GrillaVentaItems = new System.Windows.Forms.DataGridView();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pnlConsulta = new System.Windows.Forms.Panel();
            this.dgvConsultaVtaItems = new System.Windows.Forms.DataGridView();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.dgvConsultaVta = new System.Windows.Forms.DataGridView();
            this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pnlMercaderia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIngresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsulta)).BeginInit();
            this.pnlAgregar.SuspendLayout();
            this.pnlAgregarItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarItemsVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrecioU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaVentaItems)).BeginInit();
            this.pnlConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVtaItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMercaderia
            // 
            this.pnlMercaderia.Controls.Add(this.pbIngresar);
            this.pnlMercaderia.Controls.Add(this.pbExcel);
            this.pnlMercaderia.Controls.Add(this.pbConsulta);
            this.pnlMercaderia.Controls.Add(this.pnlAgregar);
            this.pnlMercaderia.Controls.Add(this.pnlConsulta);
            this.pnlMercaderia.Location = new System.Drawing.Point(12, 12);
            this.pnlMercaderia.Name = "pnlMercaderia";
            this.pnlMercaderia.Size = new System.Drawing.Size(896, 604);
            this.pnlMercaderia.TabIndex = 3;
            // 
            // pbIngresar
            // 
            this.pbIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbIngresar.BackgroundImage")));
            this.pbIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbIngresar.Location = new System.Drawing.Point(69, 10);
            this.pbIngresar.Name = "pbIngresar";
            this.pbIngresar.Size = new System.Drawing.Size(39, 39);
            this.pbIngresar.TabIndex = 1;
            this.pbIngresar.TabStop = false;
            this.pbIngresar.Tag = "Ingresar";
            this.pbIngresar.Click += new System.EventHandler(this.pbIngresar_Click_1);
            // 
            // pbExcel
            // 
            this.pbExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbExcel.BackgroundImage")));
            this.pbExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbExcel.ErrorImage = null;
            this.pbExcel.InitialImage = null;
            this.pbExcel.Location = new System.Drawing.Point(123, 3);
            this.pbExcel.Name = "pbExcel";
            this.pbExcel.Size = new System.Drawing.Size(45, 49);
            this.pbExcel.TabIndex = 23;
            this.pbExcel.TabStop = false;
            this.pbExcel.Tag = "Importar Excel";
            this.pbExcel.Click += new System.EventHandler(this.pbExcel_Click_1);
            // 
            // pbConsulta
            // 
            this.pbConsulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbConsulta.BackgroundImage")));
            this.pbConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbConsulta.Location = new System.Drawing.Point(15, 10);
            this.pbConsulta.Name = "pbConsulta";
            this.pbConsulta.Size = new System.Drawing.Size(39, 39);
            this.pbConsulta.TabIndex = 0;
            this.pbConsulta.TabStop = false;
            this.pbConsulta.Tag = "Consultar";
            this.pbConsulta.Click += new System.EventHandler(this.pbConsulta_Click_1);
            // 
            // pnlAgregar
            // 
            this.pnlAgregar.Controls.Add(this.pnlAgregarItems);
            this.pnlAgregar.Controls.Add(this.label17);
            this.pnlAgregar.Controls.Add(this.dateFEgresoVta);
            this.pnlAgregar.Controls.Add(this.lblSeleccionarArtEditar);
            this.pnlAgregar.Controls.Add(this.cbClienteVta);
            this.pnlAgregar.Controls.Add(this.btnIngresar);
            this.pnlAgregar.Controls.Add(this.lblAgregar);
            this.pnlAgregar.Controls.Add(this.GrillaVentaItems);
            this.pnlAgregar.Location = new System.Drawing.Point(68, 89);
            this.pnlAgregar.Name = "pnlAgregar";
            this.pnlAgregar.Size = new System.Drawing.Size(825, 512);
            this.pnlAgregar.TabIndex = 5;
            // 
            // pnlAgregarItems
            // 
            this.pnlAgregarItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAgregarItems.Controls.Add(this.pbAgregarItemsVenta);
            this.pnlAgregarItems.Controls.Add(this.tbPrecioU);
            this.pnlAgregarItems.Controls.Add(this.label15);
            this.pnlAgregarItems.Controls.Add(this.tbCantidad);
            this.pnlAgregarItems.Controls.Add(this.cbProducto);
            this.pnlAgregarItems.Controls.Add(this.label5);
            this.pnlAgregarItems.Controls.Add(this.label8);
            this.pnlAgregarItems.Location = new System.Drawing.Point(8, 98);
            this.pnlAgregarItems.Name = "pnlAgregarItems";
            this.pnlAgregarItems.Size = new System.Drawing.Size(764, 58);
            this.pnlAgregarItems.TabIndex = 85;
            // 
            // pbAgregarItemsVenta
            // 
            this.pbAgregarItemsVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAgregarItemsVenta.Image = ((System.Drawing.Image)(resources.GetObject("pbAgregarItemsVenta.Image")));
            this.pbAgregarItemsVenta.Location = new System.Drawing.Point(724, 7);
            this.pbAgregarItemsVenta.Name = "pbAgregarItemsVenta";
            this.pbAgregarItemsVenta.Size = new System.Drawing.Size(30, 30);
            this.pbAgregarItemsVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAgregarItemsVenta.TabIndex = 88;
            this.pbAgregarItemsVenta.TabStop = false;
            this.pbAgregarItemsVenta.Click += new System.EventHandler(this.IngresarVentaItems_Click);
            // 
            // tbPrecioU
            // 
            this.tbPrecioU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tbPrecioU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrecioU.CausesValidation = false;
            this.tbPrecioU.DecimalPlaces = 3;
            this.tbPrecioU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbPrecioU.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbPrecioU.Location = new System.Drawing.Point(609, 13);
            this.tbPrecioU.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.tbPrecioU.Name = "tbPrecioU";
            this.tbPrecioU.Size = new System.Drawing.Size(90, 21);
            this.tbPrecioU.TabIndex = 87;
            this.tbPrecioU.ThousandsSeparator = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label15.Location = new System.Drawing.Point(1, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 18);
            this.label15.TabIndex = 72;
            this.label15.Text = "Ingresar Producto:";
            // 
            // tbCantidad
            // 
            this.tbCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tbCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCantidad.CausesValidation = false;
            this.tbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbCantidad.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbCantidad.Location = new System.Drawing.Point(445, 16);
            this.tbCantidad.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(78, 21);
            this.tbCantidad.TabIndex = 86;
            this.tbCantidad.ThousandsSeparator = true;
            this.tbCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbProducto
            // 
            this.cbProducto.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cbProducto.AllowDrop = true;
            this.cbProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProducto.BackColor = System.Drawing.Color.White;
            this.cbProducto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbProducto.Location = new System.Drawing.Point(141, 12);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(206, 22);
            this.cbProducto.TabIndex = 70;
            this.cbProducto.TabStop = false;
            this.cbProducto.SelectedIndexChanged += new System.EventHandler(this.cbProducto_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(548, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 81;
            this.label5.Text = "Precio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(369, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 18);
            this.label8.TabIndex = 79;
            this.label8.Text = "Cantidad:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label17.Location = new System.Drawing.Point(395, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 18);
            this.label17.TabIndex = 74;
            this.label17.Text = "Fecha de Venta";
            // 
            // dateFEgresoVta
            // 
            this.dateFEgresoVta.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.dateFEgresoVta.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.dateFEgresoVta.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.dateFEgresoVta.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.dateFEgresoVta.Location = new System.Drawing.Point(511, 53);
            this.dateFEgresoVta.Name = "dateFEgresoVta";
            this.dateFEgresoVta.Size = new System.Drawing.Size(252, 20);
            this.dateFEgresoVta.TabIndex = 73;
            // 
            // lblSeleccionarArtEditar
            // 
            this.lblSeleccionarArtEditar.AutoSize = true;
            this.lblSeleccionarArtEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarArtEditar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSeleccionarArtEditar.Location = new System.Drawing.Point(5, 53);
            this.lblSeleccionarArtEditar.Name = "lblSeleccionarArtEditar";
            this.lblSeleccionarArtEditar.Size = new System.Drawing.Size(139, 18);
            this.lblSeleccionarArtEditar.TabIndex = 70;
            this.lblSeleccionarArtEditar.Text = "Seleccionar Cliente:";
            // 
            // cbClienteVta
            // 
            this.cbClienteVta.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cbClienteVta.AllowDrop = true;
            this.cbClienteVta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClienteVta.BackColor = System.Drawing.Color.White;
            this.cbClienteVta.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClienteVta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.cbClienteVta.FormattingEnabled = true;
            this.cbClienteVta.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbClienteVta.Location = new System.Drawing.Point(150, 53);
            this.cbClienteVta.Name = "cbClienteVta";
            this.cbClienteVta.Size = new System.Drawing.Size(206, 22);
            this.cbClienteVta.TabIndex = 69;
            this.cbClienteVta.TabStop = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnIngresar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIngresar.Location = new System.Drawing.Point(308, 478);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(223, 31);
            this.btnIngresar.TabIndex = 52;
            this.btnIngresar.Text = "GUARDAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Visible = false;
            this.btnIngresar.Click += new System.EventHandler(this.IngresarVenta_Click_1);
            // 
            // lblAgregar
            // 
            this.lblAgregar.BackColor = System.Drawing.Color.Transparent;
            this.lblAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregar.ForeColor = System.Drawing.Color.White;
            this.lblAgregar.Location = new System.Drawing.Point(2, 2);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(348, 25);
            this.lblAgregar.TabIndex = 19;
            this.lblAgregar.Text = "Ingresar Nueva Venta";
            // 
            // GrillaVentaItems
            // 
            this.GrillaVentaItems.AllowUserToAddRows = false;
            this.GrillaVentaItems.AllowUserToDeleteRows = false;
            this.GrillaVentaItems.AllowUserToResizeColumns = false;
            this.GrillaVentaItems.AllowUserToResizeRows = false;
            this.GrillaVentaItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaVentaItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.GrillaVentaItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrillaVentaItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.GrillaVentaItems.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrillaVentaItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrillaVentaItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GrillaVentaItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewLinkColumn1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrillaVentaItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrillaVentaItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrillaVentaItems.Location = new System.Drawing.Point(8, 176);
            this.GrillaVentaItems.MultiSelect = false;
            this.GrillaVentaItems.Name = "GrillaVentaItems";
            this.GrillaVentaItems.ReadOnly = true;
            this.GrillaVentaItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GrillaVentaItems.RowHeadersVisible = false;
            this.GrillaVentaItems.RowHeadersWidth = 50;
            this.GrillaVentaItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrillaVentaItems.RowTemplate.ReadOnly = true;
            this.GrillaVentaItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GrillaVentaItems.ShowCellErrors = false;
            this.GrillaVentaItems.ShowCellToolTips = false;
            this.GrillaVentaItems.ShowEditingIcon = false;
            this.GrillaVentaItems.ShowRowErrors = false;
            this.GrillaVentaItems.Size = new System.Drawing.Size(764, 286);
            this.GrillaVentaItems.TabIndex = 22;
            this.GrillaVentaItems.TabStop = false;
            this.GrillaVentaItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaVentaItems_CellContentClick);
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.ActiveLinkColor = System.Drawing.Color.White;
            this.dataGridViewLinkColumn1.HeaderText = "Eliminar";
            this.dataGridViewLinkColumn1.LinkColor = System.Drawing.Color.White;
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.ReadOnly = true;
            this.dataGridViewLinkColumn1.Text = "Eliminar";
            this.dataGridViewLinkColumn1.UseColumnTextForLinkValue = true;
            this.dataGridViewLinkColumn1.VisitedLinkColor = System.Drawing.Color.Silver;
            // 
            // pnlConsulta
            // 
            this.pnlConsulta.Controls.Add(this.dgvConsultaVtaItems);
            this.pnlConsulta.Controls.Add(this.lblConsultar);
            this.pnlConsulta.Controls.Add(this.dgvConsultaVta);
            this.pnlConsulta.Location = new System.Drawing.Point(68, 89);
            this.pnlConsulta.Name = "pnlConsulta";
            this.pnlConsulta.Size = new System.Drawing.Size(825, 515);
            this.pnlConsulta.TabIndex = 5;
            // 
            // dgvConsultaVtaItems
            // 
            this.dgvConsultaVtaItems.AllowUserToAddRows = false;
            this.dgvConsultaVtaItems.AllowUserToDeleteRows = false;
            this.dgvConsultaVtaItems.AllowUserToResizeColumns = false;
            this.dgvConsultaVtaItems.AllowUserToResizeRows = false;
            this.dgvConsultaVtaItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaVtaItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.dgvConsultaVtaItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultaVtaItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaVtaItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConsultaVtaItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultaVtaItems.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvConsultaVtaItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvConsultaVtaItems.Location = new System.Drawing.Point(3, 293);
            this.dgvConsultaVtaItems.MultiSelect = false;
            this.dgvConsultaVtaItems.Name = "dgvConsultaVtaItems";
            this.dgvConsultaVtaItems.ReadOnly = true;
            this.dgvConsultaVtaItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvConsultaVtaItems.RowHeadersVisible = false;
            this.dgvConsultaVtaItems.RowHeadersWidth = 50;
            this.dgvConsultaVtaItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvConsultaVtaItems.ShowCellErrors = false;
            this.dgvConsultaVtaItems.ShowCellToolTips = false;
            this.dgvConsultaVtaItems.ShowEditingIcon = false;
            this.dgvConsultaVtaItems.ShowRowErrors = false;
            this.dgvConsultaVtaItems.Size = new System.Drawing.Size(791, 216);
            this.dgvConsultaVtaItems.TabIndex = 27;
            this.dgvConsultaVtaItems.VirtualMode = true;
            // 
            // lblConsultar
            // 
            this.lblConsultar.BackColor = System.Drawing.Color.Transparent;
            this.lblConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultar.ForeColor = System.Drawing.Color.White;
            this.lblConsultar.Location = new System.Drawing.Point(2, 2);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(348, 25);
            this.lblConsultar.TabIndex = 21;
            this.lblConsultar.Text = "Ventas Realizadas";
            // 
            // dgvConsultaVta
            // 
            this.dgvConsultaVta.AllowUserToAddRows = false;
            this.dgvConsultaVta.AllowUserToDeleteRows = false;
            this.dgvConsultaVta.AllowUserToResizeColumns = false;
            this.dgvConsultaVta.AllowUserToResizeRows = false;
            this.dgvConsultaVta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaVta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.dgvConsultaVta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultaVta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvConsultaVta.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaVta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvConsultaVta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaVta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Link,
            this.Eliminar});
            this.dgvConsultaVta.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultaVta.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvConsultaVta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvConsultaVta.Location = new System.Drawing.Point(8, 41);
            this.dgvConsultaVta.MultiSelect = false;
            this.dgvConsultaVta.Name = "dgvConsultaVta";
            this.dgvConsultaVta.ReadOnly = true;
            this.dgvConsultaVta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvConsultaVta.RowHeadersVisible = false;
            this.dgvConsultaVta.RowHeadersWidth = 50;
            this.dgvConsultaVta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvConsultaVta.ShowCellErrors = false;
            this.dgvConsultaVta.ShowCellToolTips = false;
            this.dgvConsultaVta.ShowEditingIcon = false;
            this.dgvConsultaVta.ShowRowErrors = false;
            this.dgvConsultaVta.Size = new System.Drawing.Size(786, 225);
            this.dgvConsultaVta.TabIndex = 22;
            this.dgvConsultaVta.VirtualMode = true;
            this.dgvConsultaVta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaVenta_CellContentClick);
            // 
            // Link
            // 
            this.Link.ActiveLinkColor = System.Drawing.Color.White;
            this.Link.HeaderText = "Items";
            this.Link.LinkColor = System.Drawing.Color.White;
            this.Link.Name = "Link";
            this.Link.ReadOnly = true;
            this.Link.Text = "Ver Items";
            this.Link.UseColumnTextForLinkValue = true;
            this.Link.VisitedLinkColor = System.Drawing.Color.Silver;
            // 
            // Eliminar
            // 
            this.Eliminar.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.LinkColor = System.Drawing.Color.White;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForLinkValue = true;
            this.Eliminar.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(920, 628);
            this.Controls.Add(this.pnlMercaderia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventas";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.pnlMercaderia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIngresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsulta)).EndInit();
            this.pnlAgregar.ResumeLayout(false);
            this.pnlAgregar.PerformLayout();
            this.pnlAgregarItems.ResumeLayout(false);
            this.pnlAgregarItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarItemsVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrecioU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaVentaItems)).EndInit();
            this.pnlConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVtaItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMercaderia;
        private System.Windows.Forms.PictureBox pbIngresar;
        private System.Windows.Forms.PictureBox pbExcel;
        private System.Windows.Forms.PictureBox pbConsulta;
        private System.Windows.Forms.Panel pnlConsulta;
        private System.Windows.Forms.DataGridView dgvConsultaVta;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.Panel pnlAgregar;
        private System.Windows.Forms.Label label17;
        protected System.Windows.Forms.DateTimePicker dateFEgresoVta;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblSeleccionarArtEditar;
        private System.Windows.Forms.ComboBox cbClienteVta;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView GrillaVentaItems;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn Link;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.Panel pnlAgregarItems;
        private System.Windows.Forms.NumericUpDown tbCantidad;
        private System.Windows.Forms.NumericUpDown tbPrecioU;
        private System.Windows.Forms.PictureBox pbAgregarItemsVenta;
        private System.Windows.Forms.DataGridView dgvConsultaVtaItems;
    }
}