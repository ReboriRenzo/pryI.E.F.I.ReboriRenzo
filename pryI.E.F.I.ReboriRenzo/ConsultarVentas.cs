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
    public partial class frmConsultarVentas : Form
    {
        public string[,] matrizCargas = new string[10, 10];
        int indiceFila, indiceColumna;
        public frmConsultarVentas()
        {
            InitializeComponent();
        }

        private void dgvCargaDeVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsultarVentas_Load(object sender, EventArgs e)
        {
            indiceColumna = 0;
            indiceFila = 0;

            while (indiceFila < matrizCargas.GetLength(0))
            {
                dgvCargadeVentas.Rows.Add(matrizCargas[indiceFila, 0],
                    matrizCargas[indiceFila, 1],
                    matrizCargas[indiceFila, 2],
                    matrizCargas[indiceFila, 3],
                    matrizCargas[indiceFila, 4],
                    matrizCargas[indiceFila, 5],
                    matrizCargas[indiceFila, 6],
                    matrizCargas[indiceFila, 7],
                    matrizCargas[indiceFila, 8],
                    matrizCargas[indiceFila, 9]);


                   indiceFila++;

            }
        }
    }
}
