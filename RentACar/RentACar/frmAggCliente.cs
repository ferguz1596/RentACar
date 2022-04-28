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
    public partial class frmAggCliente : Form
    {
        public frmAggCliente()
        {
            InitializeComponent();
        }

        private void frmAggCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string output = String.Empty;
            if (validar()) {
                quitarError();
                BaseDataContext db = new BaseDataContext();
                db.SP_InsertCliente(txtDUI.Text, txtNombres.Text, txtApellidos.Text, int.Parse(txtEdad.Text), txtNLicencia.Text, txtDireccion.Text, txtTelefono.Text, ref output);
                if (output == "1")
                {
                    lblMsj.Visible = true;
                    lblMsj.Text = "Exito";
                }
                else
                {
                    lblMsj.Visible = true;
                    lblMsj.Text = "El cliente ya existe en el listado";
                }

            }
        }

        public bool validar() {
            bool band = true;
            if (txtDUI.Text == String.Empty) {
                errorProvider1.SetError(txtDUI,"Campo Requerido");
                band = false;
            }

            if (txtNombres.Text == String.Empty)
            {
                errorProvider1.SetError(txtNombres, "Campo Requerido");
                band = false;
            }

            if (txtApellidos.Text == String.Empty)
            {
                errorProvider1.SetError(txtApellidos, "Campo Requerido");
                band = false;
            }

            if (txtEdad.Text == String.Empty)
            {
                errorProvider1.SetError(txtEdad, "Campo Requerido");
                band = false;
            }

            if (txtNLicencia.Text == String.Empty)
            {
                errorProvider1.SetError(txtNLicencia, "Campo Requerido");
                band = false;
            }

            if (txtDireccion.Text == String.Empty)
            {
                errorProvider1.SetError(txtDireccion, "Campo Requerido");
                band = false;
            }

            if (txtTelefono.Text == String.Empty)
            {
                errorProvider1.SetError(txtTelefono, "Campo Requerido");
                band = false;
            }
            return band;
        }

        public void quitarError() {
            errorProvider1.SetError(txtDUI,"");
            errorProvider1.SetError(txtNombres, "");
            errorProvider1.SetError(txtApellidos, "");
            errorProvider1.SetError(txtNLicencia, "");
            errorProvider1.SetError(txtEdad, "");
            errorProvider1.SetError(txtDireccion, "");
            errorProvider1.SetError(txtTelefono, "");
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
