using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregamos
using System.Data;
using System.Data.SqlClient;
using computing_negocio;

namespace computing_data
{
   public  class ClienteADO
    {
        // Instancias...
        ConexionData MiConexion = new ConexionData();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public ClienteBE ConsultarCliente(String strCod)
        {
          
            try
            {
                ClienteBE objClienteBE = new ClienteBE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod", strCod);

                // Abrimos la conexion y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objClienteBE.Raz_soc_cli = dtr["raz_soc_cli"].ToString();
                    objClienteBE.Ruc_cli = dtr["ruc_cli"].ToString();
                    objClienteBE.Tel_cli = dtr["tel_cli"].ToString();
                    objClienteBE.Dir_cli = dtr["dir_cli"].ToString();
                    objClienteBE.Departamento = dtr["Departamento"].ToString();
                    objClienteBE.Provincia = dtr["Provincia"].ToString();
                    objClienteBE.Distrito = dtr["Distrito"].ToString();
                    objClienteBE.Est_cli = Convert.ToInt16(dtr["Est_cli"].ToString());
                    objClienteBE.Deuda = Convert.ToSingle(dtr["Deuda"]);

                }
                dtr.Close();
                return objClienteBE;

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }





        }

    }
}
