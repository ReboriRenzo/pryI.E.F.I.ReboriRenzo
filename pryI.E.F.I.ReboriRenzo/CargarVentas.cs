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
    public partial class frmCargarVentas : Form
    {
        frmConsultarVentas ventanaConsultarVentas = new frmConsultarVentas();
        readonly int indiceConsultas = 0;
        int indiceFilaConsultas;
        public string dato = "";
        
        public frmCargarVentas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mrcCargaDeVentas_Enter(object sender, EventArgs e)
        {

        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            if (txtIDVentas.Text != "")
            {
                if (txtNombreproductoVentas.Text != "")
                {
                    if (nudCantidad.Value >= 1)
                    {
                        if (dtpFechaVenta.Value <= DateTime.Today)
                        {
                            MessageBox.Show("Haz cargado tus ventas correctamente", "Ventas Cargadas", MessageBoxButtons.OKCancel, MessageBoxIcon.None);

                            ventanaConsultarVentas.matrizVentas[indiceFilaConsultas, 0] = txtIDVentas.Text;
                            ventanaConsultarVentas.matrizVentas[indiceFilaConsultas, 1] = txtNombreproductoVentas.Text;
                            ventanaConsultarVentas.matrizVentas[indiceFilaConsultas, 2] = nudCantidad.Value.ToString();
                            ventanaConsultarVentas.matrizVentas[indiceFilaConsultas, 3] = dtpFechaVenta.Value.ToString();

                            indiceFilaConsultas++;

                            if (indiceFilaConsultas == ventanaConsultarVentas.matrizVentas.GetLength(0))
                            {
                                cmdCargarVentas.Enabled = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("La fecha seleccionada es mayor a hoy", "Verifique la venta de su producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cantidad de productos NULA", "Verifique la cantidad de sus productos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("El nombre del producto no existe", "Verifique el nombre del producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El ID del producto no existe !!", "Verifique el ID del producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }      
        }
        private void Busqueda_en_grid(DataGridView d, int col)
        {
            for(int i =0; i<d.Rows.Count - 1; i++) 
            {
                dato = Convert.ToString(d.Rows[i].Cells[col].Value);
                if(dato == txtIDVentas.Text.Trim())
                {
                    MessageBox.Show("si");
                    break;
                }
            }
        }

        private void cmdConsultarVentas_Click(object sender, EventArgs e)
        {
            ventanaConsultarVentas.ShowDialog();

        }

        private void frmCargarVentas_Load(object sender, EventArgs e)
        {

        }

        private void dgvConsultarVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
