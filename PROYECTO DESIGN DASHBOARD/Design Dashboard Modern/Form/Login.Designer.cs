namespace Design_Dashboard_Modern
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblLogin = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chCuenta2 = new System.Windows.Forms.CheckBox();
            this.tbEmpresaDetalle = new System.Windows.Forms.TextBox();
            this.chCuenta1 = new System.Windows.Forms.CheckBox();
            this.lblUsuario = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Gadugi", 24F);
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblLogin.Location = new System.Drawing.Point(379, 11);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(111, 39);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "LOGIN";
            // 
            // pbClose
            // 
            this.pbClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbClose.BackgroundImage")));
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbClose.Location = new System.Drawing.Point(675, 0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(47, 47);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbClose.TabIndex = 3;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIngresar.CausesValidation = false;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnIngresar.Location = new System.Drawing.Point(269, 220);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(337, 27);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.TabStop = false;
            this.btnIngresar.Text = "ACCEDER";
            this.btnIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIngresar.UseMnemonic = false;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRegistrarse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRegistrarse.Location = new System.Drawing.Point(269, 255);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(337, 27);
            this.btnRegistrarse.TabIndex = 5;
            this.btnRegistrarse.Text = "REGISTRARSE";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.Registrarse_Click);
            // 
            // tbUsuario
            // 
            this.tbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.tbUsuario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbUsuario.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbUsuario.Location = new System.Drawing.Point(363, 83);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(265, 18);
            this.tbUsuario.TabIndex = 6;
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.tbPass.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbPass.Location = new System.Drawing.Point(363, 113);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(265, 18);
            this.tbPass.TabIndex = 7;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 294);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(0, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 152);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // chCuenta2
            // 
            this.chCuenta2.AutoSize = true;
            this.chCuenta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.chCuenta2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.chCuenta2.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.chCuenta2.Location = new System.Drawing.Point(504, 154);
            this.chCuenta2.Name = "chCuenta2";
            this.chCuenta2.Size = new System.Drawing.Size(124, 16);
            this.chCuenta2.TabIndex = 29;
            this.chCuenta2.Text = "COMERCIO  FABRICA";
            this.chCuenta2.UseVisualStyleBackColor = true;
            this.chCuenta2.CheckedChanged += new System.EventHandler(this.chCuenta2_CheckedChanged);
            // 
            // tbEmpresaDetalle
            // 
            this.tbEmpresaDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tbEmpresaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmpresaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbEmpresaDetalle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbEmpresaDetalle.Location = new System.Drawing.Point(238, 152);
            this.tbEmpresaDetalle.Multiline = true;
            this.tbEmpresaDetalle.Name = "tbEmpresaDetalle";
            this.tbEmpresaDetalle.ReadOnly = true;
            this.tbEmpresaDetalle.Size = new System.Drawing.Size(111, 18);
            this.tbEmpresaDetalle.TabIndex = 28;
            this.tbEmpresaDetalle.Text = "Seleccionar Cuenta:";
            // 
            // chCuenta1
            // 
            this.chCuenta1.AutoSize = true;
            this.chCuenta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.chCuenta1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.chCuenta1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chCuenta1.Location = new System.Drawing.Point(363, 154);
            this.chCuenta1.Name = "chCuenta1";
            this.chCuenta1.Size = new System.Drawing.Size(102, 16);
            this.chCuenta1.TabIndex = 27;
            this.chCuenta1.Text = "COMERCIO  WEB";
            this.chCuenta1.UseVisualStyleBackColor = true;
            this.chCuenta1.CheckedChanged += new System.EventHandler(this.chCuenta1_CheckedChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblUsuario.Location = new System.Drawing.Point(238, 81);
            this.lblUsuario.Multiline = true;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.ReadOnly = true;
            this.lblUsuario.Size = new System.Drawing.Size(70, 18);
            this.lblUsuario.TabIndex = 30;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblClave
            // 
            this.lblClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.lblClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblClave.Location = new System.Drawing.Point(238, 113);
            this.lblClave.Multiline = true;
            this.lblClave.Name = "lblClave";
            this.lblClave.ReadOnly = true;
            this.lblClave.Size = new System.Drawing.Size(70, 18);
            this.lblClave.TabIndex = 31;
            this.lblClave.Text = "Contraseña:";
            // 
            // Login
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(722, 294);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.chCuenta2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbEmpresaDetalle);
            this.Controls.Add(this.chCuenta1);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.lblLogin);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Black;
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chCuenta2;
        private System.Windows.Forms.TextBox tbEmpresaDetalle;
        private System.Windows.Forms.CheckBox chCuenta1;
        private System.Windows.Forms.TextBox lblUsuario;
        private System.Windows.Forms.TextBox lblClave;
    }
}