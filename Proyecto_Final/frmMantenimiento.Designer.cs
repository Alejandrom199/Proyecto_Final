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
            groupBox2.Location = new Point(952, 388);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(260, 284);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackgroundImage = (Image)resources.GetObject("btnCancelar.BackgroundImage");
            btnCancelar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancelar.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(100, 208);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(60, 60);
            btnCancelar.TabIndex = 16;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(164, 118);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(60, 60);
            btnEliminar.TabIndex = 15;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackgroundImage = (Image)resources.GetObject("btnModificar.BackgroundImage");
            btnModificar.BackgroundImageLayout = ImageLayout.Stretch;
            btnModificar.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(43, 118);
            btnModificar.Margin = new Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(60, 60);
            btnModificar.TabIndex = 14;
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackgroundImage = (Image)resources.GetObject("btnAgregar.BackgroundImage");
            btnAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAgregar.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(164, 38);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(60, 60);
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
            btnNuevo.Location = new Point(43, 38);
            btnNuevo.Margin = new Padding(2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.RightToLeft = RightToLeft.No;
            btnNuevo.Size = new Size(60, 60);
            btnNuevo.TabIndex = 12;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSeaGreen;
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
            groupBox1.Location = new Point(12, 11);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(936, 373);
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
            gbxRepuestos.Location = new Point(485, 152);
            gbxRepuestos.Name = "gbxRepuestos";
            gbxRepuestos.Size = new Size(432, 206);
            gbxRepuestos.TabIndex = 23;
            gbxRepuestos.TabStop = false;
            gbxRepuestos.Text = "Respuestos";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Perpetua Titling MT", 12.14F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(94, 168);
            label16.Name = "label16";
            label16.Size = new Size(27, 30);
            label16.TabIndex = 19;
            label16.Text = "$";
            // 
            // tbxValorRepuestos
            // 
            tbxValorRepuestos.Location = new Point(125, 170);
            tbxValorRepuestos.Name = "tbxValorRepuestos";
            tbxValorRepuestos.Size = new Size(150, 26);
            tbxValorRepuestos.TabIndex = 3;
            // 
            // tbxRepuestos
            // 
            tbxRepuestos.Location = new Point(19, 51);
            tbxRepuestos.Multiline = true;
            tbxRepuestos.Name = "tbxRepuestos";
            tbxRepuestos.Size = new Size(393, 113);
            tbxRepuestos.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(19, 174);
            label14.Name = "label14";
            label14.Size = new Size(74, 20);
            label14.TabIndex = 1;
            label14.Text = "Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 27);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 0;
            label3.Text = "repuesto:";
            // 
            // rtbxTrabajosRealizados
            // 
            rtbxTrabajosRealizados.Location = new Point(250, 239);
            rtbxTrabajosRealizados.Name = "rtbxTrabajosRealizados";
            rtbxTrabajosRealizados.Size = new Size(219, 114);
            rtbxTrabajosRealizados.TabIndex = 22;
            rtbxTrabajosRealizados.Text = "";
            // 
            // cbxTipo
            // 
            cbxTipo.FormattingEnabled = true;
            cbxTipo.Items.AddRange(new object[] { "PREVENTIVO", "CORRECTIVO" });
            cbxTipo.Location = new Point(91, 149);
            cbxTipo.Name = "cbxTipo";
            cbxTipo.Size = new Size(182, 28);
            cbxTipo.TabIndex = 21;
            cbxTipo.SelectedIndexChanged += cbxTipo_SelectedIndexChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(91, 99);
            dtpFecha.Margin = new Padding(2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(370, 26);
            dtpFecha.TabIndex = 20;
            // 
            // cbxCliente
            // 
            cbxCliente.FormattingEnabled = true;
            cbxCliente.Location = new Point(658, 94);
            cbxCliente.Margin = new Padding(2);
            cbxCliente.Name = "cbxCliente";
            cbxCliente.Size = new Size(259, 28);
            cbxCliente.TabIndex = 19;
            // 
            // cbxMecanico
            // 
            cbxMecanico.FormattingEnabled = true;
            cbxMecanico.Location = new Point(658, 36);
            cbxMecanico.Margin = new Padding(2);
            cbxMecanico.Name = "cbxMecanico";
            cbxMecanico.Size = new Size(259, 28);
            cbxMecanico.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(558, 104);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 13;
            label8.Text = "Cliente:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(534, 44);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 12;
            label7.Text = "Mecanico:";
            // 
            // tbxDiagnostico
            // 
            tbxDiagnostico.Location = new Point(18, 239);
            tbxDiagnostico.Margin = new Padding(2);
            tbxDiagnostico.Multiline = true;
            tbxDiagnostico.Name = "tbxDiagnostico";
            tbxDiagnostico.Size = new Size(219, 115);
            tbxDiagnostico.TabIndex = 11;
            // 
            // tbxId
            // 
            tbxId.Location = new Point(91, 44);
            tbxId.Margin = new Padding(2);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(102, 26);
            tbxId.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(250, 206);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(219, 20);
            label6.TabIndex = 5;
            label6.Text = "Trabajos realizados:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 152);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 4;
            label5.Text = "Tipo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 206);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 3;
            label4.Text = "Diagnostico:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 104);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Fecha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 52);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // dgvMantenimiento
            // 
            dgvMantenimiento.AllowUserToAddRows = false;
            dgvMantenimiento.AllowUserToDeleteRows = false;
            dgvMantenimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMantenimiento.Location = new Point(14, 388);
            dgvMantenimiento.Margin = new Padding(2);
            dgvMantenimiento.Name = "dgvMantenimiento";
            dgvMantenimiento.ReadOnly = true;
            dgvMantenimiento.RowHeadersWidth = 62;
            dgvMantenimiento.RowTemplate.Height = 33;
            dgvMantenimiento.Size = new Size(935, 284);
            dgvMantenimiento.TabIndex = 11;
            dgvMantenimiento.CellClick += dgvMantenimiento_CellClick;
            // 
            // tbxTotalPagar
            // 
            tbxTotalPagar.Location = new Point(83, 48);
            tbxTotalPagar.Margin = new Padding(2);
            tbxTotalPagar.Name = "tbxTotalPagar";
            tbxTotalPagar.Size = new Size(120, 26);
            tbxTotalPagar.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(58, 20);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(156, 20);
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
            groupBox3.Location = new Point(953, 296);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(260, 88);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Perpetua Titling MT", 12.14F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(55, 46);
            label15.Name = "label15";
            label15.Size = new Size(27, 30);
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
            groupBox4.Location = new Point(952, 11);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(261, 276);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Vehiculo";
            // 
            // tbxPlaca
            // 
            tbxPlaca.Location = new Point(109, 191);
            tbxPlaca.Margin = new Padding(2);
            tbxPlaca.Name = "tbxPlaca";
            tbxPlaca.Size = new Size(137, 26);
            tbxPlaca.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 192);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(71, 20);
            label10.TabIndex = 12;
            label10.Text = "Placa:";
            // 
            // tbxColor
            // 
            tbxColor.Location = new Point(109, 89);
            tbxColor.Margin = new Padding(2);
            tbxColor.Name = "tbxColor";
            tbxColor.Size = new Size(137, 26);
            tbxColor.TabIndex = 11;
            // 
            // tbxModelo
            // 
            tbxModelo.Location = new Point(109, 137);
            tbxModelo.Margin = new Padding(2);
            tbxModelo.Name = "tbxModelo";
            tbxModelo.Size = new Size(137, 26);
            tbxModelo.TabIndex = 9;
            // 
            // tbxMarca
            // 
            tbxMarca.Location = new Point(109, 41);
            tbxMarca.Margin = new Padding(2);
            tbxMarca.Name = "tbxMarca";
            tbxMarca.Size = new Size(137, 26);
            tbxMarca.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 138);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(88, 20);
            label11.TabIndex = 4;
            label11.Text = "Modelo:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 89);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(74, 20);
            label12.TabIndex = 3;
            label12.Text = "Color:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 44);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(80, 20);
            label13.TabIndex = 2;
            label13.Text = "Marca:";
            // 
            // frmMantenimiento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1222, 680);
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
    }
}