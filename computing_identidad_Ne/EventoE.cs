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
    public class EventoE
    {
        EventoData objEventoData = new EventoData();

        public DataTable ListarEvento()
        {
            return objEventoData.ListarEvento();
        }
        public EventoN ConsultarEvento(String idEvento)
        {
            return objEventoData.ConsultarEvento(idEvento);
        }

        public Boolean InsertarEvento(EventoN objEventoE)
        {
            return objEventoData.InsertarEvento(objEventoE);
        }
        public Boolean ActualizarEvento(EventoN objEventoE)
        {
            return objEventoData.ActualizarEvento(objEventoE);
        }
        public Boolean EliminarEvento(String strCodigo)
        {
            return objEventoData.EliminarEvento(strCodigo);
        }
    }
}
