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
    public partial class frmRentaDeAuto : Form
    {

        string matricula, cliente,usuario;
        int level;

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        double monto;

        public double Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        public string Usuario { get => usuario; set => usuario = value; }
        public int Level { get => level; set => level = value; }

        Propiedades pro = new Propiedades();

        public frmRentaDeAuto()
        {
            InitializeComponent();
        }


        private void btnBuscarMatricula_Click(object sender, EventArgs e)
        {
            frmSeleccionAuto auto = new frmSeleccionAuto();
            auto.ValorForm = 1;
            auto.Usuario = this.Usuario;
            auto.Level = this.Level;
            this.Hide();
            auto.ShowDialog();
            this.Close();
        }

        private void frmRentaDeAuto_Load(object sender, EventArgs e)
        {
            //frmMenuContainer me = new frmMenuContainer();
            //txtMatriculaAuto.Text = me.Matricula;
            BaseDataContext bd = new BaseDataContext();
            if (txtMatriculaAuto.Text != "")
            {
                var datos = bd.SP_ImagenRenta(txtMatriculaAuto.Text);
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
                }
            }

            mantain();
            data();
        }

        private void txtMatriculaAuto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmSeleccionarCliente client = new frmSeleccionarCliente();
            client.DatoMatricula = txtMatriculaAuto.Text;
            client.Usuario = this.Usuario;
            client.Level = this.Level;
            this.Hide();
            client.ShowDialog();
            this.Close();
        }

        private void dtpFechaDev_ValueChanged(object sender, EventArgs e)
        {
            if (Dias(dtpFechaEntrega.Value, dtpFechaDev.Value) < 0)
            {
                lblCantidadDias.Text = "0";
            }
            else
            {
                lblCantidadDias.Text = Dias(dtpFechaEntrega.Value, dtpFechaDev.Value).ToString();
                lblPrecio.Text = (double.Parse(lblCantidadDias.Text) * Monto).ToString();
                lblMontoTarifa.Text = Monto.ToString() ;
                btnRentarAuto.Enabled = true;
            }
        }

        public void data() {
            BaseDataContext bd = new BaseDataContext();
            var call = bd.SP_EspecificacionAutos(txtMatriculaAuto.Text);
            foreach (var list in call) {
                lblMarca.Text = list.marca;
                lblModelo.Text = list.modelo;
                lblAnio.Text = list.anio;
                lblColor.Text = list.color;
                lblMontoTarifa.Text = "$ "+list.montoRenta.ToString();
                Monto = double.Parse(list.montoRenta.ToString());
            }
        }

        private void btnRentarAuto_Click(object sender, EventArgs e)
        {
            BaseDataContext bd = new BaseDataContext();
            try
                {
                bd.SP_EstadoAuto(txtMatriculaAuto.Text);
                    var insert = bd.SP_InsertRentaAuto(txtMatriculaAuto.Text, txtCliente.Text, dtpFechaEntrega.Value, dtpFechaDev.Value, double.Parse(lblPrecio.Text), 1);
                    MessageBox.Show("Exitosa");
                }
                catch
                {
                }

            var id = bd.SP_extraerIdRenta();
            string ID = "";
            foreach (var ide in id) {
                ID = ide.idRenta.ToString();
            }
            form ticket = new form();
            ticket.Id = ID;
            ticket.Cliente = this.txtCliente.Text;
            ticket.Matricula = this.txtMatriculaAuto.Text;
            ticket.Usuario = this.Usuario;
            ticket.Level = this.Level; 
            ticket.FechaE = this.dtpFechaEntrega.Value.ToString();
            ticket.FechaD = this.dtpFechaDev.Value.ToString();
            ticket.Tarifa = this.lblMontoTarifa.Text;
            ticket.Monto = this.lblPrecio.Text;
            this.Hide();
            ticket.ShowDialog();
            this.Close();
            }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        public double Dias(DateTime primerFecha, DateTime segundaFecha)
        {
            TimeSpan diferencia;
            diferencia = primerFecha - segundaFecha;
            return diferencia.Days*-1;
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            //frmMenuContainer menu = new frmMenuContainer();
            //menu.openForm(new frmPrincipalAdministrador());
            //menu.Show();
            this.Close();
        }

        private void dtpFechaEntrega_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaEntrega.Value <= DateTime.Now.Date) {
                dtpFechaEntrega.Value = DateTime.Now.Date;
                    MessageBox.Show("La fecha asignada es anterior a la fecha de hoy.");
            }
        }

        private void frmRentaDeAuto_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frmRentaDeAuto_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmRentaDeAuto_Activated(object sender, EventArgs e)
        {
            //Propiedades p = new Propiedades();
            //txtMatriculaAuto.Text = p.Matricula;
        }

        private void lblRegresar_Click(object sender, EventArgs e)
        {
            frmMenuContainer m = new frmMenuContainer();
            this.Hide();
            m.Usuario = this.Usuario;
            m.Level = this.Level;
            m.ShowDialog();
            this.Close();
        }

        private void pbAuto_Click(object sender, EventArgs e)
        {

        }

        private void frmRentaDeAuto_Shown(object sender, EventArgs e)
        {
            //frmMenuContainer me = new frmMenuContainer();
            //txtMatriculaAuto.Text = me.Matricula;

        }
        public void mantain() {
            this.dtpFechaDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular); 
            this.dtpFechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            this.btnBuscarMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        }
    }
}
