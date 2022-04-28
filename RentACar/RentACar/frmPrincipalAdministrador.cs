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
    public partial class frmPrincipalAdministrador : Form
    {
        public frmPrincipalAdministrador()
        {
            InitializeComponent();
        }
        frmMenuContainer menu = new frmMenuContainer();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmRentaDeAuto renta = new frmRentaDeAuto();
            //menu.Show();
            //menu.openForm(renta);
            renta.ShowDialog();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            frmDevolverAuto devolver = new frmDevolverAuto();
            //menu.Show();
            //menu.openForm(devolver);
            devolver.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultarRentas consult = new frmConsultarRentas();
            //menu.Show();
            //menu.openForm(consult);
            consult.ShowDialog();
        }

        private void btnNewAuto_Click(object sender, EventArgs e)
        {
            frmAggAutos auto = new frmAggAutos();
            //menu.Show();
            //menu.openForm(auto);
            auto.ShowDialog();
        }

        private void btnReparar_Click(object sender, EventArgs e)
        {
            frmAggAutosAlTaller autoTaller = new frmAggAutosAlTaller();
            /*menu.Show();
            menu.openForm(autoTaller);*/
            autoTaller.ShowDialog();
        }

        private void btnArreglado_Click(object sender, EventArgs e)
        {
            frmEliminarAutoDeTaller eliminarAutoTaller = new frmEliminarAutoDeTaller();
            //menu.Show();
            //menu.openForm(eliminarAutoTaller);
            eliminarAutoTaller.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarAuto eliminar = new frmEliminarAuto();
            //menu.Show();
            //menu.openForm(eliminar);
            eliminar.ShowDialog();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            frmAggCliente newCliente = new frmAggCliente();
            //menu.Show();
            //menu.openForm(newCliente);
            newCliente.ShowDialog();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            frmAggUsuario usuario = new frmAggUsuario();
            //menu.Show();
            //menu.openForm(usuario);
            usuario.ShowDialog();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            frmDarDeBajaUsuario baja = new frmDarDeBajaUsuario();
            //menu.Show();
            //menu.openForm(baja);
            baja.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmGenerarReportes report = new frmGenerarReportes();
            //menu.Show();
            //menu.openForm(report);
            report.ShowDialog();
        }
    }
}
