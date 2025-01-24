using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar

using Expositor_Data;
namespace computing_identidad_Ne;

public class ExpositorE
{
    ExpositorData objExpositorData = new ExpositorData();

    public DataTable ListarExpositor()
    {
        return objExpositorData.ListarExpositor();
    }

}
