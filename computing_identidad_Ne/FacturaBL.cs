using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// Agregar...
using computing_data;
using System.Data;
namespace computing_identidad_Ne
{
    public class FacturaBL
    {
        FacturaADO objFacturaADO = new FacturaADO();

        public DataTable ListarFacturasClienteFechas(String strCodCli,DateTime FecIni, 
                                                                                   DateTime FecFin)
        {
            return objFacturaADO.ListarFacturasClienteFechas(strCodCli,FecIni,FecFin);
        }

      


    }
}
