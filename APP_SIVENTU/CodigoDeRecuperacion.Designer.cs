
namespace APP_SIVENTU
{
    partial class CodigoDeRecuperacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodigoDeRecuperacion));
            this.panel2 = new System.Windows.Forms.Panel();
            this.olvidocontra = new System.Windows.Forms.Label();
            this.btsalirconfir = new System.Windows.Forms.PictureBox();
            this.txtconfirm_num = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btrecuperar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btsalirconfir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.olvidocontra);
            this.panel2.Controls.Add(this.btsalirconfir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 49);
            this.panel2.TabIndex = 3;
            // 
            // olvidocontra
            // 
            this.olvidocontra.AutoSize = true;
            this.olvidocontra.BackColor = System.Drawing.Color.Transparent;
            this.olvidocontra.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvidocontra.ForeColor = System.Drawing.Color.White;
            this.olvidocontra.Location = new System.Drawing.Point(106, 9);
            this.olvidocontra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.olvidocontra.Name = "olvidocontra";
            this.olvidocontra.Size = new System.Drawing.Size(284, 31);
            this.olvidocontra.TabIndex = 11;
            this.olvidocontra.Text = "¿Olvidó su contraseña?";
            // 
            // btsalirconfir
            // 
            this.btsalirconfir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsalirconfir.Image = ((System.Drawing.Image)(resources.GetObject("btsalirconfir.Image")));
            this.btsalirconfir.Location = new System.Drawing.Point(436, 8);
            this.btsalirconfir.Margin = new System.Windows.Forms.Padding(4);
            this.btsalirconfir.Name = "btsalirconfir";
            this.btsalirconfir.Size = new System.Drawing.Size(40, 37);
            this.btsalirconfir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btsalirconfir.TabIndex = 10;
            this.btsalirconfir.TabStop = false;
            this.btsalirconfir.Click += new System.EventHandler(this.btsalirconfir_Click);
            // 
            // txtconfirm_num
            // 
            this.txtconfirm_num.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.txtconfirm_num.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtconfirm_num.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.txtconfirm_num.BorderThickness = 3;
            this.txtconfirm_num.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtconfirm_num.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtconfirm_num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtconfirm_num.isPassword = false;
            this.txtconfirm_num.Location = new System.Drawing.Point(69, 139);
            this.txtconfirm_num.Margin = new System.Windows.Forms.Padding(4);
            this.txtconfirm_num.Name = "txtconfirm_num";
            this.txtconfirm_num.Size = new System.Drawing.Size(370, 44);
            this.txtconfirm_num.TabIndex = 4;
            this.txtconfirm_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                    // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 124);
            this.label1.TabIndex = 11;
            this.label1.Text = "Coloque el código que se le proporciono\r\nen su correo electronico. \r\n\r\n\r\n";
            // 
            // btrecuperar
            // 
            this.btrecuperar.ActiveBorderThickness = 1;
            this.btrecuperar.ActiveCornerRadius = 20;
            this.btrecuperar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.btrecuperar.ActiveForecolor = System.Drawing.Color.White;
            this.btrecuperar.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btrecuperar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(194)))), ((int)(((byte)(192)))));
            this.btrecuperar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btrecuperar.BackgroundImage")));
            this.btrecuperar.ButtonText = "Enviar código";
            this.btrecuperar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrecuperar.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btrecuperar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btrecuperar.IdleBorderThickness = 1;
            this.btrecuperar.IdleCornerRadius = 20;
            this.btrecuperar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btrecuperar.IdleForecolor = System.Drawing.Color.White;
            this.btrecuperar.IdleLineColor = System.Drawing.Color.Transparent;
            this.btrecuperar.Location = new System.Drawing.Point(127, 190);
            this.btrecuperar.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btrecuperar.Name = "btrecuperar";
            this.btrecuperar.Size = new System.Drawing.Size(241, 65);
            this.btrecuperar.TabIndex = 12;
            this.btrecuperar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btrecuperar.Click += new System.EventHandler(this.btrecuperar_Click);
            // 
            // CodigoDeRecuperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(194)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(497, 280);
            this.Controls.Add(this.btrecuperar);
            this.Controls.Add(this.txtconfirm_num);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CodigoDeRecuperacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodigoDeRecuperacion";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btsalirconfir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btsalirconfir;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtconfirm_num;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btrecuperar;
        private System.Windows.Forms.Label olvidocontra;
    }
}