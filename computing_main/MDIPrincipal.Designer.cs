namespace computing_main
{
    partial class MDIPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIPrincipal));
            menuStrip1 = new MenuStrip();
            mantenimientosToolStripMenuItem = new ToolStripMenuItem();
            eventosToolStripMenuItem = new ToolStripMenuItem();
            cursosToolStripMenuItem = new ToolStripMenuItem();
            asociadosToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            facturasClienteToolStripMenuItem = new ToolStripMenuItem();
            facturasVendedorToolStripMenuItem = new ToolStripMenuItem();
            listadosToolStripMenuItem = new ToolStripMenuItem();
            listadosXMLToolStripMenuItem = new ToolStripMenuItem();
            listadosExcelToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lbl1 = new ToolStripStatusLabel();
            lblUsuario = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantenimientosToolStripMenuItem, consultasToolStripMenuItem, listadosToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1211, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            mantenimientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eventosToolStripMenuItem, cursosToolStripMenuItem, asociadosToolStripMenuItem });
            mantenimientosToolStripMenuItem.Image = (Image)resources.GetObject("mantenimientosToolStripMenuItem.Image");
            mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            mantenimientosToolStripMenuItem.Size = new Size(150, 24);
            mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // eventosToolStripMenuItem
            // 
            eventosToolStripMenuItem.Image = (Image)resources.GetObject("eventosToolStripMenuItem.Image");
            eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            eventosToolStripMenuItem.Size = new Size(224, 26);
            eventosToolStripMenuItem.Text = "Eventos";
            eventosToolStripMenuItem.Click += eventosToolStripMenuItem_Click;
            // 
            // cursosToolStripMenuItem
            // 
            cursosToolStripMenuItem.Image = (Image)resources.GetObject("cursosToolStripMenuItem.Image");
            cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            cursosToolStripMenuItem.Size = new Size(224, 26);
            cursosToolStripMenuItem.Text = "Cursos";
            cursosToolStripMenuItem.Click += cursosToolStripMenuItem_Click;
            // 
            // asociadosToolStripMenuItem
            // 
            asociadosToolStripMenuItem.Image = (Image)resources.GetObject("asociadosToolStripMenuItem.Image");
            asociadosToolStripMenuItem.Name = "asociadosToolStripMenuItem";
            asociadosToolStripMenuItem.Size = new Size(224, 26);
            asociadosToolStripMenuItem.Text = "Asociados";
            asociadosToolStripMenuItem.Click += asociadosToolStripMenuItem_Click;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { facturasClienteToolStripMenuItem, facturasVendedorToolStripMenuItem });
            consultasToolStripMenuItem.Image = (Image)resources.GetObject("consultasToolStripMenuItem.Image");
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(106, 24);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // facturasClienteToolStripMenuItem
            // 
            facturasClienteToolStripMenuItem.Name = "facturasClienteToolStripMenuItem";
            facturasClienteToolStripMenuItem.Size = new Size(213, 26);
            facturasClienteToolStripMenuItem.Text = "Facturas Cliente";
            facturasClienteToolStripMenuItem.Click += facturasClienteToolStripMenuItem_Click;
            // 
            // facturasVendedorToolStripMenuItem
            // 
            facturasVendedorToolStripMenuItem.Name = "facturasVendedorToolStripMenuItem";
            facturasVendedorToolStripMenuItem.Size = new Size(213, 26);
            facturasVendedorToolStripMenuItem.Text = "Facturas Vendedor";
            // 
            // listadosToolStripMenuItem
            // 
            listadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listadosXMLToolStripMenuItem, listadosExcelToolStripMenuItem });
            listadosToolStripMenuItem.Image = (Image)resources.GetObject("listadosToolStripMenuItem.Image");
            listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            listadosToolStripMenuItem.Size = new Size(97, 24);
            listadosToolStripMenuItem.Text = "Listados";
            // 
            // listadosXMLToolStripMenuItem
            // 
            listadosXMLToolStripMenuItem.Name = "listadosXMLToolStripMenuItem";
            listadosXMLToolStripMenuItem.Size = new Size(184, 26);
            listadosXMLToolStripMenuItem.Text = "Listados XML";
            listadosXMLToolStripMenuItem.Click += listadosXMLToolStripMenuItem_Click;
            // 
            // listadosExcelToolStripMenuItem
            // 
            listadosExcelToolStripMenuItem.Name = "listadosExcelToolStripMenuItem";
            listadosExcelToolStripMenuItem.Size = new Size(184, 26);
            listadosExcelToolStripMenuItem.Text = "Listados Excel";
            listadosExcelToolStripMenuItem.Click += listadosExcelToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirDelSistemaToolStripMenuItem, cerrarSesiónToolStripMenuItem });
            salirToolStripMenuItem.Image = (Image)resources.GetObject("salirToolStripMenuItem.Image");
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(72, 24);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.Image = (Image)resources.GetObject("salirDelSistemaToolStripMenuItem.Image");
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(224, 26);
            salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            salirDelSistemaToolStripMenuItem.Click += salirDelSistemaToolStripMenuItem_Click;
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.Image = (Image)resources.GetObject("cerrarSesiónToolStripMenuItem.Image");
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(224, 26);
            cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbl1, lblUsuario });
            statusStrip1.Location = new Point(0, 666);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 19, 0);
            statusStrip1.Size = new Size(1211, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbl1
            // 
            lbl1.BackColor = SystemColors.ButtonFace;
            lbl1.ForeColor = SystemColors.ButtonHighlight;
            lbl1.Image = (Image)resources.GetObject("lbl1.Image");
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(20, 20);
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = Color.Silver;
            lblUsuario.ForeColor = Color.Blue;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Padding = new Padding(5, 0, 5, 0);
            lblUsuario.Size = new Size(31, 20);
            lblUsuario.Text = "....";
            // 
            // MDIPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1211, 692);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MDIPrincipal";
            Text = "Menu Principal - Modulo de Ventas";
            WindowState = FormWindowState.Maximized;
            FormClosing += MDIPrincipal_FormClosing;
            FormClosed += MDIPrincipal_FormClosed;
            Load += MDIPrincipal_Load;
            Resize += MDIPrincipal_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosExcelToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private ToolStripMenuItem asociadosToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}