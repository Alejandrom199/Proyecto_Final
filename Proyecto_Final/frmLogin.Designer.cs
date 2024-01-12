namespace CapaVisual
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnVerClave = new Button();
            btnIngresar = new Button();
            label1 = new Label();
            tbxClave = new TextBox();
            tbxUsuario = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -4);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(514, 674);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(btnVerClave);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbxClave);
            panel1.Controls.Add(tbxUsuario);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(17, 10);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(412, 492);
            panel1.TabIndex = 1;
            // 
            // btnVerClave
            // 
            btnVerClave.Location = new Point(322, 300);
            btnVerClave.Name = "btnVerClave";
            btnVerClave.Size = new Size(34, 34);
            btnVerClave.TabIndex = 6;
            btnVerClave.UseVisualStyleBackColor = true;
            btnVerClave.Click += btnVerClave_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Tomato;
            btnIngresar.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(114, 409);
            btnIngresar.Margin = new Padding(4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(199, 41);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(114, 86);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 58);
            label1.TabIndex = 4;
            label1.Text = "LOGIN";
            // 
            // tbxClave
            // 
            tbxClave.Location = new Point(132, 302);
            tbxClave.Margin = new Padding(4);
            tbxClave.Name = "tbxClave";
            tbxClave.Size = new Size(191, 31);
            tbxClave.TabIndex = 3;
            tbxClave.MouseEnter += tbxClave_MouseEnter;
            tbxClave.MouseLeave += tbxClave_MouseLeave;
            // 
            // tbxUsuario
            // 
            tbxUsuario.Location = new Point(132, 220);
            tbxUsuario.Margin = new Padding(4);
            tbxUsuario.Name = "tbxUsuario";
            tbxUsuario.Size = new Size(224, 31);
            tbxUsuario.TabIndex = 2;
            tbxUsuario.MouseEnter += tbxUsuario_MouseEnter;
            tbxUsuario.MouseLeave += tbxUsuario_MouseLeave;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(61, 290);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(61, 208);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(32, 31);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(447, 520);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 599);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnIngresar;
        private Label label1;
        private TextBox tbxClave;
        private TextBox tbxUsuario;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Button btnVerClave;
    }
}