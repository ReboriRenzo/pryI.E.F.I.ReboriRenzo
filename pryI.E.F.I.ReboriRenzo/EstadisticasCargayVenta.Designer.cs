namespace pryI.E.F.I.ReboriRenzo
{
    partial class frmEstadisticasCargayVenta
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
            this.dgvEstadisticas = new System.Windows.Forms.DataGridView();
            this.cmdAñadir = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstadisticas
            // 
            this.dgvEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadisticas.Location = new System.Drawing.Point(24, 12);
            this.dgvEstadisticas.Name = "dgvEstadisticas";
            this.dgvEstadisticas.Size = new System.Drawing.Size(470, 434);
            this.dgvEstadisticas.TabIndex = 0;
            // 
            // cmdAñadir
            // 
            this.cmdAñadir.Location = new System.Drawing.Point(511, 25);
            this.cmdAñadir.Name = "cmdAñadir";
            this.cmdAñadir.Size = new System.Drawing.Size(94, 33);
            this.cmdAñadir.TabIndex = 1;
            this.cmdAñadir.Text = "button1";
            this.cmdAñadir.UseVisualStyleBackColor = true;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(511, 75);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(94, 33);
            this.cmdEliminar.TabIndex = 2;
            this.cmdEliminar.Text = "button2";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            // 
            // frmEstadisticasCargayVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 458);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdAñadir);
            this.Controls.Add(this.dgvEstadisticas);
            this.Name = "frmEstadisticasCargayVenta";
            this.Text = "Estadisticas Productos";
            this.Load += new System.EventHandler(this.frmEstadisticasCargayVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstadisticas;
        private System.Windows.Forms.Button cmdAñadir;
        private System.Windows.Forms.Button cmdEliminar;
    }
}