using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Using....
using computing_data;
using computing_negocio;

namespace computing_identidad_Ne
{
    public class UsuarioE
    {
        UsuarioData objUsuarioADO = new UsuarioData();

        public UsuarioN ConsultarUsuario(String strLogin,String strPassword)
        {
            return objUsuarioADO.ConsultarUsuario(strLogin,strPassword);

        }
    }
}
