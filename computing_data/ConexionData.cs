using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computing_data
{
    internal class ConexionData
    {
        public string GetCnx()
        {
            string strCnx =
                ConfigurationManager.ConnectionStrings["computing"].ConnectionString;
            if (object.ReferenceEquals(strCnx, string.Empty))
            {
                return string.Empty;
            }
            else
            {
                return strCnx;
            }
        }
    }
}
