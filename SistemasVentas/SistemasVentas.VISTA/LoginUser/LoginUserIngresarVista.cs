using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.LoginUser
{
    public partial class LoginUserIngresarVista : Form
    {
        public LoginUserIngresarVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            if (Conexion.VerificarCredenciales(usuario, contraseña))
            {
                MessageBox.Show("Inicio de sesion exitoso");
                WelcomeIngresarVista formulario = new WelcomeIngresarVista();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
