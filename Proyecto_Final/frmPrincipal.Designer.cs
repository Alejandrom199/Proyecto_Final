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
            label9 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 303);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnCliente
            // 
            btnCliente.Image = (Image)resources.GetObject("btnCliente.Image");
            btnCliente.Location = new Point(380, 176);
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
            btnMecanico.Location = new Point(594, 176);
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
            btnMantenimiento.Location = new Point(789, 176);
            btnMantenimiento.Margin = new Padding(4);
            btnMantenimiento.Name = "btnMantenimiento";
            btnMantenimiento.Size = new Size(150, 146);
            btnMantenimiento.TabIndex = 4;
            btnMantenimiento.UseVisualStyleBackColor = true;
            btnMantenimiento.Click += btnMantenimiento_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Silver;
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Cascadia Mono", 8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(1, 301);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(316, 268);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Integrantes";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 164);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(127, 21);
            label8.TabIndex = 4;
            label8.Text = "- Azua Marlon";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 133);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(154, 21);
            label7.TabIndex = 3;
            label7.Text = "- Maldonado Saul";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 101);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(154, 21);
            label6.TabIndex = 2;
            label6.Text = "- Fajardo Bianca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 70);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(136, 21);
            label5.TabIndex = 1;
            label5.Text = "- Ocampo Adela";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 41);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(154, 21);
            label4.TabIndex = 0;
            label4.Text = "- Bravo Domenica";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cascadia Mono", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(418, 338);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 6;
            label1.Text = "CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cascadia Mono", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(632, 338);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 7;
            label2.Text = "MECANICO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cascadia Mono", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(804, 341);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 8;
            label3.Text = "MANTENIMIENTO";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cascadia Mono", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(519, 77);
            label9.Name = "label9";
            label9.Size = new Size(273, 37);
            label9.TabIndex = 10;
            label9.Text = "Menú de Opciones";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnMantenimiento);
            panel1.Controls.Add(btnMecanico);
            panel1.Controls.Add(btnCliente);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 562);
            panel1.TabIndex = 11;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label9;
        private Panel panel1;
    }
}