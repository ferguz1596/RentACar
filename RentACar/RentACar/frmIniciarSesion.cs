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
    public partial class frmIniciarSesion : Form
    {
        public frmIniciarSesion()
        {
            InitializeComponent();
        }

        string user;
        int privilegio;
        private void IniciarSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (validar()) {
                errorProvider1.SetError(txtUsuario,"");
                errorProvider1.SetError(txtContra, "");
                try
                {
                    
                    BaseDataContext data = new BaseDataContext();
                    frmMenuContainer menu = new frmMenuContainer();
                    var result = data.Inicio_Sesion(txtUsuario.Text, txtContra.Text);
                    if (result == 1)
                    {
                        var dat = data.Inicio_SesionSP(txtUsuario.Text, txtContra.Text);

                        foreach (var item in dat)
                        {
                            privilegio = item.privilegio.Value;
                            user = item.usuario;
                            if (privilegio == 1)
                            {
                                pnlWellcome.Visible = true;
                                lblWellcome.Text = "Bienvenido " + item.usuario;
                                timer1.Enabled = true;
                                timer2.Enabled = true;
                                timer1.Start();

                            }//if
                            else
                            {
                                pnlWellcome.Visible = true;
                                lblWellcome.Text = "Bienvenido " + item.usuario;
                                timer1.Enabled = true;
                                timer2.Enabled = true;
                                timer1.Start();                           
                            }//else if
                        }//foreach
                    }//if padre
                    else
                    {
                        MessageBox.Show("Usuario y/o Contraseña incorrecta");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        bool validar() {
            bool b = true;
            if (txtUsuario.Text == String.Empty) {
                errorProvider1.SetError(txtUsuario,"Campo Obligatorio");
                b = false;
            }

            if (txtContra.Text == String.Empty) {
                errorProvider1.SetError(txtContra,"Campo Obligatorio");
                b = false;
            }
            return b;
        }


        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frmMenuContainer menu = new frmMenuContainer();
            timer1.Stop();
            timer2.Stop();
            this.Hide();
            menu.Usuario = this.user;
            menu.Level = privilegio;
            menu.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (lblWellcome.ForeColor == Color.FromArgb(0, 122, 204))
            {
                lblWellcome.ForeColor = Color.FromArgb(77, 183, 255);
            }
            else {
                lblWellcome.ForeColor = Color.FromArgb(0, 122, 204);
            }
        }

        private void lnkPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperarContra rc = new frmRecuperarContra();
            this.Hide();
            rc.ShowDialog();
        }

        private void lblWellcome_Click(object sender, EventArgs e)
        {

        }
    }
}
