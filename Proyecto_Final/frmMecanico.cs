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
    public partial class frmMecanico : Form
    {
        CN_Mecanico obj_mecanico = new CN_Mecanico();
        public frmMecanico()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            btnCancelar.Enabled = true;
            MaximizeBox = false;
            tbxId.ReadOnly = true;
            //Rellenar todo el datagridview ampliando las columnas
            dgvMecanicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void frmMecanico_Load(object sender, EventArgs e)
        {
            try
            {
                dgvMecanicos.AllowUserToAddRows = false;
                CargarGridMecanicos();

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
                dgvMecanicos.DataSource = obj_mecanico.GetListaMecanicos();
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
                    obj_mecanico.Nombre = tbxNombre.Text;
                    obj_mecanico.Apellido = tbxApellido.Text;
                    obj_mecanico.Cedula = tbxCedula.Text;
                    obj_mecanico.Especialidad = tbxEspecialidad.Text;
                    obj_mecanico.Experiencia = tbxExperiencia.Text;

                    var resultado = obj_mecanico.CrearMecanico(obj_mecanico);

                    if (resultado)
                    {
                        MessageBox.Show("Registro Creado con Éxito.");
                        CargarGridMecanicos();
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
                    MessageBox.Show("Rellene todos los datos");
                }

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!isNuevo)
            {
                obj_mecanico.Id = Convert.ToInt32(tbxId.Text);
                obj_mecanico.Nombre = tbxNombre.Text;
                obj_mecanico.Apellido = tbxApellido.Text;
                obj_mecanico.Cedula = tbxCedula.Text;
                obj_mecanico.Especialidad = tbxEspecialidad.Text;
                obj_mecanico.Experiencia = tbxExperiencia.Text;

                if (obj_mecanico.ModificarMecanico(obj_mecanico))
                {
                    MessageBox.Show("Registro actualizado!");
                    CargarGridMecanicos();
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
            obj_mecanico.Id = Convert.ToInt32(tbxId.Text);

            if (obj_mecanico.EliminarMecanico(obj_mecanico))
            {
                MessageBox.Show("Registro eliminado!");
                CargarGridMecanicos();

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

        private void dgvMecanicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisableCampos(false);
            isNuevo = false;

            if (e.RowIndex != -1)
            {
                tbxId.Text = dgvMecanicos.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbxNombre.Text = dgvMecanicos.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbxApellido.Text = dgvMecanicos.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbxCedula.Text = dgvMecanicos.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbxEspecialidad.Text = dgvMecanicos.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbxExperiencia.Text = dgvMecanicos.Rows[e.RowIndex].Cells[5].Value.ToString();

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
    }
}
