using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar....
using System.Data;
using System.Data.SqlClient;
using computing_negocio;
using System.Reflection.PortableExecutable;
namespace computing_data;

public  class AsociadoData
{
    // Instancias.....
    ConexionData MiConexion = new ConexionData();
    SqlConnection cnx = new SqlConnection();
    SqlCommand cmd = new SqlCommand();
    SqlDataReader dtr;

    public DataTable ListarAsociados()
    {
        
        try
        {

            // Codifique
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_getAllAsociados";
            cmd.Parameters.Clear();

            DataSet dts = new DataSet();
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
           // ada.SelectCommand = cmd;
            ada.Fill(dts, "Asociados");
            return dts.Tables["Asociados"];

        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message);
        }

    }
    public AsociadoN ConsultarAsociado (String idAsociado)
    {
        
        try
        {
            //Codifique
            // Creamos la instancia de ProductoBE a retornar
            AsociadoN objAsociadoN = new AsociadoN();

            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;  
            cmd.CommandText = "sp_getAsociado";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idAsociado", idAsociado);

            cnx.Open();
            dtr = cmd.ExecuteReader();

            if(dtr.HasRows == true)
            {
                // si devuelve resultados, se lee la fila y sus columnas
                // se asigna a las propiedades de la instancia objProductoBE

                dtr.Read();

              
                objAsociadoN.IdAsociado = dtr["idAsociado"].ToString();
                objAsociadoN.ApePaterno = dtr["apePaterno"].ToString();
              
                objAsociadoN.ApeMaterno = dtr["apeMaterno"].ToString();
                objAsociadoN.Nombre = dtr["nombre"].ToString() ;
                objAsociadoN.Direccion = dtr["direccion"].ToString();

                objAsociadoN.FecIngreso = dtr.GetDateTime(dtr.GetOrdinal( "fecIngreso"));

                objAsociadoN.Dni = dtr["dni"].ToString();
                objAsociadoN.TelDomicilio = dtr["telDomicilio"].ToString();
                objAsociadoN.TelCelular = dtr["telCelular"].ToString();
                objAsociadoN.Mail = dtr["mail"].ToString();

                objAsociadoN.FecUltimaCapac = dtr.GetDateTime(dtr.GetOrdinal( "fecUltimaCapac"));
               // objAsociadoN.Foto = (Byte[])dtr["foto"] ?? null ;

                objAsociadoN.Foto = dtr.IsDBNull(dtr.GetOrdinal("foto")) ? null : (byte[])dtr["Foto"];


                objAsociadoN.Estado = Convert.ToInt16( dtr["estado"]);
                objAsociadoN.UsuRegistro =dtr["usuRegistro"].ToString();
                objAsociadoN.FecRegistro = dtr.GetDateTime( dtr.GetOrdinal( "fecRegistro"));
                objAsociadoN.UsuUlt_Mod = dtr["usuUlt_Mod"].ToString();
               
                objAsociadoN.FecUlt_Mod = dtr.IsDBNull( dtr.GetOrdinal( "fecUlt_Mod")) ? null : dtr.GetDateTime(dtr.GetOrdinal("fecUlt_Mod"));
                objAsociadoN.IdUbigeo = dtr["idUbigeo"].ToString();
                objAsociadoN.Ubigeo = dtr["ubigeo"].ToString();

            }
            else
            {
                objAsociadoN.IdAsociado = string.Empty;

            }

                dtr.Close();
               return objAsociadoN;


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

    public Boolean InsertarAsociado(AsociadoN objAsociadoN)
    {
      
        try
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_addAsociado";
            cmd.Parameters.Clear();
            //Agregamos parametros
            //cmd.Parameters.AddWithValue("@idAsociado", objAsociadoN.IdAsociado);
            cmd.Parameters.AddWithValue("@apePaterno", objAsociadoN.ApePaterno);
            cmd.Parameters.AddWithValue("@apeMaterno", objAsociadoN.ApeMaterno);
            cmd.Parameters.AddWithValue("@nombre", objAsociadoN.Nombre);
            cmd.Parameters.AddWithValue("@direccion", objAsociadoN.Direccion);
            cmd.Parameters.AddWithValue("@fecIngreso", objAsociadoN.FecIngreso);
            cmd.Parameters.AddWithValue("@dni", objAsociadoN.Dni);
            cmd.Parameters.AddWithValue("@telDomicilio", objAsociadoN.TelDomicilio);
            cmd.Parameters.AddWithValue("@telCelular", objAsociadoN.TelCelular);
            cmd.Parameters.AddWithValue("@mail", objAsociadoN.Mail);
            cmd.Parameters.AddWithValue("@fecUltimaCapac", objAsociadoN.FecUltimaCapac);

            SqlParameter param = new SqlParameter("@Foto", System.Data.SqlDbType.VarBinary, -1);
            param.Value = (object)objAsociadoN.Foto ?? DBNull.Value;
            cmd.Parameters.Add(param);

            cmd.Parameters.AddWithValue("@estado", objAsociadoN.Estado);
            cmd.Parameters.AddWithValue("@usuRegistro", objAsociadoN.UsuRegistro);
            cmd.Parameters.AddWithValue("@fecRegistro", objAsociadoN.FecRegistro);
            cmd.Parameters.AddWithValue("@usuUlt_Mod", objAsociadoN.UsuUlt_Mod);
            cmd.Parameters.AddWithValue("@fecUlt_Mod", DBNull.Value);
            cmd.Parameters.AddWithValue("@idUbigeo", objAsociadoN.IdUbigeo);
            cnx.Open();
            cmd.ExecuteNonQuery();
            return true;

        }
        catch (SqlException x)
        {
            throw new Exception(x.Message);
            return false;
        }
        finally
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }

        }
    }
    public Boolean ActualizarAsociado(AsociadoN objAsociadoN)
    {
        try
        {
            //Codifique

             cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_updateAsociado";
            cmd.Parameters.Clear();
            //Agregamos parametros
            cmd.Parameters.AddWithValue("@idAsociado", objAsociadoN.IdAsociado);
            cmd.Parameters.AddWithValue("@apePaterno", objAsociadoN.ApePaterno);
            cmd.Parameters.AddWithValue("@apeMaterno", objAsociadoN.ApeMaterno);
            cmd.Parameters.AddWithValue("@nombre", objAsociadoN.Nombre);
            cmd.Parameters.AddWithValue("@direccion", objAsociadoN.Direccion);
            cmd.Parameters.AddWithValue("@fecIngreso", objAsociadoN.FecIngreso);
            cmd.Parameters.AddWithValue("@dni", objAsociadoN.Dni);
            cmd.Parameters.AddWithValue("@telDomicilio", objAsociadoN.TelDomicilio);
            cmd.Parameters.AddWithValue("@telCelular", objAsociadoN.TelCelular);
            cmd.Parameters.AddWithValue("@mail", objAsociadoN.Mail);
            cmd.Parameters.AddWithValue("@fecUltimaCapac", objAsociadoN.FecUltimaCapac);
           // cmd.Parameters.AddWithValue("@foto",(Object)objAsociadoN.Foto ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@estado", objAsociadoN.Estado);
            cmd.Parameters.AddWithValue("@usuRegistro", objAsociadoN.UsuRegistro);
            cmd.Parameters.AddWithValue("@fecRegistro", objAsociadoN.FecRegistro);
            cmd.Parameters.AddWithValue("@usuUlt_Mod", objAsociadoN.UsuUlt_Mod);
            cmd.Parameters.AddWithValue("@fecUlt_Mod", objAsociadoN.FecUlt_Mod);
            cmd.Parameters.AddWithValue("@idUbigeo", objAsociadoN.IdUbigeo);

            SqlParameter param = new SqlParameter("@Foto", System.Data.SqlDbType.VarBinary, -1);
            param.Value = (object)objAsociadoN.Foto ?? DBNull.Value;
            cmd.Parameters.Add(param);


            cnx.Open();
            cmd.ExecuteNonQuery();
            return true;

        }
        catch (SqlException x)
        {
            throw new Exception(x.Message);
            return false;
        }
        finally
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }

        }


    }

    public Boolean EliminarAsociado(String idAsociado)
    {
       

        try
        {
            //Codifique

            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_deleteAsociado";
            cmd.Parameters.Clear();
            //Agregamos parametros
            cmd.Parameters.AddWithValue("@idAsociado", idAsociado);

            cnx.Open ();
            cmd.ExecuteNonQuery();
            return true;

        }
        catch (SqlException x)
        {
            throw new Exception(x.Message);
            return false;
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
