using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class Cilindro
    {
        protected Circulo[] tapas;
        protected RectanguloDesarrollado lado;
        public Cilindro(double radio, double altura)
        {
            tapas = new Circulo[2];
            tapas[0] = new Circulo(radio);
            tapas[1] = new Circulo(radio);
            lado = new RectanguloDesarrollado(radio, altura);
        }
        public double CalcularArea()
        { 
            return 2 * tapas[0].CalcularArea() + lado.CalcularArea();
        }
        public double CalcularVolumen()
        {
            return tapas[0].CalcularArea() * lado.Largo;
        }
        public string Describir()
        {
            var culture = CultureInfo.InvariantCulture;
            string descripcion = $@"{{
 ""Tipo"": ""Cilindro"",
""Tapas"": 
[
  {tapas[0].Describir()},
  {tapas[1].Describir()}
 ],
 ""Lado"": {lado.Describir()},
 ""Area"": {CalcularArea().ToString("f2", culture)},
 ""Volumen"": {CalcularVolumen().ToString("f2", culture)}
}}";
            return descripcion;
        }
    }
}
