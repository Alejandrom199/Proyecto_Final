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
    public partial class frmMantenimiento : Form
    {
        CN_Mantenimiento obj_mantenimiento = new CN_Mantenimiento();
        public frmMantenimiento()
        {
            InitializeComponent();
            btnCancelar.Enabled = true;
            MaximizeBox = false;
            tbxId.ReadOnly = true;
        }

        private void frmMantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                dgvMantenimiento.AllowUserToAddRows = false;
                CargarGridMecanicos();

                DisableCampos(true);

                btnNuevo.Enabled = true;
                btnAgregar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisableCampos(bool valor)
        {
            if (valor)
            {
                tbxId.Enabled = false;
                tbxNombre.Enabled = false;
                tbxApellido.Enabled = false;
                tbxCedula.Enabled = false;
                tbxEspecialidad.Enabled = false;
                tbxExperiencia.Enabled = false;
            }
            else
            {
                tbxId.Enabled = true;
                tbxNombre.Enabled = true;
                tbxApellido.Enabled = true;
                tbxCedula.Enabled = true;
                tbxEspecialidad.Enabled = true;
                tbxExperiencia.Enabled = true;
            }
        }

        private bool isNuevo;

        private void SetearCampos()
        {
            tbxId.Text = string.Empty;
            tbxNombre.Text = string.Empty;
            tbxApellido.Text = string.Empty;
            tbxCedula.Text = string.Empty;
            tbxEspecialidad.Text = string.Empty;
            tbxExperiencia.Text = string.Empty;
        }

        private void CargarGridMecanicos()
        {
            try
            {
                dgvMantenimiento.DataSource = obj_mantenimiento.GetListaMecanicos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
