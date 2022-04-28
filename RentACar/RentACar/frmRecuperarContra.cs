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
    public partial class frmRecuperarContra : Form
    {
        public frmRecuperarContra()
        {
            InitializeComponent();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            BaseDataContext bd = new BaseDataContext();
            try
            {
                string correo = txtCorreo.Text.Trim();
                string contra = "";
                string mensaje = "";
                if (String.IsNullOrEmpty(correo))
                {
                    errorProvider1.SetError(txtCorreo, "Debe ingresar correo electronico");
                    txtCorreo.Focus();
                }
                else
                {
                    errorProvider1.SetError(txtCorreo, String.Empty);
                    System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();

                    bd.EnviarContra(correo, ref contra);
                    bd.evaluarExiste(correo, ref mensaje);
                    //lblMensaje.Text = mensaje;
                    msg.To.Add(correo);
                    msg.Subject = "Recuperacion de contraseña";
                    msg.SubjectEncoding = System.Text.Encoding.UTF8;
                    msg.Body = "Su contraseña es: " + contra;
                    msg.BodyEncoding = System.Text.Encoding.UTF8;
                    msg.From = new System.Net.Mail.MailAddress("proyectouml4@gmail.com");

                    System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                    cliente.Credentials = new System.Net.NetworkCredential("proyectouml4@gmail.com", "Proyecto123");
                    cliente.Port = 587;
                    cliente.EnableSsl = true;

                    cliente.Host = "smtp.gmail.com";
                    try
                    {
                        cliente.Send(msg);
                        pnlInfo.Visible = true;
                    }
                    catch (Exception eer)
                    {
                        MessageBox.Show("Error al enviar" + eer);
                    }
                }
            }
            catch
            {

            }
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            frmIniciarSesion login = new frmIniciarSesion();
            this.Hide();
            login.ShowDialog();
        }

        private void frmRecuperarContra_Load(object sender, EventArgs e)
        {

        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
