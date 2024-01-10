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
            groupBox2.Controls.Add(btnCancelar);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(btnNuevo);
            groupBox2.Location = new Point(833, 11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(188, 215);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(42, 176);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(42, 136);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(42, 96);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 34);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(42, 56);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(42, 16);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(112, 34);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(12, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(807, 298);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mantenimiento";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(93, 101);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(354, 31);
            dtpFecha.TabIndex = 20;
            // 
            // cbxCliente
            // 
            cbxCliente.FormattingEnabled = true;
            cbxCliente.Location = new Point(588, 46);
            cbxCliente.Name = "cbxCliente";
            cbxCliente.Size = new Size(205, 33);
            cbxCliente.TabIndex = 19;
            // 
            // cbxMecanico
            // 
            cbxMecanico.FormattingEnabled = true;
            cbxMecanico.Location = new Point(301, 48);
            cbxMecanico.Name = "cbxMecanico";
            cbxMecanico.Size = new Size(205, 33);
            cbxMecanico.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(516, 51);
            label8.Name = "label8";
            label8.Size = new Size(69, 25);
            label8.TabIndex = 13;
            label8.Text = "Cliente:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(204, 51);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 12;
            label7.Text = "Mecanico:";
            // 
            // tbxDiagnostico
            // 
            tbxDiagnostico.Location = new Point(554, 201);
            tbxDiagnostico.Multiline = true;
            tbxDiagnostico.Name = "tbxDiagnostico";
            tbxDiagnostico.Size = new Size(236, 83);
            tbxDiagnostico.TabIndex = 11;
            // 
            // tbxTrabajosRealizados
            // 
            tbxTrabajosRealizados.Location = new Point(18, 201);
            tbxTrabajosRealizados.Multiline = true;
            tbxTrabajosRealizados.Name = "tbxTrabajosRealizados";
            tbxTrabajosRealizados.Size = new Size(236, 83);
            tbxTrabajosRealizados.TabIndex = 10;
            // 
            // tbxTipoMantenimiento
            // 
            tbxTipoMantenimiento.Location = new Point(283, 201);
            tbxTipoMantenimiento.Multiline = true;
            tbxTipoMantenimiento.Name = "tbxTipoMantenimiento";
            tbxTipoMantenimiento.Size = new Size(236, 83);
            tbxTipoMantenimiento.TabIndex = 9;
            // 
            // tbxVehiculo
            // 
            tbxVehiculo.Location = new Point(553, 101);
            tbxVehiculo.Name = "tbxVehiculo";
            tbxVehiculo.Size = new Size(240, 31);
            tbxVehiculo.TabIndex = 8;
            // 
            // tbxId
            // 
            tbxId.Location = new Point(93, 48);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(102, 31);
            tbxId.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 165);
            label6.Name = "label6";
            label6.Size = new Size(165, 25);
            label6.TabIndex = 5;
            label6.Text = "Trabajos realizados:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(283, 169);
            label5.Name = "label5";
            label5.Size = new Size(201, 25);
            label5.TabIndex = 4;
            label5.Text = "Tipo de mantenimiento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(554, 169);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 3;
            label4.Text = "Diagnostico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(465, 104);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 2;
            label3.Text = "Vehiculo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 104);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 1;
            label2.Text = "Fecha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 51);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // dgvMantenimiento
            // 
            dgvMantenimiento.AllowUserToAddRows = false;
            dgvMantenimiento.AllowUserToDeleteRows = false;
            dgvMantenimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMantenimiento.Location = new Point(12, 320);
            dgvMantenimiento.Name = "dgvMantenimiento";
            dgvMantenimiento.ReadOnly = true;
            dgvMantenimiento.RowHeadersWidth = 62;
            dgvMantenimiento.RowTemplate.Height = 33;
            dgvMantenimiento.Size = new Size(1010, 235);
            dgvMantenimiento.TabIndex = 11;
            // 
            // tbxTotalPagar
            // 
            tbxTotalPagar.Location = new Point(20, 46);
            tbxTotalPagar.Name = "tbxTotalPagar";
            tbxTotalPagar.Size = new Size(150, 31);
            tbxTotalPagar.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 16);
            label9.Name = "label9";
            label9.Size = new Size(118, 25);
            label9.TabIndex = 17;
            label9.Text = "Total a pagar:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(tbxTotalPagar);
            groupBox3.Location = new Point(832, 222);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(189, 87);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            // 
            // frmMantenimiento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 565);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvMantenimiento);
            Name = "frmMantenimiento";
            Text = "frmMantenimiento";
            Load += frmMantenimiento_Load;
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