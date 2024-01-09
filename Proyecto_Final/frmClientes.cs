using CapaNegocio.Entidades;
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
    public partial class frmClientes : Form
    {
        CN_Cliente obj_cliente = new CN_Cliente();
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = obj_cliente.GetListaClientes();
        }
    }
}
