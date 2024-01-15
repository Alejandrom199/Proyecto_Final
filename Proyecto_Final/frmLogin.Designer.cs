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
            panel2 = new Panel();
            pnlIcono = new Panel();
            pnlMayor = new Panel();
            btnVerClave = new Button();
            pictureBox2 = new PictureBox();
            tbxClave = new TextBox();
            tbxUsuario = new TextBox();
            pictureBox3 = new PictureBox();
            btnSalir = new Button();
            pnlMenor = new Panel();
            lblIngresar = new Label();
            panel2.SuspendLayout();
            pnlMayor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlMenor.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(pnlIcono);
            panel2.Controls.Add(pnlMayor);
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(pnlMenor);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(508, 599);
            panel2.TabIndex = 2;
            // 
            // pnlIcono
            // 
            pnlIcono.BackColor = Color.Transparent;
            pnlIcono.BackgroundImage = (Image)resources.GetObject("pnlIcono.BackgroundImage");
            pnlIcono.BackgroundImageLayout = ImageLayout.Zoom;
            pnlIcono.Location = new Point(191, 35);
            pnlIcono.Name = "pnlIcono";
            pnlIcono.Size = new Size(150, 150);
            pnlIcono.TabIndex = 10;
            // 
            // pnlMayor
            // 
            pnlMayor.BackColor = Color.Transparent;
            pnlMayor.BackgroundImage = (Image)resources.GetObject("pnlMayor.BackgroundImage");
            pnlMayor.BackgroundImageLayout = ImageLayout.Stretch;
            pnlMayor.Controls.Add(btnVerClave);
            pnlMayor.Controls.Add(pictureBox2);
            pnlMayor.Controls.Add(tbxClave);
            pnlMayor.Controls.Add(tbxUsuario);
            pnlMayor.Controls.Add(pictureBox3);
            pnlMayor.Location = new Point(50, 114);
            pnlMayor.Name = "pnlMayor";
            pnlMayor.Size = new Size(409, 300);
            pnlMayor.TabIndex = 9;
            // 
            // btnVerClave
            // 
            btnVerClave.BackgroundImage = (Image)resources.GetObject("btnVerClave.BackgroundImage");
            btnVerClave.BackgroundImageLayout = ImageLayout.Stretch;
            btnVerClave.Location = new Point(313, 196);
            btnVerClave.Name = "btnVerClave";
            btnVerClave.Size = new Size(31, 31);
            btnVerClave.TabIndex = 6;
            btnVerClave.UseVisualStyleBackColor = true;
            btnVerClave.Click += btnVerClave_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(68, 105);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // tbxClave
            // 
            tbxClave.Cursor = Cursors.IBeam;
            tbxClave.Location = new Point(133, 196);
            tbxClave.Margin = new Padding(4);
            tbxClave.Name = "tbxClave";
            tbxClave.Size = new Size(182, 31);
            tbxClave.TabIndex = 3;
            tbxClave.Text = "Clave";
            // 
            // tbxUsuario
            // 
            tbxUsuario.Cursor = Cursors.IBeam;
            tbxUsuario.Location = new Point(133, 114);
            tbxUsuario.Margin = new Padding(4);
            tbxUsuario.Name = "tbxUsuario";
            tbxUsuario.Size = new Size(214, 31);
            tbxUsuario.TabIndex = 2;
            tbxUsuario.Text = "Usuario";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(68, 187);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(473, 7);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(30, 30);
            btnSalir.TabIndex = 0;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pnlMenor
            // 
            pnlMenor.BackColor = Color.Transparent;
            pnlMenor.BackgroundImage = (Image)resources.GetObject("pnlMenor.BackgroundImage");
            pnlMenor.BackgroundImageLayout = ImageLayout.Stretch;
            pnlMenor.Controls.Add(lblIngresar);
            pnlMenor.Cursor = Cursors.Hand;
            pnlMenor.Location = new Point(105, 413);
            pnlMenor.Name = "pnlMenor";
            pnlMenor.Size = new Size(300, 74);
            pnlMenor.TabIndex = 0;
            pnlMenor.Click += pnlMenor_Click;
            // 
            // lblIngresar
            // 
            lblIngresar.AutoSize = true;
            lblIngresar.Cursor = Cursors.Arrow;
            lblIngresar.FlatStyle = FlatStyle.Flat;
            lblIngresar.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngresar.ForeColor = SystemColors.ControlLightLight;
            lblIngresar.Location = new Point(86, 21);
            lblIngresar.Name = "lblIngresar";
            lblIngresar.Size = new Size(126, 32);
            lblIngresar.TabIndex = 0;
            lblIngresar.Text = "Ingresar";
            lblIngresar.Click += lblIngresar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 599);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Paint += frmLogin_Paint;
            panel2.ResumeLayout(false);
            pnlMayor.ResumeLayout(false);
            pnlMayor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlMenor.ResumeLayout(false);
            pnlMenor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel pnlMayor;
        private Button btnVerClave;
        private Button btnSalir;
        private PictureBox pictureBox2;
        private TextBox tbxClave;
        private TextBox tbxUsuario;
        private PictureBox pictureBox3;
        private Panel pnlMenor;
        private Label lblIngresar;
        private Panel pnlIcono;
    }
}