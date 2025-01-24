using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar

using Empresa_Data;
namespace computing_identidad_Ne;

public class EmpresaE
{
    EmpresaData objEmpresaData = new EmpresaData();

    public DataTable ListarEmpresa()
    {
        return objEmpresaData.ListarEmpresa();
    }

}
