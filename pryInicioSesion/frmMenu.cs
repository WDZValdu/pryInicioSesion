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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cargarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCargarUs frmCargarUs = new frmCargarUs();
            frmCargarUs.Show();
        }

        private void verReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReportes frmReportes = new frmReportes();
            frmReportes.Show();
        }
    }
}
