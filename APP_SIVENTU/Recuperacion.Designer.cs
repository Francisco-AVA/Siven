
namespace APP_SIVENTU
{
    partial class Recuperacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recuperacion));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btsalirrecu = new System.Windows.Forms.PictureBox();
            this.olvidocontra = new System.Windows.Forms.Label();
            this.txtcorreo_recuperacion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btrecuperar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btsalirrecu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.btsalirrecu);
            this.panel2.Controls.Add(this.olvidocontra);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 40);
            this.panel2.TabIndex = 2;
            // 
            // btsalirrecu
            // 
            this.btsalirrecu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsalirrecu.Image = ((System.Drawing.Image)(resources.GetObject("btsalirrecu.Image")));
            this.btsalirrecu.Location = new System.Drawing.Point(399, 5);
            this.btsalirrecu.Name = "btsalirrecu";
            this.btsalirrecu.Size = new System.Drawing.Size(30, 30);
            this.btsalirrecu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btsalirrecu.TabIndex = 9;
            this.btsalirrecu.TabStop = false;
            this.btsalirrecu.Click += new System.EventHandler(this.btsalirrecu_Click);
            // 
            // olvidocontra
            // 
            this.olvidocontra.AutoSize = true;
            this.olvidocontra.BackColor = System.Drawing.Color.Transparent;
            this.olvidocontra.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvidocontra.ForeColor = System.Drawing.Color.White;
            this.olvidocontra.Location = new System.Drawing.Point(118, 10);
            this.olvidocontra.Name = "olvidocontra";
            this.olvidocontra.Size = new System.Drawing.Size(215, 24);
            this.olvidocontra.TabIndex = 8;
            this.olvidocontra.Text = "¿Olvidó su contraseña?";
            // 
            // txtcorreo_recuperacion
            // 
            this.txtcorreo_recuperacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcorreo_recuperacion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcorreo_recuperacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcorreo_recuperacion.HintForeColor = System.Drawing.Color.Empty;
            this.txtcorreo_recuperacion.HintText = "Ingrese su correo";
            this.txtcorreo_recuperacion.isPassword = false;
            this.txtcorreo_recuperacion.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.txtcorreo_recuperacion.LineIdleColor = System.Drawing.SystemColors.InfoText;
            this.txtcorreo_recuperacion.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.txtcorreo_recuperacion.LineThickness = 3;
            this.txtcorreo_recuperacion.Location = new System.Drawing.Point(31, 106);
            this.txtcorreo_recuperacion.Name = "txtcorreo_recuperacion";
            this.txtcorreo_recuperacion.Size = new System.Drawing.Size(375, 36);
            this.txtcorreo_recuperacion.TabIndex = 4;
            this.txtcorreo_recuperacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Para recuperarla ingrese su correo por favor.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.btrecuperar.ButtonText = "Recuperar";
            this.btrecuperar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrecuperar.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btrecuperar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btrecuperar.IdleBorderThickness = 1;
            this.btrecuperar.IdleCornerRadius = 20;
            this.btrecuperar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btrecuperar.IdleForecolor = System.Drawing.Color.White;
            this.btrecuperar.IdleLineColor = System.Drawing.Color.Transparent;
            this.btrecuperar.Location = new System.Drawing.Point(123, 159);
            this.btrecuperar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btrecuperar.Name = "btrecuperar";
            this.btrecuperar.Size = new System.Drawing.Size(181, 53);
            this.btrecuperar.TabIndex = 10;
            this.btrecuperar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btrecuperar.Click += new System.EventHandler(this.btrecuperar_Click);
            // 
            // Recuperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(194)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(445, 225);
            this.Controls.Add(this.btrecuperar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcorreo_recuperacion);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Recuperacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperacion";
            this.Load += new System.EventHandler(this.Recuperacion_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btsalirrecu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcorreo_recuperacion;
        private System.Windows.Forms.Label olvidocontra;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btrecuperar;
        private System.Windows.Forms.PictureBox btsalirrecu;
    }
}