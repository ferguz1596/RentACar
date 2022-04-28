using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RentACar
{
    public partial class frmMenuContainer : Form
    {
        public frmMenuContainer()
        {
            InitializeComponent();
        }

        int level;
        int form ;
        string usuario;
        string matricula;
      
        public string Usuario { get => usuario; set => usuario = value; }
        public int Level { get => level; set => level = value; }
        public int Form { get => form; set => form = value; }
        public string Matricula { get => matricula; set => matricula = value; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void openForm(object son) {
            if (this.panelContainer.Controls.Count > 0)
            {
                this.panelContainer.Controls.RemoveAt(0);
            }
            this.AutoScaleMode = AutoScaleMode.None;
            Form fh = son as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.AutoScaleMode = AutoScaleMode.None;
            this.panelContainer.Controls.Add(fh);
            this.panelContainer.Tag = fh;
            fh.Show();
        }

        private void btnRenta_Click(object sender, EventArgs e)
        {
            frmRentaDeAuto r = new frmRentaDeAuto();
            this.Hide();
            r.Usuario = this.Usuario;
            r.Level = this.Level;
            r.ShowDialog();
            this.Close();
        }

        private void frmMenuContainer_Load(object sender, EventArgs e)
        {
            lblUser.Text = Usuario;
            retornar();

            if (Level == 2) {
                btnAutos.Visible = false;
                btnTalleres.Visible = false;
                btnUsuarios.Visible = false;
                btnAddClientes.Location = new Point(1,240);
                button2.Location = new Point(1,299);
                button1.Location = new Point(1,357);
            }
        }

        private void pcbClose_Click(object sender, EventArgs e)
        {
            frmIniciarSesion login = new frmIniciarSesion();
            this.Close();
            login.Show();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            frmDevolverAuto dev = new frmDevolverAuto();
            this.Hide();
            dev.Usuario = this.Usuario;
            dev.Level = this.Level;
            dev.Tipo = 2;
            dev.ShowDialog();
            this.Close();
        }

        private void btnAutos_Click(object sender, EventArgs e)
        {
            frmSelFuncionAuto funcion = new frmSelFuncionAuto();
            this.Hide();
            funcion.Level = this.Level;
            funcion.Usuario = this.Usuario;
            funcion.ShowDialog();
            this.Close();
        }

        private void btnAddClientes_Click(object sender, EventArgs e)
        {
            openForm(new frmAggCliente());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            openForm(new frmAggUsuario());
        }

        private void btnTalleres_Click(object sender, EventArgs e)
        {
            openForm(new frmGestionarTalleres());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            openForm(new frmGenerarReportes());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmIniciarSesion log = new frmIniciarSesion();
            this.Hide();
            log.ShowDialog();
            this.Close();
        }

        private void lblReg_Click(object sender, EventArgs e)
        {
            retornar();
        }

        private void levelAdmin() {
            this.panelContainer.Controls.RemoveAt(0);
            this.panelContainer.Controls.Add(pnlOptions);
            pnlOptions.Visible = true;
        }

        private void levelEmp()
        {
            this.panelContainer.Controls.RemoveAt(0);
            this.panelContainer.Controls.Add(pnlOptionsEmp);
            pnlOptionsEmp.Visible = true;
        }

        private void retornar(){
            if (Level == 1)
            {
                levelAdmin();
            }
            else {
                levelEmp();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmRentaDeAuto renta = new frmRentaDeAuto();
            renta.Usuario = this.Usuario;
            renta.Level = this.Level;
            this.Hide();
            renta.ShowDialog();
        }

        private void pcbHome_Click(object sender, EventArgs e)
        {
            retornar();
        }

        private void pcbPerfil_Click(object sender, EventArgs e)
        {
            openForm(new frmPerfilUser());
        }

        private void btnDevolverAdmin_Click(object sender, EventArgs e)
        {
            frmDevolverAuto dev = new frmDevolverAuto();
            this.Hide();
            dev.Usuario = this.Usuario;
            dev.Level = this.Level;
            dev.Tipo = 1;
            dev.ShowDialog();
            this.Close();
        }

        private void btnNewAutoAdmin_Click(object sender, EventArgs e)
        {
            openForm(new frmAggAutos());
        }

        private void btnRepararAdmin_Click(object sender, EventArgs e)
        {
            frmAggAutosAlTaller at = new frmAggAutosAlTaller();
            at.Usuario = this.Usuario;
            at.Level = this.Level;
            at.Retorno = 1;
            this.Hide();
            at.ShowDialog();
            this.Close();
        }

        private void btnArregladoAdmin_Click(object sender, EventArgs e)
        {
            frmEliminarAutoDeTaller et = new frmEliminarAutoDeTaller();
            et.Usuario = this.Usuario;
            et.Level = this.Level;
            et.Retorno = 1;
            this.Hide();
            et.ShowDialog();
            this.Close();
        }

        private void btnEliminarAdmin_Click(object sender, EventArgs e)
        {
            frmEliminarAuto elim = new frmEliminarAuto();
            elim.Usuario = this.Usuario;
            elim.Level = this.Level;
            elim.Retorno = 1;
            this.Hide();
            elim.ShowDialog();
            this.Close();
        }

        private void btnBajaAdmin_Click(object sender, EventArgs e)
        {
            frmDarDeBajaUsuario baja = new frmDarDeBajaUsuario();
            baja.Usuario = this.Usuario;
            baja.Level = this.Level;
            this.Hide();
            baja.ShowDialog();
            this.Close();
        }

        private void btnNuevoUsuarioAdmin_Click(object sender, EventArgs e)
        {
            openForm(new frmAggUsuario());
        }

        private void btnNuevoClienteAdmin_Click(object sender, EventArgs e)
        {
            openForm(new frmAggCliente());
        }

        private void btnRentaEmp_Click(object sender, EventArgs e)
        {
            frmRentaDeAuto renta = new frmRentaDeAuto();
            renta.Usuario = this.Usuario;
            renta.Level = this.Level;
            this.Hide();
            renta.ShowDialog();
        }

        private void btnDevolverEmp_Click(object sender, EventArgs e)
        {
            frmDevolverAuto dev = new frmDevolverAuto();
            this.Hide();
            dev.Usuario = this.Usuario;
            dev.Level = this.Level;
            dev.Tipo = 2;
            dev.ShowDialog();
            this.Close();
        }

        private void btnReparadoEmp_Click(object sender, EventArgs e)
        {
            openForm(new frmEliminarAutoDeTaller());
        }

        private void btnClienteEmp_Click(object sender, EventArgs e)
        {
            openForm(new frmAggCliente());
        }

        private void btnAddTallerEmp_Click(object sender, EventArgs e)
        {
            frmAggAutosAlTaller at = new frmAggAutosAlTaller();
            at.Usuario = this.Usuario;
            at.Level = this.Level;
            at.Retorno = 1;
            this.Hide();
            at.ShowDialog();
            this.Close();
        }

        private void btnQuitTallerEmp_Click(object sender, EventArgs e)
        {
            frmEliminarAutoDeTaller et = new frmEliminarAutoDeTaller();
            et.Usuario = this.Usuario;
            et.Level = this.Level;
            et.Retorno = 1;
            this.Hide();
            et.ShowDialog();
            this.Close();
        }

        private void pcbNotificaciones_Click(object sender, EventArgs e)
        {
            //openForm(new frmNotificaciones());
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNotificaciones n = new frmNotificaciones();
            openForm(n);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            if (panelContainer.Controls.Count>0) {
                retornar();
            }
        }

        private void pcbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlOptions_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
