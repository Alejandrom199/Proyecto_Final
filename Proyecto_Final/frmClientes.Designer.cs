namespace CapaVisual
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
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 241);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.RowTemplate.Height = 33;
            dgvClientes.Size = new Size(1010, 277);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(12, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(807, 215);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // tbxCedula
            // 
            tbxCedula.Location = new Point(611, 98);
            tbxCedula.Name = "tbxCedula";
            tbxCedula.Size = new Size(150, 31);
            tbxCedula.TabIndex = 11;
            // 
            // tbxDireccion
            // 
            tbxDireccion.Location = new Point(113, 160);
            tbxDireccion.Name = "tbxDireccion";
            tbxDireccion.Size = new Size(150, 31);
            tbxDireccion.TabIndex = 10;
            // 
            // tbxTelefono
            // 
            tbxTelefono.Location = new Point(367, 160);
            tbxTelefono.Name = "tbxTelefono";
            tbxTelefono.Size = new Size(150, 31);
            tbxTelefono.TabIndex = 9;
            // 
            // tbxApellido
            // 
            tbxApellido.Location = new Point(367, 98);
            tbxApellido.Name = "tbxApellido";
            tbxApellido.Size = new Size(150, 31);
            tbxApellido.TabIndex = 8;
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(113, 101);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(150, 31);
            tbxNombre.TabIndex = 7;
            // 
            // tbxId
            // 
            tbxId.Location = new Point(113, 48);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(102, 31);
            tbxId.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 163);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 5;
            label6.Text = "Direccion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(279, 160);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 4;
            label5.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(535, 101);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 3;
            label4.Text = "Cedula:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 104);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 2;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 104);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 51);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(42, 15);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(112, 34);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(42, 55);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(42, 95);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 34);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(42, 135);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(42, 175);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCancelar);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(btnNuevo);
            groupBox2.Location = new Point(833, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(188, 215);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 531);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvClientes);
            Name = "frmClientes";
            Text = "frmClientes";
            Load += frmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
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
    }
}