namespace Design_Dashboard_Modern
{
    partial class Mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mail));
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.pbMail = new System.Windows.Forms.PictureBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMail)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCerrar
            // 
            this.pbCerrar.BackColor = System.Drawing.Color.Transparent;
            this.pbCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(293, 2);
            this.pbCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(31, 31);
            this.pbCerrar.TabIndex = 0;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.Color.White;
            this.lblMail.Location = new System.Drawing.Point(115, 85);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(93, 17);
            this.lblMail.TabIndex = 33;
            this.lblMail.Text = "Ingresar Mail:";
            // 
            // pbMail
            // 
            this.pbMail.BackColor = System.Drawing.Color.Transparent;
            this.pbMail.Image = ((System.Drawing.Image)(resources.GetObject("pbMail.Image")));
            this.pbMail.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbMail.InitialImage")));
            this.pbMail.Location = new System.Drawing.Point(130, 2);
            this.pbMail.Name = "pbMail";
            this.pbMail.Size = new System.Drawing.Size(64, 64);
            this.pbMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMail.TabIndex = 34;
            this.pbMail.TabStop = false;
            // 
            // tbMail
            // 
            this.tbMail.BackColor = System.Drawing.Color.White;
            this.tbMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.tbMail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbMail.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbMail.Location = new System.Drawing.Point(29, 124);
            this.tbMail.Margin = new System.Windows.Forms.Padding(4);
            this.tbMail.Multiline = true;
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(263, 21);
            this.tbMail.TabIndex = 94;
            this.tbMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEnviar
            // 
            this.btnEnviar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEnviar.CausesValidation = false;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEnviar.Location = new System.Drawing.Point(79, 163);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(165, 27);
            this.btnEnviar.TabIndex = 95;
            this.btnEnviar.TabStop = false;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEnviar.UseMnemonic = false;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(326, 220);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.pbMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.pbCerrar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Mail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.PictureBox pbMail;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Button btnEnviar;
    }
}