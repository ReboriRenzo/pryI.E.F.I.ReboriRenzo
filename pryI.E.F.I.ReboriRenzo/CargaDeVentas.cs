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
                            MessageBox.Show("Productos Cargados correctamente", "Producto Cargado!!", MessageBoxButtons.OK, MessageBoxIcon.None);


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
                            MessageBox.Show("La Fecha tiene que ser al dia de hoy o posterior", "Determine una fecha valida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cantidad invalida a lo esperado", "Determine un valor cierto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Nombre del producto inexistente", "NOMBRE INCORRECTO", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("ID del producto inexistente", "ERROR EN EL ID", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
    

    

       