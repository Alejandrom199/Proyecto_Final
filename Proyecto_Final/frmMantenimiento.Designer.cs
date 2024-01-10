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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimiento));
            groupBox2 = new GroupBox();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            btnNuevo = new Button();
            groupBox1 = new GroupBox();
            gbxRepuestos = new GroupBox();
            label16 = new Label();
            tbxValorRepuestos = new TextBox();
            tbxRepuestos = new TextBox();
            label14 = new Label();
            label3 = new Label();
            rtbxTrabajosRealizados = new RichTextBox();
            cbxTipo = new ComboBox();
            dtpFecha = new DateTimePicker();
            cbxCliente = new ComboBox();
            cbxMecanico = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            tbxDiagnostico = new TextBox();
            tbxId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvMantenimiento = new DataGridView();
            tbxTotalPagar = new TextBox();
            label9 = new Label();
            groupBox3 = new GroupBox();
            label15 = new Label();
            groupBox4 = new GroupBox();
            tbxPlaca = new TextBox();
            label10 = new Label();
            tbxColor = new TextBox();
            tbxModelo = new TextBox();
            tbxMarca = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label17 = new Label();
            cbxServicios = new ComboBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            gbxRepuestos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantenimiento).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
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
            groupBox2.Location = new Point(762, 310);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(208, 227);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackgroundImage = (Image)resources.GetObject("btnCancelar.BackgroundImage");
            btnCancelar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancelar.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(80, 166);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(48, 48);
            btnCancelar.TabIndex = 16;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(131, 94);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(48, 48);
            btnEliminar.TabIndex = 15;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackgroundImage = (Image)resources.GetObject("btnModificar.BackgroundImage");
            btnModificar.BackgroundImageLayout = ImageLayout.Stretch;
            btnModificar.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(34, 94);
            btnModificar.Margin = new Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(48, 48);
            btnModificar.TabIndex = 14;
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackgroundImage = (Image)resources.GetObject("btnAgregar.BackgroundImage");
            btnAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAgregar.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(131, 30);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(48, 48);
            btnAgregar.TabIndex = 13;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Transparent;
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.Location = new Point(34, 30);
            btnNuevo.Margin = new Padding(2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.RightToLeft = RightToLeft.No;
            btnNuevo.Size = new Size(48, 48);
            btnNuevo.TabIndex = 12;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSeaGreen;
            groupBox1.Controls.Add(cbxServicios);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(gbxRepuestos);
            groupBox1.Controls.Add(rtbxTrabajosRealizados);
            groupBox1.Controls.Add(cbxTipo);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(cbxCliente);
            groupBox1.Controls.Add(cbxMecanico);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tbxDiagnostico);
            groupBox1.Controls.Add(tbxId);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(749, 298);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mantenimiento";
            // 
            // gbxRepuestos
            // 
            gbxRepuestos.Controls.Add(label16);
            gbxRepuestos.Controls.Add(tbxValorRepuestos);
            gbxRepuestos.Controls.Add(tbxRepuestos);
            gbxRepuestos.Controls.Add(label14);
            gbxRepuestos.Controls.Add(label3);
            gbxRepuestos.Location = new Point(388, 122);
            gbxRepuestos.Margin = new Padding(2, 2, 2, 2);
            gbxRepuestos.Name = "gbxRepuestos";
            gbxRepuestos.Padding = new Padding(2, 2, 2, 2);
            gbxRepuestos.Size = new Size(346, 165);
            gbxRepuestos.TabIndex = 23;
            gbxRepuestos.TabStop = false;
            gbxRepuestos.Text = "Respuestos";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Perpetua Titling MT", 12.14F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(75, 134);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(24, 26);
            label16.TabIndex = 19;
            label16.Text = "$";
            // 
            // tbxValorRepuestos
            // 
            tbxValorRepuestos.Location = new Point(100, 136);
            tbxValorRepuestos.Margin = new Padding(2, 2, 2, 2);
            tbxValorRepuestos.Name = "tbxValorRepuestos";
            tbxValorRepuestos.Size = new Size(121, 23);
            tbxValorRepuestos.TabIndex = 3;
            // 
            // tbxRepuestos
            // 
            tbxRepuestos.Location = new Point(15, 41);
            tbxRepuestos.Margin = new Padding(2, 2, 2, 2);
            tbxRepuestos.Multiline = true;
            tbxRepuestos.Name = "tbxRepuestos";
            tbxRepuestos.Size = new Size(315, 91);
            tbxRepuestos.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(15, 139);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(59, 16);
            label14.TabIndex = 1;
            label14.Text = "Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 22);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 16);
            label3.TabIndex = 0;
            label3.Text = "repuesto:";
            // 
            // rtbxTrabajosRealizados
            // 
            rtbxTrabajosRealizados.Location = new Point(200, 191);
            rtbxTrabajosRealizados.Margin = new Padding(2, 2, 2, 2);
            rtbxTrabajosRealizados.Name = "rtbxTrabajosRealizados";
            rtbxTrabajosRealizados.Size = new Size(176, 92);
            rtbxTrabajosRealizados.TabIndex = 22;
            rtbxTrabajosRealizados.Text = "";
            // 
            // cbxTipo
            // 
            cbxTipo.FormattingEnabled = true;
            cbxTipo.Items.AddRange(new object[] { "PREVENTIVO", "CORRECTIVO" });
            cbxTipo.Location = new Point(73, 119);
            cbxTipo.Margin = new Padding(2, 2, 2, 2);
            cbxTipo.Name = "cbxTipo";
            cbxTipo.Size = new Size(146, 24);
            cbxTipo.TabIndex = 21;
            cbxTipo.SelectedIndexChanged += cbxTipo_SelectedIndexChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(73, 79);
            dtpFecha.Margin = new Padding(2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(297, 23);
            dtpFecha.TabIndex = 20;
            // 
            // cbxCliente
            // 
            cbxCliente.FormattingEnabled = true;
            cbxCliente.Location = new Point(526, 75);
            cbxCliente.Margin = new Padding(2);
            cbxCliente.Name = "cbxCliente";
            cbxCliente.Size = new Size(208, 24);
            cbxCliente.TabIndex = 19;
            // 
            // cbxMecanico
            // 
            cbxMecanico.FormattingEnabled = true;
            cbxMecanico.Location = new Point(266, 34);
            cbxMecanico.Margin = new Padding(2);
            cbxMecanico.Name = "cbxMecanico";
            cbxMecanico.Size = new Size(208, 24);
            cbxMecanico.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(446, 83);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(68, 16);
            label8.TabIndex = 13;
            label8.Text = "Cliente:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(176, 42);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(86, 16);
            label7.TabIndex = 12;
            label7.Text = "Mecanico:";
            // 
            // tbxDiagnostico
            // 
            tbxDiagnostico.Location = new Point(14, 191);
            tbxDiagnostico.Margin = new Padding(2);
            tbxDiagnostico.Multiline = true;
            tbxDiagnostico.Name = "tbxDiagnostico";
            tbxDiagnostico.Size = new Size(176, 93);
            tbxDiagnostico.TabIndex = 11;
            // 
            // tbxId
            // 
            tbxId.Location = new Point(73, 35);
            tbxId.Margin = new Padding(2);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(82, 23);
            tbxId.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(200, 165);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(175, 16);
            label6.TabIndex = 5;
            label6.Text = "Trabajos realizados:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 122);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(43, 16);
            label5.TabIndex = 4;
            label5.Text = "Tipo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 165);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 16);
            label4.TabIndex = 3;
            label4.Text = "Diagnostico:";
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
            label1.Location = new Point(28, 42);
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
            dgvMantenimiento.Margin = new Padding(2);
            dgvMantenimiento.Name = "dgvMantenimiento";
            dgvMantenimiento.ReadOnly = true;
            dgvMantenimiento.RowHeadersWidth = 62;
            dgvMantenimiento.RowTemplate.Height = 33;
            dgvMantenimiento.Size = new Size(748, 227);
            dgvMantenimiento.TabIndex = 11;
            dgvMantenimiento.CellClick += dgvMantenimiento_CellClick;
            // 
            // tbxTotalPagar
            // 
            tbxTotalPagar.Location = new Point(66, 38);
            tbxTotalPagar.Margin = new Padding(2);
            tbxTotalPagar.Name = "tbxTotalPagar";
            tbxTotalPagar.Size = new Size(97, 23);
            tbxTotalPagar.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 16);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(123, 16);
            label9.TabIndex = 17;
            label9.Text = "Total a pagar:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.DarkSeaGreen;
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(tbxTotalPagar);
            groupBox3.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(762, 237);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(208, 70);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Perpetua Titling MT", 12.14F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(44, 37);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(24, 26);
            label15.TabIndex = 18;
            label15.Text = "$";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.DarkSeaGreen;
            groupBox4.Controls.Add(tbxPlaca);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(tbxColor);
            groupBox4.Controls.Add(tbxModelo);
            groupBox4.Controls.Add(tbxMarca);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label13);
            groupBox4.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(762, 9);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(209, 221);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Vehiculo";
            // 
            // tbxPlaca
            // 
            tbxPlaca.Location = new Point(87, 153);
            tbxPlaca.Margin = new Padding(2);
            tbxPlaca.Name = "tbxPlaca";
            tbxPlaca.Size = new Size(110, 23);
            tbxPlaca.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 154);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(55, 16);
            label10.TabIndex = 12;
            label10.Text = "Placa:";
            // 
            // tbxColor
            // 
            tbxColor.Location = new Point(87, 71);
            tbxColor.Margin = new Padding(2);
            tbxColor.Name = "tbxColor";
            tbxColor.Size = new Size(110, 23);
            tbxColor.TabIndex = 11;
            // 
            // tbxModelo
            // 
            tbxModelo.Location = new Point(87, 110);
            tbxModelo.Margin = new Padding(2);
            tbxModelo.Name = "tbxModelo";
            tbxModelo.Size = new Size(110, 23);
            tbxModelo.TabIndex = 9;
            // 
            // tbxMarca
            // 
            tbxMarca.Location = new Point(87, 33);
            tbxMarca.Margin = new Padding(2);
            tbxMarca.Name = "tbxMarca";
            tbxMarca.Size = new Size(110, 23);
            tbxMarca.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 110);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(72, 16);
            label11.TabIndex = 4;
            label11.Text = "Modelo:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 71);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(59, 16);
            label12.TabIndex = 3;
            label12.Text = "Color:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 35);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(62, 16);
            label13.TabIndex = 2;
            label13.Text = "Marca:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(488, 42);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(82, 16);
            label17.TabIndex = 24;
            label17.Text = "Servicios:";
            // 
            // cbxServicios
            // 
            cbxServicios.FormattingEnabled = true;
            cbxServicios.Items.AddRange(new object[] { "LAVADO", "ALINEACION", "CAMBIO DE ACEITE Y FILTRO", "SUSTITUCION DE BUJIAS", "ROTACION DE NEUMATICOS" });
            cbxServicios.Location = new Point(578, 34);
            cbxServicios.Margin = new Padding(2);
            cbxServicios.Name = "cbxServicios";
            cbxServicios.Size = new Size(156, 24);
            cbxServicios.TabIndex = 25;
            // 
            // frmMantenimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(978, 544);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvMantenimiento);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "frmMantenimiento";
            Text = "frmMantenimiento";
            Load += frmMantenimiento_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbxRepuestos.ResumeLayout(false);
            gbxRepuestos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantenimiento).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private TextBox tbxDiagnostico;
        private TextBox tbxId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private DataGridView dgvMantenimiento;
        private DateTimePicker dtpFecha;
        private ComboBox cbxCliente;
        private ComboBox cbxMecanico;
        private Label label9;
        private TextBox tbxTotalPagar;
        private GroupBox groupBox3;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Button btnNuevo;
        private GroupBox groupBox4;
        private TextBox tbxPlaca;
        private Label label10;
        private TextBox tbxColor;
        private TextBox tbxModelo;
        private TextBox tbxMarca;
        private Label label11;
        private Label label12;
        private Label label13;
        private ComboBox cbxTipo;
        private GroupBox gbxRepuestos;
        private Label label14;
        private Label label3;
        private RichTextBox rtbxTrabajosRealizados;
        private TextBox tbxRepuestos;
        private TextBox tbxValorRepuestos;
        private Label label15;
        private Label label16;
        private ComboBox cbxServicios;
        private Label label17;
    }
}