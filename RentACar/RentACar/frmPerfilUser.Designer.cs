namespace RentACar
{
    partial class frmPerfilUser
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
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtConfContra = new System.Windows.Forms.TextBox();
            this.txtNContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.llblAgregarImagen = new System.Windows.Forms.LinkLabel();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGuardarCambios.FlatAppearance.BorderSize = 0;
            this.btnGuardarCambios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnGuardarCambios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.LightGray;
            this.btnGuardarCambios.Location = new System.Drawing.Point(403, 432);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(196, 66);
            this.btnGuardarCambios.TabIndex = 29;
            this.btnGuardarCambios.Text = "GUARDAR";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(450, 345);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(333, 20);
            this.txtTelefono.TabIndex = 28;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(450, 308);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(333, 20);
            this.txtDireccion.TabIndex = 27;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(450, 271);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(333, 20);
            this.txtCorreo.TabIndex = 26;
            // 
            // txtConfContra
            // 
            this.txtConfContra.Location = new System.Drawing.Point(450, 234);
            this.txtConfContra.Name = "txtConfContra";
            this.txtConfContra.Size = new System.Drawing.Size(333, 20);
            this.txtConfContra.TabIndex = 25;
            // 
            // txtNContra
            // 
            this.txtNContra.Location = new System.Drawing.Point(450, 197);
            this.txtNContra.Name = "txtNContra";
            this.txtNContra.Size = new System.Drawing.Size(333, 20);
            this.txtNContra.TabIndex = 24;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(450, 160);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(333, 20);
            this.txtUsuario.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(188, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Teléfono (Opcional):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(188, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Dirección (Opcional):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(188, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Correo Electrónico (Opcional):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(188, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Confirmar Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(188, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nueva Contraseña (Opcional):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(188, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Usuario (Opcional):";
            // 
            // llblAgregarImagen
            // 
            this.llblAgregarImagen.AutoSize = true;
            this.llblAgregarImagen.Location = new System.Drawing.Point(189, 127);
            this.llblAgregarImagen.Name = "llblAgregarImagen";
            this.llblAgregarImagen.Size = new System.Drawing.Size(82, 13);
            this.llblAgregarImagen.TabIndex = 16;
            this.llblAgregarImagen.TabStop = true;
            this.llblAgregarImagen.Text = "Agregar Imagen";
            this.llblAgregarImagen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblAgregarImagen_LinkClicked);
            // 
            // ptbImagen
            // 
            this.ptbImagen.Location = new System.Drawing.Point(192, 36);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(107, 88);
            this.ptbImagen.TabIndex = 15;
            this.ptbImagen.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPerfilUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(951, 575);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtConfContra);
            this.Controls.Add(this.txtNContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llblAgregarImagen);
            this.Controls.Add(this.ptbImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPerfilUser";
            this.Text = "frmPerfilUser";
            this.Load += new System.EventHandler(this.frmPerfilUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtConfContra;
        private System.Windows.Forms.TextBox txtNContra;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llblAgregarImagen;
        private System.Windows.Forms.PictureBox ptbImagen;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}