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
    public partial class frmBienvenido : Form
    {
        public frmBienvenido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.ShowDialog();
            this.Close();
        }

        private void cmdCargarProductos_Click(object sender, EventArgs e)
        {
            frmCargarVentas frmCargarVentas = new frmCargarVentas();
            frmCargarVentas.ShowDialog();

            this.Close();
        }
    }
}
