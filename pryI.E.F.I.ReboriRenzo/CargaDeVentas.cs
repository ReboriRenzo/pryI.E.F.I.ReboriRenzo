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
    public partial class frmCargaDeVentas : Form
    {
        frmConsultarVentas ventanaConsultarVentas = new frmConsultarVentas();
        readonly int indiceConsultas = 0;
        int indiceFilaConsultas;
        public frmCargaDeVentas()
        {
            InitializeComponent();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if (txtIDVentas.Text != "")
            {
                if (txtNombreVentas.Text != "")
                {
                    if (nudCantidadVentas.Value >= 1)
                    {
                        if (dtpFechaVentas.Value >= DateTime.Today)
                        {
                            MessageBox.Show("Tus ventas fueron cargadas correctamente, Haz click en CONSULTAR para ver tus ventas", "Ventas Cargadas", MessageBoxButtons.OK);

                            ventanaConsultarVentas.matrizCargas[indiceFilaConsultas, 0] = txtIDVentas.Text;
                            ventanaConsultarVentas.matrizCargas[indiceFilaConsultas, 1] = txtNombreVentas.Text;
                            ventanaConsultarVentas.matrizCargas[indiceFilaConsultas, 2] = nudCantidadVentas.Value.ToString();
                            ventanaConsultarVentas.matrizCargas[indiceFilaConsultas, 3] = dtpFechaVentas.Value.ToString();


                            indiceFilaConsultas++;

                            if (indiceFilaConsultas == ventanaConsultarVentas.matrizCargas.GetLength(0))
                            {
                                cmdCargarVenta.Enabled = false;
                            }

                        }
                        else
                        {
                            MessageBox.Show("El dia de la ventana tiene que ser hoy o anterior", "Determine una fecha valida", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cantidad nula, seleccione una cantidad valida", "Cantidad Nula", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El Producto no existe o la casilla esta NULA", "Nombre del Producto no valido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("El ID del prodecuto no existe, Verificar", "Verificar ID del producto a Cargar", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
    

    

       