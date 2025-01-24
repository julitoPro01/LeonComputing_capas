
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; // Para los objetos DataTable, DataRow y DataView
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

// Agregar...
using computing_identidad_Ne;

using computing_main;

namespace Computing_main
{
    public partial class ListarAsociados01 : Form
    {
        // Instancias
        AsociadoE objAsociadoE = new AsociadoE();
        DataView dtv;

        public ListarAsociados01()
        {
            InitializeComponent();
        }

        private void ProductoMan01_Load(object sender, EventArgs e)
        {
            dtgDatos.AutoGenerateColumns = false;
            //  Invocamos al metodo CargarDatos pasandole una cadena vacia ,
            //  lo cual hara que se muestren todos los productos por defecto al 
            //momento de cargar el formulario

            CargarDatos("");

        }

        private void CargarDatos(String strFiltro)
        {

            // Construimos  el objeto Dataview dtv  en base al DataTable devuelto por el metodo ListarProducto
            // Y lo filtramos de acuerdo al parametro strFiltro
            dtv = new DataView(objAsociadoE.ListarAsociados());

            dtv.RowFilter = "apePaterno like '%" + strFiltro + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();

            // MessageBox.Show("grabajo", "fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Pasaremos al metodo CargarDatos el texto que se va escribiendo
                // en la caja de texto 
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique

                AnadirAsociado02 anadirAsociado = new AnadirAsociado02();
                anadirAsociado.ShowDialog();
                CargarDatos("");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                actualizarAsociado03 actualizarAsociado = new actualizarAsociado03();

                String strCode = dtgDatos.CurrentRow.Cells[0].Value.ToString();

                actualizarAsociado.Codigo = strCode;
                actualizarAsociado.ShowDialog();
                CargarDatos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }

        private void dtgDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica si la celda actual pertenece a la columna deseada (por ejemplo, la columna 0)
            if (e.ColumnIndex == 0)
            {
                // Cambia el estilo de fuente y color de fondo de la celda
                e.CellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                e.CellStyle.BackColor = Color.LightBlue;

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Confirmar",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                String strCodigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();

                if (objAsociadoE.EliminarAsociado(strCodigo) == true)
                {
                    CargarDatos("");
                }
                else
                {
                    throw new Exception(" Error al eliminar. Comuniquese con el administrador ");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
