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
    public partial class frmEliminarAutoDeTaller : Form
    {
        public frmEliminarAutoDeTaller()
        {
            InitializeComponent();
        }

        string usuario;
        int level,retorno;

        public string Usuario { get => usuario; set => usuario = value; }
        public int Level { get => level; set => level = value; }
        public int Retorno { get => retorno; set => retorno = value; }

        private void frmEliminarAutoDeTaller_Load(object sender, EventArgs e)
        {
            
        }

        private void btnElimDeTaller_Click(object sender, EventArgs e)
        {
            try
            {
                BaseDataContext bd = new BaseDataContext();
                var d = bd.SP_egresarTaller(txtAuto.Text, dtpFechaEgreso.Value, cbxMotivos.Text, double.Parse(txtMonto.Text));
                bd.SP_ActEstadoAuto(1,txtMonto.Text);
                MessageBox.Show("Auto egresado del Taller");
                txtAuto.Text = "";
                txtMonto.Text = "";
                rtbObservaciones.Text = "";

            }
            catch {
            }

        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            frmSeleccionAuto a = new frmSeleccionAuto();
            a.Usuario = this.Usuario;
            a.Level = this.Level;
            this.Hide();
            a.ShowDialog();
            this.Close();
        }

        private void cbxMotivos_TextChanged(object sender, EventArgs e)
        {

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

