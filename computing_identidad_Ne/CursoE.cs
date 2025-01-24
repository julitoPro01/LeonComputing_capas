using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar...
using computing_data;
using computing_negocio;

namespace computing_identidad_Ne
{
    public class CursoE
    {
        CursoDdata objCursoData = new CursoDdata();

        public DataTable ListarCurso()
        {
            return objCursoData.ListarCurso();
        }
        public CursoN ConsultarCurso(String idCurso)
        {
            return objCursoData.ConsultarCurso(idCurso);
        }

        public Boolean InsertarCurso(CursoN objCursoDatas)
        {
            return objCursoData.InsertarCurso(objCursoDatas);
        }
        public Boolean ActualizarCurso(CursoN objCursoN)
        {
            return objCursoData.ActualizarCurso(objCursoN);
        }
        public Boolean EliminarCurso(String strCodigo)
        {
            return objCursoData.EliminarCurso(strCodigo);
        }
    }
}
