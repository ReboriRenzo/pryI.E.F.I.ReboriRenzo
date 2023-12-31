﻿using System;
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
        //Declaracion variables globales

        List<Ventas> listaVentas = new List<Ventas> ();
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
                    if (nudCantidadventas.Value >= 1)
                    {
                        if (dtpFechaVenta.Value <= DateTime.Today)
                        {
                            MessageBox.Show("Haz cargado tus ventas correctamente", "Ventas Cargadas", MessageBoxButtons.OKCancel, MessageBoxIcon.None);

                            //Variable Ventas como nueva variable para cargar datos como objetos

                            Ventas nuevaVenta = new Ventas();

                            //Nuevo Listado de las ventas cargadas
                            nuevaVenta.ID = (listaVentas.Count + 1);
                            nuevaVenta.FechaVenta = dtpFechaVenta.Value;
                            nuevaVenta.Producto = txtNombreproductoVentas.Text;
                            nuevaVenta.Cantidad = int.Parse(nudCantidadventas.Text);

                            //Agregar los datos al Combo box
                            listaVentas.Add(nuevaVenta);
                            cbVentas.DataSource = null;
                            cbVentas.DataSource = listaVentas;
                            cbVentas.DisplayMember = "Producto";
                            txtNombreproductoVentas.Focus();

                            //Enviar los datos a la Grilla
                            int n = dgvConsultarVentas.Rows.Add();

                            dgvConsultarVentas.Rows[n].Cells[0].Value = txtIDVentas.Text;
                            dgvConsultarVentas.Rows[n].Cells[1].Value = txtNombreproductoVentas.Text;
                            dgvConsultarVentas.Rows[n].Cells[2].Value = nudCantidadventas.Value.ToString();
                            dgvConsultarVentas.Rows[n].Cells[3].Value = dtpFechaVenta.Value.ToString();
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
        
            
     

        private void cmdConsultarVentas_Click(object sender, EventArgs e)
        {
           

        }

        private void frmCargarVentas_Load(object sender, EventArgs e)
        {

        }

        private void dgvConsultarVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidadVentas_Click(object sender, EventArgs e)
        {

        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            frmBienvenido frmBienvenido = new frmBienvenido();
            this.Close();
        }



        //Filtrar la cantidad si el BOTON DE OPCION Cantidad esta chequeado
        private void cmdFiltrar_Click(object sender, EventArgs e)
        {
            if (optCantidad.Checked) filtrarCantidad();

            else filtrarProducto(); 
        }

        //Filtrar los productos en la variable List<ventas> para filtrar Productos

        private void filtrarProducto()
        {
            List<Ventas> filtro = new List<Ventas>();
            for (int i = 0; i < listaVentas.Count; i++)
            {
                if (listaVentas[i].Producto == txtBusqueda.Text) filtro.Add(listaVentas[i]);
            }
        //Origen y establece la propiedad  de estos datos para el filtro
            cbVentas.DataSource = filtro;
            cbVentas.DisplayMember = "Producto";
        }


        //FiltrarCantidad en variable List<ventas> para filtrar cantidades
        private void filtrarCantidad()
        {
            List<Ventas> filtro = new List<Ventas>();
            for (int i = 0; i < listaVentas.Count; i++)
            {
                if (listaVentas[i].Cantidad > int.Parse(txtBusqueda.Text)) filtro.Add(listaVentas[i]);
            }
            //Origen y establece la propiedad  de estos datos para el filtro
            cbVentas.DataSource = filtro;
            cbVentas.DisplayMember = "Producto";
            }

        private void cbVentas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvConsultarVentas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void optProducto_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
