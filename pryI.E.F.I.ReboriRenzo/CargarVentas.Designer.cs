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
            this.mrcCargaDeVentas = new System.Windows.Forms.GroupBox();
            this.lblIDVentas = new System.Windows.Forms.Label();
            this.lblNombreVentas = new System.Windows.Forms.Label();
            this.lblCantidadVentas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtNombreproductoVentas = new System.Windows.Forms.TextBox();
            this.txtIDVentas = new System.Windows.Forms.TextBox();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.cmdConsultarVentas = new System.Windows.Forms.Button();
            this.cmdCargarVentas = new System.Windows.Forms.Button();
            this.mrcCargaDeVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
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
            this.mrcCargaDeVentas.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcCargaDeVentas.Location = new System.Drawing.Point(15, 32);
            this.mrcCargaDeVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcCargaDeVentas.Name = "mrcCargaDeVentas";
            this.mrcCargaDeVentas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcCargaDeVentas.Size = new System.Drawing.Size(379, 259);
            this.mrcCargaDeVentas.TabIndex = 0;
            this.mrcCargaDeVentas.TabStop = false;
            this.mrcCargaDeVentas.Text = "Carga De Ventas";
            this.mrcCargaDeVentas.Enter += new System.EventHandler(this.mrcCargaDeVentas_Enter);
            // 
            // lblIDVentas
            // 
            this.lblIDVentas.AutoSize = true;
            this.lblIDVentas.Font = new System.Drawing.Font("Yu Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDVentas.Location = new System.Drawing.Point(7, 36);
            this.lblIDVentas.Name = "lblIDVentas";
            this.lblIDVentas.Size = new System.Drawing.Size(119, 17);
            this.lblIDVentas.TabIndex = 0;
            this.lblIDVentas.Text = "ID del Producto";
            this.lblIDVentas.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombreVentas
            // 
            this.lblNombreVentas.AutoSize = true;
            this.lblNombreVentas.Font = new System.Drawing.Font("Yu Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVentas.Location = new System.Drawing.Point(7, 79);
            this.lblNombreVentas.Name = "lblNombreVentas";
            this.lblNombreVentas.Size = new System.Drawing.Size(157, 17);
            this.lblNombreVentas.TabIndex = 1;
            this.lblNombreVentas.Text = "Nombre del Producto";
            // 
            // lblCantidadVentas
            // 
            this.lblCantidadVentas.AutoSize = true;
            this.lblCantidadVentas.Font = new System.Drawing.Font("Yu Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadVentas.Location = new System.Drawing.Point(7, 116);
            this.lblCantidadVentas.Name = "lblCantidadVentas";
            this.lblCantidadVentas.Size = new System.Drawing.Size(238, 17);
            this.lblCantidadVentas.TabIndex = 2;
            this.lblCantidadVentas.Text = "Cantidad de Productos Vendidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de venta";
            // 
            // nudCantidad
            // 
            this.nudCantidad.BackColor = System.Drawing.Color.DarkGray;
            this.nudCantidad.Location = new System.Drawing.Point(251, 114);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 28);
            this.nudCantidad.TabIndex = 4;
            // 
            // txtNombreproductoVentas
            // 
            this.txtNombreproductoVentas.BackColor = System.Drawing.Color.DarkGray;
            this.txtNombreproductoVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreproductoVentas.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreproductoVentas.Location = new System.Drawing.Point(198, 77);
            this.txtNombreproductoVentas.Name = "txtNombreproductoVentas";
            this.txtNombreproductoVentas.Size = new System.Drawing.Size(173, 28);
            this.txtNombreproductoVentas.TabIndex = 7;
            // 
            // txtIDVentas
            // 
            this.txtIDVentas.BackColor = System.Drawing.Color.DarkGray;
            this.txtIDVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDVentas.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDVentas.Location = new System.Drawing.Point(149, 34);
            this.txtIDVentas.Name = "txtIDVentas";
            this.txtIDVentas.Size = new System.Drawing.Size(222, 28);
            this.txtIDVentas.TabIndex = 8;
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Location = new System.Drawing.Point(10, 174);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(361, 28);
            this.dtpFechaVenta.TabIndex = 9;
            // 
            // cmdVolver
            // 
            this.cmdVolver.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVolver.Location = new System.Drawing.Point(31, 208);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(95, 31);
            this.cmdVolver.TabIndex = 10;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            // 
            // cmdConsultarVentas
            // 
            this.cmdConsultarVentas.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultarVentas.Location = new System.Drawing.Point(132, 207);
            this.cmdConsultarVentas.Name = "cmdConsultarVentas";
            this.cmdConsultarVentas.Size = new System.Drawing.Size(99, 32);
            this.cmdConsultarVentas.TabIndex = 11;
            this.cmdConsultarVentas.Text = "Consultar";
            this.cmdConsultarVentas.UseVisualStyleBackColor = true;
            this.cmdConsultarVentas.Click += new System.EventHandler(this.cmdConsultarVentas_Click);
            // 
            // cmdCargarVentas
            // 
            this.cmdCargarVentas.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargarVentas.Location = new System.Drawing.Point(237, 208);
            this.cmdCargarVentas.Name = "cmdCargarVentas";
            this.cmdCargarVentas.Size = new System.Drawing.Size(95, 31);
            this.cmdCargarVentas.TabIndex = 12;
            this.cmdCargarVentas.Text = "Cargar";
            this.cmdCargarVentas.UseVisualStyleBackColor = true;
            this.cmdCargarVentas.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // frmCargarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 300);
            this.Controls.Add(this.mrcCargaDeVentas);
            this.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCargarVentas";
            this.Text = "CargarVentas";
            this.mrcCargaDeVentas.ResumeLayout(false);
            this.mrcCargaDeVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
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
    }
}