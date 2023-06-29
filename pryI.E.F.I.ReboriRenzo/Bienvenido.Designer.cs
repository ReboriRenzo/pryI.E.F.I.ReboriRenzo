namespace pryI.E.F.I.ReboriRenzo
{
    partial class frmBienvenido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienvenido));
            this.cmdRegistrarProductos = new System.Windows.Forms.Button();
            this.lblBienvenidos = new System.Windows.Forms.Label();
            this.cmdCargarVentas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdRegistrarProductos
            // 
            this.cmdRegistrarProductos.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmdRegistrarProductos.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrarProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdRegistrarProductos.Location = new System.Drawing.Point(6, 158);
            this.cmdRegistrarProductos.Name = "cmdRegistrarProductos";
            this.cmdRegistrarProductos.Size = new System.Drawing.Size(137, 45);
            this.cmdRegistrarProductos.TabIndex = 0;
            this.cmdRegistrarProductos.Text = "Registrar Productos";
            this.cmdRegistrarProductos.UseVisualStyleBackColor = false;
            this.cmdRegistrarProductos.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBienvenidos
            // 
            this.lblBienvenidos.AutoSize = true;
            this.lblBienvenidos.BackColor = System.Drawing.Color.Tan;
            this.lblBienvenidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBienvenidos.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidos.ForeColor = System.Drawing.Color.Black;
            this.lblBienvenidos.Location = new System.Drawing.Point(57, 114);
            this.lblBienvenidos.Name = "lblBienvenidos";
            this.lblBienvenidos.Size = new System.Drawing.Size(173, 33);
            this.lblBienvenidos.TabIndex = 2;
            this.lblBienvenidos.Text = "PRODUCTOS";
            // 
            // cmdCargarVentas
            // 
            this.cmdCargarVentas.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmdCargarVentas.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargarVentas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdCargarVentas.Location = new System.Drawing.Point(149, 158);
            this.cmdCargarVentas.Name = "cmdCargarVentas";
            this.cmdCargarVentas.Size = new System.Drawing.Size(137, 45);
            this.cmdCargarVentas.TabIndex = 3;
            this.cmdCargarVentas.Text = "Cargar Ventas de Productos";
            this.cmdCargarVentas.UseVisualStyleBackColor = false;
            this.cmdCargarVentas.Click += new System.EventHandler(this.cmdCargarProductos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmBienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(298, 210);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdCargarVentas);
            this.Controls.Add(this.lblBienvenidos);
            this.Controls.Add(this.cmdRegistrarProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBienvenido";
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.frmBienvenido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRegistrarProductos;
        private System.Windows.Forms.Label lblBienvenidos;
        private System.Windows.Forms.Button cmdCargarVentas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}