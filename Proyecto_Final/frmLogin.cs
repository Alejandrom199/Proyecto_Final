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

namespace CapaVisual
{
    public partial class frmLogin : Form
    {
        CN_Usuario obj_usuario = new CN_Usuario();
        public bool flagVerClave;
        public frmLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
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
    }
}
