using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class Circulo
    {
        public double Radio { get; set; }
        public Circulo(double radio)
        {
            Radio = radio;
        }
        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }
        public string Describir()
        {
            var culture = CultureInfo.InvariantCulture;
            return $@"{{
    ""Tipo"": ""Circulo"",
    ""Radio"": {Radio.ToString("f2", culture)},
    ""Area"": {CalcularArea().ToString("f2", culture)}
}}";
            
        }
    }
    }

