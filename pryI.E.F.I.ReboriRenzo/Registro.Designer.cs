namespace pryI.E.F.I.ReboriRenzo
{
    partial class frmRegistro
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.mrcRegistro = new System.Windows.Forms.GroupBox();
            this.cmdConultar = new System.Windows.Forms.Button();
            this.tabRegistro = new System.Windows.Forms.TabControl();
            this.Registro = new System.Windows.Forms.TabPage();
            this.tabConsultas = new System.Windows.Forms.TabPage();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.mrcRegistro.SuspendLayout();
            this.tabRegistro.SuspendLayout();
            this.Registro.SuspendLayout();
            this.tabConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(6, 35);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(117, 21);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID del producto";
            this.lblID.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 77);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 21);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistro.Location = new System.Drawing.Point(85, 168);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(132, 21);
            this.lblFechaRegistro.TabIndex = 3;
            this.lblFechaRegistro.Text = "Fecha de Registro";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(89, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 28);
            this.txtNombre.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(129, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(173, 28);
            this.txtID.TabIndex = 6;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(3, 192);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(304, 28);
            this.dtpFecha.TabIndex = 7;
            // 
            // mrcRegistro
            // 
            this.mrcRegistro.Controls.Add(this.cmdRegistrar);
            this.mrcRegistro.Controls.Add(this.nudCantidad);
            this.mrcRegistro.Controls.Add(this.cmdCancelar);
            this.mrcRegistro.Controls.Add(this.label1);
            this.mrcRegistro.Controls.Add(this.dtpFecha);
            this.mrcRegistro.Controls.Add(this.lblID);
            this.mrcRegistro.Controls.Add(this.cmdConultar);
            this.mrcRegistro.Controls.Add(this.lblNombre);
            this.mrcRegistro.Controls.Add(this.lblFechaRegistro);
            this.mrcRegistro.Controls.Add(this.txtID);
            this.mrcRegistro.Controls.Add(this.txtNombre);
            this.mrcRegistro.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcRegistro.Location = new System.Drawing.Point(6, 6);
            this.mrcRegistro.Name = "mrcRegistro";
            this.mrcRegistro.Size = new System.Drawing.Size(308, 275);
            this.mrcRegistro.TabIndex = 10;
            this.mrcRegistro.TabStop = false;
            this.mrcRegistro.Text = "Datos de Registro";
            // 
            // cmdConultar
            // 
            this.cmdConultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdConultar.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConultar.Location = new System.Drawing.Point(106, 226);
            this.cmdConultar.Name = "cmdConultar";
            this.cmdConultar.Size = new System.Drawing.Size(95, 36);
            this.cmdConultar.TabIndex = 11;
            this.cmdConultar.Text = "Consultar";
            this.cmdConultar.UseVisualStyleBackColor = false;
            this.cmdConultar.Click += new System.EventHandler(this.cmdConultar_Click);
            // 
            // tabRegistro
            // 
            this.tabRegistro.Controls.Add(this.Registro);
            this.tabRegistro.Controls.Add(this.tabConsultas);
            this.tabRegistro.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRegistro.Location = new System.Drawing.Point(12, 12);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.SelectedIndex = 0;
            this.tabRegistro.Size = new System.Drawing.Size(327, 318);
            this.tabRegistro.TabIndex = 8;
            // 
            // Registro
            // 
            this.Registro.Controls.Add(this.mrcRegistro);
            this.Registro.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registro.Location = new System.Drawing.Point(4, 26);
            this.Registro.Name = "Registro";
            this.Registro.Padding = new System.Windows.Forms.Padding(3);
            this.Registro.Size = new System.Drawing.Size(319, 288);
            this.Registro.TabIndex = 0;
            this.Registro.Text = "Registro";
            this.Registro.UseVisualStyleBackColor = true;
            // 
            // tabConsultas
            // 
            this.tabConsultas.Controls.Add(this.dataGridView1);
            this.tabConsultas.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConsultas.Location = new System.Drawing.Point(4, 26);
            this.tabConsultas.Name = "tabConsultas";
            this.tabConsultas.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultas.Size = new System.Drawing.Size(319, 234);
            this.tabConsultas.TabIndex = 1;
            this.tabConsultas.Text = "Consulta";
            this.tabConsultas.UseVisualStyleBackColor = true;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdCancelar.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(5, 226);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(95, 36);
            this.cmdCancelar.TabIndex = 12;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(307, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdRegistrar.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrar.Location = new System.Drawing.Point(207, 226);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(95, 36);
            this.cmdRegistrar.TabIndex = 13;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = false;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(89, 126);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(86, 28);
            this.nudCantidad.TabIndex = 13;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 352);
            this.Controls.Add(this.tabRegistro);
            this.Name = "frmRegistro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.mrcRegistro.ResumeLayout(false);
            this.mrcRegistro.PerformLayout();
            this.tabRegistro.ResumeLayout(false);
            this.Registro.ResumeLayout(false);
            this.tabConsultas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox mrcRegistro;
        private System.Windows.Forms.Button cmdConultar;
        private System.Windows.Forms.TabControl tabRegistro;
        private System.Windows.Forms.TabPage Registro;
        private System.Windows.Forms.TabPage tabConsultas;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label label1;
    }
}