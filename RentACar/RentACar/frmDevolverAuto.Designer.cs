namespace RentACar
{
    partial class frmDevolverAuto
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
            this.btnDevolverAuto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaDev = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarFactura = new System.Windows.Forms.Button();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbAuto = new System.Windows.Forms.PictureBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxEstadoAuto = new System.Windows.Forms.ComboBox();
            this.lblCantidadPagar = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRecargo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rtbDesEstado = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblNombreV = new System.Windows.Forms.Label();
            this.lblDUIV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRetraso = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFechaDev = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblRecarRetraso = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblMsj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDevolverAuto
            // 
            this.btnDevolverAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDevolverAuto.FlatAppearance.BorderSize = 0;
            this.btnDevolverAuto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnDevolverAuto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDevolverAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolverAuto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolverAuto.ForeColor = System.Drawing.Color.LightGray;
            this.btnDevolverAuto.Location = new System.Drawing.Point(417, 606);
            this.btnDevolverAuto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDevolverAuto.Name = "btnDevolverAuto";
            this.btnDevolverAuto.Size = new System.Drawing.Size(195, 66);
            this.btnDevolverAuto.TabIndex = 48;
            this.btnDevolverAuto.Text = "Devolver Auto";
            this.btnDevolverAuto.UseVisualStyleBackColor = false;
            this.btnDevolverAuto.Click += new System.EventHandler(this.btnDevolverAuto_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(563, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "Recargo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(13, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Estado del Auto:";
            // 
            // dtpFechaDev
            // 
            this.dtpFechaDev.Location = new System.Drawing.Point(559, 24);
            this.dtpFechaDev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechaDev.Name = "dtpFechaDev";
            this.dtpFechaDev.Size = new System.Drawing.Size(237, 21);
            this.dtpFechaDev.TabIndex = 42;
            this.dtpFechaDev.ValueChanged += new System.EventHandler(this.dtpFechaDev_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(349, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Fecha de Devolución:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(393, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "DUI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nombre:";
            // 
            // btnBuscarFactura
            // 
            this.btnBuscarFactura.Location = new System.Drawing.Point(433, 83);
            this.btnBuscarFactura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarFactura.Name = "btnBuscarFactura";
            this.btnBuscarFactura.Size = new System.Drawing.Size(42, 22);
            this.btnBuscarFactura.TabIndex = 34;
            this.btnBuscarFactura.Text = "...";
            this.btnBuscarFactura.UseVisualStyleBackColor = true;
            this.btnBuscarFactura.Click += new System.EventHandler(this.btnBuscarFactura_Click);
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(240, 84);
            this.txtFactura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.ReadOnly = true;
            this.txtFactura.Size = new System.Drawing.Size(177, 21);
            this.txtFactura.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(77, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Factura:";
            // 
            // pbAuto
            // 
            this.pbAuto.Location = new System.Drawing.Point(16, 16);
            this.pbAuto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbAuto.Name = "pbAuto";
            this.pbAuto.Size = new System.Drawing.Size(139, 129);
            this.pbAuto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAuto.TabIndex = 30;
            this.pbAuto.TabStop = false;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAnio.Location = new System.Drawing.Point(322, 119);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(39, 20);
            this.lblAnio.TabIndex = 29;
            this.lblAnio.Text = "Año";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblColor.Location = new System.Drawing.Point(322, 99);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(49, 20);
            this.lblColor.TabIndex = 28;
            this.lblColor.Text = "Color";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblModelo.Location = new System.Drawing.Point(322, 76);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(67, 20);
            this.lblModelo.TabIndex = 27;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMarca.Location = new System.Drawing.Point(322, 52);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(59, 20);
            this.lblMarca.TabIndex = 26;
            this.lblMarca.Text = "Marca";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(646, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "$";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMatricula.Location = new System.Drawing.Point(322, 27);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(79, 20);
            this.lblMatricula.TabIndex = 50;
            this.lblMatricula.Text = "Matricula";
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrega.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFechaEntrega.Location = new System.Drawing.Point(164, 42);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(0, 20);
            this.lblFechaEntrega.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(14, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 20);
            this.label11.TabIndex = 52;
            this.label11.Text = "Fecha de Entrega:";
            // 
            // cbxEstadoAuto
            // 
            this.cbxEstadoAuto.FormattingEnabled = true;
            this.cbxEstadoAuto.Items.AddRange(new object[] {
            "En buen estado",
            "Averiado"});
            this.cbxEstadoAuto.Location = new System.Drawing.Point(177, 20);
            this.cbxEstadoAuto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxEstadoAuto.Name = "cbxEstadoAuto";
            this.cbxEstadoAuto.Size = new System.Drawing.Size(140, 24);
            this.cbxEstadoAuto.TabIndex = 54;
            this.cbxEstadoAuto.SelectedIndexChanged += new System.EventHandler(this.cbxEstadoAuto_SelectedIndexChanged);
            this.cbxEstadoAuto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxEstadoAuto_KeyPress);
            // 
            // lblCantidadPagar
            // 
            this.lblCantidadPagar.AutoSize = true;
            this.lblCantidadPagar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPagar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCantidadPagar.Location = new System.Drawing.Point(175, 163);
            this.lblCantidadPagar.Name = "lblCantidadPagar";
            this.lblCantidadPagar.Size = new System.Drawing.Size(29, 20);
            this.lblCantidadPagar.TabIndex = 58;
            this.lblCantidadPagar.Text = "0.0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(13, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 20);
            this.label13.TabIndex = 57;
            this.label13.Text = "Cantidad a Pagar:";
            // 
            // txtRecargo
            // 
            this.txtRecargo.Enabled = false;
            this.txtRecargo.Location = new System.Drawing.Point(669, 161);
            this.txtRecargo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRecargo.Name = "txtRecargo";
            this.txtRecargo.Size = new System.Drawing.Size(140, 21);
            this.txtRecargo.TabIndex = 59;
            this.txtRecargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecargo_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(13, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 20);
            this.label10.TabIndex = 60;
            this.label10.Text = "Descripción de Estado:";
            // 
            // rtbDesEstado
            // 
            this.rtbDesEstado.Location = new System.Drawing.Point(196, 72);
            this.rtbDesEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbDesEstado.Name = "rtbDesEstado";
            this.rtbDesEstado.Size = new System.Drawing.Size(614, 63);
            this.rtbDesEstado.TabIndex = 61;
            this.rtbDesEstado.Text = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblNombreV
            // 
            this.lblNombreV.AutoSize = true;
            this.lblNombreV.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreV.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNombreV.Location = new System.Drawing.Point(90, 15);
            this.lblNombreV.Name = "lblNombreV";
            this.lblNombreV.Size = new System.Drawing.Size(0, 20);
            this.lblNombreV.TabIndex = 62;
            // 
            // lblDUIV
            // 
            this.lblDUIV.AutoSize = true;
            this.lblDUIV.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUIV.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDUIV.Location = new System.Drawing.Point(439, 15);
            this.lblDUIV.Name = "lblDUIV";
            this.lblDUIV.Size = new System.Drawing.Size(0, 20);
            this.lblDUIV.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(141)))));
            this.label1.Location = new System.Drawing.Point(499, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 64;
            this.label1.Text = "Devolver Auto";
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(141)))));
            this.lblReg.Location = new System.Drawing.Point(907, 652);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(87, 20);
            this.lblReg.TabIndex = 65;
            this.lblReg.Text = "< Regresar";
            this.lblReg.Click += new System.EventHandler(this.lblReg_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 27);
            this.panel1.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(314, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Recargo por Retraso:";
            // 
            // lblRetraso
            // 
            this.lblRetraso.AutoSize = true;
            this.lblRetraso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetraso.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRetraso.Location = new System.Drawing.Point(522, 163);
            this.lblRetraso.Name = "lblRetraso";
            this.lblRetraso.Size = new System.Drawing.Size(0, 20);
            this.lblRetraso.TabIndex = 68;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(485, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 20);
            this.label14.TabIndex = 69;
            this.label14.Text = "$";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblMatricula);
            this.groupBox1.Controls.Add(this.pbAuto);
            this.groupBox1.Controls.Add(this.lblAnio);
            this.groupBox1.Controls.Add(this.lblColor);
            this.groupBox1.Controls.Add(this.lblModelo);
            this.groupBox1.Controls.Add(this.lblMarca);
            this.groupBox1.Location = new System.Drawing.Point(64, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 151);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.Location = new System.Drawing.Point(184, 119);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 20);
            this.label18.TabIndex = 68;
            this.label18.Text = "Año:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(184, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 20);
            this.label17.TabIndex = 67;
            this.label17.Text = "Marca:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(184, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 20);
            this.label16.TabIndex = 66;
            this.label16.Text = "Modelo:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(184, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 20);
            this.label15.TabIndex = 65;
            this.label15.Text = "Color:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(184, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 64;
            this.label12.Text = "Matrícula:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFechaDev);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.lblDUIV);
            this.groupBox2.Controls.Add(this.lblNombreV);
            this.groupBox2.Controls.Add(this.lblFechaEntrega);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(63, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(850, 75);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro de Renta";
            // 
            // lblFechaDev
            // 
            this.lblFechaDev.AutoSize = true;
            this.lblFechaDev.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDev.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFechaDev.Location = new System.Drawing.Point(575, 42);
            this.lblFechaDev.Name = "lblFechaDev";
            this.lblFechaDev.Size = new System.Drawing.Size(0, 20);
            this.lblFechaDev.TabIndex = 65;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label20.Location = new System.Drawing.Point(393, 42);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(176, 20);
            this.label20.TabIndex = 64;
            this.label20.Text = "Fecha de Devolución :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblRecarRetraso);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.lblRetraso);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.rtbDesEstado);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtRecargo);
            this.groupBox3.Controls.Add(this.lblCantidadPagar);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.cbxEstadoAuto);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dtpFechaDev);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(64, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(849, 218);
            this.groupBox3.TabIndex = 72;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Devolución";
            // 
            // lblRecarRetraso
            // 
            this.lblRecarRetraso.AutoSize = true;
            this.lblRecarRetraso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecarRetraso.Location = new System.Drawing.Point(503, 163);
            this.lblRecarRetraso.Name = "lblRecarRetraso";
            this.lblRecarRetraso.Size = new System.Drawing.Size(29, 20);
            this.lblRecarRetraso.TabIndex = 71;
            this.lblRecarRetraso.Text = "0.0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(163, 163);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 20);
            this.label19.TabIndex = 70;
            this.label19.Text = "$";
            // 
            // lblMsj
            // 
            this.lblMsj.AutoSize = true;
            this.lblMsj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(141)))));
            this.lblMsj.Location = new System.Drawing.Point(502, 84);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(0, 21);
            this.lblMsj.TabIndex = 73;
            // 
            // frmDevolverAuto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1035, 693);
            this.Controls.Add(this.lblMsj);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDevolverAuto);
            this.Controls.Add(this.btnBuscarFactura);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDevolverAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDevolverAuto";
            this.Load += new System.EventHandler(this.frmDevolverAuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDevolverAuto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaDev;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbAuto;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxEstadoAuto;
        private System.Windows.Forms.Label lblCantidadPagar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRecargo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbDesEstado;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblDUIV;
        private System.Windows.Forms.Label lblNombreV;
        public System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblRetraso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblRecarRetraso;
        private System.Windows.Forms.Label lblFechaDev;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblMsj;
    }
}