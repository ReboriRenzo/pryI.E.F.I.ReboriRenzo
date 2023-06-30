namespace pryI.E.F.I.ReboriRenzo
{
    partial class frmCargarVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarVentas));
            this.mrcCargaDeVentas = new System.Windows.Forms.GroupBox();
            this.cmdCargarVentas = new System.Windows.Forms.Button();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.txtIDVentas = new System.Windows.Forms.TextBox();
            this.txtNombreproductoVentas = new System.Windows.Forms.TextBox();
            this.nudCantidadventas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCantidadVentas = new System.Windows.Forms.Label();
            this.lblNombreVentas = new System.Windows.Forms.Label();
            this.lblIDVentas = new System.Windows.Forms.Label();
            this.dgvConsultarVentas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdFiltrar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cbVentas = new System.Windows.Forms.ComboBox();
            this.optProducto = new System.Windows.Forms.RadioButton();
            this.optCantidad = new System.Windows.Forms.RadioButton();
            this.mrcCargaDeVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcCargaDeVentas
            // 
            this.mrcCargaDeVentas.BackColor = System.Drawing.Color.BurlyWood;
            this.mrcCargaDeVentas.Controls.Add(this.cmdCargarVentas);
            this.mrcCargaDeVentas.Controls.Add(this.cmdVolver);
            this.mrcCargaDeVentas.Controls.Add(this.dtpFechaVenta);
            this.mrcCargaDeVentas.Controls.Add(this.txtIDVentas);
            this.mrcCargaDeVentas.Controls.Add(this.txtNombreproductoVentas);
            this.mrcCargaDeVentas.Controls.Add(this.nudCantidadventas);
            this.mrcCargaDeVentas.Controls.Add(this.label4);
            this.mrcCargaDeVentas.Controls.Add(this.lblCantidadVentas);
            this.mrcCargaDeVentas.Controls.Add(this.lblNombreVentas);
            this.mrcCargaDeVentas.Controls.Add(this.lblIDVentas);
            this.mrcCargaDeVentas.Font = new System.Drawing.Font("Yu Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcCargaDeVentas.Location = new System.Drawing.Point(3, 50);
            this.mrcCargaDeVentas.Margin = new System.Windows.Forms.Padding(5);
            this.mrcCargaDeVentas.Name = "mrcCargaDeVentas";
            this.mrcCargaDeVentas.Padding = new System.Windows.Forms.Padding(5);
            this.mrcCargaDeVentas.Size = new System.Drawing.Size(406, 266);
            this.mrcCargaDeVentas.TabIndex = 0;
            this.mrcCargaDeVentas.TabStop = false;
            this.mrcCargaDeVentas.Text = "Carga De Ventas";
            this.mrcCargaDeVentas.Enter += new System.EventHandler(this.mrcCargaDeVentas_Enter);
            // 
            // cmdCargarVentas
            // 
            this.cmdCargarVentas.BackColor = System.Drawing.Color.Tan;
            this.cmdCargarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCargarVentas.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargarVentas.Location = new System.Drawing.Point(273, 223);
            this.cmdCargarVentas.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCargarVentas.Name = "cmdCargarVentas";
            this.cmdCargarVentas.Size = new System.Drawing.Size(103, 32);
            this.cmdCargarVentas.TabIndex = 4;
            this.cmdCargarVentas.Text = "Cargar";
            this.cmdCargarVentas.UseVisualStyleBackColor = false;
            this.cmdCargarVentas.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // cmdVolver
            // 
            this.cmdVolver.BackColor = System.Drawing.Color.Tan;
            this.cmdVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdVolver.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVolver.Location = new System.Drawing.Point(153, 223);
            this.cmdVolver.Margin = new System.Windows.Forms.Padding(4);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(103, 32);
            this.cmdVolver.TabIndex = 5;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = false;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVenta.Location = new System.Drawing.Point(34, 187);
            this.dtpFechaVenta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(351, 28);
            this.dtpFechaVenta.TabIndex = 3;
            // 
            // txtIDVentas
            // 
            this.txtIDVentas.BackColor = System.Drawing.Color.DarkGray;
            this.txtIDVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDVentas.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDVentas.Location = new System.Drawing.Point(157, 32);
            this.txtIDVentas.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDVentas.Name = "txtIDVentas";
            this.txtIDVentas.Size = new System.Drawing.Size(219, 28);
            this.txtIDVentas.TabIndex = 0;
            // 
            // txtNombreproductoVentas
            // 
            this.txtNombreproductoVentas.BackColor = System.Drawing.Color.DarkGray;
            this.txtNombreproductoVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreproductoVentas.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreproductoVentas.Location = new System.Drawing.Point(183, 76);
            this.txtNombreproductoVentas.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreproductoVentas.Name = "txtNombreproductoVentas";
            this.txtNombreproductoVentas.Size = new System.Drawing.Size(202, 28);
            this.txtNombreproductoVentas.TabIndex = 1;
            // 
            // nudCantidadventas
            // 
            this.nudCantidadventas.BackColor = System.Drawing.Color.DarkGray;
            this.nudCantidadventas.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidadventas.Location = new System.Drawing.Point(264, 126);
            this.nudCantidadventas.Margin = new System.Windows.Forms.Padding(4);
            this.nudCantidadventas.Name = "nudCantidadventas";
            this.nudCantidadventas.Size = new System.Drawing.Size(121, 28);
            this.nudCantidadventas.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de venta";
            // 
            // lblCantidadVentas
            // 
            this.lblCantidadVentas.AutoSize = true;
            this.lblCantidadVentas.Font = new System.Drawing.Font("Yu Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadVentas.Location = new System.Drawing.Point(22, 128);
            this.lblCantidadVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadVentas.Name = "lblCantidadVentas";
            this.lblCantidadVentas.Size = new System.Drawing.Size(238, 17);
            this.lblCantidadVentas.TabIndex = 2;
            this.lblCantidadVentas.Text = "Cantidad de Productos Vendidos";
            this.lblCantidadVentas.Click += new System.EventHandler(this.lblCantidadVentas_Click);
            // 
            // lblNombreVentas
            // 
            this.lblNombreVentas.AutoSize = true;
            this.lblNombreVentas.Font = new System.Drawing.Font("Yu Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVentas.Location = new System.Drawing.Point(22, 78);
            this.lblNombreVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreVentas.Name = "lblNombreVentas";
            this.lblNombreVentas.Size = new System.Drawing.Size(157, 17);
            this.lblNombreVentas.TabIndex = 1;
            this.lblNombreVentas.Text = "Nombre del Producto";
            // 
            // lblIDVentas
            // 
            this.lblIDVentas.AutoSize = true;
            this.lblIDVentas.Font = new System.Drawing.Font("Yu Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDVentas.Location = new System.Drawing.Point(22, 34);
            this.lblIDVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDVentas.Name = "lblIDVentas";
            this.lblIDVentas.Size = new System.Drawing.Size(119, 17);
            this.lblIDVentas.TabIndex = 0;
            this.lblIDVentas.Text = "ID del Producto";
            this.lblIDVentas.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvConsultarVentas
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvConsultarVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultarVentas.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgvConsultarVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultarVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultarVentas.ColumnHeadersHeight = 48;
            this.dgvConsultarVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvConsultarVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Cantidad,
            this.FechaVenta});
            this.dgvConsultarVentas.EnableHeadersVisualStyles = false;
            this.dgvConsultarVentas.Location = new System.Drawing.Point(417, 64);
            this.dgvConsultarVentas.Name = "dgvConsultarVentas";
            this.dgvConsultarVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultarVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvConsultarVentas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvConsultarVentas.Size = new System.Drawing.Size(482, 230);
            this.dgvConsultarVentas.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID del Producto";
            this.ID.Name = "ID";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre del Producto";
            this.Column1.Name = "Column1";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad Vendida";
            this.Cantidad.Name = "Cantidad";
            // 
            // FechaVenta
            // 
            this.FechaVenta.HeaderText = "Fecha de Venta";
            this.FechaVenta.Name = "FechaVenta";
            // 
            // cmdFiltrar
            // 
            this.cmdFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFiltrar.Location = new System.Drawing.Point(534, 362);
            this.cmdFiltrar.Name = "cmdFiltrar";
            this.cmdFiltrar.Size = new System.Drawing.Size(229, 30);
            this.cmdFiltrar.TabIndex = 14;
            this.cmdFiltrar.Text = "Filtrar";
            this.cmdFiltrar.UseVisualStyleBackColor = true;
            this.cmdFiltrar.Click += new System.EventHandler(this.cmdFiltrar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(534, 327);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(229, 33);
            this.txtBusqueda.TabIndex = 14;
            // 
            // cbVentas
            // 
            this.cbVentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVentas.FormattingEnabled = true;
            this.cbVentas.Location = new System.Drawing.Point(432, 15);
            this.cbVentas.Name = "cbVentas";
            this.cbVentas.Size = new System.Drawing.Size(340, 29);
            this.cbVentas.TabIndex = 19;
            this.cbVentas.SelectedIndexChanged += new System.EventHandler(this.cbVentas_SelectedIndexChanged);
            // 
            // optProducto
            // 
            this.optProducto.AutoSize = true;
            this.optProducto.Checked = true;
            this.optProducto.Location = new System.Drawing.Point(552, 300);
            this.optProducto.Name = "optProducto";
            this.optProducto.Size = new System.Drawing.Size(95, 25);
            this.optProducto.TabIndex = 20;
            this.optProducto.TabStop = true;
            this.optProducto.Text = "Producto";
            this.optProducto.UseVisualStyleBackColor = true;
            // 
            // optCantidad
            // 
            this.optCantidad.AutoSize = true;
            this.optCantidad.Location = new System.Drawing.Point(669, 300);
            this.optCantidad.Name = "optCantidad";
            this.optCantidad.Size = new System.Drawing.Size(94, 25);
            this.optCantidad.TabIndex = 21;
            this.optCantidad.Text = "Cantidad";
            this.optCantidad.UseVisualStyleBackColor = true;
            // 
            // frmCargarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(940, 407);
            this.Controls.Add(this.optCantidad);
            this.Controls.Add(this.optProducto);
            this.Controls.Add(this.cmdFiltrar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cbVentas);
            this.Controls.Add(this.dgvConsultarVentas);
            this.Controls.Add(this.mrcCargaDeVentas);
            this.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCargarVentas";
            this.Text = "CargarVentas";
            this.Load += new System.EventHandler(this.frmCargarVentas_Load);
            this.mrcCargaDeVentas.ResumeLayout(false);
            this.mrcCargaDeVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcCargaDeVentas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCantidadVentas;
        private System.Windows.Forms.Label lblNombreVentas;
        private System.Windows.Forms.Label lblIDVentas;
        private System.Windows.Forms.NumericUpDown nudCantidadventas;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.TextBox txtIDVentas;
        private System.Windows.Forms.TextBox txtNombreproductoVentas;
        private System.Windows.Forms.Button cmdCargarVentas;
        private System.Windows.Forms.Button cmdVolver;
        public System.Windows.Forms.DataGridView dgvConsultarVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVenta;
        private System.Windows.Forms.Button cmdFiltrar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cbVentas;
        private System.Windows.Forms.RadioButton optProducto;
        private System.Windows.Forms.RadioButton optCantidad;
    }
}