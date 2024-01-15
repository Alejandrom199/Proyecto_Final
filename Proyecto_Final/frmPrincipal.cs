using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVisual
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmClientes pantallaClientes = new frmClientes();
            pantallaClientes.Show();
        }

        private void btnMecanico_Click(object sender, EventArgs e)
        {
            frmMecanico pantallaMecanicos = new frmMecanico();
            pantallaMecanicos.Show();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            frmMantenimiento pantallaMantenimiento = new frmMantenimiento();
            pantallaMantenimiento.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Deseas cerrar tu sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Close();
                frmLogin pantallaLogin = new frmLogin();
                pantallaLogin.Show();
            }else
            {

            }
        }
    }
}
