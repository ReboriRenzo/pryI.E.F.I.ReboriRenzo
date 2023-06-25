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
            this.cmdRegistrarProductos = new System.Windows.Forms.Button();
            this.lblBienvenidos = new System.Windows.Forms.Label();
            this.cmdCargarProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdRegistrarProductos
            // 
            this.cmdRegistrarProductos.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrarProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdRegistrarProductos.Location = new System.Drawing.Point(22, 53);
            this.cmdRegistrarProductos.Name = "cmdRegistrarProductos";
            this.cmdRegistrarProductos.Size = new System.Drawing.Size(137, 45);
            this.cmdRegistrarProductos.TabIndex = 0;
            this.cmdRegistrarProductos.Text = "Registrar Productos";
            this.cmdRegistrarProductos.UseVisualStyleBackColor = true;
            this.cmdRegistrarProductos.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBienvenidos
            // 
            this.lblBienvenidos.AutoSize = true;
            this.lblBienvenidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBienvenidos.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidos.ForeColor = System.Drawing.Color.Black;
            this.lblBienvenidos.Location = new System.Drawing.Point(12, 9);
            this.lblBienvenidos.Name = "lblBienvenidos";
            this.lblBienvenidos.Size = new System.Drawing.Size(309, 33);
            this.lblBienvenidos.TabIndex = 2;
            this.lblBienvenidos.Text = "CARGAS DE PRODUCTOS";
            // 
            // cmdCargarProductos
            // 
            this.cmdCargarProductos.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargarProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdCargarProductos.Location = new System.Drawing.Point(175, 53);
            this.cmdCargarProductos.Name = "cmdCargarProductos";
            this.cmdCargarProductos.Size = new System.Drawing.Size(137, 45);
            this.cmdCargarProductos.TabIndex = 3;
            this.cmdCargarProductos.Text = "Cargar Productos";
            this.cmdCargarProductos.UseVisualStyleBackColor = true;
            this.cmdCargarProductos.Click += new System.EventHandler(this.cmdCargarProductos_Click);
            // 
            // frmBienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 117);
            this.Controls.Add(this.cmdCargarProductos);
            this.Controls.Add(this.lblBienvenidos);
            this.Controls.Add(this.cmdRegistrarProductos);
            this.Name = "frmBienvenido";
            this.Text = "Bienvenido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRegistrarProductos;
        private System.Windows.Forms.Label lblBienvenidos;
        private System.Windows.Forms.Button cmdCargarProductos;
    }
}