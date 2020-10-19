namespace Design_Dashboard_Modern
{
    partial class Mensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mensaje));
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.tbMensaje = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImg
            // 
            this.pbImg.BackColor = System.Drawing.Color.Transparent;
            this.pbImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImg.Location = new System.Drawing.Point(130, 10);
            this.pbImg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(65, 64);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImg.TabIndex = 8;
            this.pbImg.TabStop = false;
            // 
            // tbMensaje
            // 
            this.tbMensaje.AutoEllipsis = true;
            this.tbMensaje.BackColor = System.Drawing.Color.Transparent;
            this.tbMensaje.Font = new System.Drawing.Font("Malgun Gothic", 8F);
            this.tbMensaje.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbMensaje.Location = new System.Drawing.Point(1, 78);
            this.tbMensaje.Name = "tbMensaje";
            this.tbMensaje.Size = new System.Drawing.Size(323, 50);
            this.tbMensaje.TabIndex = 0;
            this.tbMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAceptar.CausesValidation = false;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAceptar.Location = new System.Drawing.Point(111, 131);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(106, 27);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAceptar.UseMnemonic = false;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Mensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(326, 169);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbMensaje);
            this.Controls.Add(this.pbImg);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Mensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Label tbMensaje;
        private System.Windows.Forms.Button btnAceptar;
    }
}