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
    public partial class frmRegistro : Form

    {
        frmConsultas ventanaConsultas = new frmConsultas();
        readonly int indiceRegistro = 0;
        int indiceFilaRegistro;
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void cmdConultar_Click(object sender, EventArgs e)
        {
            frmConsultas frmConsultas = new frmConsultas();
            frmConsultas.ShowDialog();
            this.Hide();
        }

        

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void CmdMostrar_Click_1(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void cmdRegistrar_Click_1(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (txtNombre.Text != "")
                {
                    if (nudCantidad.Value >= 1)
                    {
                        if (dtpFecha.Value >= DateTime.Today)
                        {

                            MessageBox.Show("Productos Cargados correctamente", "Producto Cargado!!", MessageBoxButtons.OK, MessageBoxIcon.None);


                            ventanaConsultas.matrizRegistro[indiceFilaRegistro, 0] = txtID.Text;
                            ventanaConsultas.matrizRegistro[indiceFilaRegistro, 1] = txtNombre.Text;
                            ventanaConsultas.matrizRegistro[indiceFilaRegistro, 2] = nudCantidad.Value.ToString();
                            ventanaConsultas.matrizRegistro[indiceFilaRegistro, 3] = dtpFecha.Value.ToString();

                            indiceFilaRegistro++;

                            if (indiceFilaRegistro == ventanaConsultas.matrizRegistro.GetLength(0))
                            {
                                cmdRegistrar.Enabled = false;
                            }


                        }
                        else
                        {
                            MessageBox.Show("La Fecha tiene que ser al dia de hoy o posterior", "Determine una fecha valida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    else
                        MessageBox.Show("Cantidad invalida a lo esperado", "Determine un valor cierto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Nombre del producto inexistente", "NOMBRE INCORRECTO", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            }
            else
                MessageBox.Show("ID del producto inexistente", "ERROR EN EL ID", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

        }
    }
}
