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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaVisual
{
    public partial class frmMantenimiento : Form
    {

        CN_Mantenimiento obj_mantenimiento = new CN_Mantenimiento();
        CN_Cliente obj_cliente = new CN_Cliente();
        CN_Mecanico obj_mecanico = new CN_Mecanico();
        public frmMantenimiento()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cbxServicios.SelectedIndexChanged += cbxCliente_SelectedIndexChanged;
            btnCancelar.Enabled = true;
            MaximizeBox = false;

            tbxId.ReadOnly = true;
            tbxTotalPagar.ReadOnly = true;
            tbxTipo.ReadOnly = true;

            gbxRepuestos.Visible = false;

        }

        private void frmMantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                dgvMantenimiento.AllowUserToAddRows = false;
                CargarGridMantenimientos();

                DisableCampos(true);

                btnNuevo.Enabled = true;
                btnNuevo.BackColor = Color.Transparent;

                btnAgregar.Enabled = false;
                btnAgregar.BackColor = Color.PaleVioletRed;

                btnModificar.Enabled = false;
                btnModificar.BackColor = Color.PaleVioletRed;

                btnEliminar.Enabled = false;
                btnEliminar.BackColor = Color.PaleVioletRed;

                btnCancelar.Enabled = true;
                btnCancelar.BackColor = Color.Transparent;
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
                cbxMecanico.Enabled = false;
                cbxCliente.Enabled = false;
                tbxTipo.Enabled = false;
                dtpFecha.Enabled = false;
                tbxDiagnostico.Enabled = false;
                rtbxTrabajosRealizados.Enabled = false;
                cbxServicios.Enabled = false;
                tbxRepuestos.Enabled = false;
                tbxValorRepuestos.Enabled = false;
                tbxMarca.Enabled = false;
                tbxColor.Enabled = false;
                tbxModelo.Enabled = false;
                tbxPlaca.Enabled = false;
                tbxTotalPagar.Enabled = false;
            }
            else
            {
                tbxId.Enabled = true;
                cbxMecanico.Enabled = true;
                cbxCliente.Enabled = true;
                tbxTipo.Enabled = true;
                dtpFecha.Enabled = true;
                tbxDiagnostico.Enabled = true;
                rtbxTrabajosRealizados.Enabled = true;
                cbxServicios.Enabled = true;
                tbxRepuestos.Enabled = true;
                tbxValorRepuestos.Enabled = true;
                tbxMarca.Enabled = true;
                tbxColor.Enabled = true;
                tbxModelo.Enabled = true;
                tbxPlaca.Enabled = true;
                tbxTotalPagar.Enabled = true;
            }
        }

        private bool isNuevo;

        private void SetearCampos()
        {
            tbxId.Text = string.Empty;
            cbxMecanico.Text = string.Empty;
            cbxCliente.Text = string.Empty;
            tbxTipo.Text = string.Empty;
            dtpFecha.Text = string.Empty;
            tbxDiagnostico.Text = string.Empty;
            rtbxTrabajosRealizados.Text = string.Empty;
            tbxRepuestos.Text = string.Empty;
            tbxValorRepuestos.Text = string.Empty;
            tbxMarca.Text = string.Empty;
            tbxColor.Text = string.Empty;
            tbxModelo.Text = string.Empty;
            tbxPlaca.Text = string.Empty;
        }

        private void CargarGridMantenimientos()
        {
            try
            {
                dgvMantenimiento.DataSource = obj_mantenimiento.GetListaMantenimientos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            isNuevo = true;
            SetearCampos();
            LlenarComboBoxClientes();
            LlenarComboBoxMecanicos();

            btnNuevo.Enabled = false;
            btnNuevo.BackColor = Color.PaleVioletRed;

            btnAgregar.Enabled = true;
            btnAgregar.BackColor = Color.Transparent;

            btnModificar.Enabled = false;
            btnModificar.BackColor = Color.PaleVioletRed;

            btnEliminar.Enabled = false;
            btnEliminar.BackColor = Color.PaleVioletRed;

            DisableCampos(false);

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (isNuevo)
            {
                try
                {
                    obj_mantenimiento.Cliente = NombreAEnteroCliente(cbxCliente.Text);
                    obj_mantenimiento.Mecanico = NombreAEnteroMecanico(cbxMecanico.Text);
                    obj_mantenimiento.Fecha = dtpFecha.Value.ToUniversalTime();
                    obj_mantenimiento.Vehiculo_Marca = tbxMarca.Text;
                    obj_mantenimiento.Vehiculo_Color = tbxColor.Text;
                    obj_mantenimiento.Vehiculo_Modelo = tbxModelo.Text;
                    obj_mantenimiento.Vehiculo_Placa = tbxPlaca.Text;
                    obj_mantenimiento.Diagnostico = tbxDiagnostico.Text;
                    obj_mantenimiento.TrabajosRealizados = rtbxTrabajosRealizados.Text;
                    obj_mantenimiento.TipoMantenimiento = tbxTipo.Text;
                    obj_mantenimiento.Servicio = cbxServicios.Text;
                    obj_mantenimiento.Repuestos = tbxRepuestos.Text;
                    obj_mantenimiento.Valor_Repuestos = Convert.ToInt32(tbxValorRepuestos.Text);
                    obj_mantenimiento.TotalPagar = valorTotal();



                    var resultado = obj_mantenimiento.CrearMantenimiento(obj_mantenimiento);

                    if (resultado)
                    {
                        MessageBox.Show("Registro Creado con Éxito.");
                        CargarGridMantenimientos();
                        DisableCampos(true);

                        btnNuevo.Enabled = true;
                        btnNuevo.BackColor = Color.Transparent;

                        btnAgregar.Enabled = false;
                        btnAgregar.BackColor = Color.PaleVioletRed;

                        btnModificar.Enabled = false;
                        btnModificar.BackColor = Color.PaleVioletRed;

                        btnEliminar.Enabled = false;
                        btnEliminar.BackColor = Color.PaleVioletRed;
                    }
                    else { }

                    isNuevo = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Rellene todos los datos - " + ex.Message);
                }
            }
        }

        private void LlenarComboBoxClientes()
        {
            DataTable tabla = obj_cliente.GetClientesByID();
            cbxCliente.DisplayMember = "nombre";
            cbxCliente.ValueMember = "id";
            cbxCliente.DataSource = tabla;
        }

        private int NombreAEnteroCliente(string nombre)
        {
            return obj_cliente.GetCLienteIDByName(nombre);
        }

        private int NombreAEnteroMecanico(string nombre)
        {
            return obj_mecanico.GetMecanicoIDByName(nombre);
        }

        private void LlenarComboBoxMecanicos()
        {
            DataTable tabla = obj_mecanico.GetMecanicosByID();
            cbxMecanico.DisplayMember = "nombre";
            cbxMecanico.ValueMember = "id";
            cbxMecanico.DataSource = tabla;
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!isNuevo)
            {


                if (obj_mantenimiento.ModificaMantenimiento(obj_mantenimiento))
                {
                    MessageBox.Show("Registro actualizado!");
                    CargarGridMantenimientos();
                    DisableCampos(true);

                    btnNuevo.Enabled = true;
                    btnNuevo.BackColor = Color.Transparent;

                    btnAgregar.Enabled = false;
                    btnAgregar.BackColor = Color.PaleVioletRed;

                    btnModificar.Enabled = false;
                    btnModificar.BackColor = Color.PaleVioletRed;

                    btnEliminar.Enabled = false;
                    btnEliminar.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    MessageBox.Show("Registro no pudo ser actualizado!");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            obj_mantenimiento.Id = Convert.ToInt32(tbxId.Text);

            if (obj_mantenimiento.EliminarMantenimiento(obj_mantenimiento))
            {
                MessageBox.Show("Registro eliminado!");
                CargarGridMantenimientos();

                btnNuevo.Enabled = true;
                btnNuevo.BackColor = Color.Transparent;

                btnAgregar.Enabled = false;
                btnAgregar.BackColor = Color.PaleVioletRed;

                btnModificar.Enabled = false;
                btnModificar.BackColor = Color.PaleVioletRed;

                btnEliminar.Enabled = false;
                btnEliminar.BackColor = Color.PaleVioletRed;


                DisableCampos(true);
            }
            else
            {
                MessageBox.Show("Registro no pudo ser eliminado!");
            }
        }
        private void dgvMantenimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisableCampos(false);
            isNuevo = false;

            if (e.RowIndex != -1)
            {
                cbxCliente.Text = dgvMantenimiento.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbxMecanico.Text = dgvMantenimiento.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (dtpFecha.Value != null) { dtpFecha.Value = Convert.ToDateTime(dgvMantenimiento.Rows[e.RowIndex].Cells[2].Value); }
                tbxPlaca.Text = dgvMantenimiento.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbxMarca.Text = dgvMantenimiento.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbxModelo.Text = dgvMantenimiento.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbxColor.Text = dgvMantenimiento.Rows[e.RowIndex].Cells[6].Value.ToString();
                tbxDiagnostico.Text = dgvMantenimiento.Rows[e.RowIndex].Cells[7].Value.ToString();
                rtbxTrabajosRealizados.Text = dgvMantenimiento.Rows[e.RowIndex].Cells[8].Value.ToString();
                tbxTipo.Text = dgvMantenimiento.Rows[e.RowIndex].Cells[9].Value.ToString();
                tbxRepuestos.Text = dgvMantenimiento.Rows[e.RowIndex].Cells[10].Value.ToString();
                tbxValorRepuestos.Text = dgvMantenimiento.Rows[e.RowIndex].Cells[11].Value.ToString();
                tbxTotalPagar.Text = dgvMantenimiento.Rows[e.RowIndex].Cells[12].Value.ToString();

                btnNuevo.Enabled = false;
                btnNuevo.BackColor = Color.PaleVioletRed;

                btnAgregar.Enabled = false;
                btnAgregar.BackColor = Color.PaleVioletRed;

                btnModificar.Enabled = true;
                btnModificar.BackColor = Color.Transparent;

                btnEliminar.Enabled = true;
                btnEliminar.BackColor = Color.Transparent;
            }
            else { }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            float costo = (valorSubTotal()*0.12f) + valorSubTotal();
            tbxTotalPagar.Text = costo.ToString();
        }

        private float valorSubTotal()
        {

            switch (cbxServicios.SelectedIndex)
            {
                case 0:
                    tbxTipo.Text = "PREVENTIVO";
                    mostrarMenuRepuestos(tbxTipo.Text);
                    return 5;

                case 1:
                    tbxTipo.Text = "CORRECTIVO";
                    mostrarMenuRepuestos(tbxTipo.Text);
                    return 45;
                case 2:
                    tbxTipo.Text = "PREVENTIVO";
                    mostrarMenuRepuestos(tbxTipo.Text);
                    return 50;
                case 3:
                    tbxTipo.Text = "CORRECTIVO";
                    mostrarMenuRepuestos(tbxTipo.Text);
                    return 40;
                case 4:
                    tbxTipo.Text = "CORRECTIVO";
                    mostrarMenuRepuestos(tbxTipo.Text);
                    return 30;
                default:
                    tbxTipo.Text = "";
                    return 0;
            }
        }

        private void mostrarMenuRepuestos(string tipo)
        {
            if (tipo == "PREVENTIVO"){ gbxRepuestos.Visible = false; }

            else if (tipo == "CORRECTIVO"){ gbxRepuestos.Visible = true; }
        }

        private float valorRepuestos()
        {
            float valorRep = Convert.ToSingle(tbxValorRepuestos.Text);
            return valorRep;
        }
        private float valorTotal()
        {
            float preResultado = valorSubTotal() + valorRepuestos();
            float iva = preResultado * 0.12f;
            return preResultado + iva;
        }

        private void tbxValorRepuestos_TextChanged(object sender, EventArgs e)
        {
            if(tbxValorRepuestos.Text.Length >= 0)
            {
                tbxTotalPagar.Text = valorTotal().ToString();  
            }
        }
    }
}
