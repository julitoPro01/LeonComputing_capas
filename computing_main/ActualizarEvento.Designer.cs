namespace computing_main
{
    partial class ActualizarEvento
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
            evento = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            btnGrabar = new Button();
            btnCancelar = new Button();
            curso = new ComboBox();
            expositor = new ComboBox();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            local = new TextBox();
            presupuesto = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            empresa = new ComboBox();
            ubigeo = new ComboBox();
            cupos = new TextBox();
            fin = new DateTimePicker();
            inicio = new DateTimePicker();
            frecuencia = new ComboBox();
            turno = new ComboBox();
            label13 = new Label();
            codigo = new TextBox();
            SuspendLayout();
            // 
            // evento
            // 
            evento.Location = new Point(168, 63);
            evento.Name = "evento";
            evento.Size = new Size(223, 27);
            evento.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 66);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 4;
            label1.Text = "Evento: *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 347);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 5;
            label2.Text = "Inicio: *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 399);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 6;
            label3.Text = "Fin: *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 251);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 7;
            label4.Text = "Cupos: *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 114);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 12;
            label6.Text = "Frecuencia: *";
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.LightGreen;
            btnGrabar.Location = new Point(579, 409);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(94, 29);
            btnGrabar.TabIndex = 12;
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
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // curso
            // 
            curso.DropDownStyle = ComboBoxStyle.DropDownList;
            curso.FormattingEnabled = true;
            curso.Location = new Point(579, 15);
            curso.Name = "curso";
            curso.Size = new Size(223, 28);
            curso.TabIndex = 8;
            // 
            // expositor
            // 
            expositor.DropDownStyle = ComboBoxStyle.DropDownList;
            expositor.FormattingEnabled = true;
            expositor.Location = new Point(579, 98);
            expositor.Name = "expositor";
            expositor.Size = new Size(223, 28);
            expositor.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 161);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 37;
            label5.Text = "Turno: *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(266, 251);
            label7.Name = "label7";
            label7.Size = new Size(102, 20);
            label7.TabIndex = 38;
            label7.Text = "Presupuesto: *";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 210);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 39;
            label8.Text = "Local: *";
            // 
            // local
            // 
            local.Location = new Point(168, 207);
            local.Name = "local";
            local.Size = new Size(223, 27);
            local.TabIndex = 3;
            // 
            // presupuesto
            // 
            presupuesto.Location = new Point(266, 274);
            presupuesto.Name = "presupuesto";
            presupuesto.Size = new Size(125, 27);
            presupuesto.TabIndex = 5;
            presupuesto.KeyPress += presupuesto_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(477, 18);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 42;
            label9.Text = "Curso: *";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(477, 101);
            label10.Name = "label10";
            label10.Size = new Size(84, 20);
            label10.TabIndex = 43;
            label10.Text = "Expositor: *";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(477, 188);
            label11.Name = "label11";
            label11.Size = new Size(79, 20);
            label11.TabIndex = 44;
            label11.Text = "Empresa: *";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(477, 277);
            label12.Name = "label12";
            label12.Size = new Size(71, 20);
            label12.TabIndex = 45;
            label12.Text = "Ubigeo: *";
            // 
            // empresa
            // 
            empresa.DropDownStyle = ComboBoxStyle.DropDownList;
            empresa.FormattingEnabled = true;
            empresa.Location = new Point(579, 185);
            empresa.Name = "empresa";
            empresa.Size = new Size(223, 28);
            empresa.TabIndex = 10;
            // 
            // ubigeo
            // 
            ubigeo.DropDownStyle = ComboBoxStyle.DropDownList;
            ubigeo.FormattingEnabled = true;
            ubigeo.Location = new Point(579, 274);
            ubigeo.Name = "ubigeo";
            ubigeo.Size = new Size(223, 28);
            ubigeo.TabIndex = 11;
            // 
            // cupos
            // 
            cupos.Location = new Point(121, 274);
            cupos.Name = "cupos";
            cupos.Size = new Size(125, 27);
            cupos.TabIndex = 4;
            cupos.KeyPress += cupos_KeyPress;
            // 
            // fin
            // 
            fin.Location = new Point(121, 394);
            fin.Name = "fin";
            fin.Size = new Size(270, 27);
            fin.TabIndex = 7;
            // 
            // inicio
            // 
            inicio.CalendarForeColor = SystemColors.ActiveCaption;
            inicio.Location = new Point(121, 342);
            inicio.Name = "inicio";
            inicio.Size = new Size(270, 27);
            inicio.TabIndex = 6;
            // 
            // frecuencia
            // 
            frecuencia.DropDownStyle = ComboBoxStyle.DropDownList;
            frecuencia.FormattingEnabled = true;
            frecuencia.Items.AddRange(new object[] { "Lunes, Miércoles y Viernes ", "Martes, Jueves y Sábado" });
            frecuencia.Location = new Point(168, 111);
            frecuencia.Name = "frecuencia";
            frecuencia.Size = new Size(223, 28);
            frecuencia.TabIndex = 1;
            // 
            // turno
            // 
            turno.DisplayMember = "M,T,N";
            turno.DropDownStyle = ComboBoxStyle.DropDownList;
            turno.FormattingEnabled = true;
            turno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            turno.Location = new Point(168, 158);
            turno.Name = "turno";
            turno.Size = new Size(223, 28);
            turno.TabIndex = 2;
            turno.ValueMember = "M;T;N";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(17, 17);
            label13.Name = "label13";
            label13.Size = new Size(59, 20);
            label13.TabIndex = 54;
            label13.Text = "codigo:";
            // 
            // codigo
            // 
            codigo.BackColor = SystemColors.ActiveCaption;
            codigo.BorderStyle = BorderStyle.FixedSingle;
            codigo.Location = new Point(82, 15);
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            codigo.Size = new Size(102, 27);
            codigo.TabIndex = 53;
            codigo.TextAlign = HorizontalAlignment.Center;
            // 
            // ActualizarEvento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label13);
            Controls.Add(codigo);
            Controls.Add(turno);
            Controls.Add(frecuencia);
            Controls.Add(inicio);
            Controls.Add(fin);
            Controls.Add(cupos);
            Controls.Add(ubigeo);
            Controls.Add(empresa);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(presupuesto);
            Controls.Add(local);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(expositor);
            Controls.Add(curso);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(evento);
            Name = "ActualizarEvento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Evento";
            Load += ActualizarEvento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox evento;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button btnGrabar;
        private Button btnCancelar;
        private ComboBox empresa;
        private ComboBox curso;
        private ComboBox expositor;
        private Label label5;
        private Label label7;
        private Label label8;
        private TextBox local;
        private TextBox presupuesto;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox ubigeo;
        private TextBox cupos;
        private DateTimePicker fin;
        private DateTimePicker inicio;
        private ComboBox frecuencia;
        private ComboBox turno;
        private Label label13;
        private TextBox codigo;
    }
}