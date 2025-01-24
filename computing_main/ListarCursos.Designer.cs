namespace Computing_main
{
    partial class ListarCursos
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
            dtgDatos = new DataGridView();
            idCurso = new DataGridViewTextBoxColumn();
            CURSO = new DataGridViewTextBoxColumn();
            horasTeoria = new DataGridViewTextBoxColumn();
            horasPractica = new DataGridViewTextBoxColumn();
            COMPLEJIDAD = new DataGridViewTextBoxColumn();
            comentario = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            nom_estado = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnActualizar = new Button();
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
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { idCurso, CURSO, horasTeoria, horasPractica, COMPLEJIDAD, comentario, estado, nom_estado });
            dtgDatos.Location = new Point(14, 92);
            dtgDatos.Margin = new Padding(3, 4, 3, 4);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.RowHeadersWidth = 51;
            dtgDatos.RowTemplate.Height = 25;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(996, 453);
            dtgDatos.TabIndex = 0;
            dtgDatos.CellFormatting += dtgDatos_CellFormatting;
            // 
            // idCurso
            // 
            idCurso.DataPropertyName = "idCurso";
            idCurso.HeaderText = "CODIGO";
            idCurso.MinimumWidth = 6;
            idCurso.Name = "idCurso";
            idCurso.Width = 125;
            // 
            // CURSO
            // 
            CURSO.DataPropertyName = "curso";
            CURSO.HeaderText = "CURSO";
            CURSO.MinimumWidth = 6;
            CURSO.Name = "CURSO";
            CURSO.Width = 125;
            // 
            // horasTeoria
            // 
            horasTeoria.DataPropertyName = "horasTeoria";
            horasTeoria.HeaderText = "HORAS TEORIAS";
            horasTeoria.MinimumWidth = 6;
            horasTeoria.Name = "horasTeoria";
            horasTeoria.Width = 125;
            // 
            // horasPractica
            // 
            horasPractica.DataPropertyName = "horasPractica";
            horasPractica.HeaderText = "HORAS PRACTICAS";
            horasPractica.MinimumWidth = 6;
            horasPractica.Name = "horasPractica";
            horasPractica.Width = 125;
            // 
            // COMPLEJIDAD
            // 
            COMPLEJIDAD.DataPropertyName = "nom_complejidad";
            COMPLEJIDAD.HeaderText = "COMPLEJIDAD";
            COMPLEJIDAD.MinimumWidth = 6;
            COMPLEJIDAD.Name = "COMPLEJIDAD";
            COMPLEJIDAD.Width = 125;
            // 
            // comentario
            // 
            comentario.DataPropertyName = "comentario";
            comentario.HeaderText = "COMENTARIO";
            comentario.MinimumWidth = 6;
            comentario.Name = "comentario";
            comentario.Width = 125;
            // 
            // estado
            // 
            estado.DataPropertyName = "estado";
            estado.HeaderText = "COD.ESTADO";
            estado.MinimumWidth = 6;
            estado.Name = "estado";
            estado.Width = 125;
            // 
            // nom_estado
            // 
            nom_estado.DataPropertyName = "nom_estado";
            nom_estado.HeaderText = "ESTADO";
            nom_estado.MinimumWidth = 6;
            nom_estado.Name = "nom_estado";
            nom_estado.Width = 125;
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
            label1.Size = new Size(179, 20);
            label1.TabIndex = 2;
            label1.Text = "Ingrese filtro por nombre:";
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
            // ListarCursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 680);
            Controls.Add(txtFiltro);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(dtgDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ListarCursos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Cursos";
            Load += formCurso_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDatos;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnCerrar;
        private Label label1;
        private TextBox txtFiltro;
        private Label label2;
        private Label lblRegistros;
        private DataGridViewTextBoxColumn idCurso;
        private DataGridViewTextBoxColumn CURSO;
        private DataGridViewTextBoxColumn horasTeoria;
        private DataGridViewTextBoxColumn horasPractica;
        private DataGridViewTextBoxColumn COMPLEJIDAD;
        private DataGridViewTextBoxColumn comentario;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn nom_estado;
    }
}