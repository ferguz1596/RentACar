namespace RentACar
{
    partial class frmRentaDeAuto
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.pbAuto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatriculaAuto = new System.Windows.Forms.TextBox();
            this.btnBuscarMatricula = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDev = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRentarAuto = new System.Windows.Forms.Button();
            this.lblCantidadDias = new System.Windows.Forms.Label();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.lblMontoTarifa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegresar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(220, 131);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(59, 20);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(220, 160);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(67, 20);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(219, 185);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(49, 20);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "Color";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.Location = new System.Drawing.Point(220, 208);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(39, 20);
            this.lblAnio.TabIndex = 4;
            this.lblAnio.Text = "Año";
            // 
            // pbAuto
            // 
            this.pbAuto.Location = new System.Drawing.Point(53, 95);
            this.pbAuto.Name = "pbAuto";
            this.pbAuto.Size = new System.Drawing.Size(140, 131);
            this.pbAuto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAuto.TabIndex = 5;
            this.pbAuto.TabStop = false;
            this.pbAuto.Click += new System.EventHandler(this.pbAuto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Auto:";
            // 
            // txtMatriculaAuto
            // 
            this.txtMatriculaAuto.Enabled = false;
            this.txtMatriculaAuto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatriculaAuto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMatriculaAuto.Location = new System.Drawing.Point(278, 94);
            this.txtMatriculaAuto.MaximumSize = new System.Drawing.Size(192, 20);
            this.txtMatriculaAuto.Name = "txtMatriculaAuto";
            this.txtMatriculaAuto.Size = new System.Drawing.Size(192, 20);
            this.txtMatriculaAuto.TabIndex = 8;
            this.txtMatriculaAuto.TextChanged += new System.EventHandler(this.txtMatriculaAuto_TextChanged);
            // 
            // btnBuscarMatricula
            // 
            this.btnBuscarMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMatricula.Location = new System.Drawing.Point(478, 92);
            this.btnBuscarMatricula.MinimumSize = new System.Drawing.Size(35, 23);
            this.btnBuscarMatricula.Name = "btnBuscarMatricula";
            this.btnBuscarMatricula.Size = new System.Drawing.Size(35, 23);
            this.btnBuscarMatricula.TabIndex = 9;
            this.btnBuscarMatricula.Text = "...";
            this.btnBuscarMatricula.UseVisualStyleBackColor = true;
            this.btnBuscarMatricula.Click += new System.EventHandler(this.btnBuscarMatricula_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(435, 263);
            this.btnBuscarCliente.MinimumSize = new System.Drawing.Size(35, 23);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(35, 23);
            this.btnBuscarCliente.TabIndex = 13;
            this.btnBuscarCliente.Text = "...";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCliente.Location = new System.Drawing.Point(213, 266);
            this.txtCliente.MaximumSize = new System.Drawing.Size(196, 20);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(196, 20);
            this.txtCliente.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fecha de Entrega:";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEntrega.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpFechaEntrega.CalendarMonthBackground = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpFechaEntrega.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpFechaEntrega.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(210, 315);
            this.dtpFechaEntrega.MaximumSize = new System.Drawing.Size(204, 20);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(204, 20);
            this.dtpFechaEntrega.TabIndex = 16;
            this.dtpFechaEntrega.ValueChanged += new System.EventHandler(this.dtpFechaEntrega_ValueChanged);
            // 
            // dtpFechaDev
            // 
            this.dtpFechaDev.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpFechaDev.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpFechaDev.Location = new System.Drawing.Point(648, 316);
            this.dtpFechaDev.MaximumSize = new System.Drawing.Size(204, 20);
            this.dtpFechaDev.Name = "dtpFechaDev";
            this.dtpFechaDev.Size = new System.Drawing.Size(204, 20);
            this.dtpFechaDev.TabIndex = 18;
            this.dtpFechaDev.ValueChanged += new System.EventHandler(this.dtpFechaDev_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(459, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fecha de Devolución:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cantidad de Días:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(141)))));
            this.lblPrecio.Location = new System.Drawing.Point(220, 414);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(17, 20);
            this.lblPrecio.TabIndex = 22;
            this.lblPrecio.Text = "0";
            this.lblPrecio.Click += new System.EventHandler(this.lblPrecio_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Precio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(141)))));
            this.label8.Location = new System.Drawing.Point(206, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "$";
            // 
            // btnRentarAuto
            // 
            this.btnRentarAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRentarAuto.Enabled = false;
            this.btnRentarAuto.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnRentarAuto.FlatAppearance.BorderSize = 0;
            this.btnRentarAuto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRentarAuto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(141)))));
            this.btnRentarAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentarAuto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentarAuto.ForeColor = System.Drawing.Color.LightGray;
            this.btnRentarAuto.Location = new System.Drawing.Point(340, 455);
            this.btnRentarAuto.Name = "btnRentarAuto";
            this.btnRentarAuto.Size = new System.Drawing.Size(229, 68);
            this.btnRentarAuto.TabIndex = 24;
            this.btnRentarAuto.Text = "Rentar Auto";
            this.btnRentarAuto.UseVisualStyleBackColor = false;
            this.btnRentarAuto.Click += new System.EventHandler(this.btnRentarAuto_Click);
            // 
            // lblCantidadDias
            // 
            this.lblCantidadDias.AutoSize = true;
            this.lblCantidadDias.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDias.Location = new System.Drawing.Point(209, 358);
            this.lblCantidadDias.Name = "lblCantidadDias";
            this.lblCantidadDias.Size = new System.Drawing.Size(17, 20);
            this.lblCantidadDias.TabIndex = 20;
            this.lblCantidadDias.Text = "0";
            // 
            // lblTarifa
            // 
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarifa.Location = new System.Drawing.Point(49, 387);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(97, 20);
            this.lblTarifa.TabIndex = 27;
            this.lblTarifa.Text = "Tarifa Diaria:";
            // 
            // lblMontoTarifa
            // 
            this.lblMontoTarifa.AutoSize = true;
            this.lblMontoTarifa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTarifa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(141)))));
            this.lblMontoTarifa.Location = new System.Drawing.Point(209, 386);
            this.lblMontoTarifa.Name = "lblMontoTarifa";
            this.lblMontoTarifa.Size = new System.Drawing.Size(17, 20);
            this.lblMontoTarifa.TabIndex = 28;
            this.lblMontoTarifa.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(141)))));
            this.label1.Location = new System.Drawing.Point(406, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Renta de Auto";
            // 
            // lblRegresar
            // 
            this.lblRegresar.AutoSize = true;
            this.lblRegresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(141)))));
            this.lblRegresar.Location = new System.Drawing.Point(798, 531);
            this.lblRegresar.Name = "lblRegresar";
            this.lblRegresar.Size = new System.Drawing.Size(92, 21);
            this.lblRegresar.TabIndex = 31;
            this.lblRegresar.Text = "< Regresar";
            this.lblRegresar.Click += new System.EventHandler(this.lblRegresar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 26);
            this.panel1.TabIndex = 32;
            // 
            // frmRentaDeAuto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(951, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRegresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMontoTarifa);
            this.Controls.Add(this.lblTarifa);
            this.Controls.Add(this.btnRentarAuto);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCantidadDias);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFechaDev);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFechaEntrega);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarMatricula);
            this.Controls.Add(this.txtMatriculaAuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbAuto);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.label8);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRentaDeAuto";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRentaDeAuto";
            this.Activated += new System.EventHandler(this.frmRentaDeAuto_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRentaDeAuto_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRentaDeAuto_FormClosed);
            this.Load += new System.EventHandler(this.frmRentaDeAuto_Load);
            this.Shown += new System.EventHandler(this.frmRentaDeAuto_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.PictureBox pbAuto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarMatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.DateTimePicker dtpFechaDev;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRentarAuto;
        public System.Windows.Forms.TextBox txtMatriculaAuto;
        public System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCantidadDias;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.Label lblMontoTarifa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRegresar;
        private System.Windows.Forms.Panel panel1;
    }
}