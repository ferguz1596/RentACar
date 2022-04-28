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
    public partial class frmSelFuncionAuto : Form
    {
        public frmSelFuncionAuto()
        {
            InitializeComponent();
        }

        string usuario;
        int level;
        frmMenuContainer menu = new frmMenuContainer();

        public string Usuario { get => usuario; set => usuario = value; }
        public int Level { get => level; set => level = value; }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            frmMenuContainer m = new frmMenuContainer();
            this.Hide();
            m.ShowDialog();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMenuContainer m = new frmMenuContainer();
            m.Usuario = this.Usuario;
            m.Level = this.Level;
            this.Hide();
            m.Show();
            m.openForm(new frmAggAutos());
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarAuto elim = new frmEliminarAuto();
            elim.Usuario = this.Usuario;
            elim.Level = this.Level;
            this.Hide();
            elim.ShowDialog();
            elim.Close();
        }

        private void btnAutosTaller_Click(object sender, EventArgs e)
        {
            frmAggAutosAlTaller at = new frmAggAutosAlTaller();
            at.Usuario = this.Usuario;
            at.Level = this.Level;
            this.Hide();
            at.ShowDialog();
            this.Close();
        }

        private void btnEliminarAutoTaller_Click(object sender, EventArgs e)
        {
            frmEliminarAutoDeTaller et = new frmEliminarAutoDeTaller();
            et.Usuario = this.Usuario;
            et.Level = this.Level;
            this.Hide();
            et.ShowDialog();
            this.Close();
        }

        private void lblReg_Click(object sender, EventArgs e)
        {
            frmMenuContainer m = new frmMenuContainer();
            m.Usuario = this.Usuario;
            m.Level = this.Level;
            this.Hide();
            m.Show();
            this.Close();
        }
    }
}
