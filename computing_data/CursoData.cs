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

public class CursoDdata
{
    // Instancias.....
    ConexionData MiConexion = new ConexionData();
    SqlConnection cnx = new SqlConnection();
    SqlCommand cmd = new SqlCommand();
    SqlDataReader dtr;

    public DataTable ListarCurso()
    {

        try
        {

            // Codifique
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_getCurso";
            cmd.Parameters.Clear();

            DataSet dts = new DataSet();
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            // ada.SelectCommand = cmd;
            ada.Fill(dts, "Curso");
            return dts.Tables["Curso"];

        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message);
        }

    }
    public CursoN ConsultarCurso(String idCurso)
    {

        try
        {
            //Codifique
            // Creamos la instancia de ProductoBE a retornar
            CursoN objCursoN = new CursoN();

            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_getOneCurso";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idCurso", idCurso);

            cnx.Open();
            dtr = cmd.ExecuteReader();

            if (dtr.HasRows == true)
            {
                // si devuelve resultados, se lee la fila y sus columnas
                // se asigna a las propiedades de la instancia objProductoBE

                dtr.Read();


                objCursoN.IdCurso= dtr["idCurso"].ToString();
                objCursoN.NameCurso = dtr["curso"].ToString();
               objCursoN.HorasTeoria = dtr["horasTeoria"].ToString();
                objCursoN.HorasPractica = dtr["horasPractica"].ToString();
                objCursoN.Complejidad = Convert.ToInt16( dtr["complejidad"]);
                objCursoN.NomComplejidad = dtr["nom_complejidad"].ToString();
                objCursoN.Comentario = dtr["comentario"].ToString();
                objCursoN.Estado =Convert.ToInt16(  dtr["estado"]);
                objCursoN.NomEstado = dtr["nom_estado"].ToString();
                objCursoN.UsuRegistro = dtr["usuRegistro"].ToString();
                objCursoN.UsuUlt_Mod = dtr["usuUlt_Mod"].ToString();
                objCursoN.FecRegistro = dtr.GetDateTime(dtr.GetOrdinal("fecRegistro"));
                objCursoN.FecUlt_Mod = dtr.IsDBNull((dtr.GetOrdinal("fecUlt_Mod")))
                                       ? (DateTime?)null
                                        : dtr.GetDateTime(dtr.GetOrdinal("fecUlt_Mod"));
                



            }
            else
            {
                objCursoN.IdCurso = String.Empty ;

            }

            dtr.Close();
            return objCursoN;


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

    public Boolean InsertarCurso(CursoN objCursoN)
    {

        try
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_addCurso";
            cmd.Parameters.Clear();
            //Agregamos parametros
            
            cmd.Parameters.AddWithValue("@curso", objCursoN.NameCurso);
            cmd.Parameters.AddWithValue("@horasTeoria", objCursoN.HorasTeoria);
            cmd.Parameters.AddWithValue("@horasPractica", objCursoN.HorasPractica);
            cmd.Parameters.AddWithValue("@complejidad", objCursoN.Complejidad);
            cmd.Parameters.AddWithValue("@comentario", objCursoN.Comentario);
            cmd.Parameters.AddWithValue("@estado", objCursoN.Estado);
            cmd.Parameters.AddWithValue("@usuRegistro", objCursoN.UsuRegistro);
            cmd.Parameters.AddWithValue("@fecRegistro", objCursoN.FecRegistro);
            cmd.Parameters.AddWithValue("@usuUlt_Mod", objCursoN.UsuUlt_Mod);
            cmd.Parameters.AddWithValue("@fecUlt_Mod", DBNull.Value);
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
    public Boolean ActualizarCurso(CursoN objCursoN)
    {
        try
        {
            //Codifique

            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_updateCurso";
            cmd.Parameters.Clear();
            //Agregamos parametros
            cmd.Parameters.AddWithValue("@IdCurso",objCursoN.IdCurso);
            cmd.Parameters.AddWithValue("@curso", objCursoN.NameCurso);
            cmd.Parameters.AddWithValue("@horasTeoria", objCursoN.HorasTeoria);
            cmd.Parameters.AddWithValue("@horasPractica", objCursoN.HorasPractica);
            cmd.Parameters.AddWithValue("@complejidad", objCursoN.Complejidad);
            cmd.Parameters.AddWithValue("@comentario", objCursoN.Comentario);
            cmd.Parameters.AddWithValue("@estado", objCursoN.Estado);
            cmd.Parameters.AddWithValue("@usuRegistro", objCursoN.UsuRegistro);
            cmd.Parameters.AddWithValue("@fecRegistro", objCursoN.FecRegistro);
            cmd.Parameters.AddWithValue("@usuUlt_Mod", objCursoN.UsuUlt_Mod);
            cmd.Parameters.AddWithValue("@fecUlt_Mod", objCursoN.FecUlt_Mod);

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

    public Boolean EliminarCurso(String idCurso)
    {


        try
        {
            //Codifique

            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[sp_deleteCurso]";
            cmd.Parameters.Clear();
            //Agregamos parametros
            cmd.Parameters.AddWithValue("@idCurso", idCurso);

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

}
