﻿namespace CapaVisual
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            dgvClientes = new DataGridView();
            groupBox1 = new GroupBox();
            tbxCedula = new TextBox();
            tbxDireccion = new TextBox();
            tbxTelefono = new TextBox();
            tbxApellido = new TextBox();
            tbxNombre = new TextBox();
            tbxId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnNuevo = new Button();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.BackgroundColor = SystemColors.ButtonShadow;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(10, 215);
            dgvClientes.Margin = new Padding(2);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.RowTemplate.Height = 33;
            dgvClientes.Size = new Size(973, 239);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Plum;
            groupBox1.Controls.Add(tbxCedula);
            groupBox1.Controls.Add(tbxDireccion);
            groupBox1.Controls.Add(tbxTelefono);
            groupBox1.Controls.Add(tbxApellido);
            groupBox1.Controls.Add(tbxNombre);
            groupBox1.Controls.Add(tbxId);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(10, 8);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(613, 193);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // tbxCedula
            // 
            tbxCedula.Location = new Point(484, 85);
            tbxCedula.Margin = new Padding(2);
            tbxCedula.Name = "tbxCedula";
            tbxCedula.Size = new Size(121, 23);
            tbxCedula.TabIndex = 11;
            // 
            // tbxDireccion
            // 
            tbxDireccion.Location = new Point(97, 144);
            tbxDireccion.Margin = new Padding(2);
            tbxDireccion.Name = "tbxDireccion";
            tbxDireccion.Size = new Size(271, 23);
            tbxDireccion.TabIndex = 10;
            // 
            // tbxTelefono
            // 
            tbxTelefono.Location = new Point(470, 144);
            tbxTelefono.Margin = new Padding(2);
            tbxTelefono.Name = "tbxTelefono";
            tbxTelefono.Size = new Size(135, 23);
            tbxTelefono.TabIndex = 9;
            // 
            // tbxApellido
            // 
            tbxApellido.Location = new Point(288, 85);
            tbxApellido.Margin = new Padding(2);
            tbxApellido.Name = "tbxApellido";
            tbxApellido.Size = new Size(121, 23);
            tbxApellido.TabIndex = 8;
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(80, 85);
            tbxNombre.Margin = new Padding(2);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(121, 23);
            tbxNombre.TabIndex = 7;
            // 
            // tbxId
            // 
            tbxId.Location = new Point(80, 24);
            tbxId.Margin = new Padding(2);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(38, 23);
            tbxId.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 151);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(89, 16);
            label6.TabIndex = 5;
            label6.Text = "Direccion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(383, 151);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(83, 16);
            label5.TabIndex = 4;
            label5.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(413, 92);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 16);
            label4.TabIndex = 3;
            label4.Text = "Cedula:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 92);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 16);
            label3.TabIndex = 2;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 92);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 16);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(26, 16);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Transparent;
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.Location = new Point(4, 11);
            btnNuevo.Margin = new Padding(2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.RightToLeft = RightToLeft.No;
            btnNuevo.Size = new Size(48, 48);
            btnNuevo.TabIndex = 2;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackgroundImage = (Image)resources.GetObject("btnAgregar.BackgroundImage");
            btnAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAgregar.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(56, 11);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(48, 48);
            btnAgregar.TabIndex = 3;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackgroundImage = (Image)resources.GetObject("btnModificar.BackgroundImage");
            btnModificar.BackgroundImageLayout = ImageLayout.Stretch;
            btnModificar.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(4, 76);
            btnModificar.Margin = new Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(48, 48);
            btnModificar.TabIndex = 4;
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(56, 76);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(48, 48);
            btnEliminar.TabIndex = 5;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackgroundImage = (Image)resources.GetObject("btnCancelar.BackgroundImage");
            btnCancelar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancelar.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(30, 135);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(48, 48);
            btnCancelar.TabIndex = 6;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Plum;
            groupBox2.Controls.Add(btnCancelar);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(btnNuevo);
            groupBox2.Location = new Point(872, 8);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(111, 193);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Plum;
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(639, 8);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(217, 193);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Vehiculo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(87, 144);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 151);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(55, 16);
            label7.TabIndex = 12;
            label7.Text = "Placa:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 62);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(87, 101);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(87, 24);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 23);
            textBox4.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 108);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(72, 16);
            label8.TabIndex = 4;
            label8.Text = "Modelo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(4, 69);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(59, 16);
            label9.TabIndex = 3;
            label9.Text = "Color:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 33);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(62, 16);
            label10.TabIndex = 2;
            label10.Text = "Marca:";
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(995, 471);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvClientes);
            Margin = new Padding(2);
            Name = "frmClientes";
            Text = "frmClientes";
            Load += frmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvClientes;
        private GroupBox groupBox1;
        private TextBox tbxCedula;
        private TextBox tbxDireccion;
        private TextBox tbxTelefono;
        private TextBox tbxApellido;
        private TextBox tbxNombre;
        private TextBox tbxId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnNuevo;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnCancelar;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox2;
        private Label label7;
    }
}