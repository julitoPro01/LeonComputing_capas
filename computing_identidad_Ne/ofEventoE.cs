using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OfEvento_data;
namespace computing_identidad_Ne
{
    internal class OfEventoE
    {
      
        public ComboBoxItem ListarTurno(string display, int value)
        {
            return new ComboBoxItem(display,value);
        }
    }
}
