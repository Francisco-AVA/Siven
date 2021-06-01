
namespace APP_SIVENTU
{
    partial class FormAyuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAyuda));
            this.panel3 = new System.Windows.Forms.Panel();
            this.payuda2 = new System.Windows.Forms.PictureBox();
            this.payuda = new System.Windows.Forms.PictureBox();
            this.Labelayudatitulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.payuda3 = new System.Windows.Forms.PictureBox();
            this.busqueda = new Bunifu.Framework.UI.BunifuTextbox();
            this.b1ayuda = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bayuda5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bayuda4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bayuda3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bayuda2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bayuda6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payuda2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payuda3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.panel3.Controls.Add(this.payuda2);
            this.panel3.Controls.Add(this.payuda);
            this.panel3.Controls.Add(this.Labelayudatitulo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 47);
            this.panel3.TabIndex = 5;
            // 
            // payuda2
            // 
            this.payuda2.BackColor = System.Drawing.Color.Transparent;
            this.payuda2.Image = global::APP_SIVENTU.Properties.Resources.pregunta;
            this.payuda2.Location = new System.Drawing.Point(123, 2);
            this.payuda2.Name = "payuda2";
            this.payuda2.Size = new System.Drawing.Size(49, 35);
            this.payuda2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.payuda2.TabIndex = 8;
            this.payuda2.TabStop = false;
            // 
            // payuda
            // 
            this.payuda.BackColor = System.Drawing.Color.Transparent;
            this.payuda.Image = global::APP_SIVENTU.Properties.Resources.pregunta;
            this.payuda.Location = new System.Drawing.Point(466, 3);
            this.payuda.Name = "payuda";
            this.payuda.Size = new System.Drawing.Size(49, 35);
            this.payuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.payuda.TabIndex = 7;
            this.payuda.TabStop = false;
            this.payuda.Click += new System.EventHandler(this.payuda_Click);
            // 
            // Labelayudatitulo
            // 
            this.Labelayudatitulo.AutoSize = true;
            this.Labelayudatitulo.BackColor = System.Drawing.Color.Transparent;
            this.Labelayudatitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelayudatitulo.ForeColor = System.Drawing.Color.White;
            this.Labelayudatitulo.Location = new System.Drawing.Point(170, 7);
            this.Labelayudatitulo.Name = "Labelayudatitulo";
            this.Labelayudatitulo.Size = new System.Drawing.Size(299, 32);
            this.Labelayudatitulo.TabIndex = 6;
            this.Labelayudatitulo.Text = "AYUDA DEL SISTEMA";
            // 
            // payuda3
            // 
            this.payuda3.Image = global::APP_SIVENTU.Properties.Resources.logo_removebg_preview;
            this.payuda3.Location = new System.Drawing.Point(10, 54);
            this.payuda3.Name = "payuda3";
            this.payuda3.Size = new System.Drawing.Size(128, 78);
            this.payuda3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.payuda3.TabIndex = 6;
            this.payuda3.TabStop = false;
            // 
            // busqueda
            // 
            this.busqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(194)))), ((int)(((byte)(192)))));
            this.busqueda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("busqueda.BackgroundImage")));
            this.busqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.busqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.busqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
            this.busqueda.Icon = ((System.Drawing.Image)(resources.GetObject("busqueda.Icon")));
            this.busqueda.Location = new System.Drawing.Point(148, 68);
            this.busqueda.Name = "busqueda";
            this.busqueda.Size = new System.Drawing.Size(472, 42);
            this.busqueda.TabIndex = 8;
            this.busqueda.text = "";
            this.busqueda.OnTextChange += new System.EventHandler(this.busqueda_OnTextChange);
            // 
            // b1ayuda
            // 
            this.b1ayuda.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(3)))), ((int)(((byte)(72)))));
            this.b1ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.b1ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b1ayuda.BorderRadius = 0;
            this.b1ayuda.ButtonText = "¿Cómo crear una factura?";
            this.b1ayuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b1ayuda.DisabledColor = System.Drawing.Color.Gray;
            this.b1ayuda.Iconcolor = System.Drawing.Color.Transparent;
            this.b1ayuda.Iconimage = null;
            this.b1ayuda.Iconimage_right = null;
            this.b1ayuda.Iconimage_right_Selected = null;
            this.b1ayuda.Iconimage_Selected = null;
            this.b1ayuda.IconMarginLeft = 0;
            this.b1ayuda.IconMarginRight = 0;
            this.b1ayuda.IconRightVisible = true;
            this.b1ayuda.IconRightZoom = 0D;
            this.b1ayuda.IconVisible = true;
            this.b1ayuda.IconZoom = 90D;
            this.b1ayuda.IsTab = false;
            this.b1ayuda.Location = new System.Drawing.Point(16, 146);
            this.b1ayuda.Name = "b1ayuda";
            this.b1ayuda.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.b1ayuda.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.b1ayuda.OnHoverTextColor = System.Drawing.Color.White;
            this.b1ayuda.selected = false;
            this.b1ayuda.Size = new System.Drawing.Size(299, 48);
            this.b1ayuda.TabIndex = 9;
            this.b1ayuda.Text = "¿Cómo crear una factura?";
            this.b1ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.b1ayuda.Textcolor = System.Drawing.Color.White;
            this.b1ayuda.TextFont = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1ayuda.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bayuda5
            // 
            this.bayuda5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(3)))), ((int)(((byte)(72)))));
            this.bayuda5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.bayuda5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bayuda5.BorderRadius = 0;
            this.bayuda5.ButtonText = "¿Por qué al ingresar datos en los registros, los toma como invalidos?";
            this.bayuda5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bayuda5.DisabledColor = System.Drawing.Color.Gray;
            this.bayuda5.Iconcolor = System.Drawing.Color.Transparent;
            this.bayuda5.Iconimage = null;
            this.bayuda5.Iconimage_right = null;
            this.bayuda5.Iconimage_right_Selected = null;
            this.bayuda5.Iconimage_Selected = null;
            this.bayuda5.IconMarginLeft = 0;
            this.bayuda5.IconMarginRight = 0;
            this.bayuda5.IconRightVisible = true;
            this.bayuda5.IconRightZoom = 0D;
            this.bayuda5.IconVisible = true;
            this.bayuda5.IconZoom = 90D;
            this.bayuda5.IsTab = false;
            this.bayuda5.Location = new System.Drawing.Point(16, 274);
            this.bayuda5.Name = "bayuda5";
            this.bayuda5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.bayuda5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.bayuda5.OnHoverTextColor = System.Drawing.Color.White;
            this.bayuda5.selected = false;
            this.bayuda5.Size = new System.Drawing.Size(604, 48);
            this.bayuda5.TabIndex = 10;
            this.bayuda5.Text = "¿Por qué al ingresar datos en los registros, los toma como invalidos?";
            this.bayuda5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bayuda5.Textcolor = System.Drawing.Color.White;
            this.bayuda5.TextFont = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bayuda5.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bayuda4
            // 
            this.bayuda4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(3)))), ((int)(((byte)(72)))));
            this.bayuda4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.bayuda4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bayuda4.BorderRadius = 0;
            this.bayuda4.ButtonText = "¿Cómo eliminar un producto de una factura?";
            this.bayuda4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bayuda4.DisabledColor = System.Drawing.Color.Gray;
            this.bayuda4.Iconcolor = System.Drawing.Color.Transparent;
            this.bayuda4.Iconimage = null;
            this.bayuda4.Iconimage_right = null;
            this.bayuda4.Iconimage_right_Selected = null;
            this.bayuda4.Iconimage_Selected = null;
            this.bayuda4.IconMarginLeft = 0;
            this.bayuda4.IconMarginRight = 0;
            this.bayuda4.IconRightVisible = true;
            this.bayuda4.IconRightZoom = 0D;
            this.bayuda4.IconVisible = true;
            this.bayuda4.IconZoom = 90D;
            this.bayuda4.IsTab = false;
            this.bayuda4.Location = new System.Drawing.Point(256, 210);
            this.bayuda4.Name = "bayuda4";
            this.bayuda4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.bayuda4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.bayuda4.OnHoverTextColor = System.Drawing.Color.White;
            this.bayuda4.selected = false;
            this.bayuda4.Size = new System.Drawing.Size(364, 48);
            this.bayuda4.TabIndex = 11;
            this.bayuda4.Text = "¿Cómo eliminar un producto de una factura?";
            this.bayuda4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bayuda4.Textcolor = System.Drawing.Color.White;
            this.bayuda4.TextFont = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bayuda4.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bayuda3
            // 
            this.bayuda3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(3)))), ((int)(((byte)(72)))));
            this.bayuda3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.bayuda3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bayuda3.BorderRadius = 0;
            this.bayuda3.ButtonText = "¿Cómo anular registros?";
            this.bayuda3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bayuda3.DisabledColor = System.Drawing.Color.Gray;
            this.bayuda3.Iconcolor = System.Drawing.Color.Transparent;
            this.bayuda3.Iconimage = null;
            this.bayuda3.Iconimage_right = null;
            this.bayuda3.Iconimage_right_Selected = null;
            this.bayuda3.Iconimage_Selected = null;
            this.bayuda3.IconMarginLeft = 0;
            this.bayuda3.IconMarginRight = 0;
            this.bayuda3.IconRightVisible = true;
            this.bayuda3.IconRightZoom = 0D;
            this.bayuda3.IconVisible = true;
            this.bayuda3.IconZoom = 90D;
            this.bayuda3.IsTab = false;
            this.bayuda3.Location = new System.Drawing.Point(16, 210);
            this.bayuda3.Name = "bayuda3";
            this.bayuda3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.bayuda3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.bayuda3.OnHoverTextColor = System.Drawing.Color.White;
            this.bayuda3.selected = false;
            this.bayuda3.Size = new System.Drawing.Size(231, 48);
            this.bayuda3.TabIndex = 12;
            this.bayuda3.Text = "¿Cómo anular registros?";
            this.bayuda3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bayuda3.Textcolor = System.Drawing.Color.White;
            this.bayuda3.TextFont = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bayuda3.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bayuda2
            // 
            this.bayuda2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(3)))), ((int)(((byte)(72)))));
            this.bayuda2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.bayuda2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bayuda2.BorderRadius = 0;
            this.bayuda2.ButtonText = "¿Cómo agregar más registros?";
            this.bayuda2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bayuda2.DisabledColor = System.Drawing.Color.Gray;
            this.bayuda2.Iconcolor = System.Drawing.Color.Transparent;
            this.bayuda2.Iconimage = null;
            this.bayuda2.Iconimage_right = null;
            this.bayuda2.Iconimage_right_Selected = null;
            this.bayuda2.Iconimage_Selected = null;
            this.bayuda2.IconMarginLeft = 0;
            this.bayuda2.IconMarginRight = 0;
            this.bayuda2.IconRightVisible = true;
            this.bayuda2.IconRightZoom = 0D;
            this.bayuda2.IconVisible = true;
            this.bayuda2.IconZoom = 90D;
            this.bayuda2.IsTab = false;
            this.bayuda2.Location = new System.Drawing.Point(321, 146);
            this.bayuda2.Name = "bayuda2";
            this.bayuda2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.bayuda2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.bayuda2.OnHoverTextColor = System.Drawing.Color.White;
            this.bayuda2.selected = false;
            this.bayuda2.Size = new System.Drawing.Size(299, 48);
            this.bayuda2.TabIndex = 13;
            this.bayuda2.Text = "¿Cómo agregar más registros?";
            this.bayuda2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bayuda2.Textcolor = System.Drawing.Color.White;
            this.bayuda2.TextFont = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bayuda2.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // bayuda6
            // 
            this.bayuda6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(3)))), ((int)(((byte)(72)))));
            this.bayuda6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.bayuda6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bayuda6.BorderRadius = 0;
            this.bayuda6.ButtonText = "¿Cómo puedo modificar datos errorneos ingresados en los registros?";
            this.bayuda6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bayuda6.DisabledColor = System.Drawing.Color.Gray;
            this.bayuda6.Iconcolor = System.Drawing.Color.Transparent;
            this.bayuda6.Iconimage = null;
            this.bayuda6.Iconimage_right = null;
            this.bayuda6.Iconimage_right_Selected = null;
            this.bayuda6.Iconimage_Selected = null;
            this.bayuda6.IconMarginLeft = 0;
            this.bayuda6.IconMarginRight = 0;
            this.bayuda6.IconRightVisible = true;
            this.bayuda6.IconRightZoom = 0D;
            this.bayuda6.IconVisible = true;
            this.bayuda6.IconZoom = 90D;
            this.bayuda6.IsTab = false;
            this.bayuda6.Location = new System.Drawing.Point(16, 338);
            this.bayuda6.Name = "bayuda6";
            this.bayuda6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.bayuda6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.bayuda6.OnHoverTextColor = System.Drawing.Color.White;
            this.bayuda6.selected = false;
            this.bayuda6.Size = new System.Drawing.Size(604, 48);
            this.bayuda6.TabIndex = 14;
            this.bayuda6.Text = "¿Cómo puedo modificar datos errorneos ingresados en los registros?";
            this.bayuda6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bayuda6.Textcolor = System.Drawing.Color.White;
            this.bayuda6.TextFont = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bayuda6.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // FormAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(194)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(630, 555);
            this.Controls.Add(this.bayuda6);
            this.Controls.Add(this.bayuda2);
            this.Controls.Add(this.bayuda3);
            this.Controls.Add(this.bayuda4);
            this.Controls.Add(this.bayuda5);
            this.Controls.Add(this.b1ayuda);
            this.Controls.Add(this.busqueda);
            this.Controls.Add(this.payuda3);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAyuda";
            this.Text = "FormAyuda";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payuda2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payuda3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox payuda2;
        private System.Windows.Forms.PictureBox payuda;
        private Bunifu.Framework.UI.BunifuCustomLabel Labelayudatitulo;
        private System.Windows.Forms.PictureBox payuda3;
        private Bunifu.Framework.UI.BunifuTextbox busqueda;
        private Bunifu.Framework.UI.BunifuFlatButton b1ayuda;
        private Bunifu.Framework.UI.BunifuFlatButton bayuda5;
        private Bunifu.Framework.UI.BunifuFlatButton bayuda4;
        private Bunifu.Framework.UI.BunifuFlatButton bayuda3;
        private Bunifu.Framework.UI.BunifuFlatButton bayuda2;
        private Bunifu.Framework.UI.BunifuFlatButton bayuda6;
    }
}