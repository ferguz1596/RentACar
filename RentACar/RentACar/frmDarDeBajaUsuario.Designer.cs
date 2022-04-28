namespace RentACar
{
    partial class frmDarDeBajaUsuario
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
            this.btnDarDeBaja = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDarDeBaja
            // 
            this.btnDarDeBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDarDeBaja.FlatAppearance.BorderSize = 0;
            this.btnDarDeBaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnDarDeBaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDarDeBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarDeBaja.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarDeBaja.ForeColor = System.Drawing.Color.LightGray;
            this.btnDarDeBaja.Location = new System.Drawing.Point(391, 326);
            this.btnDarDeBaja.Name = "btnDarDeBaja";
            this.btnDarDeBaja.Size = new System.Drawing.Size(172, 59);
            this.btnDarDeBaja.TabIndex = 35;
            this.btnDarDeBaja.Text = "Dar de Baja";
            this.btnDarDeBaja.UseVisualStyleBackColor = false;
            this.btnDarDeBaja.Click += new System.EventHandler(this.btnDarDeBaja_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(391, 212);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(207, 20);
            this.txtUsuario.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(309, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Usuario:";
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(604, 210);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(24, 23);
            this.btnUsuario.TabIndex = 36;
            this.btnUsuario.Text = "...";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(141)))));
            this.label9.Location = new System.Drawing.Point(398, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 23);
            this.label9.TabIndex = 37;
            this.label9.Text = "Dar Baja a Usuario";
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(141)))));
            this.lblReg.Location = new System.Drawing.Point(840, 526);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(87, 20);
            this.lblReg.TabIndex = 66;
            this.lblReg.Text = "< Regresar";
            // 
            // frmDarDeBajaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 575);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnDarDeBaja);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDarDeBajaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDarDeBajaUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDarDeBaja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblReg;
        public System.Windows.Forms.TextBox txtUsuario;
    }
}