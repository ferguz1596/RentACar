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
    public partial class frmDarDeBajaUsuario : Form
    {
        string usuario;
        int level;

        public string Usuario { get => usuario; set => usuario = value; }
        public int Level { get => level; set => level = value; }

        public frmDarDeBajaUsuario()
        {
            InitializeComponent();
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDarDeBaja_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmSeleccionarCliente cl = new frmSeleccionarCliente();
            cl.Usuario = this.Usuario;
            cl.Level = this.Level;
            cl.Retorno = 2;
            this.Hide();
            cl.ShowDialog();
            this.Close();
        }
    }
}
