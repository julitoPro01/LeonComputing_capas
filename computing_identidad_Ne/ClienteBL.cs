using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregamos
using computing_data;
using computing_negocio;
namespace computing_identidad_Ne
{
    public class ClienteBL
    {
        ClienteADO objClienteADO = new ClienteADO();

        public ClienteBE ConsultarCliente(String strCod)
        {
            return objClienteADO.ConsultarCliente(strCod);
        }
    }
}
