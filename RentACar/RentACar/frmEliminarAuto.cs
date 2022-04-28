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
    public partial class frmEliminarAuto : Form
    {
        public frmEliminarAuto()
        {
            InitializeComponent();
        }

        string usuario;
        int level,retorno;

        public string Usuario { get => usuario; set => usuario = value; }
        public int Level { get => level; set => level = value; }
        public int Retorno { get => retorno; set => retorno = value; }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string resultado = String.Empty;

            if (String.IsNullOrEmpty(txtAuto.Text))
            {
                errorProvider1.SetError(btnAuto, "Presiona el botón para seleccionar el auto");
                btnAuto.Focus();
            }
            else if (String.IsNullOrEmpty(rtbMotivos.Text))
            {
                errorProvider1.SetError(btnAuto, String.Empty);
                errorProvider1.SetError(rtbMotivos, "Debes ingresar los motivos por los cuales eliminas el auto");
                rtbMotivos.Focus();
            }
            else
            {
                errorProvider1.SetError(rtbMotivos, String.Empty);
                BaseDataContext db = new BaseDataContext();
                try
                {
                    db.ELIM_AUTOS(txtAuto.Text, rtbMotivos.Text, ref resultado);
                    if (resultado == "1")
                    {
                        MessageBox.Show("Auto eliminado de la flota correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAuto.Text = String.Empty;
                        rtbMotivos.Text = String.Empty;

                        txtAuto.Focus();
                        frmSelFuncionAuto f = new frmSelFuncionAuto();
                        f.Usuario = this.Usuario;
                        f.Level = this.Level;
                        this.Hide();
                        f.ShowDialog();
                        this.Close();
                    }
                    else if (resultado == "0")
                    {
                        MessageBox.Show("No se pudo eliminar el auto:\nIntenta nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAuto.Focus();
                    }

                }
                catch (Exception)
                {

                }
            }

        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            frmSeleccionAuto a = new frmSeleccionAuto();
            a.ValorForm = 3;
            a.Usuario = this.Usuario;
            a.Level = this.Level;
            a.ValorForm = 2;
            this.Hide();
            a.ShowDialog();
            this.Close();
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEliminarAuto_Load(object sender, EventArgs e)
        {
            txtAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            btnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular); 
            rtbMotivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        }

        private void lblReg_Click(object sender, EventArgs e)
        {
            if (Retorno!=1) {
                frmSelFuncionAuto m = new frmSelFuncionAuto();
                m.Usuario = this.Usuario;
                m.Level = this.Level;
                this.Hide();
                m.Show();
                this.Close();
            }
            else {
                frmMenuContainer m = new frmMenuContainer();
                m.Usuario = this.Usuario;
                m.Level = this.Level;
                this.Hide();
                m.Show();
                this.Close();
            }
        }
    }
}
