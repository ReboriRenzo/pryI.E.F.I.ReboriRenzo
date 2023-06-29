using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryI.E.F.I.ReboriRenzo
{
    public partial class frmConsultarVentas : Form
    {
        public string[,] matrizVentas = new string[10, 10];
        int indiceFila, indiceColumna;


        public frmConsultarVentas()
        {
            InitializeComponent();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltro.Text != "")
            {
                dgvConsultarVentas.CurrentCell = null;
                foreach (DataGridViewRow r in dgvConsultarVentas.Rows)
                {
                    r.Visible = true;
                }
                foreach (DataGridViewRow r in dgvConsultarVentas.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if (((c.Value.ToString().ToUpper())).IndexOf(txtFiltro.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            

                
                

                

            
        }
    

        private void frmConsultarVentas_Load(object sender, EventArgs e)
        {
            indiceFila = 0;
            indiceColumna = 0;

            while(indiceFila < matrizVentas.GetLength(0))
            {
                dgvConsultarVentas.Rows.Add(matrizVentas[indiceFila, 0],
                    matrizVentas[indiceFila, 1],
                    matrizVentas[indiceFila, 2],
                    matrizVentas[indiceFila, 3],
                    matrizVentas[indiceFila, 4],
                    matrizVentas[indiceFila, 5],
                    matrizVentas[indiceFila, 6],
                    matrizVentas[indiceFila, 7],
                    matrizVentas[indiceFila, 8],
                    matrizVentas[indiceFila, 9]);
                indiceFila++;


            }
        }
    }
}
