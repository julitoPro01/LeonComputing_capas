namespace Computing_main
{
    partial class ListarAsociados01
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dtgDatos = new DataGridView();
            idAsociado = new DataGridViewTextBoxColumn();
            apePaterno = new DataGridViewTextBoxColumn();
            apeMaterno = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            mail = new DataGridViewTextBoxColumn();
            nom_estado = new DataGridViewTextBoxColumn();
            fecIngreso = new DataGridViewTextBoxColumn();
            fecRegistro = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            txtFiltro = new TextBox();
            label2 = new Label();
            lblRegistros = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { idAsociado, apePaterno, apeMaterno, nombre, mail, nom_estado, fecIngreso, fecRegistro });
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
            // idAsociado
            // 
            idAsociado.DataPropertyName = "idAsociado";
            idAsociado.HeaderText = "Codigo";
            idAsociado.MinimumWidth = 6;
            idAsociado.Name = "idAsociado";
            idAsociado.ReadOnly = true;
            // 
            // apePaterno
            // 
            apePaterno.DataPropertyName = "apePaterno";
            apePaterno.HeaderText = "A.Paterno";
            apePaterno.MinimumWidth = 6;
            apePaterno.Name = "apePaterno";
            apePaterno.ReadOnly = true;
            // 
            // apeMaterno
            // 
            apeMaterno.DataPropertyName = "apeMaterno";
            apeMaterno.HeaderText = "A.Materno";
            apeMaterno.MinimumWidth = 6;
            apeMaterno.Name = "apeMaterno";
            apeMaterno.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "nombre";
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // mail
            // 
            mail.DataPropertyName = "mail";
            mail.HeaderText = "Email";
            mail.MinimumWidth = 6;
            mail.Name = "mail";
            mail.ReadOnly = true;
            // 
            // nom_estado
            // 
            nom_estado.DataPropertyName = "nom_estado";
            nom_estado.HeaderText = "Estado";
            nom_estado.MinimumWidth = 6;
            nom_estado.Name = "nom_estado";
            nom_estado.ReadOnly = true;
            // 
            // fecIngreso
            // 
            fecIngreso.DataPropertyName = "fecIngreso";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            fecIngreso.DefaultCellStyle = dataGridViewCellStyle5;
            fecIngreso.HeaderText = "Fec.Ingreso";
            fecIngreso.MinimumWidth = 6;
            fecIngreso.Name = "fecIngreso";
            fecIngreso.ReadOnly = true;
            // 
            // fecRegistro
            // 
            fecRegistro.DataPropertyName = "fecRegistro";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "d";
            fecRegistro.DefaultCellStyle = dataGridViewCellStyle6;
            fecRegistro.HeaderText = "Fec.Registro";
            fecRegistro.MinimumWidth = 6;
            fecRegistro.Name = "fecRegistro";
            fecRegistro.ReadOnly = true;
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
            label1.Location = new Point(23, 36);
            label1.Name = "label1";
            label1.Size = new Size(189, 20);
            label1.TabIndex = 2;
            label1.Text = "Ingrese filtro por A.paterno";
            label1.Click += label1_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(246, 32);
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
            // ListarAsociados01
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
            Name = "ListarAsociados01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Asociados";
            Load += ProductoMan01_Load;
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
        private DataGridViewTextBoxColumn idAsociado;
        private DataGridViewTextBoxColumn apePaterno;
        private DataGridViewTextBoxColumn apeMaterno;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn mail;
        private DataGridViewTextBoxColumn nom_estado;
        private DataGridViewTextBoxColumn fecIngreso;
        private DataGridViewTextBoxColumn fecRegistro;
    }
}