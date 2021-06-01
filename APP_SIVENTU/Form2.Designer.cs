
namespace APP_SIVENTU
{
    partial class InicioDeSeccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioDeSeccion));
            this.panel2 = new System.Windows.Forms.Panel();
            this.botonderegreso = new System.Windows.Forms.PictureBox();
            this.btmini2 = new System.Windows.Forms.PictureBox();
            this.btsalir2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.button_ocultar = new System.Windows.Forms.Button();
            this.button_desactive = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btingreso = new Bunifu.Framework.UI.BunifuThinButton2();
            this.olvidocontra = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtcontra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtnombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonderegreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btmini2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btsalir2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.botonderegreso);
            this.panel2.Controls.Add(this.btmini2);
            this.panel2.Controls.Add(this.btsalir2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 40);
            this.panel2.TabIndex = 1;
            // 
            // botonderegreso
            // 
            this.botonderegreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonderegreso.Image = global::APP_SIVENTU.Properties.Resources.regreso;
            this.botonderegreso.Location = new System.Drawing.Point(20, 5);
            this.botonderegreso.Name = "botonderegreso";
            this.botonderegreso.Size = new System.Drawing.Size(30, 30);
            this.botonderegreso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonderegreso.TabIndex = 2;
            this.botonderegreso.TabStop = false;
            this.botonderegreso.Click += new System.EventHandler(this.botonderegreso_Click);
            // 
            // btmini2
            // 
            this.btmini2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmini2.Image = ((System.Drawing.Image)(resources.GetObject("btmini2.Image")));
            this.btmini2.Location = new System.Drawing.Point(721, 5);
            this.btmini2.Name = "btmini2";
            this.btmini2.Size = new System.Drawing.Size(30, 30);
            this.btmini2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btmini2.TabIndex = 1;
            this.btmini2.TabStop = false;
            this.btmini2.Click += new System.EventHandler(this.BtMini_Click);
            // 
            // btsalir2
            // 
            this.btsalir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsalir2.Image = ((System.Drawing.Image)(resources.GetObject("btsalir2.Image")));
            this.btsalir2.Location = new System.Drawing.Point(766, 5);
            this.btsalir2.Name = "btsalir2";
            this.btsalir2.Size = new System.Drawing.Size(30, 30);
            this.btsalir2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btsalir2.TabIndex = 0;
            this.btsalir2.TabStop = false;
            this.btsalir2.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.button_ocultar);
            this.panel3.Controls.Add(this.button_desactive);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.btingreso);
            this.panel3.Controls.Add(this.olvidocontra);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txtcontra);
            this.panel3.Controls.Add(this.txtnombre);
            this.panel3.Controls.Add(this.Label1);
            this.panel3.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(194)))), ((int)(((byte)(192)))));
            this.panel3.GradientBottomRight = System.Drawing.Color.White;
            this.panel3.GradientTopLeft = System.Drawing.Color.White;
            this.panel3.GradientTopRight = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(48, 74);
            this.panel3.Name = "panel3";
            this.panel3.Quality = 10;
            this.panel3.Size = new System.Drawing.Size(703, 467);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button_ocultar
            // 
            this.button_ocultar.FlatAppearance.BorderSize = 0;
            this.button_ocultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ocultar.Image = global::APP_SIVENTU.Properties.Resources.invisible1;
            this.button_ocultar.Location = new System.Drawing.Point(496, 268);
            this.button_ocultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_ocultar.Name = "button_ocultar";
            this.button_ocultar.Size = new System.Drawing.Size(49, 44);
            this.button_ocultar.TabIndex = 13;
            this.button_ocultar.UseVisualStyleBackColor = true;
            this.button_ocultar.Click += new System.EventHandler(this.button_ocultar_Click);
            // 
            // button_desactive
            // 
            this.button_desactive.FlatAppearance.BorderSize = 0;
            this.button_desactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_desactive.Image = global::APP_SIVENTU.Properties.Resources.ojo_visible___copia;
            this.button_desactive.Location = new System.Drawing.Point(496, 268);
            this.button_desactive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_desactive.Name = "button_desactive";
            this.button_desactive.Size = new System.Drawing.Size(49, 44);
            this.button_desactive.TabIndex = 12;
            this.button_desactive.UseVisualStyleBackColor = true;
            this.button_desactive.Click += new System.EventHandler(this.button_desactive_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-7, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // btingreso
            // 
            this.btingreso.ActiveBorderThickness = 1;
            this.btingreso.ActiveCornerRadius = 20;
            this.btingreso.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.btingreso.ActiveForecolor = System.Drawing.Color.White;
            this.btingreso.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btingreso.BackColor = System.Drawing.Color.White;
            this.btingreso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btingreso.BackgroundImage")));
            this.btingreso.ButtonText = "Ingresar";
            this.btingreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btingreso.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btingreso.ForeColor = System.Drawing.Color.SeaGreen;
            this.btingreso.IdleBorderThickness = 1;
            this.btingreso.IdleCornerRadius = 20;
            this.btingreso.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btingreso.IdleForecolor = System.Drawing.Color.White;
            this.btingreso.IdleLineColor = System.Drawing.Color.Transparent;
            this.btingreso.Location = new System.Drawing.Point(251, 380);
            this.btingreso.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btingreso.Name = "btingreso";
            this.btingreso.Size = new System.Drawing.Size(208, 58);
            this.btingreso.TabIndex = 9;
            this.btingreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btingreso.Click += new System.EventHandler(this.btIngreso_Click);
            // 
            // olvidocontra
            // 
            this.olvidocontra.AutoSize = true;
            this.olvidocontra.BackColor = System.Drawing.Color.Transparent;
            this.olvidocontra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.olvidocontra.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvidocontra.Location = new System.Drawing.Point(247, 339);
            this.olvidocontra.Name = "olvidocontra";
            this.olvidocontra.Size = new System.Drawing.Size(215, 24);
            this.olvidocontra.TabIndex = 7;
            this.olvidocontra.Text = "¿Olvido su contraseña?";
            this.olvidocontra.Click += new System.EventHandler(this.olvidocontra_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::APP_SIVENTU.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(299, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtcontra
            // 
            this.txtcontra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcontra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcontra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcontra.HintForeColor = System.Drawing.Color.Empty;
            this.txtcontra.HintText = "Ingrese su contraseña";
            this.txtcontra.isPassword = false;
            this.txtcontra.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.txtcontra.LineIdleColor = System.Drawing.SystemColors.InfoText;
            this.txtcontra.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.txtcontra.LineThickness = 3;
            this.txtcontra.Location = new System.Drawing.Point(175, 268);
            this.txtcontra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(322, 44);
            this.txtcontra.TabIndex = 5;
            this.txtcontra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcontra.OnValueChanged += new System.EventHandler(this.txtcontra_OnValueChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.AccessibleDescription = "";
            this.txtnombre.AccessibleName = "";
            this.txtnombre.BackColor = System.Drawing.Color.White;
            this.txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtnombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtnombre.HintText = "Ingrese su nombre de usuario";
            this.txtnombre.isPassword = false;
            this.txtnombre.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.txtnombre.LineIdleColor = System.Drawing.SystemColors.InfoText;
            this.txtnombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.txtnombre.LineThickness = 3;
            this.txtnombre.Location = new System.Drawing.Point(175, 189);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(370, 44);
            this.txtnombre.TabIndex = 4;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnombre_KeyPress);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(306, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(110, 32);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "LOGIN";
            // 
            // InicioDeSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioDeSeccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.botonderegreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btmini2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btsalir2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btmini2;
        private System.Windows.Forms.PictureBox btsalir2;
        private Bunifu.Framework.UI.BunifuGradientPanel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel Label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtnombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcontra;
        private Bunifu.Framework.UI.BunifuThinButton2 btingreso;
        private System.Windows.Forms.Label olvidocontra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox botonderegreso;
        private System.Windows.Forms.Button button_desactive;
        private System.Windows.Forms.Button button_ocultar;
    }
}