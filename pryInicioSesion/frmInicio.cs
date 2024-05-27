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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            clsUsuario objBD = new clsUsuario();
            objBD.ValidarUsuario(txtUsuario.Text, txtContraseña.Text);

            if (objBD.estadoConexion == "Usuario EXISTE")
            {
                objBD.RegistroLogInicioSesion();
                this.Hide();
                frmMenu frmMenu = new frmMenu();
                frmMenu.Show();
            }
            else
            {
                MessageBox.Show("Usuario y Contraseña incorrectos");
                objBD.LogInicioSesionRechazado();
            }
        }
    }
}
