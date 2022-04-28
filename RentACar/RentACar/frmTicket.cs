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
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        string matricula;
        string usuario;
        string cliente;
        string fechaE;
        string fechaD;
        string tarifa;
        string monto;
        string id;
        int level;

        public string Matricula { get => matricula; set => matricula = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string FechaE { get => fechaE; set => fechaE = value; }
        public string FechaD { get => fechaD; set => fechaD = value; }
        public string Tarifa { get => tarifa; set => tarifa = value; }
        public string Monto { get => monto; set => monto = value; }
        public int Level { get => level; set => level = value; }
        public string Id { get => id; set => id = value; }

        private void frmTicket_Load(object sender, EventArgs e)
        {
            string[] campos = new string[3];
            campos = Datos();
            lblRenta.Text = this.Id;
            lblCliente.Text = campos[1];
            lblDui.Text = Cliente;
            lblAuto.Text = campos[0];
            lblMatricula.Text = Matricula;
            lblFechTrans.Text = DateTime.Today.ToString();
            lblFechEntrega.Text = FechaE;
            lblFechDev.Text = FechaD;
            lblTarifa.Text = Tarifa;
            lblMonto.Text = Monto;
            lblEmp.Text = campos[2];
        }

        private String [] Datos() {
            BaseDataContext bd = new BaseDataContext();
            string[] data = new String[10];
            var dataAuto = bd.SP_AutoTicketRenta(Matricula);
            foreach (var item in dataAuto)
            {
                data[0] = item.tipo+" "+item.marca+" "+item.modelo;
            }
            var dataCliente = bd.SP_ClinteTicketRenta(Cliente);
            foreach (var itemC in dataCliente)
            {
                data[1] = itemC.nombresCliente + " " + itemC.apellidosCliente;
            }
            var dataUser = bd.SP_EmpleadoTicketRenta(Usuario);
            foreach (var itemE in dataUser)
            {
                data[2] = itemE.nombresEmpleado + " " + itemE.apellidosEmpleado;
            }
            return data;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuContainer m = new frmMenuContainer();
            m.Level = this.Level;
            m.Usuario = this.Usuario;
            m.Show();
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
