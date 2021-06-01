
namespace APP_SIVENTU
{
    partial class FormFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lbventu = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbventu2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbventu3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbventu4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.factu = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.nit = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.nrc = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labnum = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dgvfactu = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_u = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventas_af = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labproducto = new System.Windows.Forms.Label();
            this.labcodigo = new System.Windows.Forms.Label();
            this.labnombre = new System.Windows.Forms.Label();
            this.labprecio = new System.Windows.Forms.Label();
            this.labcantidad = new System.Windows.Forms.Label();
            this.labTotalpagar = new System.Windows.Forms.Label();
            this.labefectivo = new System.Windows.Forms.Label();
            this.labdevolucion = new System.Windows.Forms.Label();
            this.combofactu = new System.Windows.Forms.ComboBox();
            this.txtefectivo = new System.Windows.Forms.TextBox();
            this.btlimpiar_fac = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btagregar_fac = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btguardar_fac = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.labnum2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfactu)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbventu
            // 
            this.Lbventu.AutoSize = true;
            this.Lbventu.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbventu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.Lbventu.Location = new System.Drawing.Point(27, 5);
            this.Lbventu.Name = "Lbventu";
            this.Lbventu.Size = new System.Drawing.Size(220, 27);
            this.Lbventu.TabIndex = 1;
            this.Lbventu.Text = "CEREALES VENTURA";
            this.Lbventu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbventu2
            // 
            this.Lbventu2.AutoSize = true;
            this.Lbventu2.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbventu2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.Lbventu2.Location = new System.Drawing.Point(85, 37);
            this.Lbventu2.Name = "Lbventu2";
            this.Lbventu2.Size = new System.Drawing.Size(129, 15);
            this.Lbventu2.TabIndex = 2;
            this.Lbventu2.Text = "VENTA DE CEREALES";
            this.Lbventu2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbventu3
            // 
            this.Lbventu3.AutoSize = true;
            this.Lbventu3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbventu3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.Lbventu3.Location = new System.Drawing.Point(36, 55);
            this.Lbventu3.Name = "Lbventu3";
            this.Lbventu3.Size = new System.Drawing.Size(202, 42);
            this.Lbventu3.TabIndex = 3;
            this.Lbventu3.Text = "1a. Calle Oriente No.48, Usulután.\r\nEl Salvador, C.A.\r\nTel.: 2662-1843";
            this.Lbventu3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbventu4
            // 
            this.Lbventu4.AutoSize = true;
            this.Lbventu4.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbventu4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.Lbventu4.Location = new System.Drawing.Point(39, 106);
            this.Lbventu4.Name = "Lbventu4";
            this.Lbventu4.Size = new System.Drawing.Size(199, 14);
            this.Lbventu4.TabIndex = 4;
            this.Lbventu4.Text = "NELSON ORLANDO VENTURA SORTO";
            this.Lbventu4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(420, 7);
            this.bunifuProgressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.Teal;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(203, 33);
            this.bunifuProgressBar1.TabIndex = 5;
            this.bunifuProgressBar1.Value = 0;
            // 
            // factu
            // 
            this.factu.AutoSize = true;
            this.factu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.factu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factu.ForeColor = System.Drawing.Color.LightCyan;
            this.factu.Location = new System.Drawing.Point(427, 15);
            this.factu.Name = "factu";
            this.factu.Size = new System.Drawing.Size(155, 17);
            this.factu.TabIndex = 7;
            this.factu.Text = "FACTURA 20NU000F";
            this.factu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nit
            // 
            this.nit.AutoSize = true;
            this.nit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.nit.Location = new System.Drawing.Point(428, 88);
            this.nit.Name = "nit";
            this.nit.Size = new System.Drawing.Size(143, 15);
            this.nit.TabIndex = 8;
            this.nit.Text = "NIT: 1123-300383-101-5";
            this.nit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nrc
            // 
            this.nrc.AutoSize = true;
            this.nrc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.nrc.Location = new System.Drawing.Point(428, 73);
            this.nrc.Name = "nrc";
            this.nrc.Size = new System.Drawing.Size(94, 15);
            this.nrc.TabIndex = 9;
            this.nrc.Text = "NRC: 291931-9";
            this.nrc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labnum
            // 
            this.labnum.AutoSize = true;
            this.labnum.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labnum.ForeColor = System.Drawing.Color.Maroon;
            this.labnum.Location = new System.Drawing.Point(434, 44);
            this.labnum.Name = "labnum";
            this.labnum.Size = new System.Drawing.Size(37, 23);
            this.labnum.TabIndex = 10;
            this.labnum.Text = "No";
            this.labnum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.bunifuMetroTextbox1.BorderThickness = 3;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuMetroTextbox1.Enabled = false;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(418, 26);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(206, 92);
            this.bunifuMetroTextbox1.TabIndex = 11;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dgvfactu
            // 
            this.dgvfactu.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvfactu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvfactu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvfactu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(224)))), ((int)(((byte)(222)))));
            this.dgvfactu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvfactu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvfactu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvfactu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvfactu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfactu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cant,
            this.descripcion,
            this.precio_u,
            this.ventas_af,
            this.total});
            this.dgvfactu.DoubleBuffered = true;
            this.dgvfactu.EnableHeadersVisualStyles = false;
            this.dgvfactu.GridColor = System.Drawing.Color.White;
            this.dgvfactu.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.dgvfactu.HeaderForeColor = System.Drawing.Color.White;
            this.dgvfactu.Location = new System.Drawing.Point(12, 277);
            this.dgvfactu.Name = "dgvfactu";
            this.dgvfactu.ReadOnly = true;
            this.dgvfactu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvfactu.RowHeadersWidth = 51;
            this.dgvfactu.Size = new System.Drawing.Size(609, 133);
            this.dgvfactu.TabIndex = 22;
            // 
            // cant
            // 
            this.cant.HeaderText = "CODIGO";
            this.cant.MinimumWidth = 6;
            this.cant.Name = "cant";
            this.cant.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "PRODUCTO";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // precio_u
            // 
            this.precio_u.HeaderText = "PRECIO ";
            this.precio_u.MinimumWidth = 6;
            this.precio_u.Name = "precio_u";
            this.precio_u.ReadOnly = true;
            // 
            // ventas_af
            // 
            this.ventas_af.HeaderText = "CANTIDAD";
            this.ventas_af.MinimumWidth = 6;
            this.ventas_af.Name = "ventas_af";
            this.ventas_af.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "TOTAL";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // labproducto
            // 
            this.labproducto.AutoSize = true;
            this.labproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labproducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
            this.labproducto.Location = new System.Drawing.Point(36, 141);
            this.labproducto.Name = "labproducto";
            this.labproducto.Size = new System.Drawing.Size(68, 15);
            this.labproducto.TabIndex = 70;
            this.labproducto.Text = "Producto:";
            // 
            // labcodigo
            // 
            this.labcodigo.AutoSize = true;
            this.labcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
            this.labcodigo.Location = new System.Drawing.Point(36, 168);
            this.labcodigo.Name = "labcodigo";
            this.labcodigo.Size = new System.Drawing.Size(56, 15);
            this.labcodigo.TabIndex = 71;
            this.labcodigo.Text = "Código:";
            // 
            // labnombre
            // 
            this.labnombre.AutoSize = true;
            this.labnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labnombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
            this.labnombre.Location = new System.Drawing.Point(36, 197);
            this.labnombre.Name = "labnombre";
            this.labnombre.Size = new System.Drawing.Size(62, 15);
            this.labnombre.TabIndex = 72;
            this.labnombre.Text = "Nombre:";
            // 
            // labprecio
            // 
            this.labprecio.AutoSize = true;
            this.labprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labprecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
            this.labprecio.Location = new System.Drawing.Point(36, 226);
            this.labprecio.Name = "labprecio";
            this.labprecio.Size = new System.Drawing.Size(52, 15);
            this.labprecio.TabIndex = 73;
            this.labprecio.Text = "Precio:";
            // 
            // labcantidad
            // 
            this.labcantidad.AutoSize = true;
            this.labcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
            this.labcantidad.Location = new System.Drawing.Point(36, 254);
            this.labcantidad.Name = "labcantidad";
            this.labcantidad.Size = new System.Drawing.Size(68, 15);
            this.labcantidad.TabIndex = 74;
            this.labcantidad.Text = "Cantidad:";
            // 
            // labTotalpagar
            // 
            this.labTotalpagar.AutoSize = true;
            this.labTotalpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalpagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
            this.labTotalpagar.Location = new System.Drawing.Point(39, 425);
            this.labTotalpagar.Name = "labTotalpagar";
            this.labTotalpagar.Size = new System.Drawing.Size(92, 15);
            this.labTotalpagar.TabIndex = 75;
            this.labTotalpagar.Text = "Total a pagar";
            // 
            // labefectivo
            // 
            this.labefectivo.AutoSize = true;
            this.labefectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labefectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
            this.labefectivo.Location = new System.Drawing.Point(273, 425);
            this.labefectivo.Name = "labefectivo";
            this.labefectivo.Size = new System.Drawing.Size(57, 15);
            this.labefectivo.TabIndex = 77;
            this.labefectivo.Text = "Efectivo";
            // 
            // labdevolucion
            // 
            this.labdevolucion.AutoSize = true;
            this.labdevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labdevolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
            this.labdevolucion.Location = new System.Drawing.Point(475, 425);
            this.labdevolucion.Name = "labdevolucion";
            this.labdevolucion.Size = new System.Drawing.Size(78, 15);
            this.labdevolucion.TabIndex = 78;
            this.labdevolucion.Text = "Devolución";
            // 
            // combofactu
            // 
            this.combofactu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combofactu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
            this.combofactu.FormattingEnabled = true;
            this.combofactu.Items.AddRange(new object[] {
            "jugo",
            "galleta",
            "dulces"});
            this.combofactu.Location = new System.Drawing.Point(171, 133);
            this.combofactu.Name = "combofactu";
            this.combofactu.Size = new System.Drawing.Size(121, 23);
            this.combofactu.TabIndex = 80;
            this.combofactu.SelectedIndexChanged += new System.EventHandler(this.combofactu_SelectedIndexChanged);
            // 
            // txtefectivo
            // 
            this.txtefectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtefectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
            this.txtefectivo.Location = new System.Drawing.Point(257, 449);
            this.txtefectivo.Name = "txtefectivo";
            this.txtefectivo.Size = new System.Drawing.Size(100, 21);
            this.txtefectivo.TabIndex = 85;
            this.txtefectivo.TextChanged += new System.EventHandler(this.txtefectivo_TextChanged);
            // 
            // btlimpiar_fac
            // 
            this.btlimpiar_fac.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiar_fac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btlimpiar_fac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btlimpiar_fac.BorderRadius = 0;
            this.btlimpiar_fac.ButtonText = "ELIMINAR PRODUCTO";
            this.btlimpiar_fac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlimpiar_fac.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiar_fac.Iconcolor = System.Drawing.Color.Transparent;
            this.btlimpiar_fac.Iconimage = global::APP_SIVENTU.Properties.Resources.eliminar;
            this.btlimpiar_fac.Iconimage_right = null;
            this.btlimpiar_fac.Iconimage_right_Selected = null;
            this.btlimpiar_fac.Iconimage_Selected = null;
            this.btlimpiar_fac.IconMarginLeft = 0;
            this.btlimpiar_fac.IconMarginRight = 0;
            this.btlimpiar_fac.IconRightVisible = true;
            this.btlimpiar_fac.IconRightZoom = 0D;
            this.btlimpiar_fac.IconVisible = true;
            this.btlimpiar_fac.IconZoom = 50D;
            this.btlimpiar_fac.IsTab = false;
            this.btlimpiar_fac.Location = new System.Drawing.Point(426, 200);
            this.btlimpiar_fac.Margin = new System.Windows.Forms.Padding(4);
            this.btlimpiar_fac.Name = "btlimpiar_fac";
            this.btlimpiar_fac.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btlimpiar_fac.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiar_fac.OnHoverTextColor = System.Drawing.Color.White;
            this.btlimpiar_fac.selected = false;
            this.btlimpiar_fac.Size = new System.Drawing.Size(195, 59);
            this.btlimpiar_fac.TabIndex = 68;
            this.btlimpiar_fac.Text = "ELIMINAR PRODUCTO";
            this.btlimpiar_fac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btlimpiar_fac.Textcolor = System.Drawing.Color.White;
            this.btlimpiar_fac.TextFont = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpiar_fac.Click += new System.EventHandler(this.btlimpiar_fac_Click);
            // 
            // btagregar_fac
            // 
            this.btagregar_fac.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btagregar_fac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btagregar_fac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btagregar_fac.BorderRadius = 0;
            this.btagregar_fac.ButtonText = "AGREGAR";
            this.btagregar_fac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btagregar_fac.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btagregar_fac.Iconcolor = System.Drawing.Color.Transparent;
            this.btagregar_fac.Iconimage = global::APP_SIVENTU.Properties.Resources.boton_editar__1_;
            this.btagregar_fac.Iconimage_right = null;
            this.btagregar_fac.Iconimage_right_Selected = null;
            this.btagregar_fac.Iconimage_Selected = null;
            this.btagregar_fac.IconMarginLeft = 0;
            this.btagregar_fac.IconMarginRight = 0;
            this.btagregar_fac.IconRightVisible = true;
            this.btagregar_fac.IconRightZoom = 0D;
            this.btagregar_fac.IconVisible = true;
            this.btagregar_fac.IconZoom = 50D;
            this.btagregar_fac.IsTab = false;
            this.btagregar_fac.Location = new System.Drawing.Point(428, 133);
            this.btagregar_fac.Margin = new System.Windows.Forms.Padding(4);
            this.btagregar_fac.Name = "btagregar_fac";
            this.btagregar_fac.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btagregar_fac.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btagregar_fac.OnHoverTextColor = System.Drawing.Color.White;
            this.btagregar_fac.selected = false;
            this.btagregar_fac.Size = new System.Drawing.Size(193, 59);
            this.btagregar_fac.TabIndex = 67;
            this.btagregar_fac.Text = "AGREGAR";
            this.btagregar_fac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btagregar_fac.Textcolor = System.Drawing.Color.White;
            this.btagregar_fac.TextFont = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btagregar_fac.Click += new System.EventHandler(this.btagregar_fac_Click);
            // 
            // btguardar_fac
            // 
            this.btguardar_fac.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btguardar_fac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btguardar_fac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btguardar_fac.BorderRadius = 0;
            this.btguardar_fac.ButtonText = "GUARDAR";
            this.btguardar_fac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btguardar_fac.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btguardar_fac.Iconcolor = System.Drawing.Color.Transparent;
            this.btguardar_fac.Iconimage = global::APP_SIVENTU.Properties.Resources.disquete1;
            this.btguardar_fac.Iconimage_right = null;
            this.btguardar_fac.Iconimage_right_Selected = null;
            this.btguardar_fac.Iconimage_Selected = null;
            this.btguardar_fac.IconMarginLeft = 0;
            this.btguardar_fac.IconMarginRight = 0;
            this.btguardar_fac.IconRightVisible = true;
            this.btguardar_fac.IconRightZoom = 0D;
            this.btguardar_fac.IconVisible = true;
            this.btguardar_fac.IconZoom = 50D;
            this.btguardar_fac.IsTab = false;
            this.btguardar_fac.Location = new System.Drawing.Point(214, 483);
            this.btguardar_fac.Margin = new System.Windows.Forms.Padding(4);
            this.btguardar_fac.Name = "btguardar_fac";
            this.btguardar_fac.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btguardar_fac.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btguardar_fac.OnHoverTextColor = System.Drawing.Color.White;
            this.btguardar_fac.selected = false;
            this.btguardar_fac.Size = new System.Drawing.Size(186, 59);
            this.btguardar_fac.TabIndex = 66;
            this.btguardar_fac.Text = "GUARDAR";
            this.btguardar_fac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btguardar_fac.Textcolor = System.Drawing.Color.White;
            this.btguardar_fac.TextFont = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btguardar_fac.Click += new System.EventHandler(this.btguardar_fac_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
            this.txtcantidad.Location = new System.Drawing.Point(171, 247);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 21);
            this.txtcantidad.TabIndex = 86;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-5, 106);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(843, 43);
            this.bunifuSeparator1.TabIndex = 87;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // labnum2
            // 
            this.labnum2.AutoSize = true;
            this.labnum2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold);
            this.labnum2.ForeColor = System.Drawing.Color.Maroon;
            this.labnum2.Location = new System.Drawing.Point(532, 46);
            this.labnum2.Name = "labnum2";
            this.labnum2.Size = new System.Drawing.Size(17, 23);
            this.labnum2.TabIndex = 88;
            this.labnum2.Text = "-";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
            this.textBox1.Location = new System.Drawing.Point(171, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 89;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
            this.textBox2.Location = new System.Drawing.Point(171, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 90;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
            this.textBox3.Location = new System.Drawing.Point(171, 220);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 91;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
            this.textBox4.Location = new System.Drawing.Point(32, 449);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 92;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
            this.textBox5.Location = new System.Drawing.Point(453, 449);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 93;
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(224)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(646, 561);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labnum2);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtefectivo);
            this.Controls.Add(this.combofactu);
            this.Controls.Add(this.labdevolucion);
            this.Controls.Add(this.labefectivo);
            this.Controls.Add(this.labTotalpagar);
            this.Controls.Add(this.labcantidad);
            this.Controls.Add(this.labprecio);
            this.Controls.Add(this.labnombre);
            this.Controls.Add(this.labcodigo);
            this.Controls.Add(this.labproducto);
            this.Controls.Add(this.btlimpiar_fac);
            this.Controls.Add(this.btagregar_fac);
            this.Controls.Add(this.btguardar_fac);
            this.Controls.Add(this.dgvfactu);
            this.Controls.Add(this.labnum);
            this.Controls.Add(this.nit);
            this.Controls.Add(this.nrc);
            this.Controls.Add(this.factu);
            this.Controls.Add(this.Lbventu4);
            this.Controls.Add(this.Lbventu3);
            this.Controls.Add(this.Lbventu2);
            this.Controls.Add(this.Lbventu);
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.bunifuMetroTextbox1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFactura";
            this.Text = "FormFactura";
            this.Load += new System.EventHandler(this.FormFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfactu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel Lbventu;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbventu2;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbventu3;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbventu4;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private Bunifu.Framework.UI.BunifuCustomLabel labnum;
        private Bunifu.Framework.UI.BunifuCustomLabel nit;
        private Bunifu.Framework.UI.BunifuCustomLabel nrc;
        private Bunifu.Framework.UI.BunifuCustomLabel factu;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvfactu;
        private Bunifu.Framework.UI.BunifuFlatButton btlimpiar_fac;
        private Bunifu.Framework.UI.BunifuFlatButton btagregar_fac;
        private Bunifu.Framework.UI.BunifuFlatButton btguardar_fac;
        private System.Windows.Forms.Label labproducto;
        private System.Windows.Forms.Label labcodigo;
        private System.Windows.Forms.Label labnombre;
        private System.Windows.Forms.Label labprecio;
        private System.Windows.Forms.Label labcantidad;
        private System.Windows.Forms.Label labTotalpagar;
        private System.Windows.Forms.Label labefectivo;
        private System.Windows.Forms.Label labdevolucion;
        private System.Windows.Forms.ComboBox combofactu;
        private System.Windows.Forms.TextBox txtefectivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_u;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventas_af;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.TextBox txtcantidad;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label labnum2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}