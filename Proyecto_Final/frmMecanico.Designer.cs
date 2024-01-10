namespace CapaVisual
{
    partial class frmMecanico
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
            tbxCedula = new TextBox();
            tbxEspecialidad = new TextBox();
            tbxExperiencia = new TextBox();
            tbxApellido = new TextBox();
            tbxNombre = new TextBox();
            tbxId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvMecanicos = new DataGridView();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMecanicos).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Turquoise;
            groupBox2.Controls.Add(btnCancelar);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(btnNuevo);
            groupBox2.Location = new Point(666, 9);
            groupBox2.Margin = new Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 2, 2, 2);
            groupBox2.Size = new Size(150, 172);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(34, 140);
            btnCancelar.Margin = new Padding(2, 2, 2, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 27);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(34, 108);
            btnEliminar.Margin = new Padding(2, 2, 2, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 27);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(34, 76);
            btnModificar.Margin = new Padding(2, 2, 2, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(90, 27);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(34, 44);
            btnAgregar.Margin = new Padding(2, 2, 2, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(90, 27);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.Location = new Point(34, 12);
            btnNuevo.Margin = new Padding(2, 2, 2, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(90, 27);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Turquoise;
            groupBox1.Controls.Add(tbxCedula);
            groupBox1.Controls.Add(tbxEspecialidad);
            groupBox1.Controls.Add(tbxExperiencia);
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
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(646, 172);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mecanico";
            // 
            // tbxCedula
            // 
            tbxCedula.Location = new Point(521, 69);
            tbxCedula.Margin = new Padding(2, 2, 2, 2);
            tbxCedula.Name = "tbxCedula";
            tbxCedula.Size = new Size(121, 23);
            tbxCedula.TabIndex = 11;
            // 
            // tbxEspecialidad
            // 
            tbxEspecialidad.Location = new Point(121, 125);
            tbxEspecialidad.Margin = new Padding(2, 2, 2, 2);
            tbxEspecialidad.Name = "tbxEspecialidad";
            tbxEspecialidad.Size = new Size(209, 23);
            tbxEspecialidad.TabIndex = 10;
            // 
            // tbxExperiencia
            // 
            tbxExperiencia.Location = new Point(441, 125);
            tbxExperiencia.Margin = new Padding(2, 2, 2, 2);
            tbxExperiencia.Name = "tbxExperiencia";
            tbxExperiencia.Size = new Size(201, 23);
            tbxExperiencia.TabIndex = 9;
            // 
            // tbxApellido
            // 
            tbxApellido.Location = new Point(314, 69);
            tbxApellido.Margin = new Padding(2, 2, 2, 2);
            tbxApellido.Name = "tbxApellido";
            tbxApellido.Size = new Size(121, 23);
            tbxApellido.TabIndex = 8;
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(102, 69);
            tbxNombre.Margin = new Padding(2, 2, 2, 2);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(121, 23);
            tbxNombre.TabIndex = 7;
            // 
            // tbxId
            // 
            tbxId.Location = new Point(102, 20);
            tbxId.Margin = new Padding(2, 2, 2, 2);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(82, 23);
            tbxId.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 132);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(110, 16);
            label6.TabIndex = 5;
            label6.Text = "Especialidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(334, 132);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 16);
            label5.TabIndex = 4;
            label5.Text = "Experiencia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(449, 76);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 16);
            label4.TabIndex = 3;
            label4.Text = "Cedula:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 76);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 16);
            label3.TabIndex = 2;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 76);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 16);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(26, 16);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // dgvMecanicos
            // 
            dgvMecanicos.AllowUserToAddRows = false;
            dgvMecanicos.AllowUserToDeleteRows = false;
            dgvMecanicos.BackgroundColor = SystemColors.ButtonShadow;
            dgvMecanicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMecanicos.Location = new Point(10, 194);
            dgvMecanicos.Margin = new Padding(2, 2, 2, 2);
            dgvMecanicos.Name = "dgvMecanicos";
            dgvMecanicos.ReadOnly = true;
            dgvMecanicos.RowHeadersWidth = 62;
            dgvMecanicos.RowTemplate.Height = 33;
            dgvMecanicos.Size = new Size(808, 222);
            dgvMecanicos.TabIndex = 8;
            dgvMecanicos.CellClick += dgvMecanicos_CellClick;
            // 
            // frmMecanico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(827, 425);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvMecanicos);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmMecanico";
            Text = "frmMecanico";
            Load += frmMecanico_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMecanicos).EndInit();
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
        private TextBox tbxCedula;
        private TextBox tbxEspecialidad;
        private TextBox tbxExperiencia;
        private TextBox tbxApellido;
        private TextBox tbxNombre;
        private TextBox tbxId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvMecanicos;
    }
}