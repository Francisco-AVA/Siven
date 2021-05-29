
namespace APP_SIVENTU
{
    partial class RegistroDeEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroDeEmpleados));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCorreo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtConfirmacion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtContra2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btlimpiar_regis = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btguardar_regis = new Bunifu.Framework.UI.BunifuFlatButton();
            this.errorempleados = new System.Windows.Forms.ErrorProvider(this.components);
            this.button_mostrar_emple = new System.Windows.Forms.Button();
            this.button_mostrar_emple2 = new System.Windows.Forms.Button();
            this.button_ocultar_emple = new System.Windows.Forms.Button();
            this.button_ocultar_emple2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorempleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Sexo";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefono.HintForeColor = System.Drawing.Color.Empty;
            this.txtTelefono.HintText = "Ingrese su numero de telefono";
            this.txtTelefono.isPassword = false;
            this.txtTelefono.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.txtTelefono.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTelefono.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.txtTelefono.LineThickness = 3;
            this.txtTelefono.Location = new System.Drawing.Point(119, 390);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(370, 32);
            this.txtTelefono.TabIndex = 28;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefonoo_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCorreo.HintForeColor = System.Drawing.Color.Empty;
            this.txtCorreo.HintText = "Ingrese su correo electronico";
            this.txtCorreo.isPassword = false;
            this.txtCorreo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.txtCorreo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCorreo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.txtCorreo.LineThickness = 3;
            this.txtCorreo.Location = new System.Drawing.Point(119, 341);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(370, 32);
            this.txtCorreo.TabIndex = 27;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCorreo.OnValueChanged += new System.EventHandler(this.txtCorreo_OnValueChanged);
            // 
            // txtConfirmacion
            // 
            this.txtConfirmacion.BackColor = System.Drawing.Color.White;
            this.txtConfirmacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmacion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtConfirmacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmacion.HintForeColor = System.Drawing.Color.Empty;
            this.txtConfirmacion.HintText = "Confirme su contraseña";
            this.txtConfirmacion.isPassword = true;
            this.txtConfirmacion.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.txtConfirmacion.LineIdleColor = System.Drawing.Color.Gray;
            this.txtConfirmacion.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.txtConfirmacion.LineThickness = 3;
            this.txtConfirmacion.Location = new System.Drawing.Point(119, 245);
            this.txtConfirmacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmacion.Name = "txtConfirmacion";
            this.txtConfirmacion.Size = new System.Drawing.Size(326, 41);
            this.txtConfirmacion.TabIndex = 26;
            this.txtConfirmacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfirmacion.OnValueChanged += new System.EventHandler(this.txtConfirmacion_OnValueChanged);
            // 
            // txtContra2
            // 
            this.txtContra2.BackColor = System.Drawing.Color.White;
            this.txtContra2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContra2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtContra2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContra2.HintForeColor = System.Drawing.Color.Empty;
            this.txtContra2.HintText = "Ingrese su contraseña";
            this.txtContra2.isPassword = true;
            this.txtContra2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.txtContra2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtContra2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.txtContra2.LineThickness = 3;
            this.txtContra2.Location = new System.Drawing.Point(119, 184);
            this.txtContra2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContra2.Name = "txtContra2";
            this.txtContra2.Size = new System.Drawing.Size(326, 41);
            this.txtContra2.TabIndex = 23;
            this.txtContra2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContra2.OnValueChanged += new System.EventHandler(this.txtContra2_OnValueChanged_1);
            // 
            // txtNombre2
            // 
            this.txtNombre2.BackColor = System.Drawing.Color.White;
            this.txtNombre2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre2.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombre2.HintText = "Ingrese su nombre de usuario";
            this.txtNombre2.isPassword = false;
            this.txtNombre2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.txtNombre2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombre2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.txtNombre2.LineThickness = 3;
            this.txtNombre2.Location = new System.Drawing.Point(119, 144);
            this.txtNombre2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(370, 32);
            this.txtNombre2.TabIndex = 22;
            this.txtNombre2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre2_KeyPress);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(182, 15);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(402, 32);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "REGISTRO DE EMPLEADOS\r\n";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBox1.Location = new System.Drawing.Point(184, 303);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 32;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(32, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(287, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btlimpiar_regis
            // 
            this.btlimpiar_regis.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiar_regis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btlimpiar_regis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btlimpiar_regis.BorderRadius = 0;
            this.btlimpiar_regis.ButtonText = "ELIMINAR";
            this.btlimpiar_regis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlimpiar_regis.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiar_regis.Iconcolor = System.Drawing.Color.Transparent;
            this.btlimpiar_regis.Iconimage = global::APP_SIVENTU.Properties.Resources.eliminar;
            this.btlimpiar_regis.Iconimage_right = null;
            this.btlimpiar_regis.Iconimage_right_Selected = null;
            this.btlimpiar_regis.Iconimage_Selected = null;
            this.btlimpiar_regis.IconMarginLeft = 0;
            this.btlimpiar_regis.IconMarginRight = 0;
            this.btlimpiar_regis.IconRightVisible = true;
            this.btlimpiar_regis.IconRightZoom = 0D;
            this.btlimpiar_regis.IconVisible = true;
            this.btlimpiar_regis.IconZoom = 60D;
            this.btlimpiar_regis.IsTab = false;
            this.btlimpiar_regis.Location = new System.Drawing.Point(335, 470);
            this.btlimpiar_regis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btlimpiar_regis.Name = "btlimpiar_regis";
            this.btlimpiar_regis.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btlimpiar_regis.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiar_regis.OnHoverTextColor = System.Drawing.Color.White;
            this.btlimpiar_regis.selected = false;
            this.btlimpiar_regis.Size = new System.Drawing.Size(154, 57);
            this.btlimpiar_regis.TabIndex = 67;
            this.btlimpiar_regis.Text = "ELIMINAR";
            this.btlimpiar_regis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btlimpiar_regis.Textcolor = System.Drawing.Color.White;
            this.btlimpiar_regis.TextFont = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpiar_regis.Click += new System.EventHandler(this.btlimpiar_clientes_Click);
            // 
            // btguardar_regis
            // 
            this.btguardar_regis.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btguardar_regis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btguardar_regis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btguardar_regis.BorderRadius = 0;
            this.btguardar_regis.ButtonText = "GUARDAR";
            this.btguardar_regis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btguardar_regis.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btguardar_regis.Iconcolor = System.Drawing.Color.Transparent;
            this.btguardar_regis.Iconimage = global::APP_SIVENTU.Properties.Resources.disquete;
            this.btguardar_regis.Iconimage_right = null;
            this.btguardar_regis.Iconimage_right_Selected = null;
            this.btguardar_regis.Iconimage_Selected = null;
            this.btguardar_regis.IconMarginLeft = 0;
            this.btguardar_regis.IconMarginRight = 0;
            this.btguardar_regis.IconRightVisible = true;
            this.btguardar_regis.IconRightZoom = 0D;
            this.btguardar_regis.IconVisible = true;
            this.btguardar_regis.IconZoom = 60D;
            this.btguardar_regis.IsTab = false;
            this.btguardar_regis.Location = new System.Drawing.Point(129, 470);
            this.btguardar_regis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btguardar_regis.Name = "btguardar_regis";
            this.btguardar_regis.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btguardar_regis.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btguardar_regis.OnHoverTextColor = System.Drawing.Color.White;
            this.btguardar_regis.selected = false;
            this.btguardar_regis.Size = new System.Drawing.Size(146, 57);
            this.btguardar_regis.TabIndex = 66;
            this.btguardar_regis.Text = "GUARDAR";
            this.btguardar_regis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btguardar_regis.Textcolor = System.Drawing.Color.White;
            this.btguardar_regis.TextFont = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btguardar_regis.Click += new System.EventHandler(this.btguardar_regis_Click);
            // 
            // errorempleados
            // 
            this.errorempleados.ContainerControl = this;
            // 
            // button_mostrar_emple
            // 
            this.button_mostrar_emple.FlatAppearance.BorderSize = 0;
            this.button_mostrar_emple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_mostrar_emple.Image = global::APP_SIVENTU.Properties.Resources.ojo_visible___copia;
            this.button_mostrar_emple.Location = new System.Drawing.Point(437, 184);
            this.button_mostrar_emple.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_mostrar_emple.Name = "button_mostrar_emple";
            this.button_mostrar_emple.Size = new System.Drawing.Size(52, 41);
            this.button_mostrar_emple.TabIndex = 68;
            this.button_mostrar_emple.UseVisualStyleBackColor = true;
            this.button_mostrar_emple.Click += new System.EventHandler(this.button_mostrar_emple_Click);
            // 
            // button_mostrar_emple2
            // 
            this.button_mostrar_emple2.FlatAppearance.BorderSize = 0;
            this.button_mostrar_emple2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_mostrar_emple2.Image = global::APP_SIVENTU.Properties.Resources.ojo_visible___copia;
            this.button_mostrar_emple2.Location = new System.Drawing.Point(437, 245);
            this.button_mostrar_emple2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_mostrar_emple2.Name = "button_mostrar_emple2";
            this.button_mostrar_emple2.Size = new System.Drawing.Size(52, 41);
            this.button_mostrar_emple2.TabIndex = 69;
            this.button_mostrar_emple2.UseVisualStyleBackColor = true;
            this.button_mostrar_emple2.Click += new System.EventHandler(this.button_mostrar_emple2_Click);
            // 
            // button_ocultar_emple
            // 
            this.button_ocultar_emple.FlatAppearance.BorderSize = 0;
            this.button_ocultar_emple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ocultar_emple.ForeColor = System.Drawing.Color.White;
            this.button_ocultar_emple.Image = global::APP_SIVENTU.Properties.Resources.invisible1;
            this.button_ocultar_emple.Location = new System.Drawing.Point(437, 184);
            this.button_ocultar_emple.Margin = new System.Windows.Forms.Padding(0);
            this.button_ocultar_emple.Name = "button_ocultar_emple";
            this.button_ocultar_emple.Size = new System.Drawing.Size(52, 41);
            this.button_ocultar_emple.TabIndex = 70;
            this.button_ocultar_emple.UseVisualStyleBackColor = true;
            this.button_ocultar_emple.Click += new System.EventHandler(this.button_ocultar_emple_Click);
            // 
            // button_ocultar_emple2
            // 
            this.button_ocultar_emple2.FlatAppearance.BorderSize = 0;
            this.button_ocultar_emple2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ocultar_emple2.Image = global::APP_SIVENTU.Properties.Resources.invisible1;
            this.button_ocultar_emple2.Location = new System.Drawing.Point(437, 245);
            this.button_ocultar_emple2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_ocultar_emple2.Name = "button_ocultar_emple2";
            this.button_ocultar_emple2.Size = new System.Drawing.Size(52, 41);
            this.button_ocultar_emple2.TabIndex = 71;
            this.button_ocultar_emple2.UseVisualStyleBackColor = true;
            this.button_ocultar_emple2.Click += new System.EventHandler(this.button_ocultar_emple2_Click);
            // 
            // RegistroDeEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(167)))), ((int)(((byte)(185)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 555);
            this.Controls.Add(this.button_ocultar_emple2);
            this.Controls.Add(this.button_ocultar_emple);
            this.Controls.Add(this.button_mostrar_emple2);
            this.Controls.Add(this.button_mostrar_emple);
            this.Controls.Add(this.btlimpiar_regis);
            this.Controls.Add(this.btguardar_regis);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtConfirmacion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtContra2);
            this.Controls.Add(this.txtNombre2);
            this.Controls.Add(this.Label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroDeEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RegistroDeEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorempleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefono;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCorreo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtConfirmacion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtContra2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre2;
        private Bunifu.Framework.UI.BunifuCustomLabel Label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btlimpiar_regis;
        private Bunifu.Framework.UI.BunifuFlatButton btguardar_regis;
        private System.Windows.Forms.ErrorProvider errorempleados;
        private System.Windows.Forms.Button button_mostrar_emple;
        private System.Windows.Forms.Button button_mostrar_emple2;
        private System.Windows.Forms.Button button_ocultar_emple2;
        private System.Windows.Forms.Button button_ocultar_emple;
    }
}