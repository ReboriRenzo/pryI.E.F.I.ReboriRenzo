using System;

namespace pryI.E.F.I.ReboriRenzo
{
    partial class frmCargaDeVentas
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
            this.mrcVentas = new System.Windows.Forms.GroupBox();
            this.cmdConsultas = new System.Windows.Forms.Button();
            this.cmdCargarVenta = new System.Windows.Forms.Button();
            this.nudCantidadVentas = new System.Windows.Forms.NumericUpDown();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dtpFechaVentas = new System.Windows.Forms.DateTimePicker();
            this.lblIDVentas = new System.Windows.Forms.Label();
            this.lblNombreVentas = new System.Windows.Forms.Label();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.txtIDVentas = new System.Windows.Forms.TextBox();
            this.txtNombreVentas = new System.Windows.Forms.TextBox();
            this.mrcVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcVentas
            // 
            this.mrcVentas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mrcVentas.Controls.Add(this.cmdConsultas);
            this.mrcVentas.Controls.Add(this.cmdCargarVenta);
            this.mrcVentas.Controls.Add(this.nudCantidadVentas);
            this.mrcVentas.Controls.Add(this.cmdCancelar);
            this.mrcVentas.Controls.Add(this.lblCantidad);
            this.mrcVentas.Controls.Add(this.dtpFechaVentas);
            this.mrcVentas.Controls.Add(this.lblIDVentas);
            this.mrcVentas.Controls.Add(this.lblNombreVentas);
            this.mrcVentas.Controls.Add(this.lblFechaVenta);
            this.mrcVentas.Controls.Add(this.txtIDVentas);
            this.mrcVentas.Controls.Add(this.txtNombreVentas);
            this.mrcVentas.Font = new System.Drawing.Font("Yu Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcVentas.Location = new System.Drawing.Point(12, 12);
            this.mrcVentas.Name = "mrcVentas";
            this.mrcVentas.Size = new System.Drawing.Size(336, 265);
            this.mrcVentas.TabIndex = 12;
            this.mrcVentas.TabStop = false;
            this.mrcVentas.Text = "Datos de tu Venta";
            // 
            // cmdConsultas
            // 
            this.cmdConsultas.BackColor = System.Drawing.Color.Tan;
            this.cmdConsultas.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultas.Location = new System.Drawing.Point(104, 226);
            this.cmdConsultas.Name = "cmdConsultas";
            this.cmdConsultas.Size = new System.Drawing.Size(125, 36);
            this.cmdConsultas.TabIndex = 14;
            this.cmdConsultas.Text = "Consultar Venta";
            this.cmdConsultas.UseVisualStyleBackColor = false;
            this.cmdConsultas.Click += new System.EventHandler(this.cmdConsultas_Click);
            // 
            // cmdCargarVenta
            // 
            this.cmdCargarVenta.BackColor = System.Drawing.Color.Tan;
            this.cmdCargarVenta.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargarVenta.Location = new System.Drawing.Point(235, 226);
            this.cmdCargarVenta.Name = "cmdCargarVenta";
            this.cmdCargarVenta.Size = new System.Drawing.Size(95, 36);
            this.cmdCargarVenta.TabIndex = 13;
            this.cmdCargarVenta.Text = "Cargar";
            this.cmdCargarVenta.UseVisualStyleBackColor = false;
            this.cmdCargarVenta.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // nudCantidadVentas
            // 
            this.nudCantidadVentas.BackColor = System.Drawing.Color.DarkGray;
            this.nudCantidadVentas.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidadVentas.Location = new System.Drawing.Point(129, 126);
            this.nudCantidadVentas.Name = "nudCantidadVentas";
            this.nudCantidadVentas.Size = new System.Drawing.Size(201, 28);
            this.nudCantidadVentas.TabIndex = 13;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.Color.Tan;
            this.cmdCancelar.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(3, 226);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(95, 36);
            this.cmdCancelar.TabIndex = 12;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(26, 126);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(72, 21);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Cantidad";
            // 
            // dtpFechaVentas
            // 
            this.dtpFechaVentas.CalendarMonthBackground = System.Drawing.Color.DarkGray;
            this.dtpFechaVentas.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVentas.Location = new System.Drawing.Point(23, 192);
            this.dtpFechaVentas.Name = "dtpFechaVentas";
            this.dtpFechaVentas.Size = new System.Drawing.Size(297, 28);
            this.dtpFechaVentas.TabIndex = 7;
            // 
            // lblIDVentas
            // 
            this.lblIDVentas.AutoSize = true;
            this.lblIDVentas.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDVentas.Location = new System.Drawing.Point(6, 35);
            this.lblIDVentas.Name = "lblIDVentas";
            this.lblIDVentas.Size = new System.Drawing.Size(117, 21);
            this.lblIDVentas.TabIndex = 1;
            this.lblIDVentas.Text = "ID del producto";
            // 
            // lblNombreVentas
            // 
            this.lblNombreVentas.AutoSize = true;
            this.lblNombreVentas.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVentas.Location = new System.Drawing.Point(30, 84);
            this.lblNombreVentas.Name = "lblNombreVentas";
            this.lblNombreVentas.Size = new System.Drawing.Size(68, 21);
            this.lblNombreVentas.TabIndex = 2;
            this.lblNombreVentas.Text = "Nombre";
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVenta.Location = new System.Drawing.Point(99, 164);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(141, 25);
            this.lblFechaVenta.TabIndex = 3;
            this.lblFechaVenta.Text = "Fecha de Venta";
            // 
            // txtIDVentas
            // 
            this.txtIDVentas.BackColor = System.Drawing.Color.DarkGray;
            this.txtIDVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDVentas.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDVentas.Location = new System.Drawing.Point(129, 28);
            this.txtIDVentas.Name = "txtIDVentas";
            this.txtIDVentas.Size = new System.Drawing.Size(203, 28);
            this.txtIDVentas.TabIndex = 6;
            // 
            // txtNombreVentas
            // 
            this.txtNombreVentas.BackColor = System.Drawing.Color.DarkGray;
            this.txtNombreVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreVentas.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreVentas.Location = new System.Drawing.Point(129, 77);
            this.txtNombreVentas.Name = "txtNombreVentas";
            this.txtNombreVentas.Size = new System.Drawing.Size(201, 28);
            this.txtNombreVentas.TabIndex = 5;
            // 
            // frmCargaDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 287);
            this.Controls.Add(this.mrcVentas);
            this.Name = "frmCargaDeVentas";
            this.Text = "Carga de Ventas";
            this.Load += new System.EventHandler(this.frmCargaDeVentas_Load);
            this.mrcVentas.ResumeLayout(false);
            this.mrcVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadVentas)).EndInit();
            this.ResumeLayout(false);

        }

        private void frmCargaDeVentas_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdConsultas_Click(object sender, EventArgs e)
        {
            frmConsultarVentas frmConsultarVentas = new frmConsultarVentas();
            frmConsultarVentas.ShowDialog();
            this.Hide();
        }

        #endregion

        private System.Windows.Forms.GroupBox mrcVentas;
        private System.Windows.Forms.Button cmdConsultas;
        private System.Windows.Forms.Button cmdCargarVenta;
        private System.Windows.Forms.NumericUpDown nudCantidadVentas;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DateTimePicker dtpFechaVentas;
        private System.Windows.Forms.Label lblIDVentas;
        private System.Windows.Forms.Label lblNombreVentas;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.TextBox txtIDVentas;
        private System.Windows.Forms.TextBox txtNombreVentas;
    }
}