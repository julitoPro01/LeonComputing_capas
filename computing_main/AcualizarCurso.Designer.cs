namespace computing_main
{
    partial class ActualizarCurso
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
            curso = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            activo = new CheckBox();
            btnGrabar = new Button();
            btnCancelar = new Button();
            complejidad = new ListBox();
            comentario = new TextBox();
            horaTeoria = new ComboBox();
            horaPractica = new ComboBox();
            label12 = new Label();
            codigo = new TextBox();
            SuspendLayout();
            // 
            // curso
            // 
            curso.Location = new Point(168, 96);
            curso.Name = "curso";
            curso.Size = new Size(223, 27);
            curso.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 99);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 4;
            label1.Text = "Curso: *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 153);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 5;
            label2.Text = "Horas de Teoria: *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 212);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 6;
            label3.Text = "Horas de Practica: *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(472, 37);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 7;
            label4.Text = "Complejidad: *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 271);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 12;
            label6.Text = "Comentario: *";
            // 
            // activo
            // 
            activo.AutoSize = true;
            activo.Location = new Point(472, 189);
            activo.Name = "activo";
            activo.Size = new Size(73, 24);
            activo.TabIndex = 5;
            activo.Text = "Activo";
            activo.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.LightGreen;
            btnGrabar.Location = new Point(579, 409);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(94, 29);
            btnGrabar.TabIndex = 6;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.Location = new Point(694, 409);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // complejidad
            // 
            complejidad.DisplayMember = "Basico";
            complejidad.FormattingEnabled = true;
            complejidad.Items.AddRange(new object[] { "Basico", "Intermedio", "Avanzado" });
            complejidad.Location = new Point(472, 69);
            complejidad.Name = "complejidad";
            complejidad.Size = new Size(302, 84);
            complejidad.TabIndex = 4;
            complejidad.Tag = "";
            complejidad.ValueMember = "Basico";
            // 
            // comentario
            // 
            comentario.Location = new Point(168, 271);
            comentario.Multiline = true;
            comentario.Name = "comentario";
            comentario.Size = new Size(223, 155);
            comentario.TabIndex = 3;
            // 
            // horaTeoria
            // 
            horaTeoria.DropDownStyle = ComboBoxStyle.DropDownList;
            horaTeoria.FormattingEnabled = true;
            horaTeoria.Items.AddRange(new object[] { "01:00:00", "01:30:00", "02:00:00", "02:30:00", "03:00:00", "03:30:00" });
            horaTeoria.Location = new Point(168, 150);
            horaTeoria.Name = "horaTeoria";
            horaTeoria.Size = new Size(223, 28);
            horaTeoria.TabIndex = 1;
            // 
            // horaPractica
            // 
            horaPractica.DropDownStyle = ComboBoxStyle.DropDownList;
            horaPractica.FormattingEnabled = true;
            horaPractica.Items.AddRange(new object[] { "01:00:00", "01:30:00", "02:00:00", "02:30:00", "03:00:00", "03:30:00" });
            horaPractica.Location = new Point(168, 209);
            horaPractica.Name = "horaPractica";
            horaPractica.Size = new Size(223, 28);
            horaPractica.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(13, 14);
            label12.Name = "label12";
            label12.Size = new Size(59, 20);
            label12.TabIndex = 36;
            label12.Text = "codigo:";
            // 
            // codigo
            // 
            codigo.BackColor = SystemColors.ActiveCaption;
            codigo.BorderStyle = BorderStyle.FixedSingle;
            codigo.Location = new Point(78, 12);
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            codigo.Size = new Size(102, 27);
            codigo.TabIndex = 35;
            codigo.TextAlign = HorizontalAlignment.Center;
            // 
            // ActualizarCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label12);
            Controls.Add(codigo);
            Controls.Add(horaPractica);
            Controls.Add(horaTeoria);
            Controls.Add(comentario);
            Controls.Add(complejidad);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(activo);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(curso);
            Name = "ActualizarCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Curso";
            Load += ActualizarCurso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox curso;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private CheckBox activo;
        private Button btnGrabar;
        private Button btnCancelar;
        private ListBox complejidad;
        private TextBox comentario;
        private ComboBox comboBox1;
        private ComboBox horaTeoria;
        private ComboBox horaPractica;
        private Label label12;
        private TextBox codigo;
    }
}