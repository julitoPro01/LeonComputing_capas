using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using computing_identidad_Ne;
using computing_negocio;
namespace computing_main
{
    public partial class frmConsFacturasCliente : Form
    {
        FacturaBL objFacturaBL = new FacturaBL();
        ClienteBL objClienteBL = new ClienteBL();
        ClienteBE objClienteBE = new ClienteBE();

        public frmConsFacturasCliente()
        {
            InitializeComponent();
        }

        private void frmConsFacturasCliente_Load(object sender, EventArgs e)
        {
            try
            {               

                // Desactivamos la generacion de columnas automaticas del datagrid...
                dtgFacturas.AutoGenerateColumns = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

         private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                objClienteBE = objClienteBL.ConsultarCliente(txtCod.Text.Trim());
                //EVALUAMOS
                if (objClienteBE.Raz_soc_cli == null)
                {
                    //SI NO EXISTE
                    LimpiarResultados();
                    throw new Exception("Codigo de cliente no existe");

                }
                else
                {
                    //SI EXISTE - MOSTRAMOS LOS DATOS
                    lblRazSoc.Text = objClienteBE.Raz_soc_cli;
                    lblUbicacion.Text = objClienteBE.Departamento + "-" + objClienteBE.Provincia + "-"
                                    + objClienteBE.Distrito;
                    //TODO:

                    // MOSTRAMOS LA FACTURA
                    dtgFacturas.DataSource = objFacturaBL.ListarFacturasClienteFechas(
                        txtCod.Text.Trim(),dtpFecIni.Value.Date, dtpFecFin.Value.Date );

                    lblRegistros.Text = dtgFacturas.Rows.Count.ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
              

        private void LimpiarResultados()
        {
            // Limpiamos los label  de resultado...
            foreach (Control miControl in this.Controls)
            {
                if (miControl.Name.StartsWith("lbl") == true)
                {
                    miControl.Text = String.Empty;
                }

            }
            // Limpiamos el datagridview
            dtgFacturas.DataSource = null;
            txtCod.SelectAll();
            txtCod.Focus();
        }
    }
}
