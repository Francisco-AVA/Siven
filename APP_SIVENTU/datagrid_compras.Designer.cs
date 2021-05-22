
namespace APP_SIVENTU
{
    partial class datagrid_compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(datagrid_compras));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dataGridViewCompras = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.botonderegreso2 = new System.Windows.Forms.PictureBox();
            this.btminicom = new System.Windows.Forms.PictureBox();
            this.btsalircom = new System.Windows.Forms.PictureBox();
            this.btlimpiar_com = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompras)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonderegreso2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btminicom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btsalircom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(156, 88);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(366, 32);
            this.bunifuCustomLabel1.TabIndex = 89;
            this.bunifuCustomLabel1.Text = "REGISTRO DE COMPRAS\r\n";
            // 
            // dataGridViewCompras
            // 
            this.dataGridViewCompras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.dataGridViewCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompras.Location = new System.Drawing.Point(45, 190);
            this.dataGridViewCompras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCompras.Name = "dataGridViewCompras";
            this.dataGridViewCompras.RowHeadersWidth = 51;
            this.dataGridViewCompras.RowTemplate.Height = 24;
            this.dataGridViewCompras.Size = new System.Drawing.Size(554, 284);
            this.dataGridViewCompras.TabIndex = 86;
            this.dataGridViewCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCompras_CellClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.panel4.Controls.Add(this.botonderegreso2);
            this.panel4.Controls.Add(this.btminicom);
            this.panel4.Controls.Add(this.btsalircom);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(630, 40);
            this.panel4.TabIndex = 85;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseUp);
            // 
            // botonderegreso2
            // 
            this.botonderegreso2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonderegreso2.Image = global::APP_SIVENTU.Properties.Resources.regreso;
            this.botonderegreso2.Location = new System.Drawing.Point(16, 5);
            this.botonderegreso2.Name = "botonderegreso2";
            this.botonderegreso2.Size = new System.Drawing.Size(0, 0);
            this.botonderegreso2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonderegreso2.TabIndex = 3;
            this.botonderegreso2.TabStop = false;
            // 
            // btminicom
            // 
            this.btminicom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btminicom.Image = ((System.Drawing.Image)(resources.GetObject("btminicom.Image")));
            this.btminicom.Location = new System.Drawing.Point(545, 5);
            this.btminicom.Name = "btminicom";
            this.btminicom.Size = new System.Drawing.Size(30, 30);
            this.btminicom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btminicom.TabIndex = 1;
            this.btminicom.TabStop = false;
            this.btminicom.Click += new System.EventHandler(this.btminicom_Click);
            // 
            // btsalircom
            // 
            this.btsalircom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsalircom.Image = ((System.Drawing.Image)(resources.GetObject("btsalircom.Image")));
            this.btsalircom.Location = new System.Drawing.Point(590, 5);
            this.btsalircom.Name = "btsalircom";
            this.btsalircom.Size = new System.Drawing.Size(30, 30);
            this.btsalircom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btsalircom.TabIndex = 0;
            this.btsalircom.TabStop = false;
            this.btsalircom.Click += new System.EventHandler(this.btsalircom_Click);
            // 
            // btlimpiar_com
            // 
            this.btlimpiar_com.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiar_com.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btlimpiar_com.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btlimpiar_com.BorderRadius = 0;
            this.btlimpiar_com.ButtonText = "ELIMINAR";
            this.btlimpiar_com.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlimpiar_com.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiar_com.Iconcolor = System.Drawing.Color.Transparent;
            this.btlimpiar_com.Iconimage = global::APP_SIVENTU.Properties.Resources.eliminar;
            this.btlimpiar_com.Iconimage_right = null;
            this.btlimpiar_com.Iconimage_right_Selected = null;
            this.btlimpiar_com.Iconimage_Selected = null;
            this.btlimpiar_com.IconMarginLeft = 0;
            this.btlimpiar_com.IconMarginRight = 0;
            this.btlimpiar_com.IconRightVisible = true;
            this.btlimpiar_com.IconRightZoom = 0D;
            this.btlimpiar_com.IconVisible = true;
            this.btlimpiar_com.IconZoom = 60D;
            this.btlimpiar_com.IsTab = false;
            this.btlimpiar_com.Location = new System.Drawing.Point(256, 488);
            this.btlimpiar_com.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btlimpiar_com.Name = "btlimpiar_com";
            this.btlimpiar_com.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btlimpiar_com.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiar_com.OnHoverTextColor = System.Drawing.Color.White;
            this.btlimpiar_com.selected = false;
            this.btlimpiar_com.Size = new System.Drawing.Size(143, 55);
            this.btlimpiar_com.TabIndex = 88;
            this.btlimpiar_com.Text = "ELIMINAR";
            this.btlimpiar_com.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btlimpiar_com.Textcolor = System.Drawing.Color.White;
            this.btlimpiar_com.TextFont = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpiar_com.Click += new System.EventHandler(this.btlimpiar_com_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 87;
            this.pictureBox2.TabStop = false;
            // 
            // datagrid_compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(630, 555);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btlimpiar_com);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridViewCompras);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "datagrid_compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "datagrid_compras";
            this.Load += new System.EventHandler(this.datagrid_compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompras)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.botonderegreso2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btminicom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btsalircom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btlimpiar_com;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridViewCompras;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox botonderegreso2;
        private System.Windows.Forms.PictureBox btminicom;
        private System.Windows.Forms.PictureBox btsalircom;
    }
}