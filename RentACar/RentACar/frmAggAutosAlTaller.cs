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
    public partial class frmAggAutosAlTaller : Form
    {
        int idT = 0;
        public frmAggAutosAlTaller()
        {
            InitializeComponent();
        }

        string usuario;
        int level,retorno;

        public string Usuario { get => usuario; set => usuario = value; }
        public int Level { get => level; set => level = value; }
        public int Retorno { get => retorno; set => retorno = value; }

        private void btnAggATaller_Click(object sender, EventArgs e)
        {
            idT = int.Parse(cbxTaller.SelectedValue.ToString());
            string resultado = String.Empty;

            if (String.IsNullOrEmpty(txtAuto.Text))
            {
                errorProvider1.SetError(btnAuto, "Presiona el botón para seleccionar el auto");
                btnAuto.Focus();
            }
            else if (cbxTaller.SelectedIndex < 0)
            {
                errorProvider1.SetError(btnAuto, String.Empty);
                errorProvider1.SetError(cbxTaller, "Debes seleccionar una opción");
                cbxTaller.Focus();
            }
            else if (cbxMotivos.SelectedIndex < 0)
            {
                errorProvider1.SetError(cbxTaller, String.Empty);
                errorProvider1.SetError(cbxMotivos, "Debes seleccionar una opción");
                cbxMotivos.Focus();
            }
            else if (String.IsNullOrEmpty(rtbDescripcion.Text))
            {
                errorProvider1.SetError(cbxMotivos, String.Empty);
                errorProvider1.SetError(rtbDescripcion, "Escribe una descripción");
                rtbDescripcion.Focus();
            }
            else
            {
                try
                {
                    BaseDataContext db = new BaseDataContext();

                    db.AGGAUTOS_TALLER(idT, txtAuto.Text, cbxMotivos.Text, rtbDescripcion.Text, dtpFechaIngreso.Value, ref resultado);
                    if (resultado == "1")
                    {
                        MessageBox.Show("Auto agregado al taller correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAuto.Text = String.Empty;
                        cbxMotivos.Text = "Selecciona";
                        cbxTaller.Text = "Selecciona";
                        dtpFechaIngreso.Value = DateTime.Now;
                        rtbDescripcion.Text = String.Empty;

                        txtAuto.Focus();
                    }
                    else if (resultado == "0")
                    {
                        MessageBox.Show("No se pudo agregar al taller:\nIntenta nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAuto.Focus();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo agregar al taller:\nIntenta nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAuto.Focus();
                }
            }
        }

        private void frmAggAutosAlTaller_Load(object sender, EventArgs e)
        {
            try
            {
                BaseDataContext db = new BaseDataContext();

                //Declaramos un "tipo anónimo" para obtener los datos del procedimiento almacenado
                var t = from talleres in db.CONS_TALLERES() select new { talleres.idTaller, talleres.nomTaller };

                cbxTaller.DisplayMember = "nomTaller";//Datos que se mostraran
                cbxTaller.ValueMember = "idTaller";//Valor correspondiente (tomado de la base de datos) al dato mostrado en el comboBox 
                cbxTaller.DataSource = t.ToList();//Se enlistan los datos de la tabla
                                                  //cbxTaller.SelectedIndex = 0;//Indice de la lista "r.ToList()" que se muestra primero al cargar el comboBox

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            cbxTaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            cbxMotivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            dtpFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            rtbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            frmSeleccionAuto frmSeleccionAuto = new frmSeleccionAuto();
            frmSeleccionAuto.ValorForm = 3;
            frmSeleccionAuto.Usuario = this.Usuario;
            frmSeleccionAuto.Level = this.Level;
            this.Hide();
            frmSeleccionAuto.ShowDialog();
            this.Close();
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblReg_Click(object sender, EventArgs e)
        {
            if (retorno != 1)
            {
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
