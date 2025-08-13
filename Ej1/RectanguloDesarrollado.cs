using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class RectanguloDesarrollado
    {
        public double Ancho { get; set; }
        public double Largo { get; set; }
        public RectanguloDesarrollado(double radio, double altura)
        {
            Ancho = radio * 2 * Math.PI;
            Largo = altura;
        }
        public double CalcularArea()
        {
            return Ancho * Largo;
        }
        public string Describir()
        {
            var culture = CultureInfo.InvariantCulture;
            return $@"
{{
 ""Tipo"": ""Rectangulo Desarrollado"",
 ""Largo"": {Largo.ToString("f2", culture)},
 ""Ancho"": {Ancho.ToString("f2", culture)},
 ""Area"": {CalcularArea().ToString("f2", culture)}
        }}";
        }
    }
}
