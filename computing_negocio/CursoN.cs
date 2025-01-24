using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace computing_negocio
{
    public class CursoN
    {

        public String IdCurso { get; set; }
        public String NameCurso { get; set; }
        public String HorasTeoria { get; set; }
        public String HorasPractica { get; set; }
        public Int16 Complejidad { get; set; }
        public String Comentario { get; set; }
        public Int16 Estado { get; set; }
        public String NomComplejidad { get; set; }
        public String NomEstado { get; set; }
        public String UsuRegistro { get; set; }
        public DateTime FecRegistro { get; set; }
        public String UsuUlt_Mod { get; set; }
        public DateTime? FecUlt_Mod { get; set; }
  
    }
}
