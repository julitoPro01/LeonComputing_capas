using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace computing_data
{
    public class FacturaADO
    {
        ConexionData MiConexion = new ConexionData();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataView dtv;

        public DataTable ListarFacturasClienteFechas(String strCodCli, 
                                                              DateTime FecIni, DateTime FecFin)
        {
            
            try
            {
                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = " sp_listarFacturasClienteFechas";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codcli",strCodCli);
                cmd.Parameters.AddWithValue("@fecini",FecIni);
                cmd.Parameters.AddWithValue("@fecfin",FecFin);

                DataSet dts = new DataSet();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts,"facturasClientes");
                return dts.Tables["facturasClientes"];



            }
            catch (SqlException ex)
            {
                throw new Exception("Error en el listado:" + ex.Message);
            }
        }

     

    }
}
