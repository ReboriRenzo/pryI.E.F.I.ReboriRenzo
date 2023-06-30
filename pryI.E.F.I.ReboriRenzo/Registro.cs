using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace pryI.E.F.I.ReboriRenzo
{
    public partial class frmRegistro : Form

    {
        Producto nuevoProducto = new Producto();
        List<Producto> listaProductos = new List<Producto>();
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

                            int n = dgvRegistro.Rows.Add();


                            //Variable Ventas como nueva variable para cargar datos como objetos
                            Producto nuevoProducto = new Producto();

                            //Enviar los datos a la Grilla
                            dgvRegistro.Rows[n].Cells[0].Value = txtID.Text;
                            dgvRegistro.Rows[n].Cells[1].Value = txtNombre.Text;
                            dgvRegistro.Rows[n].Cells[2].Value = nudCantidad.Value.ToString();
                            dgvRegistro.Rows[n].Cells[3].Value = dtpFecha.Value.ToString();

                            //Nuevo Listado de los productos cargados
                            nuevoProducto.ID = (listaProductos.Count + 1);
                            nuevoProducto.Nombre = txtNombre.Text;
                            nuevoProducto.Cantidad = int.Parse(nudCantidad.Text);
                            nuevoProducto.FechaRegistro = dtpFecha.Value;


                            //Agregar los datos cargados al Combo box
                            listaProductos.Add(nuevoProducto);
                            cbProductos.DataSource = null;
                            cbProductos.DataSource = listaProductos;
                            cbProductos.DisplayMember = "Nombre";
                            txtNombre.Focus();
                        }
                        else
                        {
                            
                            //Mensajes al no colocar bien los datos

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


        //Filtrar los productos en la variable List<Productos> para filtrar Productos
        private void filtrarProducto()
        {
            List<Producto> filtro = new List<Producto>();
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].Productos == txtFiltro.Text) filtro.Add(listaProductos[i]);
            }
            //Origen y establece la propiedad  de estos datos para el filtro
            cbProductos.DataSource = filtro;
            cbProductos.DisplayMember = "Producto";
        }

        //Filtrar cantidad en variable List<Productos> para filtrar cantidades
        private void filtrarCantidad()
        {
            List<Producto> filtro = new List<Producto>();
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].Cantidad > int.Parse(txtFiltro.Text))
                {
                    filtro.Add(listaProductos[i]);
                }
            }

            //Origen y establece la propiedad  de estos datos para el filtro
            cbProductos.DataSource = filtro;
            cbProductos.DisplayMember = "Producto";
        }

        private void cmdFiltrar_Click(object sender, EventArgs e)
        {
            if (optCantidad.Checked) filtrarCantidad();

            else filtrarProducto();
        }
    }
}
