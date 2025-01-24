namespace Computing_main
{
    partial class ListarEvento
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dtgDatos = new DataGridView();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            txtFiltro = new TextBox();
            label2 = new Label();
            lblRegistros = new Label();
            idEvento = new DataGridViewTextBoxColumn();
            evento = new DataGridViewTextBoxColumn();
            fecInicio = new DataGridViewTextBoxColumn();
            fecFin = new DataGridViewTextBoxColumn();
            frecuencia = new DataGridViewTextBoxColumn();
            turno = new DataGridViewTextBoxColumn();
            presupuesto = new DataGridViewTextBoxColumn();
            direcLocal = new DataGridViewTextBoxColumn();
            cuposProg = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { idEvento, evento, fecInicio, fecFin, frecuencia, turno, presupuesto, direcLocal, cuposProg });
            dtgDatos.Location = new Point(14, 92);
            dtgDatos.Margin = new Padding(3, 4, 3, 4);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.RowHeadersWidth = 51;
            dtgDatos.RowTemplate.Height = 25;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1110, 453);
            dtgDatos.TabIndex = 0;
            dtgDatos.CellFormatting += dtgDatos_CellFormatting;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(582, 621);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(111, 43);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(714, 621);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(111, 43);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(846, 621);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(111, 43);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(1013, 621);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(111, 43);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 20);
            label1.Name = "label1";
            label1.Size = new Size(179, 20);
            label1.TabIndex = 2;
            label1.Text = "Ingrese filtro por nombre:";
            label1.Click += label1_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(199, 17);
            txtFiltro.Margin = new Padding(3, 4, 3, 4);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(358, 27);
            txtFiltro.TabIndex = 3;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(937, 561);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(1027, 561);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(96, 29);
            lblRegistros.TabIndex = 2;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // idEvento
            // 
            idEvento.DataPropertyName = "idEvento";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.NullValue = null;
            idEvento.DefaultCellStyle = dataGridViewCellStyle1;
            idEvento.HeaderText = "CODIGO";
            idEvento.MinimumWidth = 6;
            idEvento.Name = "idEvento";
            idEvento.ReadOnly = true;
            idEvento.Width = 125;
            // 
            // evento
            // 
            evento.DataPropertyName = "evento";
            evento.HeaderText = "EVENTO";
            evento.MinimumWidth = 6;
            evento.Name = "evento";
            evento.ReadOnly = true;
            evento.Width = 125;
            // 
            // fecInicio
            // 
            fecInicio.DataPropertyName = "fecInicio";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "d";
            fecInicio.DefaultCellStyle = dataGridViewCellStyle2;
            fecInicio.HeaderText = "FECHA INICIO";
            fecInicio.MinimumWidth = 6;
            fecInicio.Name = "fecInicio";
            fecInicio.ReadOnly = true;
            fecInicio.Width = 125;
            // 
            // fecFin
            // 
            fecFin.DataPropertyName = "fecFin";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "d";
            fecFin.DefaultCellStyle = dataGridViewCellStyle3;
            fecFin.HeaderText = "FECHA FIN";
            fecFin.MinimumWidth = 6;
            fecFin.Name = "fecFin";
            fecFin.ReadOnly = true;
            fecFin.Width = 125;
            // 
            // frecuencia
            // 
            frecuencia.DataPropertyName = "frecuencia";
            frecuencia.HeaderText = "FRECUENCIA";
            frecuencia.MinimumWidth = 6;
            frecuencia.Name = "frecuencia";
            frecuencia.ReadOnly = true;
            frecuencia.Width = 125;
            // 
            // turno
            // 
            turno.DataPropertyName = "turno";
            turno.HeaderText = "TURNO";
            turno.MinimumWidth = 6;
            turno.Name = "turno";
            turno.ReadOnly = true;
            turno.Width = 125;
            // 
            // presupuesto
            // 
            presupuesto.DataPropertyName = "presupuesto";
            presupuesto.HeaderText = "PRESUPUESTO";
            presupuesto.MinimumWidth = 6;
            presupuesto.Name = "presupuesto";
            presupuesto.ReadOnly = true;
            presupuesto.Width = 125;
            // 
            // direcLocal
            // 
            direcLocal.DataPropertyName = "direcLocal";
            direcLocal.HeaderText = "DIRECCIÓN LOCAL";
            direcLocal.MinimumWidth = 6;
            direcLocal.Name = "direcLocal";
            direcLocal.ReadOnly = true;
            direcLocal.Width = 125;
            // 
            // cuposProg
            // 
            cuposProg.DataPropertyName = "cuposProg";
            cuposProg.HeaderText = "CUPOS PROGRAMADOS";
            cuposProg.MinimumWidth = 6;
            cuposProg.Name = "cuposProg";
            cuposProg.ReadOnly = true;
            cuposProg.Width = 125;
            // 
            // ListarEvento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 680);
            Controls.Add(txtFiltro);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(dtgDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ListarEvento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Eventos";
            Load += formEvento_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDatos;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnCerrar;
        private Label label1;
        private TextBox txtFiltro;
        private Label label2;
        private Label lblRegistros;
        private DataGridViewTextBoxColumn idEvento;
        private DataGridViewTextBoxColumn evento;
        private DataGridViewTextBoxColumn fecInicio;
        private DataGridViewTextBoxColumn fecFin;
        private DataGridViewTextBoxColumn frecuencia;
        private DataGridViewTextBoxColumn turno;
        private DataGridViewTextBoxColumn presupuesto;
        private DataGridViewTextBoxColumn direcLocal;
        private DataGridViewTextBoxColumn cuposProg;
    }
}