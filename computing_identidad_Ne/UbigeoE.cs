using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar

using Ubigeo_Data;
namespace computing_identidad_Ne;

public  class UbigeoE
{
    UbigeoData objUbigeoData = new UbigeoData();

    public DataTable ListarUbigeo()
    {
        return objUbigeoData.ListarUbigeo();
    }

}
