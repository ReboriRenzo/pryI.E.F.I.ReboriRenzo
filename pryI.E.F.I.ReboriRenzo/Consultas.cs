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
        public string[,] matrizRegistro = new string[10, 10];
        int indiceFila, indiceColumna;

        public frmConsultas()
        {
            InitializeComponent();
        }

        private void dgvRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRegistro_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

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
                    matrizRegistro[indiceFila, 3],
                    matrizRegistro[indiceFila, 4],
                    matrizRegistro[indiceFila, 5],
                    matrizRegistro[indiceFila, 6],
                    matrizRegistro[indiceFila, 7],
                    matrizRegistro[indiceFila, 8],
                    matrizRegistro[indiceFila, 9]);


                indiceFila++;
            }
        }
    }
}
