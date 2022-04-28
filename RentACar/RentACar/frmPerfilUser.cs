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
    public partial class frmPerfilUser : Form
    {
        public frmPerfilUser()
        {
            InitializeComponent();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                RentACar.BaseDataContext bd = new RentACar.BaseDataContext();
                string Usuario = txtUsuario.Text.Trim();
                string NContra = txtNContra.Text.Trim();
                string ConfContra = txtConfContra.Text.Trim();
                string Correo = txtCorreo.Text.Trim();
                string direccion = txtDireccion.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                string usuaV = "";
                if (String.IsNullOrEmpty(Usuario))
                {
                    errorProvider1.SetError(txtUsuario, "Debe Ingresar usuario");
                    txtUsuario.Focus();
                }
                else if (NContra == ConfContra)
                {
                    bd.validaActualizacion(Usuario, ref usuaV);
                    if (usuaV == "1")
                    {
                        bd.Actualizar_Usuario(Usuario, NContra, Correo, direccion, telefono);
                        MessageBox.Show("Usuario actulizado correctamente");
                    }
                    else if (usuaV == "2")
                    {
                        MessageBox.Show("Usuario no existe");
                    }
                }
                else
                {

                    errorProvider1.SetError(txtNContra, "Las contraseñas no coinciden");
                    NContra = String.Empty;
                    ConfContra = String.Empty;
                    txtNContra.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Intente otra vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
            }
        }

        private void llblAgregarImagen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                ptbImagen.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void frmPerfilUser_Load(object sender, EventArgs e)
        {
            txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            txtNContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            txtConfContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        }
    }
}
