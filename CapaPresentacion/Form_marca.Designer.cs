namespace CapaPresentacion
{
    partial class Form_marca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_marca));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mover_formulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel_top = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radio_elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_excel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_imprimir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pic_buscar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.datagrid_marca = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_eliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_nuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_modificar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_guardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_marca)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mover_formulario
            // 
            this.mover_formulario.Fixed = true;
            this.mover_formulario.Horizontal = true;
            this.mover_formulario.TargetControl = this.panel_top;
            this.mover_formulario.Vertical = true;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.panel_top.Controls.Add(this.bunifuImageButton1);
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Controls.Add(this.pictureBox1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(805, 44);
            this.panel_top.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(754, 10);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(39, 31);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 31;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marca";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.icono;
            this.pictureBox1.Location = new System.Drawing.Point(20, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // radio_elipse
            // 
            this.radio_elipse.ElipseRadius = 7;
            this.radio_elipse.TargetControl = this;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txt_buscar);
            this.panel3.Controls.Add(this.btn_excel);
            this.panel3.Controls.Add(this.btn_imprimir);
            this.panel3.Controls.Add(this.pic_buscar);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(5, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(788, 67);
            this.panel3.TabIndex = 31;
            // 
            // txt_buscar
            // 
            this.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_buscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.txt_buscar.Location = new System.Drawing.Point(41, 24);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(293, 19);
            this.txt_buscar.TabIndex = 1;
            this.txt_buscar.Click += new System.EventHandler(this.txt_buscar_Click);
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // btn_excel
            // 
            this.btn_excel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.btn_excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.btn_excel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_excel.BorderRadius = 7;
            this.btn_excel.ButtonText = "Excel";
            this.btn_excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excel.DisabledColor = System.Drawing.Color.Gray;
            this.btn_excel.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_excel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_excel.Iconimage")));
            this.btn_excel.Iconimage_right = null;
            this.btn_excel.Iconimage_right_Selected = null;
            this.btn_excel.Iconimage_Selected = null;
            this.btn_excel.IconMarginLeft = 0;
            this.btn_excel.IconMarginRight = 0;
            this.btn_excel.IconRightVisible = true;
            this.btn_excel.IconRightZoom = 0D;
            this.btn_excel.IconVisible = true;
            this.btn_excel.IconZoom = 50D;
            this.btn_excel.IsTab = false;
            this.btn_excel.Location = new System.Drawing.Point(629, 17);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.btn_excel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(126)))));
            this.btn_excel.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_excel.selected = false;
            this.btn_excel.Size = new System.Drawing.Size(125, 35);
            this.btn_excel.TabIndex = 13;
            this.btn_excel.Text = "Excel";
            this.btn_excel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_excel.Textcolor = System.Drawing.Color.White;
            this.btn_excel.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.btn_imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.btn_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir.BorderRadius = 7;
            this.btn_imprimir.ButtonText = "Imprimir";
            this.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimir.DisabledColor = System.Drawing.Color.Gray;
            this.btn_imprimir.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_imprimir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_imprimir.Iconimage")));
            this.btn_imprimir.Iconimage_right = null;
            this.btn_imprimir.Iconimage_right_Selected = null;
            this.btn_imprimir.Iconimage_Selected = null;
            this.btn_imprimir.IconMarginLeft = 0;
            this.btn_imprimir.IconMarginRight = 0;
            this.btn_imprimir.IconRightVisible = true;
            this.btn_imprimir.IconRightZoom = 0D;
            this.btn_imprimir.IconVisible = true;
            this.btn_imprimir.IconZoom = 50D;
            this.btn_imprimir.IsTab = false;
            this.btn_imprimir.Location = new System.Drawing.Point(473, 17);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.btn_imprimir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(126)))));
            this.btn_imprimir.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_imprimir.selected = false;
            this.btn_imprimir.Size = new System.Drawing.Size(125, 35);
            this.btn_imprimir.TabIndex = 12;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_imprimir.Textcolor = System.Drawing.Color.White;
            this.btn_imprimir.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // pic_buscar
            // 
            this.pic_buscar.Image = global::CapaPresentacion.Properties.Resources.buscar2;
            this.pic_buscar.Location = new System.Drawing.Point(13, 21);
            this.pic_buscar.Name = "pic_buscar";
            this.pic_buscar.Size = new System.Drawing.Size(22, 22);
            this.pic_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_buscar.TabIndex = 3;
            this.pic_buscar.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.caja_buscar;
            this.pictureBox2.Location = new System.Drawing.Point(7, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(344, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.txt_codigo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_descripcion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Location = new System.Drawing.Point(473, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 231);
            this.panel1.TabIndex = 36;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.txt_nombre.Location = new System.Drawing.Point(22, 106);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(243, 19);
            this.txt_nombre.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CapaPresentacion.Properties.Resources.caja_buscar;
            this.pictureBox4.Location = new System.Drawing.Point(17, 100);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(263, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // txt_codigo
            // 
            this.txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.txt_codigo.Location = new System.Drawing.Point(23, 44);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(242, 19);
            this.txt_codigo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(14, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Codigo";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_descripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.txt_descripcion.Location = new System.Drawing.Point(23, 172);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(242, 35);
            this.txt_descripcion.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(14, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nombre ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.caja_buscar;
            this.pictureBox3.Location = new System.Drawing.Point(18, 166);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(262, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(14, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Descripcion";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CapaPresentacion.Properties.Resources.caja_buscar;
            this.pictureBox6.Location = new System.Drawing.Point(18, 38);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(262, 31);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 24;
            this.pictureBox6.TabStop = false;
            // 
            // datagrid_marca
            // 
            this.datagrid_marca.AllowUserToAddRows = false;
            this.datagrid_marca.AllowUserToDeleteRows = false;
            this.datagrid_marca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_marca.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagrid_marca.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.datagrid_marca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid_marca.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_marca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_marca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_marca.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_marca.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_marca.Location = new System.Drawing.Point(10, 152);
            this.datagrid_marca.Name = "datagrid_marca";
            this.datagrid_marca.ReadOnly = true;
            this.datagrid_marca.RowHeadersVisible = false;
            this.datagrid_marca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_marca.Size = new System.Drawing.Size(440, 192);
            this.datagrid_marca.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.label4.Location = new System.Drawing.Point(184, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 22);
            this.label4.TabIndex = 34;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.label3.Location = new System.Drawing.Point(74, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nombre ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.label2.Location = new System.Drawing.Point(9, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Cod";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_eliminar);
            this.panel2.Controls.Add(this.btn_nuevo);
            this.panel2.Controls.Add(this.btn_modificar);
            this.panel2.Controls.Add(this.btn_guardar);
            this.panel2.Location = new System.Drawing.Point(10, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 80);
            this.panel2.TabIndex = 37;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.BorderRadius = 7;
            this.btn_eliminar.ButtonText = "Eliminar";
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_eliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_eliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Iconimage")));
            this.btn_eliminar.Iconimage_right = null;
            this.btn_eliminar.Iconimage_right_Selected = null;
            this.btn_eliminar.Iconimage_Selected = null;
            this.btn_eliminar.IconMarginLeft = 0;
            this.btn_eliminar.IconMarginRight = 0;
            this.btn_eliminar.IconRightVisible = true;
            this.btn_eliminar.IconRightZoom = 0D;
            this.btn_eliminar.IconVisible = true;
            this.btn_eliminar.IconZoom = 50D;
            this.btn_eliminar.IsTab = false;
            this.btn_eliminar.Location = new System.Drawing.Point(298, 25);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.btn_eliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(126)))));
            this.btn_eliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_eliminar.selected = false;
            this.btn_eliminar.Size = new System.Drawing.Size(125, 35);
            this.btn_eliminar.TabIndex = 11;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_eliminar.Textcolor = System.Drawing.Color.White;
            this.btn_eliminar.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo.BorderRadius = 7;
            this.btn_nuevo.ButtonText = "Nuevo";
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.DisabledColor = System.Drawing.Color.Gray;
            this.btn_nuevo.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_nuevo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.Iconimage")));
            this.btn_nuevo.Iconimage_right = null;
            this.btn_nuevo.Iconimage_right_Selected = null;
            this.btn_nuevo.Iconimage_Selected = null;
            this.btn_nuevo.IconMarginLeft = 0;
            this.btn_nuevo.IconMarginRight = 0;
            this.btn_nuevo.IconRightVisible = true;
            this.btn_nuevo.IconRightZoom = 0D;
            this.btn_nuevo.IconVisible = true;
            this.btn_nuevo.IconZoom = 50D;
            this.btn_nuevo.IsTab = false;
            this.btn_nuevo.Location = new System.Drawing.Point(13, 25);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.btn_nuevo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(126)))));
            this.btn_nuevo.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_nuevo.selected = false;
            this.btn_nuevo.Size = new System.Drawing.Size(124, 35);
            this.btn_nuevo.TabIndex = 9;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_nuevo.Textcolor = System.Drawing.Color.White;
            this.btn_nuevo.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.BorderRadius = 7;
            this.btn_modificar.ButtonText = "Modificar";
            this.btn_modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modificar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_modificar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_modificar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_modificar.Iconimage")));
            this.btn_modificar.Iconimage_right = null;
            this.btn_modificar.Iconimage_right_Selected = null;
            this.btn_modificar.Iconimage_Selected = null;
            this.btn_modificar.IconMarginLeft = 0;
            this.btn_modificar.IconMarginRight = 0;
            this.btn_modificar.IconRightVisible = true;
            this.btn_modificar.IconRightZoom = 0D;
            this.btn_modificar.IconVisible = true;
            this.btn_modificar.IconZoom = 50D;
            this.btn_modificar.IsTab = false;
            this.btn_modificar.Location = new System.Drawing.Point(154, 25);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.btn_modificar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(126)))));
            this.btn_modificar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_modificar.selected = false;
            this.btn_modificar.Size = new System.Drawing.Size(124, 35);
            this.btn_modificar.TabIndex = 10;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_modificar.Textcolor = System.Drawing.Color.White;
            this.btn_modificar.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.BorderRadius = 7;
            this.btn_guardar.ButtonText = "Guardar";
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_guardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_guardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Iconimage")));
            this.btn_guardar.Iconimage_right = null;
            this.btn_guardar.Iconimage_right_Selected = null;
            this.btn_guardar.Iconimage_Selected = null;
            this.btn_guardar.IconMarginLeft = 0;
            this.btn_guardar.IconMarginRight = 0;
            this.btn_guardar.IconRightVisible = true;
            this.btn_guardar.IconRightZoom = 0D;
            this.btn_guardar.IconVisible = true;
            this.btn_guardar.IconZoom = 50D;
            this.btn_guardar.IsTab = false;
            this.btn_guardar.Location = new System.Drawing.Point(484, 25);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.btn_guardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(126)))));
            this.btn_guardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_guardar.selected = false;
            this.btn_guardar.Size = new System.Drawing.Size(263, 35);
            this.btn_guardar.TabIndex = 14;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_guardar.Textcolor = System.Drawing.Color.White;
            this.btn_guardar.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Form_marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.datagrid_marca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_marca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_marca";
            this.Load += new System.EventHandler(this.Form_marca_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_marca)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl mover_formulario;
        private Bunifu.Framework.UI.BunifuElipse radio_elipse;
        private System.Windows.Forms.Panel panel_top;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_buscar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_excel;
        private Bunifu.Framework.UI.BunifuFlatButton btn_imprimir;
        private System.Windows.Forms.PictureBox pic_buscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.DataGridView datagrid_marca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_eliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_nuevo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_modificar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_guardar;
    }
}