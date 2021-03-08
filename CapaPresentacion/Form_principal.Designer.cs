namespace CapaPresentacion
{
    partial class Form_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_principal));
            this.sidebar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wrapper = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.flecha = new System.Windows.Forms.PictureBox();
            this.btn_dashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_ganancia = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_proveedores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_clientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_trabajadores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_compras = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_ventas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_producto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidebar.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.sidebar.Controls.Add(this.flecha);
            this.sidebar.Controls.Add(this.btn_dashboard);
            this.sidebar.Controls.Add(this.btn_ganancia);
            this.sidebar.Controls.Add(this.btn_proveedores);
            this.sidebar.Controls.Add(this.btn_clientes);
            this.sidebar.Controls.Add(this.btn_trabajadores);
            this.sidebar.Controls.Add(this.btn_compras);
            this.sidebar.Controls.Add(this.btn_ventas);
            this.sidebar.Controls.Add(this.btn_producto);
            this.sidebar.Controls.Add(this.label3);
            this.sidebar.Controls.Add(this.pictureBox2);
            this.sidebar.Controls.Add(this.label2);
            this.sidebar.Controls.Add(this.pictureBox1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(243, 687);
            this.sidebar.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label3.Location = new System.Drawing.Point(96, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Allan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label2.Location = new System.Drawing.Point(82, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "APP";
            // 
            // wrapper
            // 
            this.wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapper.Location = new System.Drawing.Point(243, 0);
            this.wrapper.Name = "wrapper";
            this.wrapper.Size = new System.Drawing.Size(957, 687);
            this.wrapper.TabIndex = 1;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.header.Controls.Add(this.label1);
            this.header.Controls.Add(this.btn_salir);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(243, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(957, 70);
            this.header.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DASHBOARD";
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.Image = global::CapaPresentacion.Properties.Resources.Salir;
            this.btn_salir.Location = new System.Drawing.Point(903, 12);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(42, 42);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_salir.TabIndex = 0;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // flecha
            // 
            this.flecha.Image = global::CapaPresentacion.Properties.Resources.Flecha;
            this.flecha.Location = new System.Drawing.Point(209, 229);
            this.flecha.Name = "flecha";
            this.flecha.Size = new System.Drawing.Size(43, 40);
            this.flecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flecha.TabIndex = 14;
            this.flecha.TabStop = false;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Activecolor = System.Drawing.Color.Transparent;
            this.btn_dashboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dashboard.BorderRadius = 0;
            this.btn_dashboard.ButtonText = "        DASHBOARD";
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btn_dashboard.ForeColor = System.Drawing.Color.Transparent;
            this.btn_dashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_dashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_dashboard.Iconimage")));
            this.btn_dashboard.Iconimage_right = null;
            this.btn_dashboard.Iconimage_right_Selected = null;
            this.btn_dashboard.Iconimage_Selected = global::CapaPresentacion.Properties.Resources.Dashboard_Verde;
            this.btn_dashboard.IconMarginLeft = 0;
            this.btn_dashboard.IconMarginRight = 0;
            this.btn_dashboard.IconRightVisible = true;
            this.btn_dashboard.IconRightZoom = 0D;
            this.btn_dashboard.IconVisible = true;
            this.btn_dashboard.IconZoom = 90D;
            this.btn_dashboard.IsTab = true;
            this.btn_dashboard.Location = new System.Drawing.Point(12, 229);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_dashboard.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_dashboard.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(195)))), ((int)(((byte)(140)))));
            this.btn_dashboard.selected = false;
            this.btn_dashboard.Size = new System.Drawing.Size(200, 40);
            this.btn_dashboard.TabIndex = 13;
            this.btn_dashboard.Text = "        DASHBOARD";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Textcolor = System.Drawing.Color.White;
            this.btn_dashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // btn_ganancia
            // 
            this.btn_ganancia.Activecolor = System.Drawing.Color.Transparent;
            this.btn_ganancia.BackColor = System.Drawing.Color.Transparent;
            this.btn_ganancia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ganancia.BorderRadius = 0;
            this.btn_ganancia.ButtonText = "       GANANCIAS";
            this.btn_ganancia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ganancia.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ganancia.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ganancia.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ganancia.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_ganancia.Iconimage")));
            this.btn_ganancia.Iconimage_right = null;
            this.btn_ganancia.Iconimage_right_Selected = null;
            this.btn_ganancia.Iconimage_Selected = global::CapaPresentacion.Properties.Resources.Ganancinas_Verde;
            this.btn_ganancia.IconMarginLeft = 0;
            this.btn_ganancia.IconMarginRight = 0;
            this.btn_ganancia.IconRightVisible = true;
            this.btn_ganancia.IconRightZoom = 0D;
            this.btn_ganancia.IconVisible = true;
            this.btn_ganancia.IconZoom = 90D;
            this.btn_ganancia.IsTab = true;
            this.btn_ganancia.Location = new System.Drawing.Point(14, 626);
            this.btn_ganancia.Name = "btn_ganancia";
            this.btn_ganancia.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_ganancia.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_ganancia.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(195)))), ((int)(((byte)(140)))));
            this.btn_ganancia.selected = false;
            this.btn_ganancia.Size = new System.Drawing.Size(200, 40);
            this.btn_ganancia.TabIndex = 12;
            this.btn_ganancia.Text = "       GANANCIAS";
            this.btn_ganancia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ganancia.Textcolor = System.Drawing.Color.White;
            this.btn_ganancia.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ganancia.Click += new System.EventHandler(this.btn_ganancia_Click);
            // 
            // btn_proveedores
            // 
            this.btn_proveedores.Activecolor = System.Drawing.Color.Transparent;
            this.btn_proveedores.BackColor = System.Drawing.Color.Transparent;
            this.btn_proveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_proveedores.BorderRadius = 0;
            this.btn_proveedores.ButtonText = "        PROVEEDORES";
            this.btn_proveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_proveedores.DisabledColor = System.Drawing.Color.Gray;
            this.btn_proveedores.ForeColor = System.Drawing.Color.Transparent;
            this.btn_proveedores.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_proveedores.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_proveedores.Iconimage")));
            this.btn_proveedores.Iconimage_right = null;
            this.btn_proveedores.Iconimage_right_Selected = null;
            this.btn_proveedores.Iconimage_Selected = global::CapaPresentacion.Properties.Resources.Proveedores_Verde;
            this.btn_proveedores.IconMarginLeft = 0;
            this.btn_proveedores.IconMarginRight = 0;
            this.btn_proveedores.IconRightVisible = true;
            this.btn_proveedores.IconRightZoom = 0D;
            this.btn_proveedores.IconVisible = true;
            this.btn_proveedores.IconZoom = 90D;
            this.btn_proveedores.IsTab = true;
            this.btn_proveedores.Location = new System.Drawing.Point(12, 569);
            this.btn_proveedores.Name = "btn_proveedores";
            this.btn_proveedores.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_proveedores.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_proveedores.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(195)))), ((int)(((byte)(140)))));
            this.btn_proveedores.selected = false;
            this.btn_proveedores.Size = new System.Drawing.Size(200, 40);
            this.btn_proveedores.TabIndex = 11;
            this.btn_proveedores.Text = "        PROVEEDORES";
            this.btn_proveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_proveedores.Textcolor = System.Drawing.Color.White;
            this.btn_proveedores.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proveedores.Click += new System.EventHandler(this.btn_proveedores_Click);
            // 
            // btn_clientes
            // 
            this.btn_clientes.Activecolor = System.Drawing.Color.Transparent;
            this.btn_clientes.BackColor = System.Drawing.Color.Transparent;
            this.btn_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clientes.BorderRadius = 0;
            this.btn_clientes.ButtonText = "        CLIENTES";
            this.btn_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clientes.DisabledColor = System.Drawing.Color.Gray;
            this.btn_clientes.ForeColor = System.Drawing.Color.Transparent;
            this.btn_clientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_clientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_clientes.Iconimage")));
            this.btn_clientes.Iconimage_right = null;
            this.btn_clientes.Iconimage_right_Selected = null;
            this.btn_clientes.Iconimage_Selected = global::CapaPresentacion.Properties.Resources.Clientes_Verde;
            this.btn_clientes.IconMarginLeft = 0;
            this.btn_clientes.IconMarginRight = 0;
            this.btn_clientes.IconRightVisible = true;
            this.btn_clientes.IconRightZoom = 0D;
            this.btn_clientes.IconVisible = true;
            this.btn_clientes.IconZoom = 90D;
            this.btn_clientes.IsTab = true;
            this.btn_clientes.Location = new System.Drawing.Point(12, 508);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_clientes.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_clientes.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(195)))), ((int)(((byte)(140)))));
            this.btn_clientes.selected = false;
            this.btn_clientes.Size = new System.Drawing.Size(200, 40);
            this.btn_clientes.TabIndex = 10;
            this.btn_clientes.Text = "        CLIENTES";
            this.btn_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clientes.Textcolor = System.Drawing.Color.White;
            this.btn_clientes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // btn_trabajadores
            // 
            this.btn_trabajadores.Activecolor = System.Drawing.Color.Transparent;
            this.btn_trabajadores.BackColor = System.Drawing.Color.Transparent;
            this.btn_trabajadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_trabajadores.BorderRadius = 0;
            this.btn_trabajadores.ButtonText = "        TRABAJADORES";
            this.btn_trabajadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_trabajadores.DisabledColor = System.Drawing.Color.Gray;
            this.btn_trabajadores.ForeColor = System.Drawing.Color.Transparent;
            this.btn_trabajadores.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_trabajadores.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_trabajadores.Iconimage")));
            this.btn_trabajadores.Iconimage_right = null;
            this.btn_trabajadores.Iconimage_right_Selected = null;
            this.btn_trabajadores.Iconimage_Selected = global::CapaPresentacion.Properties.Resources.Trabajadores_Verde;
            this.btn_trabajadores.IconMarginLeft = 0;
            this.btn_trabajadores.IconMarginRight = 0;
            this.btn_trabajadores.IconRightVisible = true;
            this.btn_trabajadores.IconRightZoom = 0D;
            this.btn_trabajadores.IconVisible = true;
            this.btn_trabajadores.IconZoom = 90D;
            this.btn_trabajadores.IsTab = true;
            this.btn_trabajadores.Location = new System.Drawing.Point(12, 447);
            this.btn_trabajadores.Name = "btn_trabajadores";
            this.btn_trabajadores.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_trabajadores.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_trabajadores.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(195)))), ((int)(((byte)(140)))));
            this.btn_trabajadores.selected = false;
            this.btn_trabajadores.Size = new System.Drawing.Size(200, 40);
            this.btn_trabajadores.TabIndex = 9;
            this.btn_trabajadores.Text = "        TRABAJADORES";
            this.btn_trabajadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trabajadores.Textcolor = System.Drawing.Color.White;
            this.btn_trabajadores.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trabajadores.Click += new System.EventHandler(this.btn_trabajadores_Click);
            // 
            // btn_compras
            // 
            this.btn_compras.Activecolor = System.Drawing.Color.Transparent;
            this.btn_compras.BackColor = System.Drawing.Color.Transparent;
            this.btn_compras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_compras.BorderRadius = 0;
            this.btn_compras.ButtonText = "        COMPRAS";
            this.btn_compras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_compras.DisabledColor = System.Drawing.Color.Gray;
            this.btn_compras.ForeColor = System.Drawing.Color.Transparent;
            this.btn_compras.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_compras.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_compras.Iconimage")));
            this.btn_compras.Iconimage_right = null;
            this.btn_compras.Iconimage_right_Selected = null;
            this.btn_compras.Iconimage_Selected = global::CapaPresentacion.Properties.Resources.Compras_Verde;
            this.btn_compras.IconMarginLeft = 0;
            this.btn_compras.IconMarginRight = 0;
            this.btn_compras.IconRightVisible = true;
            this.btn_compras.IconRightZoom = 0D;
            this.btn_compras.IconVisible = true;
            this.btn_compras.IconZoom = 90D;
            this.btn_compras.IsTab = true;
            this.btn_compras.Location = new System.Drawing.Point(12, 400);
            this.btn_compras.Name = "btn_compras";
            this.btn_compras.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_compras.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_compras.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(195)))), ((int)(((byte)(140)))));
            this.btn_compras.selected = false;
            this.btn_compras.Size = new System.Drawing.Size(200, 40);
            this.btn_compras.TabIndex = 8;
            this.btn_compras.Text = "        COMPRAS";
            this.btn_compras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_compras.Textcolor = System.Drawing.Color.White;
            this.btn_compras.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compras.Click += new System.EventHandler(this.btn_compras_Click);
            // 
            // btn_ventas
            // 
            this.btn_ventas.Activecolor = System.Drawing.Color.Transparent;
            this.btn_ventas.BackColor = System.Drawing.Color.Transparent;
            this.btn_ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ventas.BorderRadius = 0;
            this.btn_ventas.ButtonText = "        VENTAS";
            this.btn_ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ventas.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ventas.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ventas.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ventas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_ventas.Iconimage")));
            this.btn_ventas.Iconimage_right = null;
            this.btn_ventas.Iconimage_right_Selected = null;
            this.btn_ventas.Iconimage_Selected = global::CapaPresentacion.Properties.Resources.Ventas_Verde;
            this.btn_ventas.IconMarginLeft = 0;
            this.btn_ventas.IconMarginRight = 0;
            this.btn_ventas.IconRightVisible = true;
            this.btn_ventas.IconRightZoom = 0D;
            this.btn_ventas.IconVisible = true;
            this.btn_ventas.IconZoom = 90D;
            this.btn_ventas.IsTab = true;
            this.btn_ventas.Location = new System.Drawing.Point(12, 344);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_ventas.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_ventas.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(195)))), ((int)(((byte)(140)))));
            this.btn_ventas.selected = false;
            this.btn_ventas.Size = new System.Drawing.Size(200, 40);
            this.btn_ventas.TabIndex = 7;
            this.btn_ventas.Text = "        VENTAS";
            this.btn_ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ventas.Textcolor = System.Drawing.Color.White;
            this.btn_ventas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // btn_producto
            // 
            this.btn_producto.Activecolor = System.Drawing.Color.Transparent;
            this.btn_producto.BackColor = System.Drawing.Color.Transparent;
            this.btn_producto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_producto.BorderRadius = 0;
            this.btn_producto.ButtonText = "        PRODUCTOS";
            this.btn_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_producto.DisabledColor = System.Drawing.Color.Gray;
            this.btn_producto.ForeColor = System.Drawing.Color.Transparent;
            this.btn_producto.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_producto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_producto.Iconimage")));
            this.btn_producto.Iconimage_right = null;
            this.btn_producto.Iconimage_right_Selected = null;
            this.btn_producto.Iconimage_Selected = global::CapaPresentacion.Properties.Resources.Productos_Verde;
            this.btn_producto.IconMarginLeft = 0;
            this.btn_producto.IconMarginRight = 0;
            this.btn_producto.IconRightVisible = true;
            this.btn_producto.IconRightZoom = 0D;
            this.btn_producto.IconVisible = true;
            this.btn_producto.IconZoom = 90D;
            this.btn_producto.IsTab = true;
            this.btn_producto.Location = new System.Drawing.Point(12, 285);
            this.btn_producto.Name = "btn_producto";
            this.btn_producto.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_producto.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_producto.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(195)))), ((int)(((byte)(140)))));
            this.btn_producto.selected = false;
            this.btn_producto.Size = new System.Drawing.Size(200, 40);
            this.btn_producto.TabIndex = 6;
            this.btn_producto.Text = "        PRODUCTOS";
            this.btn_producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_producto.Textcolor = System.Drawing.Color.White;
            this.btn_producto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_producto.Click += new System.EventHandler(this.btn_producto_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.Administrador;
            this.pictureBox2.Location = new System.Drawing.Point(57, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.icono1;
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 687);
            this.Controls.Add(this.header);
            this.Controls.Add(this.wrapper);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_principal";
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel wrapper;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_dashboard;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ganancia;
        private Bunifu.Framework.UI.BunifuFlatButton btn_proveedores;
        private Bunifu.Framework.UI.BunifuFlatButton btn_clientes;
        private Bunifu.Framework.UI.BunifuFlatButton btn_trabajadores;
        private Bunifu.Framework.UI.BunifuFlatButton btn_compras;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ventas;
        private Bunifu.Framework.UI.BunifuFlatButton btn_producto;
        private System.Windows.Forms.PictureBox flecha;
    }
}