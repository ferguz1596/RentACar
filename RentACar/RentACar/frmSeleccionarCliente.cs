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
    public partial class frmSeleccionarCliente : Form
    {
        public frmSeleccionarCliente()
        {
            InitializeComponent();
        }

        string datoMatricula,usuario;
        int level,retorno;

        public string DatoMatricula
        {
            get { return datoMatricula; }
            set { datoMatricula = value; }
        }

        public string Usuario { get => usuario; set => usuario = value; }
        public int Level { get => level; set => level = value; }
        public int Retorno { get => retorno; set => retorno = value; }

        private void frmSeleccionarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                RentACar.BaseDataContext data = new RentACar.BaseDataContext();
                this.dgvCliente.DataSource = data.Listar_UsuarioSP();

            }
            catch
            {

            }
            dgvCliente.Columns[0].HeaderText = "DUI";
            dgvCliente.Columns[1].HeaderText = "Nombres";
            dgvCliente.Columns[2].HeaderText = "Apellidos";
            dgvCliente.Columns[3].HeaderText = "Edad";
            dgvCliente.Columns[4].HeaderText = "Licencia";
            dgvCliente.Columns[5].HeaderText = "Direccion";
            dgvCliente.Columns[6].HeaderText = "Telefono";
        }

        private void llblAggCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmAggCliente Add = new frmAggCliente();
            Add.Show();
            this.Dispose();
        }

        private void btnSelecCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRentaDeAuto frm = new frmRentaDeAuto();
            frm.Level = this.Level;
            frm.Usuario = this.Usuario;
            frm.txtMatriculaAuto.Text = DatoMatricula;
            frm.Show();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            fillCallClientesLike();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCliente.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
        }

        public List<Filtrar_ClienteSPResult> callClientesLike(){
            BaseDataContext db = new BaseDataContext();
            var call = db.Filtrar_ClienteSP(txtCliente.Text);
            return call.ToList();
        }

        public void fillCallClientesLike() {
            dgvCliente.DataSource = callClientesLike();
        }

        private void btnSelecCliente_Click_1(object sender, EventArgs e)
        {
            frmRentaDeAuto renta = new frmRentaDeAuto();
            renta.txtCliente.Text = this.txtCliente.Text;
            renta.txtMatriculaAuto.Text = DatoMatricula;
            renta.Usuario = this.Usuario;
            renta.Level = this.Level;
            this.Hide();
            renta.ShowDialog();
            this.Close();
        }

        private void txtCliente_TextChanged_1(object sender, EventArgs e)
        {
            fillCallClientesLike();
        }

        private void llblAggCliente_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMenuContainer m = new frmMenuContainer();
            this.Hide();
            m.Usuario = this.Usuario;
            m.Level = this.Level;
            m.Show();
            m.openForm(new frmAggCliente());
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
  
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
