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
    public partial class frmSeleccionAuto : Form
    {

        string cliente;
        string matricula,usuario;
        public int valorForm;
        private int level;

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public int ValorForm { get => valorForm; set => valorForm = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public int Level { get => level; set => level = value; }
        int n;
        public frmSeleccionAuto()
        {
            InitializeComponent();
            
            cbxMarca.Enabled = false;
            txtModelo.Enabled = false;
            txtColor.Enabled = false;
        }

        private void frmSeleccionAuto_Load(object sender, EventArgs e)
        {
            mantain();
            if (ValorForm == 1)
            {
                FillDataGrid(1);
                n = 1;
            }
            else if (valorForm == 2)
            {
                FillDataGrid(1);
                n = 1;
            }
            else if (ValorForm == 3)
            {
                FillDataGrid(5);
                n = 5;
            }
            else if (ValorForm == 4)
            {
                FillDataGrid(3);
                n = 3;
            }
        }

        private void btnSelecAuto_Click(object sender, EventArgs e)
        {
            if (txtMatricula.Text == String.Empty)
            {
                errorProvider1.SetError(txtMatricula, "Campo Obligatorio");
                lblMsj.Visible = true;
            }
            else
            {
                
                if (ValorForm == 1)
                {
                    lblMsj.Visible = false;
                    errorProvider1.SetError(txtMatricula, "");
                    frmRentaDeAuto auto = new frmRentaDeAuto();
                    auto.txtMatriculaAuto.Text= txtMatricula.Text;
                    auto.Level = this.Level;
                    auto.Usuario = this.Usuario;
                    this.Hide();
                    auto.ShowDialog();
                    this.Close();
                }
                else if(ValorForm == 2)
                {
                    lblMsj.Visible = false;
                    frmEliminarAuto f = new frmEliminarAuto();
                    f.txtAuto.Text = txtMatricula.Text;
                    errorProvider1.SetError(txtMatricula, "");
                    this.Hide();
                    f.Level = this.Level;
                    f.Usuario = this.Usuario;
                    f.ShowDialog();
                    this.Close();
                }
                else if(ValorForm == 3)
                {
                    lblMsj.Visible = false;
                    frmAggAutosAlTaller f = new frmAggAutosAlTaller();
                    f.txtAuto.Text = txtMatricula.Text;
                    errorProvider1.SetError(txtMatricula, "");
                    this.Hide();
                    f.Level = this.Level;
                    f.Usuario = this.Usuario;
                    f.ShowDialog();
                    this.Close();
                }
                else if (ValorForm == 4)
                {
                    lblMsj.Visible = false;
                    frmEliminarAutoDeTaller f = new frmEliminarAutoDeTaller();
                    f.txtAuto.Text = txtMatricula.Text;
                    errorProvider1.SetError(txtMatricula, "");
                    this.Hide();
                    f.Level = this.Level;
                    f.Usuario = this.Usuario;
                    f.ShowDialog();
                    this.Close();
                }
            }
        }

        //llenar sin filtros
        public List<SP_SeleccionarAutoResult> callData(int stado)
        {
            BaseDataContext Base = new BaseDataContext();
            var call = Base.SP_SeleccionarAuto(stado);
            return call.ToList();
        }

        public void FillDataGrid(int param)
        {
            dataGridView1.DataSource = callData(param);
        }

        //Llenar con filtros
        public List<SP_SeleccionAutoFiltrosResult> callDataFiltros()
        {
            BaseDataContext Base = new BaseDataContext();
            var call = Base.SP_SeleccionAutoFiltros(n,cbxTipo.Text,cbxMarca.Text,txtModelo.Text,txtColor.Text);
            return call.ToList();
        }

        public void FillDataGridFiltros()
        {
            dataGridView1.DataSource = callDataFiltros();
        }
        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDataGridFiltros();
            var result = callDataFiltros();
            if (result.Count != 1)
            {
                cbxMarca.Enabled = true;
            }
        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDataGridFiltros();
 
            var result = callDataFiltros();
            if (result.Count != 1)
            {
                txtModelo.Enabled = true;
            }
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            FillDataGridFiltros();
            var result = callDataFiltros();
            if(result.Count != 1)
            {
                txtColor.Enabled = true; 
            }
        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {
            if (txtMatricula.Text != String.Empty)
            {
                btnClean.Enabled = true;
                FillDataGridLike();
            }
            else {
                FillDataGrid(n);
            }

            var result = callDataFiltros();

            if (result.Count == 0)
            {
                btnSelecAuto.Enabled = false;
            }
            else
            {
                btnSelecAuto.Enabled = true;
            }
        }

        //Like
        public List<SP_BuscarMatriculaResult> callDataLike()
        {
            BaseDataContext Base = new BaseDataContext();
            var call = Base.SP_BuscarMatricula(txtMatricula.Text,cbxTipo.Text,cbxMarca.Text,txtModelo.Text,txtColor.Text);
            return call.ToList();
        }

        public void FillDataGridLike()
        {
            dataGridView1.DataSource = callDataLike();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMatricula.Text = String.Empty;
            cbxMarca.Text = "Marca";
            cbxTipo.Text = "Tipo";
            txtModelo.Text = String.Empty;
            txtColor.Text = String.Empty;
        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {
            FillDataGridFiltros();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMatricula.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            errorProvider1.SetError(txtMatricula,"");
            btnSelecAuto.Enabled = true;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            FillDataGrid(n);
            txtMatricula.Text = String.Empty;
            txtMatricula.Enabled = true;
            cbxMarca.Text = "Marca";
            cbxMarca.Enabled = false;
            cbxTipo.Text = "Tipo";
            txtModelo.Text = String.Empty;
            txtModelo.Enabled = false;
            txtColor.Text = String.Empty;
            txtColor.Enabled = false;

        }

        public void mantain() {
            txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            cbxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            cbxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            dataGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSeleccionAuto_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Propiedades p = new Propiedades();
            //p.Matricula = txtMatricula.Text;
        }

        private void frmSeleccionAuto_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Propiedades p = new Propiedades();
            //p.Matricula = txtMatricula.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            frmMenuContainer m = new frmMenuContainer();
                m.Usuario = this.Usuario;
                m.Level = this.Level;
                this.Hide();
                m.Show();
                this.Close();
        }

        private void frmSeleccionAuto_Deactivate(object sender, EventArgs e)
        {
            //Propiedades p = new Propiedades();
            //p.Matricula = txtMatricula.Text;
            //MessageBox.Show(p.Matricula);
        }
    }
}
