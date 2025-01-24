
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
    public partial class ListarCursos : Form
    {
        // Instancias
        CursoE objCursoE = new CursoE();
        DataView dtv;

        public ListarCursos()
        {
            InitializeComponent();
        }

        private void formCurso_Load(object sender, EventArgs e)
        {
            //  Invocamos al metodo CargarDatos pasandole una cadena vacia ,
            //  lo cual hara que se muestren todos los productos por defecto al 
            //momento de cargar el formulario

            CargarDatos("");

        }

        private void CargarDatos(String strFiltro)
        {
            dtgDatos.AutoGenerateColumns=false;
            
            // Construimos  el objeto Dataview dtv  en base al DataTable devuelto por el metodo ListarProducto
            // Y lo filtramos de acuerdo al parametro strFiltro
            dtv = new DataView(objCursoE.ListarCurso());

            dtv.RowFilter = "curso like '%" + strFiltro + "%'";
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

                AnadirCurso anadirCurso = new AnadirCurso();
                anadirCurso.ShowDialog();

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
                ActualizarCurso actualizarCurso = new ActualizarCurso();

                // if(dtgDatos.RowCount==1)
                //     btnActualizar.Enabled = true;


                // MessageBox.Show(dtgDatos.RowCount. ToString(), "msg", MessageBoxButtons.OK);                 
                String strCode = dtgDatos.CurrentRow.Cells[0].Value.ToString();

                actualizarCurso.Codigo = strCode;
                actualizarCurso.ShowDialog();
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


       
    }
}
