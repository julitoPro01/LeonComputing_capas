using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfEvento_data
{

        public class ComboBoxItem
        {
            public string Display { get; set; }
            public int Value { get; set; }

            public ComboBoxItem(string display, int value)
            {
                Display = display;
                Value = value;
            }

            // Sobrescribe el método ToString para mostrar el valor de Display en el ComboBox
            public override string ToString()
            {
                return Display;
            }

         
        }


}
