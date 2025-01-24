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
using System.Diagnostics;
namespace computing_data;

public class EventoData
{
    // Instancias.....
    ConexionData MiConexion = new ConexionData();
    SqlConnection cnx = new SqlConnection();
    SqlCommand cmd = new SqlCommand();
    SqlDataReader dtr;

    public DataTable ListarEvento()
    {

        try
        {

            // Codifique
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_getEventos";
            cmd.Parameters.Clear();

            DataSet dts = new DataSet();
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            // ada.SelectCommand = cmd;
            ada.Fill(dts, "Eventos");
            return dts.Tables["Eventos"];

        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message);
        }

    }
    public EventoN ConsultarEvento(String idEvento)
    {

        try
        {
            //Codifique
            // Creamos la instancia de ProductoBE a retornar
            EventoN objEventoN = new EventoN();

            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_getEvento";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idevento", idEvento);

            cnx.Open();
            dtr = cmd.ExecuteReader();

            if (dtr.HasRows == true)
            {
                // si devuelve resultados, se lee la fila y sus columnas
                // se asigna a las propiedades de la instancia objProductoBE

                dtr.Read();


                objEventoN.IdEvento = dtr["idevento"].ToString();
                objEventoN.Evento = dtr["evento"].ToString();
                objEventoN.FecInicio = dtr.GetDateTime(dtr.GetOrdinal("fecinicio"));
                objEventoN.FecFin = dtr.GetDateTime(dtr.GetOrdinal("fecfin"));
                objEventoN.nameFrecuencia = dtr["frecuencia"].ToString();
                objEventoN.Frecuencia = Convert.ToInt16(dtr["cod_frecuencia"]);

                objEventoN.Turno = dtr["cod_turno"].ToString();
                objEventoN.nameTurno = dtr["turno"].ToString();

                objEventoN.Presupuesto = Convert.ToSingle(dtr["presupuesto"]);
                objEventoN.DirecLocal = dtr["direclocal"].ToString();
                objEventoN.CuposProg = Convert.ToInt16(dtr["cuposProg"]);

                objEventoN.IdCurso = Convert.ToInt16(dtr["idCurso"]);
                objEventoN.Curso = dtr["Curso"].ToString();
                objEventoN.IdExpositor = dtr["idExpositor"].ToString();
                objEventoN.Expositor = dtr["nombre_exp"].ToString();
                objEventoN.IdEmpresa = Convert.ToInt16(dtr["idEmpresa"]);
                objEventoN.RazonSocial = dtr["razonSocial"].ToString();
         

                objEventoN.UsuRegistro = dtr["usuRegistro"].ToString();
                objEventoN.FecRegistro = dtr.GetDateTime(dtr.GetOrdinal("fecRegistro"));
                objEventoN.UsuUlt_Mod = dtr["usuUlt_Mod"].ToString();
           
                objEventoN.FecUlt_Mod =dtr.IsDBNull(dtr.GetOrdinal("fecUlt_Mod"))
                            ? (DateTime?)null
                            : dtr.GetDateTime(dtr.GetOrdinal("fecUlt_Mod"));


                objEventoN.IdUbigeo = dtr["idUbigeo"].ToString();
                objEventoN.Ubigeo = dtr["Ubigeo"].ToString();
              /* 
              */

            }
            else
            {
                objEventoN.IdEvento = string.Empty;

            }

            dtr.Close();
            return objEventoN;


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

    public Boolean InsertarEvento(EventoN objEventoN)
    {

        try
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_addEvento";
            cmd.Parameters.Clear();
            //Agregamos parametros
            //cmd.Parameters.AddWithValue("@idAsociado", objAsociadoN.IdAsociado);
            cmd.Parameters.AddWithValue("@evento", objEventoN.Evento);
            cmd.Parameters.AddWithValue("@fecInicio", objEventoN.FecInicio);
            cmd.Parameters.AddWithValue("@fecFin", objEventoN.FecFin);
            cmd.Parameters.AddWithValue("@frecuencia", objEventoN.Frecuencia);
            cmd.Parameters.AddWithValue("@turno", objEventoN.Turno);
            cmd.Parameters.AddWithValue("@presupuesto", objEventoN.Presupuesto);
            cmd.Parameters.AddWithValue("@direcLocal", objEventoN.DirecLocal);
            cmd.Parameters.AddWithValue("@cuposProg", objEventoN.CuposProg);
            cmd.Parameters.AddWithValue("@usuRegistro", objEventoN.UsuRegistro);
            cmd.Parameters.AddWithValue("@fecRegistro", objEventoN.FecRegistro);

            cmd.Parameters.AddWithValue("@usuUlt_Mod", objEventoN.UsuUlt_Mod);
            cmd.Parameters.AddWithValue("@fecUlt_Mod", (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@idCurso", objEventoN.IdCurso);
            cmd.Parameters.AddWithValue("@idExpositor", objEventoN.IdExpositor);
            cmd.Parameters.AddWithValue("@idEmpresa", objEventoN.IdEmpresa);
            cmd.Parameters.AddWithValue("@idUbigeo", objEventoN.IdUbigeo);
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
    public Boolean ActualizarEvento(EventoN objEventoN)
    {
        try
        {
            //Codifique

            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_updateEvento";
            cmd.Parameters.Clear();
            //Agregamos parametros
            cmd.Parameters.AddWithValue("@idevento", objEventoN.IdEvento);
            cmd.Parameters.AddWithValue("@evento", objEventoN.Evento);
            cmd.Parameters.AddWithValue("@fecInicio", objEventoN.FecInicio);
            cmd.Parameters.AddWithValue("@fecFin", objEventoN.FecFin);
            cmd.Parameters.AddWithValue("@frecuencia", objEventoN.Frecuencia);
            cmd.Parameters.AddWithValue("@turno", objEventoN.Turno);
            cmd.Parameters.AddWithValue("@presupuesto", objEventoN.Presupuesto);
            cmd.Parameters.AddWithValue("@direcLocal", objEventoN.DirecLocal);
            cmd.Parameters.AddWithValue("@cuposProg", objEventoN.CuposProg);
            cmd.Parameters.AddWithValue("@usuRegistro", objEventoN.UsuRegistro);
            cmd.Parameters.AddWithValue("@fecRegistro", objEventoN.FecRegistro);

            cmd.Parameters.AddWithValue("@usuUlt_Mod", objEventoN.UsuUlt_Mod);
            cmd.Parameters.AddWithValue("@fecUlt_Mod", objEventoN.FecUlt_Mod);
            cmd.Parameters.AddWithValue("@idCurso", objEventoN.IdCurso);
            cmd.Parameters.AddWithValue("@idExpositor", objEventoN.IdExpositor);
            cmd.Parameters.AddWithValue("@idEmpresa", objEventoN.IdEmpresa);
            cmd.Parameters.AddWithValue("@idUbigeo", objEventoN.IdUbigeo);


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

    public Boolean EliminarEvento(String idAsociado)
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

