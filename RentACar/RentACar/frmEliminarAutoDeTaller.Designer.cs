namespace RentACar
{
    partial class frmEliminarAutoDeTaller
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
            this.rtbObservaciones = new System.Windows.Forms.RichTextBox();
            this.dtpFechaEgreso = new System.Windows.Forms.DateTimePicker();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnElimDeTaller = new System.Windows.Forms.Button();
            this.txtAuto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.cbxMotivos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbObservaciones
            // 
            this.rtbObservaciones.Location = new System.Drawing.Point(401, 263);
            this.rtbObservaciones.Name = "rtbObservaciones";
            this.rtbObservaciones.Size = new System.Drawing.Size(314, 105);
            this.rtbObservaciones.TabIndex = 45;
            this.rtbObservaciones.Text = "";
            // 
            // dtpFechaEgreso
            // 
            this.dtpFechaEgreso.Location = new System.Drawing.Point(401, 135);
            this.dtpFechaEgreso.Name = "dtpFechaEgreso";
            this.dtpFechaEgreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEgreso.TabIndex = 44;
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(616, 77);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(29, 23);
            this.btnAuto.TabIndex = 41;
            this.btnAuto.Text = "...";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnElimDeTaller
            // 
            this.btnElimDeTaller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnElimDeTaller.FlatAppearance.BorderSize = 0;
            this.btnElimDeTaller.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnElimDeTaller.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnElimDeTaller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimDeTaller.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimDeTaller.ForeColor = System.Drawing.Color.LightGray;
            this.btnElimDeTaller.Location = new System.Drawing.Point(380, 403);
            this.btnElimDeTaller.Name = "btnElimDeTaller";
            this.btnElimDeTaller.Size = new System.Drawing.Size(213, 78);
            this.btnElimDeTaller.TabIndex = 39;
            this.btnElimDeTaller.Text = "Eliminar de Taller";
            this.btnElimDeTaller.UseVisualStyleBackColor = false;
            this.btnElimDeTaller.Click += new System.EventHandler(this.btnElimDeTaller_Click);
            // 
            // txtAuto
            // 
            this.txtAuto.Enabled = false;
            this.txtAuto.Location = new System.Drawing.Point(401, 79);
            this.txtAuto.Name = "txtAuto";
            this.txtAuto.Size = new System.Drawing.Size(200, 20);
            this.txtAuto.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(250, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Observaciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(250, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Fecha de Egreso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(250, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Motivos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(250, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Auto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(141)))));
            this.label9.Location = new System.Drawing.Point(383, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 23);
            this.label9.TabIndex = 47;
            this.label9.Text = "Egresar Auto de Taller";
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(141)))));
            this.lblReg.Location = new System.Drawing.Point(831, 506);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(92, 21);
            this.lblReg.TabIndex = 48;
            this.lblReg.Text = "< Regresar";
            this.lblReg.Click += new System.EventHandler(this.lblReg_Click);
            // 
            // cbxMotivos
            // 
            this.cbxMotivos.Location = new System.Drawing.Point(401, 225);
            this.cbxMotivos.Name = "cbxMotivos";
            this.cbxMotivos.Size = new System.Drawing.Size(200, 20);
            this.cbxMotivos.TabIndex = 49;
            this.cbxMotivos.TextChanged += new System.EventHandler(this.cbxMotivos_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(250, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(401, 178);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(200, 20);
            this.txtMonto.TabIndex = 51;
            // 
            // frmEliminarAutoDeTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 536);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxMotivos);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rtbObservaciones);
            this.Controls.Add(this.dtpFechaEgreso);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnElimDeTaller);
            this.Controls.Add(this.txtAuto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEliminarAutoDeTaller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEliminarAutoDeTaller";
            this.Load += new System.EventHandler(this.frmEliminarAutoDeTaller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbObservaciones;
        private System.Windows.Forms.DateTimePicker dtpFechaEgreso;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnElimDeTaller;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtAuto;
        private System.Windows.Forms.Label lblReg;
        public System.Windows.Forms.TextBox cbxMotivos;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtMonto;
    }
}