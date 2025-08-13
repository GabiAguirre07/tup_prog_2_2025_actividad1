using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1
{
    internal class Rectangulo
    {
        public double Ancho {  get; set; }
        public double Largo { get; set; }
        public Rectangulo(double ancho, double largo)
        {
            Ancho = ancho;
            Largo = largo;
        }
        public double CalcularArea()
            { return Ancho * Largo; }
        public string Describir ()
        {
            var culture = CultureInfo.InvariantCulture;

            return $@"
{{ 
  ""Tipo"": ""Rectangulo"", 
  ""Largo"": {Largo.ToString("f2", culture)},
  ""Ancho"": {Ancho.ToString("f2", culture)},
  ""Area"": {CalcularArea().ToString("f2", culture)}
}}";
        }
    }
}
