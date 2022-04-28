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
    public partial class frmConsultarRentas : Form
    {
        public frmConsultarRentas()
        {
            InitializeComponent();
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
