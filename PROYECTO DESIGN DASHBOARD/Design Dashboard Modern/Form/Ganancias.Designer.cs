namespace Design_Dashboard_Modern
{
    partial class Ganancias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ganancias));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.chGanancias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvEstadisticas = new System.Windows.Forms.DataGridView();
            this.tcDoc = new System.Windows.Forms.TabControl();
            this.tcGanancias = new System.Windows.Forms.TabPage();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.Estadisticas = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chGanancias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticas)).BeginInit();
            this.tcDoc.SuspendLayout();
            this.tcGanancias.SuspendLayout();
            this.Estadisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbFiltro
            // 
            this.cbFiltro.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cbFiltro.AllowDrop = true;
            this.cbFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbFiltro.BackColor = System.Drawing.Color.White;
            this.cbFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFiltro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbFiltro.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028"});
            this.cbFiltro.Location = new System.Drawing.Point(101, 66);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(263, 21);
            this.cbFiltro.TabIndex = 26;
            this.cbFiltro.TabStop = false;
            this.cbFiltro.Text = "INGRESAR AÑO";
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // pbSave
            // 
            this.pbSave.ErrorImage = null;
            this.pbSave.Image = ((System.Drawing.Image)(resources.GetObject("pbSave.Image")));
            this.pbSave.Location = new System.Drawing.Point(852, 6);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(30, 30);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSave.TabIndex = 21;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // chGanancias
            // 
            this.chGanancias.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.chGanancias.BackColor = System.Drawing.Color.Transparent;
            this.chGanancias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chGanancias.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chGanancias.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chGanancias.BorderlineWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.chGanancias.ChartAreas.Add(chartArea2);
            this.chGanancias.ImeMode = System.Windows.Forms.ImeMode.On;
            this.chGanancias.Location = new System.Drawing.Point(0, 93);
            this.chGanancias.Name = "chGanancias";
            this.chGanancias.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chGanancias.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.MediumSpringGreen};
            series2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series2.ChartArea = "ChartArea1";
            series2.CustomProperties = "PixelPointWidth=50, DrawSideBySide=True, DrawingStyle=Cylinder, MinPixelPointWidt" +
    "h=50, PointWidth=1, LabelStyle=Top, MaxPixelPointWidth=50";
            series2.EmptyPointStyle.CustomProperties = "LabelStyle=Center";
            series2.IsVisibleInLegend = false;
            series2.MarkerBorderColor = System.Drawing.Color.White;
            series2.MarkerBorderWidth = 2;
            series2.Name = "Serie1";
            series2.ShadowOffset = 5;
            series2.YValuesPerPoint = 2;
            this.chGanancias.Series.Add(series2);
            this.chGanancias.Size = new System.Drawing.Size(872, 479);
            this.chGanancias.TabIndex = 0;
            this.chGanancias.Text = "chart1";
            this.chGanancias.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            // 
            // dgvEstadisticas
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvEstadisticas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEstadisticas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvEstadisticas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstadisticas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.dgvEstadisticas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstadisticas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstadisticas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEstadisticas.ColumnHeadersHeight = 22;
            this.dgvEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEstadisticas.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstadisticas.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEstadisticas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEstadisticas.Enabled = false;
            this.dgvEstadisticas.GridColor = System.Drawing.Color.White;
            this.dgvEstadisticas.Location = new System.Drawing.Point(30, 87);
            this.dgvEstadisticas.Margin = new System.Windows.Forms.Padding(5);
            this.dgvEstadisticas.MultiSelect = false;
            this.dgvEstadisticas.Name = "dgvEstadisticas";
            this.dgvEstadisticas.ReadOnly = true;
            this.dgvEstadisticas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstadisticas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEstadisticas.RowHeadersVisible = false;
            this.dgvEstadisticas.RowHeadersWidth = 150;
            this.dgvEstadisticas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEstadisticas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvEstadisticas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvEstadisticas.Size = new System.Drawing.Size(824, 377);
            this.dgvEstadisticas.TabIndex = 27;
            // 
            // tcDoc
            // 
            this.tcDoc.Controls.Add(this.tcGanancias);
            this.tcDoc.Controls.Add(this.Estadisticas);
            this.tcDoc.Location = new System.Drawing.Point(12, 12);
            this.tcDoc.Name = "tcDoc";
            this.tcDoc.SelectedIndex = 0;
            this.tcDoc.Size = new System.Drawing.Size(896, 604);
            this.tcDoc.TabIndex = 28;
            // 
            // tcGanancias
            // 
            this.tcGanancias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.tcGanancias.Controls.Add(this.lblConsultar);
            this.tcGanancias.Controls.Add(this.chGanancias);
            this.tcGanancias.Controls.Add(this.pbSave);
            this.tcGanancias.Controls.Add(this.cbFiltro);
            this.tcGanancias.Location = new System.Drawing.Point(4, 22);
            this.tcGanancias.Name = "tcGanancias";
            this.tcGanancias.Padding = new System.Windows.Forms.Padding(3);
            this.tcGanancias.Size = new System.Drawing.Size(888, 578);
            this.tcGanancias.TabIndex = 1;
            this.tcGanancias.Text = "Ganancias";
            // 
            // lblConsultar
            // 
            this.lblConsultar.BackColor = System.Drawing.Color.Transparent;
            this.lblConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultar.ForeColor = System.Drawing.Color.White;
            this.lblConsultar.Location = new System.Drawing.Point(25, 16);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(186, 25);
            this.lblConsultar.TabIndex = 27;
            this.lblConsultar.Text = "Ganancias";
            // 
            // Estadisticas
            // 
            this.Estadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Estadisticas.Controls.Add(this.label1);
            this.Estadisticas.Controls.Add(this.dgvEstadisticas);
            this.Estadisticas.Location = new System.Drawing.Point(4, 22);
            this.Estadisticas.Name = "Estadisticas";
            this.Estadisticas.Padding = new System.Windows.Forms.Padding(3);
            this.Estadisticas.Size = new System.Drawing.Size(888, 578);
            this.Estadisticas.TabIndex = 0;
            this.Estadisticas.Text = "Estadisticas";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Estadisticas";
            // 
            // Ganancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(920, 628);
            this.Controls.Add(this.tcDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ganancias";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chGanancias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticas)).EndInit();
            this.tcDoc.ResumeLayout(false);
            this.tcGanancias.ResumeLayout(false);
            this.Estadisticas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.DataVisualization.Charting.Chart chGanancias;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.DataGridView dgvEstadisticas;
        private System.Windows.Forms.TabControl tcDoc;
        private System.Windows.Forms.TabPage tcGanancias;
        private System.Windows.Forms.TabPage Estadisticas;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.Label label1;
    }
}