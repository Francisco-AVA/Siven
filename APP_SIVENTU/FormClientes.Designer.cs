﻿
namespace APP_SIVENTU
{
    partial class FormClientes
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
            this.components = new System.ComponentModel.Container();
            this.labeltitulocliente = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.txtcorreocliente = new System.Windows.Forms.TextBox();
            this.labelnumercliente = new System.Windows.Forms.Label();
            this.labelnombrecliente = new System.Windows.Forms.Label();
            this.labeltelefonocliente = new System.Windows.Forms.Label();
            this.labeldireccioncliente = new System.Windows.Forms.Label();
            this.labelfechacliente = new System.Windows.Forms.Label();
            this.Txtfechacliente = new System.Windows.Forms.MaskedTextBox();
            this.txtnumcliente = new System.Windows.Forms.TextBox();
            this.txttelefonoclientes = new System.Windows.Forms.MaskedTextBox();
            this.labelciudadclientes = new System.Windows.Forms.Label();
            this.Txtciudadcliente = new System.Windows.Forms.TextBox();
            this.labeldireccionesclientes = new System.Windows.Forms.Label();
            this.Txtdireccioncliente = new System.Windows.Forms.TextBox();
            this.labelsexoclientes = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btmodificar_clientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btguardar_clientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btlimpiar_clientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.errorcliente = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // labeltitulocliente
            // 
            this.labeltitulocliente.AutoSize = true;
            this.labeltitulocliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.labeltitulocliente.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulocliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labeltitulocliente.Location = new System.Drawing.Point(383, -1);
            this.labeltitulocliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltitulocliente.Name = "labeltitulocliente";
            this.labeltitulocliente.Size = new System.Drawing.Size(168, 51);
            this.labeltitulocliente.TabIndex = 0;
            this.labeltitulocliente.Text = "Clientes";
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(364, 171);
            this.txtnombrecliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(287, 22);
            this.txtnombrecliente.TabIndex = 6;
            this.txtnombrecliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_KeyPress);
            // 
            // txtcorreocliente
            // 
            this.txtcorreocliente.Location = new System.Drawing.Point(364, 299);
            this.txtcorreocliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtcorreocliente.Name = "txtcorreocliente";
            this.txtcorreocliente.Size = new System.Drawing.Size(287, 22);
            this.txtcorreocliente.TabIndex = 8;
            this.txtcorreocliente.TextChanged += new System.EventHandler(this.txtcorreocliente_TextChanged_1);
            // 
            // labelnumercliente
            // 
            this.labelnumercliente.AutoSize = true;
            this.labelnumercliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.labelnumercliente.Location = new System.Drawing.Point(229, 130);
            this.labelnumercliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelnumercliente.Name = "labelnumercliente";
            this.labelnumercliente.Size = new System.Drawing.Size(100, 23);
            this.labelnumercliente.TabIndex = 10;
            this.labelnumercliente.Text = "COIDGO:";
            // 
            // labelnombrecliente
            // 
            this.labelnombrecliente.AutoSize = true;
            this.labelnombrecliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.labelnombrecliente.Location = new System.Drawing.Point(229, 171);
            this.labelnombrecliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelnombrecliente.Name = "labelnombrecliente";
            this.labelnombrecliente.Size = new System.Drawing.Size(105, 23);
            this.labelnombrecliente.TabIndex = 11;
            this.labelnombrecliente.Text = "NOMBRE:";
            // 
            // labeltelefonocliente
            // 
            this.labeltelefonocliente.AutoSize = true;
            this.labeltelefonocliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.labeltelefonocliente.Location = new System.Drawing.Point(213, 257);
            this.labeltelefonocliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltelefonocliente.Name = "labeltelefonocliente";
            this.labeltelefonocliente.Size = new System.Drawing.Size(126, 23);
            this.labeltelefonocliente.TabIndex = 12;
            this.labeltelefonocliente.Text = "TELÉFONO:";
            // 
            // labeldireccioncliente
            // 
            this.labeldireccioncliente.AutoSize = true;
            this.labeldireccioncliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.labeldireccioncliente.Location = new System.Drawing.Point(256, 300);
            this.labeldireccioncliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeldireccioncliente.Name = "labeldireccioncliente";
            this.labeldireccioncliente.Size = new System.Drawing.Size(82, 23);
            this.labeldireccioncliente.TabIndex = 13;
            this.labeldireccioncliente.Text = "EMAIL:";
            // 
            // labelfechacliente
            // 
            this.labelfechacliente.AutoSize = true;
            this.labelfechacliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.labelfechacliente.Location = new System.Drawing.Point(256, 428);
            this.labelfechacliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelfechacliente.Name = "labelfechacliente";
            this.labelfechacliente.Size = new System.Drawing.Size(84, 23);
            this.labelfechacliente.TabIndex = 14;
            this.labelfechacliente.Text = "FECHA:";
            // 
            // Txtfechacliente
            // 
            this.Txtfechacliente.Location = new System.Drawing.Point(364, 427);
            this.Txtfechacliente.Margin = new System.Windows.Forms.Padding(4);
            this.Txtfechacliente.Mask = "00/00/0000";
            this.Txtfechacliente.Name = "Txtfechacliente";
            this.Txtfechacliente.Size = new System.Drawing.Size(132, 22);
            this.Txtfechacliente.TabIndex = 36;
            // 
            // txtnumcliente
            // 
            this.txtnumcliente.Location = new System.Drawing.Point(364, 130);
            this.txtnumcliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumcliente.Name = "txtnumcliente";
            this.txtnumcliente.Size = new System.Drawing.Size(132, 22);
            this.txtnumcliente.TabIndex = 5;
            this.txtnumcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.N_KeyPress);
            // 
            // txttelefonoclientes
            // 
            this.txttelefonoclientes.Location = new System.Drawing.Point(364, 255);
            this.txttelefonoclientes.Margin = new System.Windows.Forms.Padding(4);
            this.txttelefonoclientes.Mask = "0000-0000";
            this.txttelefonoclientes.Name = "txttelefonoclientes";
            this.txttelefonoclientes.Size = new System.Drawing.Size(132, 22);
            this.txttelefonoclientes.TabIndex = 37;
            // 
            // labelciudadclientes
            // 
            this.labelciudadclientes.AutoSize = true;
            this.labelciudadclientes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.labelciudadclientes.Location = new System.Drawing.Point(243, 386);
            this.labelciudadclientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelciudadclientes.Name = "labelciudadclientes";
            this.labelciudadclientes.Size = new System.Drawing.Size(94, 23);
            this.labelciudadclientes.TabIndex = 54;
            this.labelciudadclientes.Text = "CIUDAD:";
            // 
            // Txtciudadcliente
            // 
            this.Txtciudadcliente.Location = new System.Drawing.Point(364, 385);
            this.Txtciudadcliente.Margin = new System.Windows.Forms.Padding(4);
            this.Txtciudadcliente.Name = "Txtciudadcliente";
            this.Txtciudadcliente.Size = new System.Drawing.Size(287, 22);
            this.Txtciudadcliente.TabIndex = 53;
            this.Txtciudadcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtciudadclientes_KeyPress);
            // 
            // labeldireccionesclientes
            // 
            this.labeldireccionesclientes.AutoSize = true;
            this.labeldireccionesclientes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.labeldireccionesclientes.Location = new System.Drawing.Point(204, 342);
            this.labeldireccionesclientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeldireccionesclientes.Name = "labeldireccionesclientes";
            this.labeldireccionesclientes.Size = new System.Drawing.Size(130, 23);
            this.labeldireccionesclientes.TabIndex = 56;
            this.labeldireccionesclientes.Text = "DIRECCIÓN:";
            // 
            // Txtdireccioncliente
            // 
            this.Txtdireccioncliente.Location = new System.Drawing.Point(364, 341);
            this.Txtdireccioncliente.Margin = new System.Windows.Forms.Padding(4);
            this.Txtdireccioncliente.Name = "Txtdireccioncliente";
            this.Txtdireccioncliente.Size = new System.Drawing.Size(287, 22);
            this.Txtdireccioncliente.TabIndex = 55;
            // 
            // labelsexoclientes
            // 
            this.labelsexoclientes.AutoSize = true;
            this.labelsexoclientes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.labelsexoclientes.Location = new System.Drawing.Point(259, 210);
            this.labelsexoclientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelsexoclientes.Name = "labelsexoclientes";
            this.labelsexoclientes.Size = new System.Drawing.Size(70, 23);
            this.labelsexoclientes.TabIndex = 57;
            this.labelsexoclientes.Text = "SEXO:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBox1.Location = new System.Drawing.Point(364, 210);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 62;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::APP_SIVENTU.Properties.Resources.logo_removebg_preview1;
            this.pictureBox1.Location = new System.Drawing.Point(32, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // btmodificar_clientes
            // 
            this.btmodificar_clientes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btmodificar_clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btmodificar_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btmodificar_clientes.BorderRadius = 0;
            this.btmodificar_clientes.ButtonText = "MODIFICAR";
            this.btmodificar_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmodificar_clientes.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btmodificar_clientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btmodificar_clientes.Iconimage = global::APP_SIVENTU.Properties.Resources.boton_editar__1_;
            this.btmodificar_clientes.Iconimage_right = null;
            this.btmodificar_clientes.Iconimage_right_Selected = null;
            this.btmodificar_clientes.Iconimage_Selected = null;
            this.btmodificar_clientes.IconMarginLeft = 0;
            this.btmodificar_clientes.IconMarginRight = 0;
            this.btmodificar_clientes.IconRightVisible = true;
            this.btmodificar_clientes.IconRightZoom = 0D;
            this.btmodificar_clientes.IconVisible = true;
            this.btmodificar_clientes.IconZoom = 70D;
            this.btmodificar_clientes.IsTab = false;
            this.btmodificar_clientes.Location = new System.Drawing.Point(59, 532);
            this.btmodificar_clientes.Margin = new System.Windows.Forms.Padding(5);
            this.btmodificar_clientes.Name = "btmodificar_clientes";
            this.btmodificar_clientes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btmodificar_clientes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btmodificar_clientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btmodificar_clientes.selected = false;
            this.btmodificar_clientes.Size = new System.Drawing.Size(209, 70);
            this.btmodificar_clientes.TabIndex = 63;
            this.btmodificar_clientes.Text = "MODIFICAR";
            this.btmodificar_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmodificar_clientes.Textcolor = System.Drawing.Color.White;
            this.btmodificar_clientes.TextFont = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btguardar_clientes
            // 
            this.btguardar_clientes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btguardar_clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btguardar_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btguardar_clientes.BorderRadius = 0;
            this.btguardar_clientes.ButtonText = "GUARDAR";
            this.btguardar_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btguardar_clientes.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btguardar_clientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btguardar_clientes.Iconimage = global::APP_SIVENTU.Properties.Resources.disquete;
            this.btguardar_clientes.Iconimage_right = null;
            this.btguardar_clientes.Iconimage_right_Selected = null;
            this.btguardar_clientes.Iconimage_Selected = null;
            this.btguardar_clientes.IconMarginLeft = 0;
            this.btguardar_clientes.IconMarginRight = 0;
            this.btguardar_clientes.IconRightVisible = true;
            this.btguardar_clientes.IconRightZoom = 0D;
            this.btguardar_clientes.IconVisible = true;
            this.btguardar_clientes.IconZoom = 70D;
            this.btguardar_clientes.IsTab = false;
            this.btguardar_clientes.Location = new System.Drawing.Point(319, 532);
            this.btguardar_clientes.Margin = new System.Windows.Forms.Padding(5);
            this.btguardar_clientes.Name = "btguardar_clientes";
            this.btguardar_clientes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btguardar_clientes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btguardar_clientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btguardar_clientes.selected = false;
            this.btguardar_clientes.Size = new System.Drawing.Size(205, 70);
            this.btguardar_clientes.TabIndex = 64;
            this.btguardar_clientes.Text = "GUARDAR";
            this.btguardar_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btguardar_clientes.Textcolor = System.Drawing.Color.White;
            this.btguardar_clientes.TextFont = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btguardar_clientes.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btlimpiar_clientes
            // 
            this.btlimpiar_clientes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiar_clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btlimpiar_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btlimpiar_clientes.BorderRadius = 0;
            this.btlimpiar_clientes.ButtonText = "ELIMINAR";
            this.btlimpiar_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlimpiar_clientes.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiar_clientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btlimpiar_clientes.Iconimage = global::APP_SIVENTU.Properties.Resources.eliminar;
            this.btlimpiar_clientes.Iconimage_right = null;
            this.btlimpiar_clientes.Iconimage_right_Selected = null;
            this.btlimpiar_clientes.Iconimage_Selected = null;
            this.btlimpiar_clientes.IconMarginLeft = 0;
            this.btlimpiar_clientes.IconMarginRight = 0;
            this.btlimpiar_clientes.IconRightVisible = true;
            this.btlimpiar_clientes.IconRightZoom = 0D;
            this.btlimpiar_clientes.IconVisible = true;
            this.btlimpiar_clientes.IconZoom = 70D;
            this.btlimpiar_clientes.IsTab = false;
            this.btlimpiar_clientes.Location = new System.Drawing.Point(575, 532);
            this.btlimpiar_clientes.Margin = new System.Windows.Forms.Padding(5);
            this.btlimpiar_clientes.Name = "btlimpiar_clientes";
            this.btlimpiar_clientes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btlimpiar_clientes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiar_clientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btlimpiar_clientes.selected = false;
            this.btlimpiar_clientes.Size = new System.Drawing.Size(204, 70);
            this.btlimpiar_clientes.TabIndex = 65;
            this.btlimpiar_clientes.Text = "ELIMINAR";
            this.btlimpiar_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btlimpiar_clientes.Textcolor = System.Drawing.Color.White;
            this.btlimpiar_clientes.TextFont = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpiar_clientes.Click += new System.EventHandler(this.btlimpiar_clientes_Click);
            // 
            // errorcliente
            // 
            this.errorcliente.ContainerControl = this;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(167)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(840, 683);
            this.Controls.Add(this.btlimpiar_clientes);
            this.Controls.Add(this.btguardar_clientes);
            this.Controls.Add(this.btmodificar_clientes);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelsexoclientes);
            this.Controls.Add(this.labeldireccionesclientes);
            this.Controls.Add(this.Txtdireccioncliente);
            this.Controls.Add(this.labelciudadclientes);
            this.Controls.Add(this.Txtciudadcliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txttelefonoclientes);
            this.Controls.Add(this.Txtfechacliente);
            this.Controls.Add(this.labelfechacliente);
            this.Controls.Add(this.labeldireccioncliente);
            this.Controls.Add(this.labeltelefonocliente);
            this.Controls.Add(this.labelnombrecliente);
            this.Controls.Add(this.labelnumercliente);
            this.Controls.Add(this.txtcorreocliente);
            this.Controls.Add(this.txtnombrecliente);
            this.Controls.Add(this.txtnumcliente);
            this.Controls.Add(this.labeltitulocliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel labeltitulocliente;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.TextBox txtcorreocliente;
        private System.Windows.Forms.Label labelnumercliente;
        private System.Windows.Forms.Label labelnombrecliente;
        private System.Windows.Forms.Label labeltelefonocliente;
        private System.Windows.Forms.Label labeldireccioncliente;
        private System.Windows.Forms.Label labelfechacliente;
        private System.Windows.Forms.MaskedTextBox Txtfechacliente;
        private System.Windows.Forms.TextBox txtnumcliente;
        private System.Windows.Forms.MaskedTextBox txttelefonoclientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelciudadclientes;
        private System.Windows.Forms.TextBox Txtciudadcliente;
        private System.Windows.Forms.Label labeldireccionesclientes;
        private System.Windows.Forms.TextBox Txtdireccioncliente;
        private System.Windows.Forms.Label labelsexoclientes;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btlimpiar_clientes;
        private Bunifu.Framework.UI.BunifuFlatButton btguardar_clientes;
        private Bunifu.Framework.UI.BunifuFlatButton btmodificar_clientes;
        private System.Windows.Forms.ErrorProvider errorcliente;
    }
}