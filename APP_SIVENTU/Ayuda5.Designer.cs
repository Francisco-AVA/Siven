
namespace APP_SIVENTU
{
    partial class Ayuda5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayuda5));
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btmini3 = new System.Windows.Forms.PictureBox();
            this.btsalir3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btmini3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btsalir3)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(184, 304);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "¿Cómo anular registro?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::APP_SIVENTU.Properties.Resources.logo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(635, 56);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.panel3.Controls.Add(this.btmini3);
            this.panel3.Controls.Add(this.btsalir3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(840, 58);
            this.panel3.TabIndex = 9;
            // 
            // btmini3
            // 
            this.btmini3.Image = ((System.Drawing.Image)(resources.GetObject("btmini3.Image")));
            this.btmini3.Location = new System.Drawing.Point(727, 13);
            this.btmini3.Margin = new System.Windows.Forms.Padding(4);
            this.btmini3.Name = "btmini3";
            this.btmini3.Size = new System.Drawing.Size(40, 37);
            this.btmini3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btmini3.TabIndex = 10;
            this.btmini3.TabStop = false;
            this.btmini3.Click += new System.EventHandler(this.btmini3_Click);
            // 
            // btsalir3
            // 
            this.btsalir3.Image = ((System.Drawing.Image)(resources.GetObject("btsalir3.Image")));
            this.btsalir3.Location = new System.Drawing.Point(787, 13);
            this.btsalir3.Margin = new System.Windows.Forms.Padding(4);
            this.btsalir3.Name = "btsalir3";
            this.btsalir3.Size = new System.Drawing.Size(40, 37);
            this.btsalir3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btsalir3.TabIndex = 9;
            this.btsalir3.TabStop = false;
            this.btsalir3.Click += new System.EventHandler(this.btsalir3_Click);
            // 
            // Ayuda5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(224)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(840, 683);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ayuda5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayuda5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btmini3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btsalir3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btmini3;
        private System.Windows.Forms.PictureBox btsalir3;
    }
}