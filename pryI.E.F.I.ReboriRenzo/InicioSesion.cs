using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryI.E.F.I.ReboriRenzo
{
    public partial class frmInicioSesion : Form
    {
        string vUsuario;
        string vContraseña;
        int vContadorLogin = 0;
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            vUsuario = txtIniciarSesion.Text;
            vContraseña = txtContraseña.Text;

            if (vUsuario == "ENCARGO19" && vContraseña == "Encargo3")
            {
                frmBienvenido ventanaPrincipal = new frmBienvenido();
                ventanaPrincipal.ShowDialog();
                this.Hide();
            }
            else
            {
                vContadorLogin++;
                if (vContadorLogin == 3)
                {
                    MessageBox.Show("Realizo muchos intentos", "Intentelo de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();

                }
                else
                {
                    MessageBox.Show("Algun dato incorrecto. Intenta nuevamente: " + vContadorLogin.ToString() + "de 3", "Datos mal ingresados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
