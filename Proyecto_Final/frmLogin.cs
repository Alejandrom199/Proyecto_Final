using CapaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing.Drawing2D;

namespace CapaVisual
{
    public partial class frmLogin : Form
    {
        CN_Usuario obj_usuario = new CN_Usuario();
        public bool flagVerClave;
        public frmLogin()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(frmLogin_Paint);

            lblIngresar.ForeColor = SystemColors.ControlLightLight;

            AplicarBorderRadiusMayor(pnlIcono, 150);

            AplicarBorderRadiusMayor(pnlMayor, 75);
            AplicarBorderRadiusMenor(pnlMenor, 75);

            StartPosition = FormStartPosition.CenterScreen;
            lblIngresar.Click += new EventHandler(lblIngresar_Click);


            MaximizeBox = false;

            tbxClave.PasswordChar = '*';
            flagVerClave = true;

            string rutaImagen = "C:\\Users\\ALEJANDRO\\Desktop\\Proyectos C#\\Proyecto_Final\\Proyecto_Final\\imagenes\\ojo-abierto.png";

            if (File.Exists(rutaImagen))
            {
                btnVerClave.BackgroundImage = Image.FromFile(rutaImagen);
                btnVerClave.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
        }

        private void btnVerClave_Click(object sender, EventArgs e)
        {
            string rutaImagen;

            if (flagVerClave)
            {
                tbxClave.PasswordChar = '\0';
                flagVerClave = false;

                rutaImagen = "C:\\Users\\ALEJANDRO\\Desktop\\Proyectos C#\\Proyecto_Final\\Proyecto_Final\\imagenes\\ojo-cerrado.png";

                if (File.Exists(rutaImagen))
                {
                    btnVerClave.BackgroundImage = Image.FromFile(rutaImagen);
                    btnVerClave.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            else
            {
                tbxClave.PasswordChar = '*';
                flagVerClave = true;

                rutaImagen = "C:\\Users\\ALEJANDRO\\Desktop\\Proyectos C#\\Proyecto_Final\\Proyecto_Final\\imagenes\\ojo-abierto.png";

                if (File.Exists(rutaImagen))
                {
                    btnVerClave.BackgroundImage = Image.FromFile(rutaImagen);
                    btnVerClave.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }

        private void AplicarBorderRadiusMayor(Panel panel, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(panel.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(panel.Width - radio, panel.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, panel.Height - radio, radio, radio, 90, 90);

            panel.Region = new Region(path);
        }

        private void AplicarBorderRadiusMenor(Panel panel, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 0.1f, 0.1f, 90, 90);
            path.AddArc(panel.Width, 0, 0.1f, 0.1f, 270, 90);
            path.AddArc(panel.Width - radio, panel.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, panel.Height - radio, radio, radio, 90, 90);

            panel.Region = new Region(path);
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicación?", "Cerrar aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void frmLogin_Paint(object sender, PaintEventArgs e)
        {
            // Dibujar esquinas redondeadas
            GraphicsPath path = new GraphicsPath();
            int radio = 50; // Ajusta este valor según tu preferencia

            // Esquinas superiores izquierda y derecha
            path.AddArc(0, 0, radio * 2, radio * 2, 180, 90);
            path.AddLine(radio, 0, this.Width - radio, 0);

            // Esquinas superiores derecha e inferior derecha
            path.AddArc(this.Width - radio * 2, 0, radio * 2, radio * 2, 270, 90);
            path.AddLine(this.Width, radio, this.Width, this.Height - radio);

            // Esquinas inferiores derecha e izquierda
            path.AddArc(this.Width - radio * 2, this.Height - radio * 2, radio * 2, radio * 2, 0, 90);
            path.AddLine(this.Width - radio, this.Height, radio, this.Height);

            // Esquinas inferiores izquierda e izquierda superior
            path.AddArc(0, this.Height - radio * 2, radio * 2, radio * 2, 90, 90);
            path.AddLine(0, this.Height - radio, 0, radio);

            // Dibujar el formulario con esquinas redondeadas
            this.Region = new Region(path);

        }

        private void pnlMenor_Click(object sender, EventArgs e)
        {
            CN_Usuario user = new CN_Usuario();
            user.Username = tbxUsuario.Text;
            user.Clave = tbxClave.Text;

            if (obj_usuario.ValidarUsuario(user))
            {
                MessageBox.Show("Inicio de sesión exitoso de " + user.Username);

                frmPrincipal pantallaIncial = new frmPrincipal();
                pantallaIncial.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Credenciales inválidas");
            }
        }

        private void lblIngresar_Click(object sender, EventArgs e)
        {

        }
    }
}
