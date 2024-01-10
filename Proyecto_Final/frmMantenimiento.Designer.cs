namespace CapaVisual
{
    partial class frmMantenimiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            btnNuevo = new Button();
            groupBox1 = new GroupBox();
            dtpFecha = new DateTimePicker();
            cbxCliente = new ComboBox();
            cbxMecanico = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            tbxDiagnostico = new TextBox();
            tbxTrabajosRealizados = new TextBox();
            tbxTipoMantenimiento = new TextBox();
            tbxVehiculo = new TextBox();
            tbxId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvMantenimiento = new DataGridView();
            tbxTotalPagar = new TextBox();
            label9 = new Label();
            groupBox3 = new GroupBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantenimiento).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkSeaGreen;
            groupBox2.Controls.Add(btnCancelar);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(btnNuevo);
            groupBox2.Location = new Point(763, 11);
            groupBox2.Margin = new Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 2, 2, 2);
            groupBox2.Size = new Size(151, 225);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(27, 183);
            btnCancelar.Margin = new Padding(2, 2, 2, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 27);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(27, 142);
            btnEliminar.Margin = new Padding(2, 2, 2, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 27);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(27, 101);
            btnModificar.Margin = new Padding(2, 2, 2, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(97, 27);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(27, 59);
            btnAgregar.Margin = new Padding(2, 2, 2, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(97, 27);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.Location = new Point(27, 15);
            btnNuevo.Margin = new Padding(2, 2, 2, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(97, 27);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSeaGreen;
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(cbxCliente);
            groupBox1.Controls.Add(cbxMecanico);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tbxDiagnostico);
            groupBox1.Controls.Add(tbxTrabajosRealizados);
            groupBox1.Controls.Add(tbxTipoMantenimiento);
            groupBox1.Controls.Add(tbxVehiculo);
            groupBox1.Controls.Add(tbxId);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(749, 286);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mantenimiento";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(73, 79);
            dtpFecha.Margin = new Padding(2, 2, 2, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(297, 23);
            dtpFecha.TabIndex = 20;
            // 
            // cbxCliente
            // 
            cbxCliente.FormattingEnabled = true;
            cbxCliente.Location = new Point(549, 29);
            cbxCliente.Margin = new Padding(2, 2, 2, 2);
            cbxCliente.Name = "cbxCliente";
            cbxCliente.Size = new Size(185, 24);
            cbxCliente.TabIndex = 19;
            // 
            // cbxMecanico
            // 
            cbxMecanico.FormattingEnabled = true;
            cbxMecanico.Location = new Point(255, 29);
            cbxMecanico.Margin = new Padding(2, 2, 2, 2);
            cbxMecanico.Name = "cbxMecanico";
            cbxMecanico.Size = new Size(177, 24);
            cbxMecanico.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(454, 37);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(68, 16);
            label8.TabIndex = 13;
            label8.Text = "Cliente:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(163, 37);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(86, 16);
            label7.TabIndex = 12;
            label7.Text = "Mecanico:";
            // 
            // tbxDiagnostico
            // 
            tbxDiagnostico.Location = new Point(526, 176);
            tbxDiagnostico.Margin = new Padding(2, 2, 2, 2);
            tbxDiagnostico.Multiline = true;
            tbxDiagnostico.Name = "tbxDiagnostico";
            tbxDiagnostico.Size = new Size(208, 93);
            tbxDiagnostico.TabIndex = 11;
            // 
            // tbxTrabajosRealizados
            // 
            tbxTrabajosRealizados.Location = new Point(14, 176);
            tbxTrabajosRealizados.Margin = new Padding(2, 2, 2, 2);
            tbxTrabajosRealizados.Multiline = true;
            tbxTrabajosRealizados.Name = "tbxTrabajosRealizados";
            tbxTrabajosRealizados.Size = new Size(235, 93);
            tbxTrabajosRealizados.TabIndex = 10;
            // 
            // tbxTipoMantenimiento
            // 
            tbxTipoMantenimiento.Location = new Point(280, 176);
            tbxTipoMantenimiento.Margin = new Padding(2, 2, 2, 2);
            tbxTipoMantenimiento.Multiline = true;
            tbxTipoMantenimiento.Name = "tbxTipoMantenimiento";
            tbxTipoMantenimiento.Size = new Size(216, 93);
            tbxTipoMantenimiento.TabIndex = 9;
            // 
            // tbxVehiculo
            // 
            tbxVehiculo.Location = new Point(526, 81);
            tbxVehiculo.Margin = new Padding(2, 2, 2, 2);
            tbxVehiculo.Name = "tbxVehiculo";
            tbxVehiculo.Size = new Size(208, 23);
            tbxVehiculo.TabIndex = 8;
            // 
            // tbxId
            // 
            tbxId.Location = new Point(59, 30);
            tbxId.Margin = new Padding(2, 2, 2, 2);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(82, 23);
            tbxId.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 144);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(175, 16);
            label6.TabIndex = 5;
            label6.Text = "Trabajos realizados:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(292, 144);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(194, 16);
            label5.TabIndex = 4;
            label5.Text = "Tipo de mantenimiento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(581, 144);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 16);
            label4.TabIndex = 3;
            label4.Text = "Diagnostico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 84);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 16);
            label3.TabIndex = 2;
            label3.Text = "Vehiculo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 83);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 16);
            label2.TabIndex = 1;
            label2.Text = "Fecha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 37);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(26, 16);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // dgvMantenimiento
            // 
            dgvMantenimiento.AllowUserToAddRows = false;
            dgvMantenimiento.AllowUserToDeleteRows = false;
            dgvMantenimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMantenimiento.Location = new Point(11, 310);
            dgvMantenimiento.Margin = new Padding(2, 2, 2, 2);
            dgvMantenimiento.Name = "dgvMantenimiento";
            dgvMantenimiento.ReadOnly = true;
            dgvMantenimiento.RowHeadersWidth = 62;
            dgvMantenimiento.RowTemplate.Height = 33;
            dgvMantenimiento.Size = new Size(903, 223);
            dgvMantenimiento.TabIndex = 11;
            // 
            // tbxTotalPagar
            // 
            tbxTotalPagar.Location = new Point(16, 37);
            tbxTotalPagar.Margin = new Padding(2, 2, 2, 2);
            tbxTotalPagar.Name = "tbxTotalPagar";
            tbxTotalPagar.Size = new Size(121, 23);
            tbxTotalPagar.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 13);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(123, 16);
            label9.TabIndex = 17;
            label9.Text = "Total a pagar:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.DarkSeaGreen;
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(tbxTotalPagar);
            groupBox3.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(763, 225);
            groupBox3.Margin = new Padding(2, 2, 2, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 2, 2, 2);
            groupBox3.Size = new Size(151, 70);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            // 
            // frmMantenimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(925, 544);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvMantenimiento);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmMantenimiento";
            Text = "frmMantenimiento";
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantenimiento).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Button btnNuevo;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private TextBox tbxDiagnostico;
        private TextBox tbxTrabajosRealizados;
        private TextBox tbxTipoMantenimiento;
        private TextBox tbxVehiculo;
        private TextBox tbxId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvMantenimiento;
        private DateTimePicker dtpFecha;
        private ComboBox cbxCliente;
        private ComboBox cbxMecanico;
        private Label label9;
        private TextBox tbxTotalPagar;
        private GroupBox groupBox3;
    }
}