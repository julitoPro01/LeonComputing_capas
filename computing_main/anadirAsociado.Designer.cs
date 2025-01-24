namespace computing_main
{
    partial class AnadirAsociado02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnadirAsociado02));
            paterno = new TextBox();
            direccion = new TextBox();
            nombre = new TextBox();
            materno = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ingreso = new DateTimePicker();
            label5 = new Label();
            dni = new TextBox();
            label6 = new Label();
            domicilio = new TextBox();
            celular = new TextBox();
            label7 = new Label();
            label8 = new Label();
            correo = new TextBox();
            label9 = new Label();
            capacitacion = new DateTimePicker();
            label10 = new Label();
            imagen = new PictureBox();
            btnAddImg = new Button();
            ubigeo = new ComboBox();
            label11 = new Label();
            activo = new CheckBox();
            btnGrabar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)imagen).BeginInit();
            SuspendLayout();
            // 
            // paterno
            // 
            paterno.Location = new Point(168, 12);
            paterno.Name = "paterno";
            paterno.Size = new Size(185, 27);
            paterno.TabIndex = 0;
            // 
            // direccion
            // 
            direccion.Location = new Point(168, 197);
            direccion.Name = "direccion";
            direccion.Size = new Size(185, 27);
            direccion.TabIndex = 3;
            // 
            // nombre
            // 
            nombre.Location = new Point(168, 138);
            nombre.Name = "nombre";
            nombre.Size = new Size(185, 27);
            nombre.TabIndex = 2;
            // 
            // materno
            // 
            materno.Location = new Point(168, 75);
            materno.Name = "materno";
            materno.Size = new Size(185, 27);
            materno.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 4;
            label1.Text = "Apellido Paterno: *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 5;
            label2.Text = "Apellido Materno: *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 145);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 6;
            label3.Text = "Nombre: *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 204);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 7;
            label4.Text = "Dirección: *";
            // 
            // ingreso
            // 
            ingreso.Location = new Point(529, 75);
            ingreso.Name = "ingreso";
            ingreso.Size = new Size(250, 27);
            ingreso.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(379, 78);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 10;
            label5.Text = "Fecha de Ingreso:";
            // 
            // dni
            // 
            dni.Location = new Point(168, 256);
            dni.MaxLength = 8;
            dni.Name = "dni";
            dni.Size = new Size(185, 27);
            dni.TabIndex = 4;
            dni.KeyPress += dni_KeyPress;
            dni.Validating += dni_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 256);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 12;
            label6.Text = "Dni: *";
            // 
            // domicilio
            // 
            domicilio.Location = new Point(168, 321);
            domicilio.MaxLength = 10;
            domicilio.Name = "domicilio";
            domicilio.Size = new Size(185, 27);
            domicilio.TabIndex = 5;
            domicilio.KeyPress += celular_KeyPress;
            // 
            // celular
            // 
            celular.Location = new Point(168, 368);
            celular.MaxLength = 9;
            celular.Name = "celular";
            celular.Size = new Size(185, 27);
            celular.TabIndex = 6;
            celular.KeyPress += celular_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 324);
            label7.Name = "label7";
            label7.Size = new Size(139, 20);
            label7.TabIndex = 15;
            label7.Text = "Telefono Domicilio:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 375);
            label8.Name = "label8";
            label8.Size = new Size(126, 20);
            label8.TabIndex = 16;
            label8.Text = "Numero Celular: *";
            // 
            // correo
            // 
            correo.Location = new Point(529, 197);
            correo.Name = "correo";
            correo.PlaceholderText = "corre@gmail.com";
            correo.Size = new Size(250, 27);
            correo.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(379, 204);
            label9.Name = "label9";
            label9.Size = new Size(67, 20);
            label9.TabIndex = 18;
            label9.Text = "Correo: *";
            // 
            // capacitacion
            // 
            capacitacion.Location = new Point(529, 140);
            capacitacion.Name = "capacitacion";
            capacitacion.Size = new Size(250, 27);
            capacitacion.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(379, 145);
            label10.Name = "label10";
            label10.Size = new Size(146, 20);
            label10.TabIndex = 20;
            label10.Text = "Ultima Capacitación:";
            // 
            // imagen
            // 
            imagen.BorderStyle = BorderStyle.Fixed3D;
            imagen.ErrorImage = (Image)resources.GetObject("imagen.ErrorImage");
            imagen.InitialImage = (Image)resources.GetObject("imagen.InitialImage");
            imagen.Location = new Point(378, 299);
            imagen.Name = "imagen";
            imagen.Size = new Size(125, 62);
            imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            imagen.TabIndex = 21;
            imagen.TabStop = false;
            // 
            // btnAddImg
            // 
            btnAddImg.Location = new Point(379, 367);
            btnAddImg.Name = "btnAddImg";
            btnAddImg.Size = new Size(125, 29);
            btnAddImg.TabIndex = 12;
            btnAddImg.Text = "Añadir Imagen";
            btnAddImg.UseVisualStyleBackColor = true;
            btnAddImg.Click += btnAddImg_Click;
            // 
            // ubigeo
            // 
            ubigeo.DropDownStyle = ComboBoxStyle.DropDownList;
            ubigeo.FormattingEnabled = true;
            ubigeo.Location = new Point(461, 11);
            ubigeo.Name = "ubigeo";
            ubigeo.Size = new Size(318, 28);
            ubigeo.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(379, 15);
            label11.Name = "label11";
            label11.Size = new Size(71, 20);
            label11.TabIndex = 26;
            label11.Text = "Ubigeo: *";
            // 
            // activo
            // 
            activo.AutoSize = true;
            activo.Location = new Point(379, 259);
            activo.Name = "activo";
            activo.Size = new Size(73, 24);
            activo.TabIndex = 11;
            activo.Text = "Activo";
            activo.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.LightGreen;
            btnGrabar.Location = new Point(579, 409);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(94, 29);
            btnGrabar.TabIndex = 13;
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
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AnadirAsociado02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(activo);
            Controls.Add(label11);
            Controls.Add(ubigeo);
            Controls.Add(btnAddImg);
            Controls.Add(imagen);
            Controls.Add(label10);
            Controls.Add(capacitacion);
            Controls.Add(label9);
            Controls.Add(correo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(celular);
            Controls.Add(domicilio);
            Controls.Add(label6);
            Controls.Add(dni);
            Controls.Add(label5);
            Controls.Add(ingreso);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(materno);
            Controls.Add(nombre);
            Controls.Add(direccion);
            Controls.Add(paterno);
            Name = "AnadirAsociado02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Añadir Asociado";
            Load += AnadirAsociado02_Load;
            ((System.ComponentModel.ISupportInitialize)imagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox paterno;
        private TextBox direccion;
        private TextBox nombre;
        private TextBox materno;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker ingreso;
        private Label label5;
        private TextBox dni;
        private Label label6;
        private TextBox domicilio;
        private TextBox celular;
        private Label label7;
        private Label label8;
        private TextBox correo;
        private Label label9;
        private DateTimePicker capacitacion;
        private Label label10;
        private PictureBox imagen;
        private Button btnAddImg;
        private ComboBox ubigeo;
        private Label label11;
        private CheckBox activo;
        private Button btnGrabar;
        private Button btnCancelar;
    }
}