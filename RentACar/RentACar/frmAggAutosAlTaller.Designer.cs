namespace RentACar
{
    partial class frmAggAutosAlTaller
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
            this.btnAggATaller = new System.Windows.Forms.Button();
            this.txtAuto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAuto = new System.Windows.Forms.Button();
            this.cbxTaller = new System.Windows.Forms.ComboBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblReg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxMotivos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAggATaller
            // 
            this.btnAggATaller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAggATaller.FlatAppearance.BorderSize = 0;
            this.btnAggATaller.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAggATaller.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAggATaller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggATaller.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggATaller.ForeColor = System.Drawing.Color.LightGray;
            this.btnAggATaller.Location = new System.Drawing.Point(360, 414);
            this.btnAggATaller.Name = "btnAggATaller";
            this.btnAggATaller.Size = new System.Drawing.Size(217, 83);
            this.btnAggATaller.TabIndex = 26;
            this.btnAggATaller.Text = "Añadir a Taller";
            this.btnAggATaller.UseVisualStyleBackColor = false;
            this.btnAggATaller.Click += new System.EventHandler(this.btnAggATaller_Click);
            // 
            // txtAuto
            // 
            this.txtAuto.Location = new System.Drawing.Point(400, 83);
            this.txtAuto.Name = "txtAuto";
            this.txtAuto.Size = new System.Drawing.Size(200, 20);
            this.txtAuto.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(249, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(249, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fecha de Ingreso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(249, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Taller:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(250, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Auto:";
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(628, 81);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(29, 23);
            this.btnAuto.TabIndex = 28;
            this.btnAuto.Text = "...";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // cbxTaller
            // 
            this.cbxTaller.FormattingEnabled = true;
            this.cbxTaller.Location = new System.Drawing.Point(400, 124);
            this.cbxTaller.Name = "cbxTaller";
            this.cbxTaller.Size = new System.Drawing.Size(200, 21);
            this.cbxTaller.TabIndex = 29;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(400, 215);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIngreso.TabIndex = 31;
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Location = new System.Drawing.Point(400, 257);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(277, 105);
            this.rtbDescripcion.TabIndex = 32;
            this.rtbDescripcion.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(141)))));
            this.label9.Location = new System.Drawing.Point(370, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 23);
            this.label9.TabIndex = 33;
            this.label9.Text = "Enviar Auto al Taller";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(141)))));
            this.lblReg.Location = new System.Drawing.Point(831, 506);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(92, 21);
            this.lblReg.TabIndex = 34;
            this.lblReg.Text = "< Regresar";
            this.lblReg.Click += new System.EventHandler(this.lblReg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(249, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Motivos:";
            // 
            // cbxMotivos
            // 
            this.cbxMotivos.FormattingEnabled = true;
            this.cbxMotivos.Location = new System.Drawing.Point(400, 169);
            this.cbxMotivos.Name = "cbxMotivos";
            this.cbxMotivos.Size = new System.Drawing.Size(200, 21);
            this.cbxMotivos.TabIndex = 30;
            // 
            // frmAggAutosAlTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 536);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rtbDescripcion);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.cbxMotivos);
            this.Controls.Add(this.cbxTaller);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnAggATaller);
            this.Controls.Add(this.txtAuto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAggAutosAlTaller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAggAutosAlTaller";
            this.Load += new System.EventHandler(this.frmAggAutosAlTaller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAggATaller;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.ComboBox cbxTaller;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.TextBox txtAuto;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.ComboBox cbxMotivos;
        private System.Windows.Forms.Label label3;
    }
}