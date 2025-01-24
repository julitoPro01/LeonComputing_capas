using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar using...
using System.Data;
using System.Data.SqlClient;
using computing_negocio;
namespace computing_data
{
    public class UsuarioData
    {
        ConexionData MiConexion = new ConexionData();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;


        public UsuarioN ConsultarUsuario(String strLogin,String strPassword)
        {
            UsuarioN objUsuarioN = new UsuarioN();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_getUser";
            // Agregamos el parametro...
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@user", strLogin);
            cmd.Parameters.AddWithValue("@passUser", strPassword);
            try
            {
                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objUsuarioN.Login_Usuario  = dtr["LoginUser"].ToString();
                    objUsuarioN.Pass_Usuario  = dtr["PassUser"].ToString();
                    objUsuarioN.Niv_Usuario = Convert.ToInt16 (dtr["NivUser"]);
                    objUsuarioN.Fec_Registro  = Convert.ToDateTime(dtr["FecRegistro"]);
                    objUsuarioN.Usu_Registro  = dtr["UsuRegistro"].ToString ();
                    objUsuarioN.Est_Usuario = Convert.ToInt16(dtr["estado"]);
                }
                dtr.Close();
                return objUsuarioN;
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
