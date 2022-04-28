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
    public partial class frmConsultarFacturasDevolverAuto : Form
    {
        string valorIDRenta = String.Empty;
        string usuario;
        int level;

        public string Usuario { get => usuario; set => usuario = value; }
        public int Level { get => level; set => level = value; }

        public frmConsultarFacturasDevolverAuto()
        {
            InitializeComponent();
        }

        private void frmConsultarFacturasDevolverAuto_Load(object sender, EventArgs e)
        {
            try
            {
                BaseDataContext db = new BaseDataContext();
                this.dgvFacturas.DataSource = db.CON_FACTURA();
            }
            catch { };
            dgvFacturas.Columns[0].HeaderText = "ID Renta";
            dgvFacturas.Columns[1].HeaderText = "Matricula de Auto";
            dgvFacturas.Columns[2].HeaderText = "DUI";
            dgvFacturas.Columns[3].HeaderText = "Fecha de Entrega";
            dgvFacturas.Columns[4].HeaderText = "Fecha de Devolución";
            dgvFacturas.Columns[5].HeaderText = "Monto";
           
        }

        public void dgvFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDevolverAuto devolverAuto = new frmDevolverAuto();
            int indiceFilas = e.RowIndex;
            if (indiceFilas >= 0)
            {
                valorIDRenta = dgvFacturas.Rows[e.RowIndex].Cells[0].Value.ToString();
                devolverAuto.txtFactura.Text = valorIDRenta;
                devolverAuto.Usuario = this.Usuario;
                devolverAuto.Level = this.Level;
                this.Hide();
                devolverAuto.ShowDialog();
                this.Close();
            }
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblReg_Click(object sender, EventArgs e)
        {
            frmMenuContainer dev = new frmMenuContainer();
            dev.Usuario = this.Usuario;
            dev.Level = this.Level;
            this.Hide();
            dev.ShowDialog();
            this.Close();
        }
    }
}
