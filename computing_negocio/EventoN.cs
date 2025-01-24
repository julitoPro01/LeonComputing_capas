using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace computing_negocio
{
    public class EventoN
    {

        public String IdEvento { get; set; }
        public String Evento { get; set; }
        public DateTime FecInicio{ get; set; }
        public DateTime FecFin { get; set; }
        public String nameFrecuencia  { get; set; }
        public Int16 Frecuencia { get; set; }
        public String nameTurno { get; set; }
        public String Turno { get; set; }
        public float Presupuesto { get; set; }
        public String DirecLocal { get; set; }
        public Int16 CuposProg { get; set; }

        public Int16? IdCurso { get; set; }
        public String Curso { get; set; }
        public String? IdExpositor { get; set; }
        public String Expositor { get; set; }
        public Int16? IdEmpresa { get; set; }
        public String RazonSocial { get; set; }
        public String IdUbigeo { get; set; }
        public String Ubigeo { get; set; }
        public String Departamento { get; set; }
        public String Provincia { get; set; }
        public String Distrio { get; set; }
        public String UsuRegistro { get; set; }
        public DateTime FecRegistro { get; set; }
        public String? UsuUlt_Mod { get; set; }
        public DateTime? FecUlt_Mod { get; set; }

    }
}
