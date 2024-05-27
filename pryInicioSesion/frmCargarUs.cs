using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryInicioSesion
{
    public partial class frmCargarUs : Form
    {
        public frmCargarUs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsUsuario objBD = new clsUsuario();
            objBD.CargaCliente(txtUsuario.Text, txtContra.Text,Convert.ToString(cmbPerfil.SelectedItem));
            txtContra.Text = "";
            txtUsuario.Text = "";
            cmbPerfil.Text = "";
            MessageBox.Show("usuario cargado correctamente");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }
    }
}
