using Computing_main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computing_main
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarEvento listarEvento = new ListarEvento();
            listarEvento.MdiParent = this;
            listarEvento.Show();

        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarCursos listarCursos = new ListarCursos();
            listarCursos.MdiParent = this;
            listarCursos.Show();


        }

        private void facturasClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmConsFacturasCliente frmc1 = new frmConsFacturasCliente();
            //frmc1.MdiParent = this;
            //frmc1.Show();

        }

        private void listadosXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmXMLDemo_01 frmxml01 = new frmXMLDemo_01();
            //frmxml01.MdiParent = this;
            //frmxml01.Show();
        }

        private void listadosExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmListadosExcel frmExcel = new frmListadosExcel();
            //frmExcel.MdiParent = this;
            //frmExcel.Show();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            
            if (clsCredenciales.Nivel == 1)
            {
                mantenimientosToolStripMenuItem.Visible = true;
                consultasToolStripMenuItem.Visible = true;
                listadosExcelToolStripMenuItem.Visible = true;
                salirDelSistemaToolStripMenuItem.Visible = true;
            }
            else if (clsCredenciales.Nivel == 2)
            {
                mantenimientosToolStripMenuItem.Visible = true;
                consultasToolStripMenuItem.Visible = false;
                listadosExcelToolStripMenuItem.Visible = true;
                salirDelSistemaToolStripMenuItem.Visible = true;
            }
            
            this.lblUsuario.Text = clsCredenciales.Usuario;
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta;
            vrpta = MessageBox.Show("Seguro de salir del aplicativo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrpta == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void asociadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarAsociados01 listarAsociados01 = new ListarAsociados01();
            listarAsociados01.MdiParent = this;
            listarAsociados01.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MDIPrincipal_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
