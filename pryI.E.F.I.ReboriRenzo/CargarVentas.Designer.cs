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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mrcCargaDeVentas = new System.Windows.Forms.GroupBox();
            this.cmdCargarVentas = new System.Windows.Forms.Button();
            this.cmdConsultarVentas = new System.Windows.Forms.Button();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.txtIDVentas = new System.Windows.Forms.TextBox();
            this.txtNombreproductoVentas = new System.Windows.Forms.TextBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCantidadVentas = new System.Windows.Forms.Label();
            this.lblNombreVentas = new System.Windows.Forms.Label();
            this.lblIDVentas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvConsultarVentas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcCargaDeVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcCargaDeVentas
            // 
            this.mrcCargaDeVentas.Controls.Add(this.cmdCargarVentas);
            this.mrcCargaDeVentas.Controls.Add(this.cmdConsultarVentas);
            this.mrcCargaDeVentas.Controls.Add(this.cmdVolver);
            this.mrcCargaDeVentas.Controls.Add(this.dtpFechaVenta);
            this.mrcCargaDeVentas.Controls.Add(this.txtIDVentas);
            this.mrcCargaDeVentas.Controls.Add(this.txtNombreproductoVentas);
            this.mrcCargaDeVentas.Controls.Add(this.nudCantidad);
            this.mrcCargaDeVentas.Controls.Add(this.label4);
            this.mrcCargaDeVentas.Controls.Add(this.lblCantidadVentas);
            this.mrcCargaDeVentas.Controls.Add(this.lblNombreVentas);
            this.mrcCargaDeVentas.Controls.Add(this.lblIDVentas);
            this.mrcCargaDeVentas.Controls.Add(this.pictureBox1);
            this.mrcCargaDeVentas.Font = new System.Drawing.Font("Yu Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcCargaDeVentas.Location = new System.Drawing.Point(34, 8);
            this.mrcCargaDeVentas.Margin = new System.Windows.Forms.Padding(5);
            this.mrcCargaDeVentas.Name = "mrcCargaDeVentas";
            this.mrcCargaDeVentas.Padding = new System.Windows.Forms.Padding(5);
            this.mrcCargaDeVentas.Size = new System.Drawing.Size(389, 217);
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
            this.cmdCargarVentas.Location = new System.Drawing.Point(255, 223);
            this.cmdCargarVentas.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCargarVentas.Name = "cmdCargarVentas";
            this.cmdCargarVentas.Size = new System.Drawing.Size(103, 32);
            this.cmdCargarVentas.TabIndex = 12;
            this.cmdCargarVentas.Text = "Cargar";
            this.cmdCargarVentas.UseVisualStyleBackColor = false;
            this.cmdCargarVentas.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // cmdConsultarVentas
            // 
            this.cmdConsultarVentas.BackColor = System.Drawing.Color.Tan;
            this.cmdConsultarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdConsultarVentas.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultarVentas.Location = new System.Drawing.Point(136, 223);
            this.cmdConsultarVentas.Margin = new System.Windows.Forms.Padding(4);
            this.cmdConsultarVentas.Name = "cmdConsultarVentas";
            this.cmdConsultarVentas.Size = new System.Drawing.Size(105, 32);
            this.cmdConsultarVentas.TabIndex = 11;
            this.cmdConsultarVentas.Text = "Consultar";
            this.cmdConsultarVentas.UseVisualStyleBackColor = false;
            this.cmdConsultarVentas.Click += new System.EventHandler(this.cmdConsultarVentas_Click);
            // 
            // cmdVolver
            // 
            this.cmdVolver.BackColor = System.Drawing.Color.Tan;
            this.cmdVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdVolver.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVolver.Location = new System.Drawing.Point(25, 223);
            this.cmdVolver.Margin = new System.Windows.Forms.Padding(4);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(103, 32);
            this.cmdVolver.TabIndex = 10;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = false;
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVenta.Location = new System.Drawing.Point(13, 187);
            this.dtpFechaVenta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(363, 28);
            this.dtpFechaVenta.TabIndex = 9;
            // 
            // txtIDVentas
            // 
            this.txtIDVentas.BackColor = System.Drawing.Color.DarkGray;
            this.txtIDVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDVentas.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDVentas.Location = new System.Drawing.Point(142, 30);
            this.txtIDVentas.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDVentas.Name = "txtIDVentas";
            this.txtIDVentas.Size = new System.Drawing.Size(234, 28);
            this.txtIDVentas.TabIndex = 8;
            // 
            // txtNombreproductoVentas
            // 
            this.txtNombreproductoVentas.BackColor = System.Drawing.Color.DarkGray;
            this.txtNombreproductoVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreproductoVentas.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreproductoVentas.Location = new System.Drawing.Point(174, 76);
            this.txtNombreproductoVentas.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreproductoVentas.Name = "txtNombreproductoVentas";
            this.txtNombreproductoVentas.Size = new System.Drawing.Size(202, 28);
            this.txtNombreproductoVentas.TabIndex = 7;
            // 
            // nudCantidad
            // 
            this.nudCantidad.BackColor = System.Drawing.Color.DarkGray;
            this.nudCantidad.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(255, 126);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(121, 28);
            this.nudCantidad.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de venta";
            // 
            // lblCantidadVentas
            // 
            this.lblCantidadVentas.AutoSize = true;
            this.lblCantidadVentas.Font = new System.Drawing.Font("Yu Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadVentas.Location = new System.Drawing.Point(3, 128);
            this.lblCantidadVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadVentas.Name = "lblCantidadVentas";
            this.lblCantidadVentas.Size = new System.Drawing.Size(238, 17);
            this.lblCantidadVentas.TabIndex = 2;
            this.lblCantidadVentas.Text = "Cantidad de Productos Vendidos";
            // 
            // lblNombreVentas
            // 
            this.lblNombreVentas.AutoSize = true;
            this.lblNombreVentas.Font = new System.Drawing.Font("Yu Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVentas.Location = new System.Drawing.Point(9, 78);
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
            this.lblIDVentas.Location = new System.Drawing.Point(9, 32);
            this.lblIDVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDVentas.Name = "lblIDVentas";
            this.lblIDVentas.Size = new System.Drawing.Size(119, 17);
            this.lblIDVentas.TabIndex = 0;
            this.lblIDVentas.Text = "ID del Producto";
            this.lblIDVentas.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(454, 265);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mrcCargaDeVentas);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(446, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvConsultarVentas);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(446, 231);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvConsultarVentas
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvConsultarVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultarVentas.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgvConsultarVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultarVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultarVentas.ColumnHeadersHeight = 40;
            this.dgvConsultarVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvConsultarVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Cantidad,
            this.FechaVenta});
            this.dgvConsultarVentas.EnableHeadersVisualStyles = false;
            this.dgvConsultarVentas.Location = new System.Drawing.Point(2, 6);
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
            this.dgvConsultarVentas.Size = new System.Drawing.Size(444, 222);
            this.dgvConsultarVentas.TabIndex = 1;
            this.dgvConsultarVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultarVentas_CellContentClick);
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
            // frmCargarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 282);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCargarVentas";
            this.Text = "CargarVentas";
            this.Load += new System.EventHandler(this.frmCargarVentas_Load);
            this.mrcCargaDeVentas.ResumeLayout(false);
            this.mrcCargaDeVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcCargaDeVentas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCantidadVentas;
        private System.Windows.Forms.Label lblNombreVentas;
        private System.Windows.Forms.Label lblIDVentas;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.TextBox txtIDVentas;
        private System.Windows.Forms.TextBox txtNombreproductoVentas;
        private System.Windows.Forms.Button cmdCargarVentas;
        private System.Windows.Forms.Button cmdConsultarVentas;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.DataGridView dgvConsultarVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVenta;
    }
}