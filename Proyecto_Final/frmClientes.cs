using CapaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
            btnCancelar.Enabled = true;
            MaximizeBox = false;
            tbxId.ReadOnly = true;
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

            try
            {
                dgvClientes.AllowUserToAddRows = false;
                CargarGridCandidatas();

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
                tbxDireccion.Enabled = false;
                tbxTelefono.Enabled = false;
            }
            else
            {
                tbxId.Enabled = true;
                tbxNombre.Enabled = true;
                tbxApellido.Enabled = true;
                tbxCedula.Enabled = true;
                tbxDireccion.Enabled = true;
                tbxTelefono.Enabled = true;
            }
        }

        private bool isNuevo;

        private void SetearCampos()
        {
            tbxId.Text = string.Empty;
            tbxNombre.Text = string.Empty;
            tbxApellido.Text = string.Empty;
            tbxCedula.Text = string.Empty;
            tbxDireccion.Text = string.Empty;
            tbxTelefono.Text = string.Empty;
        }
        private void CargarGridCandidatas()
        {
            try
            {
                dgvClientes.DataSource = obj_cliente.GetListaClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (isNuevo)
            {
                try
                {
                    obj_cliente.Nombre = tbxNombre.Text;
                    obj_cliente.Apellido = tbxApellido.Text;
                    obj_cliente.Cedula = tbxCedula.Text;
                    obj_cliente.Direccion = tbxDireccion.Text;
                    obj_cliente.Telefono = tbxTelefono.Text;

                    var resultado = obj_cliente.CrearCliente(obj_cliente);

                    if (resultado)
                    {
                        MessageBox.Show("Registro Creado con Éxito.");
                        CargarGridCandidatas();
                        DisableCampos(true);

                        btnNuevo.Enabled = true;
                        btnAgregar.Enabled = false;
                        btnModificar.Enabled = false;
                        btnEliminar.Enabled = false;
                    }
                    else { }

                    isNuevo = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Rellene todos los datos");
                }

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            isNuevo = true;
            SetearCampos();

            btnNuevo.Enabled = false;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            DisableCampos(false);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!isNuevo)
            {
                obj_cliente.Id = Convert.ToInt32(tbxId.Text);
                obj_cliente.Nombre = tbxNombre.Text;
                obj_cliente.Apellido = tbxApellido.Text;
                obj_cliente.Cedula = tbxCedula.Text;
                obj_cliente.Direccion = tbxDireccion.Text;
                obj_cliente.Telefono = tbxTelefono.Text;

                if (obj_cliente.ModificarCliente(obj_cliente))
                {
                    MessageBox.Show("Registro actualizado!");
                    CargarGridCandidatas();
                    DisableCampos(true);

                    btnNuevo.Enabled = true;
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Registro no pudo ser actualizado!");
                }
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisableCampos(false);
            isNuevo = false;

            if (e.RowIndex != -1)
            {
                tbxId.Text = dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbxNombre.Text = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbxApellido.Text = dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbxCedula.Text = dgvClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbxTelefono.Text = dgvClientes.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbxDireccion.Text = dgvClientes.Rows[e.RowIndex].Cells[5].Value.ToString();

                btnNuevo.Enabled = false;
                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else { }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            obj_cliente.Id = Convert.ToInt32(tbxId.Text);

            if (obj_cliente.EliminarCliente(obj_cliente))
            {
                MessageBox.Show("Registro eliminado!");
                CargarGridCandidatas();

                btnNuevo.Enabled = true;
                btnAgregar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;

                DisableCampos(true);
            }
            else
            {
                MessageBox.Show("Registro no pudo ser eliminado!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
