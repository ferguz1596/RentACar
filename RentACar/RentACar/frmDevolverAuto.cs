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
    public partial class frmDevolverAuto : Form
    {
        public frmDevolverAuto()
        {
            InitializeComponent();
        }
        string usuario;
        int level,tipo;
        string fechaDev;

        public string Usuario { get => usuario; set => usuario = value; }
        public int Level { get => level; set => level = value; }
        public int Tipo { get => tipo; set => tipo = value; }

        private void btnDevolverAuto_Click(object sender, EventArgs e)
        {
            string resultado = String.Empty;
            string resultado2 = String.Empty;
            string resultado3 = String.Empty;
            int estadoAuto = 0;

            //Envío de dato "Recargo" cuando está vacío
            if (String.IsNullOrEmpty(txtRecargo.Text))
            {
                txtRecargo.Text = "0.0";
            }

            if (String.IsNullOrEmpty(txtFactura.Text.Trim()))
            {
                errorProvider1.SetError(btnBuscarFactura, "Presiona el botón para mostar las facturas");
            }
            else if (cbxEstadoAuto.Text == "En buen estado")
            {
                errorProvider1.SetError(btnBuscarFactura, String.Empty);
                estadoAuto = 1;
                try
                {
                    BaseDataContext db = new BaseDataContext();
                    db.DEVOLVER_AUTO(lblMatricula.Text, estadoAuto, rtbDesEstado.Text, ref resultado3);
                    db.ACT_RENTA(Convert.ToInt32(txtFactura.Text), ref resultado2);
                    db.IN_DEVOLUCION(Convert.ToInt32(txtFactura.Text), lblMatricula.Text, lblDUIV.Text, dtpFechaDev.Value, estadoAuto, Convert.ToDouble(txtRecargo.Text), ref resultado);
                    if (resultado == "1" && resultado2 == "1" && resultado3 == "1")
                    {
                        MessageBox.Show("Devolución realizada con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        send();
                        txtFactura.Text = String.Empty;
                        txtRecargo.Text = String.Empty;
                        lblMarca.Text = String.Empty;
                        lblMatricula.Text = String.Empty;
                        lblModelo.Text = String.Empty;
                        lblColor.Text = String.Empty;
                        lblAnio.Text = String.Empty;
                        lblNombreV.Text = String.Empty;
                        lblDUIV.Text = String.Empty;
                        lblFechaEntrega.Text = String.Empty;
                        dtpFechaDev.Value = DateTime.Now;
                        cbxEstadoAuto.Text = "Seleccione una opción";
                        rtbDesEstado.Text = String.Empty;
                        lblCantidadPagar.Text = String.Empty;
                        pbAuto.Image = null;
                        
                    }
                    else
                    {
                        MessageBox.Show("No se pudo realizar la devolución, intente otra vez", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //MessageBox.Show("No se pudo realizar la devolución, itente otra vez", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cbxEstadoAuto.Text == "Averiado")
            {
                errorProvider1.SetError(btnBuscarFactura, String.Empty);
                estadoAuto = 5;
                try
                {
                    if (txtRecargo.Text == String.Empty)
                    {
                        btnDevolverAuto.Enabled = false;
                        MessageBox.Show("Debe agregar un 'Recargo' por el estado Averiado del auto");
                    }
                    else {
                        BaseDataContext db = new BaseDataContext();
                        db.DEVOLVER_AUTO(lblMatricula.Text, estadoAuto, rtbDesEstado.Text, ref resultado3);
                        db.ACT_RENTA(Convert.ToInt32(txtFactura.Text), ref resultado2);
                        db.IN_DEVOLUCION(Convert.ToInt32(txtFactura.Text), lblMatricula.Text, lblDUIV.Text, dtpFechaDev.Value, estadoAuto, Convert.ToDouble(txtRecargo.Text), ref resultado);

                        if (resultado == "1" && resultado2 == "1" && resultado3 == "1")
                        {
                            MessageBox.Show("Devolución realizada con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            send();
                            txtFactura.Text = String.Empty;
                            txtRecargo.Text = String.Empty;
                            lblMarca.Text = String.Empty;
                            lblMatricula.Text = String.Empty;
                            lblModelo.Text = String.Empty;
                            lblColor.Text = String.Empty;
                            lblAnio.Text = String.Empty;
                            lblNombreV.Text = String.Empty;
                            lblDUIV.Text = String.Empty;
                            lblFechaEntrega.Text = String.Empty;
                            dtpFechaDev.Value = DateTime.Now;
                            cbxEstadoAuto.Text = "Seleccione una opción";
                            rtbDesEstado.Text = String.Empty;
                            lblCantidadPagar.Text = String.Empty;
                            pbAuto.Image = null;

                        }
                        else
                        {
                            MessageBox.Show("No se pudo realizar la devolución, intente otra vez", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una opción de \"Estado Auto\"", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxEstadoAuto.Focus();
            }
        }

        private void btnBuscarFactura_Click(object sender, EventArgs e)
        {
            frmMenuContainer menu = new frmMenuContainer();
            frmConsultarFacturasDevolverAuto consultaFacturas = new frmConsultarFacturasDevolverAuto();
            //menu.Show();
            //menu.openForm(consultaFacturas);
            this.Hide();
            consultaFacturas.Usuario = this.Usuario;
            consultaFacturas.Level = this.Level;
            consultaFacturas.ShowDialog();
            this.Close();

        }

        private void frmDevolverAuto_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFactura.Text.Trim()))
            {
                txtFactura.Text = String.Empty;
                txtRecargo.Text = String.Empty;
                lblMarca.Text = String.Empty;
                lblMatricula.Text = String.Empty;
                lblModelo.Text = String.Empty;
                lblColor.Text = String.Empty;
                lblAnio.Text = String.Empty;
                lblNombreV.Text = String.Empty;
                lblDUIV.Text = String.Empty;
                lblFechaEntrega.Text = String.Empty;
                cbxEstadoAuto.Text = "Seleccione una opción";
                rtbDesEstado.Text = String.Empty;
                lblCantidadPagar.Text = String.Empty;
            }
            else
            {
                cbxEstadoAuto.Text = "Seleccione una opción";

                try
                {
                    BaseDataContext db = new BaseDataContext();
                    var datos = db.CON_DatosRenta(Convert.ToInt32(txtFactura.Text));
                    foreach (var item in datos)
                    {
                        //-Creamos un MemorySream
                        //-Convertimos "item.imagenAuto" a un arreglo byte[] para obtener el valor
                        // de bytes según la imagen almacenada
                        //Con "System.Drawing.Bitmap.FromStream(ms)" se crea la imagen a partir
                        //de los datos brindados
                        if (item.imagenAuto == null)
                        {
                            pbAuto.Image = null;
                        }
                        else
                        {
                            System.IO.MemoryStream ms = new System.IO.MemoryStream(item.imagenAuto.ToArray());
                            pbAuto.Image = System.Drawing.Bitmap.FromStream(ms);
                        }

                        lblDUIV.Text = item.DUICliente;
                        lblFechaEntrega.Text = item.fechaEntregaR.ToString();
                        lblCantidadPagar.Text = item.monto.ToString();
                        lblMatricula.Text = item.matriculaAutoR;
                        lblMarca.Text = item.marca;
                        lblModelo.Text = item.modelo;
                        lblColor.Text = item.color;
                        lblAnio.Text = item.anio;
                        lblNombreV.Text = item.NomCompleto;
                        fechaDev = item.fechaDevolucionR.ToString();
                        lblFechaDev.Text = fechaDev;
                        verificarEntrega();
                    }
                }
                catch
                {

                }
            }
        }

        private void cbxEstadoAuto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

        private void txtRecargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumerosDec(e);
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void send() {
            frmFactura f = new frmFactura();
            f.Cliente = this.lblDUIV.Text;
            f.Matricula = this.lblMatricula.Text;
            f.Usuario = this.Usuario;
            f.FechaE = this.lblFechaEntrega.Text;
            f.FechaD = this.dtpFechaDev.Value.ToLongDateString();
            f.Monto = this.lblCantidadPagar.Text;
            f.Usuario = this.Usuario;
            f.Recargo = this.txtRecargo.Text;
            f.Estado = this.cbxEstadoAuto.Text;
            f.Level = this.Level;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void cbxEstadoAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEstadoAuto.Text == "Averiado") {
                txtRecargo.Enabled = true;
            }
        }

        private double recargoRetraso(string fechaAcord)
        {
            double tarifa = 0,RecargoAveria= 0;
            BaseDataContext bd = new BaseDataContext();
            var monto = bd.SP_TarifaAuto(lblMatricula.Text);

            foreach (var dato in monto) {
                tarifa = double.Parse(dato.montoRenta.ToString());
            }

            TimeSpan diference = TimeSpan.Zero;
            DateTime fechaAcordada = Convert.ToDateTime(fechaAcord);
            diference = (DateTime.Now - fechaAcordada);
            RecargoAveria = diference.Days*tarifa;
            return RecargoAveria;
        }

        private void dtpFechaDev_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaDev.Value < DateTime.Now) {
                dtpFechaDev.Value = DateTime.Now;
            }
        }

        private void verificarEntrega() {
            if (fechaDev != String.Empty)
            {
                if (fechaDev == DateTime.Now.ToString())
                {
                    dtpFechaDev.Enabled = false;
                }

                if (Convert.ToDateTime(fechaDev).Day > DateTime.Now.Day)
                {
                    lblMsj.Text = "Faltan Días para la fecha de Devolución Acordada";
                    MessageBox.Show("Faltan Días para la fecha de Devolución Acordada");
                    cbxEstadoAuto.Enabled = false;
                    dtpFechaDev.Enabled = false;
                    lblCantidadPagar.Text = String.Empty;
                    lblRecarRetraso.Text = String.Empty;
                    btnDevolverAuto.Enabled = false;
                }

                if (Convert.ToDateTime(fechaDev) < DateTime.Now) {
                    lblMsj.Text = "Transacción con Retraso";
                    MessageBox.Show("Transacción con Retraso");
                    lblRecarRetraso.Text = recargoRetraso(lblFechaDev.Text).ToString();
                    lblCantidadPagar.Text = (double.Parse(lblCantidadPagar.Text)+double.Parse(lblRecarRetraso.Text)).ToString();
                }
            }
        }

        private void lblReg_Click(object sender, EventArgs e)
        {
            frmMenuContainer m = new frmMenuContainer();
            m.Level = this.Level;
            m.Usuario = this.Usuario;
            this.Hide();
            m.Show();
            this.Close();
        }
    }
}
