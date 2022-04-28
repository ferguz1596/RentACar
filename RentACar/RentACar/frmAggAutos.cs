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
    public partial class frmAggAutos : Form
    {
        public frmAggAutos()
        {
            InitializeComponent();
        }

        int tipo;

        public int Tipo { get => tipo; set => tipo = value; }

        private void llblAggImagen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                pbAuto.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string resultado = String.Empty;

            if (txtMatricula.Text.Length < 8)
            {
                errorProvider1.SetError(txtMatricula, "Debes ingresar la matricula del auto");
                txtMatricula.Focus();
            }
            else if (cbxMarca.SelectedIndex < 0)
            {
                errorProvider1.SetError(txtMatricula, String.Empty);
                errorProvider1.SetError(cbxMarca, "Debes seleccionar una marca");
                cbxMarca.Focus();
            }
            else if (String.IsNullOrEmpty(txtModelo.Text))
            {
                errorProvider1.SetError(txtMatricula, String.Empty);
                errorProvider1.SetError(cbxMarca, String.Empty);
                errorProvider1.SetError(txtModelo, "Debes ingresar el modelo del auto");
                txtModelo.Focus();
            }
            else if (String.IsNullOrEmpty(txtAnio.Text))
            {
                errorProvider1.SetError(txtMatricula, String.Empty);
                errorProvider1.SetError(cbxMarca, String.Empty);
                errorProvider1.SetError(txtModelo, String.Empty);
                errorProvider1.SetError(txtAnio, "Debes ingresar el año del auto");
                txtAnio.Focus();
            }
            else if (String.IsNullOrEmpty(txtColor.Text))
            {
                errorProvider1.SetError(txtMatricula, String.Empty);
                errorProvider1.SetError(cbxMarca, String.Empty);
                errorProvider1.SetError(txtModelo, String.Empty);
                errorProvider1.SetError(txtAnio, String.Empty);
                errorProvider1.SetError(txtColor, "Debes ingresar el color del auto");
                txtColor.Focus();
            }
            else if (cbxTipo.SelectedIndex < 0)
            {
                errorProvider1.SetError(txtMatricula, String.Empty);
                errorProvider1.SetError(cbxMarca, String.Empty);
                errorProvider1.SetError(txtModelo, String.Empty);
                errorProvider1.SetError(txtAnio, String.Empty);
                errorProvider1.SetError(txtColor, String.Empty);
                errorProvider1.SetError(cbxTipo, "Debes seleccionar una opcion");
                cbxTipo.Focus();
            }
            else if (String.IsNullOrEmpty(txtCapacidad.Text))
            {
                errorProvider1.SetError(txtMatricula, String.Empty);
                errorProvider1.SetError(cbxMarca, String.Empty);
                errorProvider1.SetError(txtModelo, String.Empty);
                errorProvider1.SetError(txtAnio, String.Empty);
                errorProvider1.SetError(txtColor, String.Empty);
                errorProvider1.SetError(cbxTipo, String.Empty);
                errorProvider1.SetError(txtCapacidad, "Debes ingresar la capacidad de personas del auto");
                txtCapacidad.Focus();
            }
            else if (String.IsNullOrEmpty(txtAdquiridoA.Text))
            {
                errorProvider1.SetError(txtMatricula, String.Empty);
                errorProvider1.SetError(cbxMarca, String.Empty);
                errorProvider1.SetError(txtModelo, String.Empty);
                errorProvider1.SetError(txtAnio, String.Empty);
                errorProvider1.SetError(txtColor, String.Empty);
                errorProvider1.SetError(cbxTipo, String.Empty);
                errorProvider1.SetError(txtCapacidad, String.Empty);
                errorProvider1.SetError(txtAdquiridoA, "Debes ingresar el concesionario donde se adiquirió el auto");
                txtAdquiridoA.Focus();
            }
            else if (String.IsNullOrEmpty(txtMonto.Text))
            {
                errorProvider1.SetError(txtMatricula, String.Empty);
                errorProvider1.SetError(cbxMarca, String.Empty);
                errorProvider1.SetError(txtModelo, String.Empty);
                errorProvider1.SetError(txtAnio, String.Empty);
                errorProvider1.SetError(txtColor, String.Empty);
                errorProvider1.SetError(cbxTipo, String.Empty);
                errorProvider1.SetError(txtCapacidad, String.Empty);
                errorProvider1.SetError(txtAdquiridoA, String.Empty);
                errorProvider1.SetError(txtMonto, "Debes ingresar el monto por renta diario del auto");
                txtMonto.Focus();
            }
            else if (pbAuto.Image != null)
            {
                errorProvider1.SetError(txtMatricula, String.Empty);
                errorProvider1.SetError(cbxMarca, String.Empty);
                errorProvider1.SetError(txtModelo, String.Empty);
                errorProvider1.SetError(txtAnio, String.Empty);
                errorProvider1.SetError(txtColor, String.Empty);
                errorProvider1.SetError(cbxTipo, String.Empty);
                errorProvider1.SetError(txtCapacidad, String.Empty);
                errorProvider1.SetError(txtAdquiridoA, String.Empty);
                errorProvider1.SetError(txtMonto, String.Empty);
                try
                {
                    BaseDataContext db = new BaseDataContext();

                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    // Se guarda la imagen en el buffer
                    pbAuto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //Pasamos como parametro "ms.GetBuffer" para almacenar la imagen como bytes

                    db.AGG_AUTOS(txtMatricula.Text, cbxMarca.Text, txtModelo.Text, txtColor.Text, txtAnio.Text, cbxTipo.Text, Convert.ToInt32(txtCapacidad.Text), ms.GetBuffer(), Convert.ToDouble(txtMonto.Text), txtAdquiridoA.Text, dtpFechaAdqui.Value, rtbObservaciones.Text, ref resultado);

                    if (resultado == "1")
                    {
                        MessageBox.Show("Auto registrado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMatricula.Text = String.Empty;
                        cbxMarca.Text = String.Empty;
                        txtModelo.Text = String.Empty;
                        txtColor.Text = String.Empty;
                        txtAnio.Text = String.Empty;
                        cbxTipo.Text = String.Empty;
                        txtCapacidad.Text = String.Empty;
                        pbAuto.Image.Dispose();
                        pbAuto.Image = null;
                        txtMonto.Text = String.Empty;
                        txtAdquiridoA.Text = String.Empty;
                        dtpFechaAdqui.Text = String.Empty;
                        rtbObservaciones.Text = String.Empty;
                    }
                    else if (resultado == "0")
                    {
                        MessageBox.Show("El número de matricula ya existe", "INTENTE DE NUEVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMatricula.Text = String.Empty;
                        txtMatricula.Focus();
                    }

                }
                catch//(Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debes agregar una imagen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                llblAggImagen.Focus();
            }

            txtMatricula.Focus();
        }

        private void frmAggAutos_Load(object sender, EventArgs e)
        {
            txtMatricula.Font =  new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            cbxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            txtAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            txtAdquiridoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            txtCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            cbxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            dtpFechaAdqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        }

        public void soloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        public void soloNumerosDec(KeyPressEventArgs e)
        {
            char puntoDecimal = (char)46;
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.Equals(e.KeyChar, puntoDecimal))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumerosDec(e);
        }

        private void txtCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
