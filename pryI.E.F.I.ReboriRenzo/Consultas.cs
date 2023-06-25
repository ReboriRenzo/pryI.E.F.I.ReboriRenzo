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
    public partial class frmConsultas : Form
    {
        public string[,] matrizRegistro = new string[4, 4];
        int indiceFila, indiceColumna;

        public frmConsultas()
        {
            InitializeComponent();
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            indiceColumna = 0;
            indiceFila = 0;

            while (indiceFila < matrizRegistro.GetLength(0))
            {
                dgvRegistro.Rows.Add(matrizRegistro[indiceFila, 0],
                    matrizRegistro[indiceFila, 1],
                    matrizRegistro[indiceFila, 2],
                    matrizRegistro[indiceFila, 3]);

                indiceFila++;
            }
        }
    }
}
