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
    public  class AsociadoE
    {
        AsociadoData objAsociadoData = new AsociadoData();

        public DataTable ListarAsociados()
        { 
           return objAsociadoData.ListarAsociados();
        }
        public AsociadoN ConsultarAsociado(String idAsociado)
        {
            return objAsociadoData.ConsultarAsociado(idAsociado);
        }

        public Boolean InsertarAsociado(AsociadoN objAsociadoDatas)
        {
            return objAsociadoData.InsertarAsociado( objAsociadoDatas );
        }
        public Boolean ActualizarAsociado(AsociadoN objAsociadoN)
        {
            return objAsociadoData.ActualizarAsociado(objAsociadoN);
        }
        public Boolean EliminarAsociado(String strCodigo)
        {
            return objAsociadoData.EliminarAsociado(strCodigo);
        }
    }
}
