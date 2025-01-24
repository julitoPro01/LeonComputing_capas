namespace computing_main
{
    partial class frmConsFacturasCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgFacturas = new System.Windows.Forms.DataGridView();
            this.Num_fac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_fac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_can = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRazSoc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRuc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ingrese codigo del cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de Fin:";
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIni.Location = new System.Drawing.Point(163, 196);
            this.dtpFecIni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(148, 23);
            this.dtpFecIni.TabIndex = 3;
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(470, 196);
            this.dtpFecFin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(148, 23);
            this.dtpFecFin.TabIndex = 5;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(680, 187);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(138, 42);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(848, 472);
            this.lblRegistros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(57, 26);
            this.lblRegistros.TabIndex = 9;
            this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(765, 472);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Registros:";
            // 
            // dtgFacturas
            // 
            this.dtgFacturas.AllowUserToAddRows = false;
            this.dtgFacturas.AllowUserToDeleteRows = false;
            this.dtgFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num_fac,
            this.Fec_fac,
            this.Fec_can,
            this.Total,
            this.Estado});
            this.dtgFacturas.Location = new System.Drawing.Point(27, 235);
            this.dtgFacturas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtgFacturas.Name = "dtgFacturas";
            this.dtgFacturas.ReadOnly = true;
            this.dtgFacturas.RowHeadersVisible = false;
            this.dtgFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgFacturas.Size = new System.Drawing.Size(878, 228);
            this.dtgFacturas.TabIndex = 7;
            // 
            // Num_fac
            // 
            this.Num_fac.DataPropertyName = "num_fac";
            this.Num_fac.HeaderText = "Nro. Factura";
            this.Num_fac.Name = "Num_fac";
            this.Num_fac.ReadOnly = true;
            // 
            // Fec_fac
            // 
            this.Fec_fac.DataPropertyName = "Fec_fac";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "d";
            this.Fec_fac.DefaultCellStyle = dataGridViewCellStyle1;
            this.Fec_fac.HeaderText = "Fec. Facturacion";
            this.Fec_fac.Name = "Fec_fac";
            this.Fec_fac.ReadOnly = true;
            // 
            // Fec_can
            // 
            this.Fec_can.DataPropertyName = "fec_can";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = "-";
            this.Fec_can.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fec_can.HeaderText = "Fec. Cancelacion";
            this.Fec_can.Name = "Fec_can";
            this.Fec_can.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "total";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "n2";
            this.Total.DefaultCellStyle = dataGridViewCellStyle3;
            this.Total.HeaderText = "Total (S/.)";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // txtCod
            // 
            this.txtCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCod.Location = new System.Drawing.Point(174, 14);
            this.txtCod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCod.MaxLength = 4;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(90, 23);
            this.txtCod.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Razon social:";
            // 
            // lblRazSoc
            // 
            this.lblRazSoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRazSoc.Location = new System.Drawing.Point(388, 14);
            this.lblRazSoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazSoc.Name = "lblRazSoc";
            this.lblRazSoc.Size = new System.Drawing.Size(534, 26);
            this.lblRazSoc.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "RUC:";
            // 
            // lblRuc
            // 
            this.lblRuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRuc.Location = new System.Drawing.Point(68, 55);
            this.lblRuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRuc.Name = "lblRuc";
            this.lblRuc.Size = new System.Drawing.Size(116, 26);
            this.lblRuc.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Direccion:";
            // 
            // lblDir
            // 
            this.lblDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDir.Location = new System.Drawing.Point(280, 57);
            this.lblDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(642, 26);
            this.lblDir.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 103);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Telefono:";
            // 
            // lblTel
            // 
            this.lblTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTel.Location = new System.Drawing.Point(90, 102);
            this.lblTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(94, 26);
            this.lblTel.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(205, 103);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "Ubicacion:";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUbicacion.Location = new System.Drawing.Point(280, 102);
            this.lblUbicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(473, 26);
            this.lblUbicacion.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(778, 103);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 15);
            this.label14.TabIndex = 11;
            this.label14.Text = "Estado:";
            // 
            // lblEstado
            // 
            this.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstado.Location = new System.Drawing.Point(835, 103);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(87, 25);
            this.lblEstado.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Deuda:";
            // 
            // lblDeuda
            // 
            this.lblDeuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeuda.Location = new System.Drawing.Point(90, 143);
            this.lblDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(94, 26);
            this.lblDeuda.TabIndex = 12;
            this.lblDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmConsFacturasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 532);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblDeuda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblRuc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblRazSoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.dtgFacturas);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtpFecFin);
            this.Controls.Add(this.dtpFecIni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(954, 571);
            this.MinimumSize = new System.Drawing.Size(907, 548);
            this.Name = "frmConsFacturasCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Facturas por Cliente";
            this.Load += new System.EventHandler(this.frmConsFacturasCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_fac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_fac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_can;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRazSoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRuc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDeuda;
    }
}