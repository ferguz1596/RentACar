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
    public partial class frmGestionarTalleres : Form
    {
        public frmGestionarTalleres()
        {
            InitializeComponent();
        }

        private void frmGestionarTalleres_Load(object sender, EventArgs e)
        {
            fillConsultarTalleres();
            dgvTalleres.Columns[0].HeaderText = "N°";
            dgvTalleres.Columns[1].HeaderText = "Nombre";
            dgvTalleres.Columns[2].HeaderText = "Dirección";
            dgvTalleres.Columns[3].HeaderText = "Teléfono";
            dgvTalleres.Columns[4].HeaderText = "Encargado";
        }

        public List<SP_ConsultarTallerResult> ConsultarTalleres() {
            BaseDataContext bd = new BaseDataContext();
            var call = bd.SP_ConsultarTaller();
            return call.ToList();
        }

        public void fillConsultarTalleres() {
            dgvTalleres.DataSource = ConsultarTalleres();
        }

        public List<SP_BuscarTallerResult> buscarTaller()
        {
            BaseDataContext bd = new BaseDataContext();
            var call = bd.SP_BuscarTaller(txtNomTaller.Text);
            return call.ToList();
        }

        public void fillBuscarTalleres()
        {
            dgvTalleres.DataSource = buscarTaller();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNomTaller.Text = String.Empty;
            txtEncargado.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtTelefono.Text = String.Empty;

            txtNomTaller.Enabled = true;
            txtEncargado.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;

            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BaseDataContext bd = new BaseDataContext();
            string result = String.Empty;
            var guardar = bd.SP_InsertarTaller(txtNomTaller.Text,txtDireccion.Text,txtTelefono.Text,txtEncargado.Text, ref result);

            if (result == "1")
            {
                lblMsj.Text = "Taller Registrado";
                fillConsultarTalleres();
            }
            else {
                lblMsj.Text = "El taller ya esta registrado";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BaseDataContext bd = new BaseDataContext();
            string result = String.Empty;
            bd.SP_EliminarTaller(txtNomTaller.Text,ref result);
            if (result == "1")
            {
                lblMsj.Text = "Taller eliminado";
                fillConsultarTalleres();
            }
            else {
                lblMsj.Text = "El taller no existe en los registros";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvTalleres_CellContentClick(null,null);
        }

        private void txtNomTaller_TextChanged(object sender, EventArgs e)
        {
            fillBuscarTalleres();
        }

        private void dgvTalleres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNomTaller.Text = dgvTalleres.CurrentRow.Cells[1].Value.ToString();
            txtEncargado.Text = dgvTalleres.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text = dgvTalleres.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = dgvTalleres.CurrentRow.Cells[3].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEncargado_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
