
namespace APP_SIVENTU
{
    partial class datagrid_productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(datagrid_productos));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.botonderegreso2 = new System.Windows.Forms.PictureBox();
            this.btminiprod = new System.Windows.Forms.PictureBox();
            this.btsalirprod = new System.Windows.Forms.PictureBox();
            this.btlimpiar_prod = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonderegreso2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btminiprod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btsalirprod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(208, 93);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(518, 42);
            this.bunifuCustomLabel1.TabIndex = 84;
            this.bunifuCustomLabel1.Text = "REGISTRO DE PRODUCTOS";
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.dataGridViewProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(60, 219);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.RowHeadersWidth = 51;
            this.dataGridViewProductos.RowTemplate.Height = 24;
            this.dataGridViewProductos.Size = new System.Drawing.Size(738, 349);
            this.dataGridViewProductos.TabIndex = 81;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.panel4.Controls.Add(this.botonderegreso2);
            this.panel4.Controls.Add(this.btminiprod);
            this.panel4.Controls.Add(this.btsalirprod);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(840, 49);
            this.panel4.TabIndex = 80;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseUp);
            // 
            // botonderegreso2
            // 
            this.botonderegreso2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonderegreso2.Image = global::APP_SIVENTU.Properties.Resources.regreso;
            this.botonderegreso2.Location = new System.Drawing.Point(22, 6);
            this.botonderegreso2.Margin = new System.Windows.Forms.Padding(4);
            this.botonderegreso2.Name = "botonderegreso2";
            this.botonderegreso2.Size = new System.Drawing.Size(0, 0);
            this.botonderegreso2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonderegreso2.TabIndex = 3;
            this.botonderegreso2.TabStop = false;
            // 
            // btminiprod
            // 
            this.btminiprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btminiprod.Image = ((System.Drawing.Image)(resources.GetObject("btminiprod.Image")));
            this.btminiprod.Location = new System.Drawing.Point(727, 6);
            this.btminiprod.Margin = new System.Windows.Forms.Padding(4);
            this.btminiprod.Name = "btminiprod";
            this.btminiprod.Size = new System.Drawing.Size(40, 37);
            this.btminiprod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btminiprod.TabIndex = 1;
            this.btminiprod.TabStop = false;
            this.btminiprod.Click += new System.EventHandler(this.btminiprod_Click);
            // 
            // btsalirprod
            // 
            this.btsalirprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsalirprod.Image = ((System.Drawing.Image)(resources.GetObject("btsalirprod.Image")));
            this.btsalirprod.Location = new System.Drawing.Point(787, 6);
            this.btsalirprod.Margin = new System.Windows.Forms.Padding(4);
            this.btsalirprod.Name = "btsalirprod";
            this.btsalirprod.Size = new System.Drawing.Size(40, 37);
            this.btsalirprod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btsalirprod.TabIndex = 0;
            this.btsalirprod.TabStop = false;
            this.btsalirprod.Click += new System.EventHandler(this.btsalirprod_Click);
            // 
            // btlimpiar_prod
            // 
            this.btlimpiar_prod.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiar_prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btlimpiar_prod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btlimpiar_prod.BorderRadius = 0;
            this.btlimpiar_prod.ButtonText = "ELIMINAR";
            this.btlimpiar_prod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlimpiar_prod.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiar_prod.Iconcolor = System.Drawing.Color.Transparent;
            this.btlimpiar_prod.Iconimage = global::APP_SIVENTU.Properties.Resources.eliminar;
            this.btlimpiar_prod.Iconimage_right = null;
            this.btlimpiar_prod.Iconimage_right_Selected = null;
            this.btlimpiar_prod.Iconimage_Selected = null;
            this.btlimpiar_prod.IconMarginLeft = 0;
            this.btlimpiar_prod.IconMarginRight = 0;
            this.btlimpiar_prod.IconRightVisible = true;
            this.btlimpiar_prod.IconRightZoom = 0D;
            this.btlimpiar_prod.IconVisible = true;
            this.btlimpiar_prod.IconZoom = 60D;
            this.btlimpiar_prod.IsTab = false;
            this.btlimpiar_prod.Location = new System.Drawing.Point(341, 585);
            this.btlimpiar_prod.Margin = new System.Windows.Forms.Padding(5);
            this.btlimpiar_prod.Name = "btlimpiar_prod";
            this.btlimpiar_prod.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btlimpiar_prod.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiar_prod.OnHoverTextColor = System.Drawing.Color.White;
            this.btlimpiar_prod.selected = false;
            this.btlimpiar_prod.Size = new System.Drawing.Size(191, 68);
            this.btlimpiar_prod.TabIndex = 83;
            this.btlimpiar_prod.Text = "ELIMINAR";
            this.btlimpiar_prod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btlimpiar_prod.Textcolor = System.Drawing.Color.White;
            this.btlimpiar_prod.TextFont = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 75);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 82;
            this.pictureBox2.TabStop = false;
            // 
            // datagrid_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(840, 683);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btlimpiar_prod);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "datagrid_productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "datagrid_productos";
            this.Load += new System.EventHandler(this.datagrid_productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.botonderegreso2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btminiprod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btsalirprod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btlimpiar_prod;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox botonderegreso2;
        private System.Windows.Forms.PictureBox btminiprod;
        private System.Windows.Forms.PictureBox btsalirprod;
    }
}