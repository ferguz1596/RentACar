using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class frmAggUsuario : Form
    {
        public frmAggUsuario()
        {
            InitializeComponent();
            cbxSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPrivilegio.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        int privilegio;
        int sexo;

        private void llblAgregarImg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //var imagen = pbUsuario;
            //Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            //Se muestra al usuario esperando una accion
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
              //  pbUsuario.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void frmAggUsuario_Load(object sender, EventArgs e)
        {
            txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            txtDui.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            cbxPrivilegio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            cbxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            BaseDataContext db = new BaseDataContext();

            try
            {
                string vUsuario = "";
                string usuario = txtUsuario.Text.Trim();
                string dui = txtDui.Text.Trim();
                string nombres = txtNombres.Text.Trim();
                string apellidos = txtApellidos.Text.Trim();
                string direccion = txtDireccion.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                string correo = txtCorreo.Text.Trim();
                string cargo = txtCargo.Text.Trim();
                string contra = txtContra.Text.Trim();
                //Valida que no este vacio DUI

                if (String.IsNullOrEmpty(dui))
                {
                    errorProvider1.SetError(txtDui, "Ingrese valor");

                    txtDui.Text = String.Empty;
                }
                //Valida que no este vacio Nombres

                else if (String.IsNullOrEmpty(txtNombres.Text.Trim()))
                {
                    errorProvider1.SetError(txtNombres, "Ingrese valor");
                    txtNombres.Text = String.Empty;
                    txtNombres.Focus();
                }
                //Valida que no este vacio apellidos

                else if (String.IsNullOrEmpty(txtApellidos.Text.Trim()))
                {
                    errorProvider1.SetError(txtApellidos, "Ingrese valor");
                    txtApellidos.Text = String.Empty;
                    txtApellidos.Focus();
                }
                //Valida que no este vacio direccion

                else if (String.IsNullOrEmpty(txtDireccion.Text.Trim()))
                {
                    errorProvider1.SetError(txtDireccion, "Ingrese valor");
                    txtDireccion.Text = String.Empty;
                    txtDireccion.Focus();
                }
                //Valida que no este vacio telefono

                else if (String.IsNullOrEmpty(txtTelefono.Text.Trim()))
                {
                    errorProvider1.SetError(txtTelefono, "Ingrese valor");
                    txtTelefono.Text = String.Empty;
                    txtTelefono.Focus();
                }
                //Valida que no este vacio cargo

                else if (String.IsNullOrEmpty(txtCargo.Text.Trim()))
                {
                    errorProvider1.SetError(txtCargo, "Ingrese valor");
                    txtCargo.Text = String.Empty;
                    txtCargo.Focus();
                }
                //Valida que no este vacio correo

                else if (String.IsNullOrEmpty(txtCorreo.Text.Trim()))
                {
                    errorProvider1.SetError(txtCorreo, "Ingrese valor");
                    txtCorreo.Text = String.Empty;
                    txtCorreo.Focus();
                }
                //Valida que ingrese usuario
                else if (String.IsNullOrEmpty(txtUsuario.Text.Trim()))
                {
                    errorProvider1.SetError(txtUsuario, "Ingrese Usuario");
                    txtUsuario.Focus();
                }

                //Valida que no este vacio contraseña

                else if (String.IsNullOrEmpty(txtContra.Text.Trim()))
                {
                    errorProvider1.SetError(txtContra, "Ingrese valor");
                    txtContra.Text = String.Empty;
                    txtContra.Focus();
                }

                else
                {
                    if (cbxSexo.SelectedIndex >= 0)
                    {
                        switch (cbxSexo.SelectedIndex)
                        {
                            case 0:
                                sexo = 1;
                                break;
                            case 1:
                                sexo = 2;
                                break;
                        }
                    }
                    if (cbxPrivilegio.SelectedIndex >= 0)
                    {
                        switch (cbxPrivilegio.SelectedIndex)
                        {
                            case 0:
                                privilegio = 1;
                                break;
                            case 1:
                                privilegio = 2;
                                break;
                        }
                    }
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    // Se guarda la imagen en el buffer
                    //pbUsuario.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    int estado = 1;
                    db.validarUsuario(usuario, ref vUsuario);
                    string validaUsuario = vUsuario;
                    if (vUsuario == "2")
                    {
                        db.Add_Usuario(dui, nombres, apellidos, sexo, direccion, telefono, cargo, privilegio, correo, contra, usuario, ms.GetBuffer(), estado);
                        MessageBox.Show("Usuario agregado exitosamente");
                        txtUsuario.Text = String.Empty;
                        txtDui.Text = String.Empty;
                        txtNombres.Text = String.Empty;
                        txtApellidos.Text = String.Empty;
                        txtDireccion.Text = String.Empty;
                        txtTelefono.Text = String.Empty;
                        txtCargo.Text = String.Empty;
                        txtCorreo.Text = String.Empty;
                        txtContra.Text = String.Empty;
                    }
                    else if (vUsuario == "1")
                    {
                        MessageBox.Show("Usuario ya existe");
                    }
                }

            }
            catch
            {
                MessageBox.Show("No ha agregado algun registro\nIntente otra vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDui.Focus();
            }

        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
