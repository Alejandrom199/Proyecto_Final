namespace CapaVisual
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            pictureBox1 = new PictureBox();
            btnCliente = new Button();
            btnMecanico = new Button();
            btnMantenimiento = new Button();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 45);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(406, 450);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnCliente
            // 
            btnCliente.Image = (Image)resources.GetObject("btnCliente.Image");
            btnCliente.Location = new Point(464, 54);
            btnCliente.Margin = new Padding(4);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(150, 146);
            btnCliente.TabIndex = 2;
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnMecanico
            // 
            btnMecanico.Image = (Image)resources.GetObject("btnMecanico.Image");
            btnMecanico.Location = new Point(692, 54);
            btnMecanico.Margin = new Padding(4);
            btnMecanico.Name = "btnMecanico";
            btnMecanico.Size = new Size(150, 146);
            btnMecanico.TabIndex = 3;
            btnMecanico.UseVisualStyleBackColor = true;
            btnMecanico.Click += btnMecanico_Click;
            // 
            // btnMantenimiento
            // 
            btnMantenimiento.Image = (Image)resources.GetObject("btnMantenimiento.Image");
            btnMantenimiento.Location = new Point(464, 319);
            btnMantenimiento.Margin = new Padding(4);
            btnMantenimiento.Name = "btnMantenimiento";
            btnMantenimiento.Size = new Size(150, 146);
            btnMantenimiento.TabIndex = 4;
            btnMantenimiento.UseVisualStyleBackColor = true;
            btnMantenimiento.Click += btnMantenimiento_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Thistle;
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(665, 306);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(302, 208);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Integrantes";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 165);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(156, 20);
            label8.TabIndex = 4;
            label8.Text = "- Azua Marlon";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 134);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(251, 20);
            label7.TabIndex = 3;
            label7.Text = "- Maldonado Alejandro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 102);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(177, 20);
            label6.TabIndex = 2;
            label6.Text = "- Fajardo Bianca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 71);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(161, 20);
            label5.TabIndex = 1;
            label5.Text = "- Ocampo Adela";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 42);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(185, 20);
            label4.TabIndex = 0;
            label4.Text = "- Bravo Domenica";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(503, 216);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 6;
            label1.Text = "CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(718, 216);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 7;
            label2.Text = "MECANICO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(461, 484);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(161, 20);
            label3.TabIndex = 8;
            label3.Text = "MANTENIMIENTO";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PeachPuff;
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnMantenimiento);
            groupBox1.Controls.Add(btnMecanico);
            groupBox1.Controls.Add(btnCliente);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(-3, -1);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1008, 566);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackgroundImage = (Image)resources.GetObject("btnCancelar.BackgroundImage");
            btnCancelar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancelar.Location = new Point(931, 13);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(60, 60);
            btnCancelar.TabIndex = 9;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnCliente;
        private Button btnMecanico;
        private Button btnMantenimiento;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Button btnCancelar;
    }
}