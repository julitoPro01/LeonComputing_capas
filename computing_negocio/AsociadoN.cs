using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace computing_negocio
{
    public class AsociadoN
    {
  
        public String IdAsociado { get; set; }
        public String ApePaterno { get; set; }
        public String ApeMaterno { get; set; }
        public String  Nombre { get; set; }
        public String Direccion { get; set; }
        public DateTime  FecIngreso { get; set; }
        public String  Dni { get; set; }
        public String TelDomicilio { get; set; }
        public String  TelCelular { get; set; }
        public String Mail { get; set; }
        public DateTime  FecUltimaCapac { get; set; }
        public Byte[] Foto { get; set; }
        public Int16 Estado { get; set; }
        public String UsuRegistro { get; set; }
        public DateTime FecRegistro { get; set; }
        public String UsuUlt_Mod { get; set; }
        public DateTime? FecUlt_Mod { get; set; }
        public String IdUbigeo { get; set; }
        public String Ubigeo { get; set; }
    }
}
