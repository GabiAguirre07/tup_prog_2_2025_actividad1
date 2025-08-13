using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class Cubo
    {
        protected Cuadrado[] caras { get; set; }
        public Cubo(double lado)
        {
            caras = new Cuadrado[6];
            for (int n = 0; n < 6; n++)
            {
                caras[n] = new Cuadrado(lado);
            }
           
        }
        public double CalcularArea()
        {
            return caras[0].CalcularArea() * 6;
        }
        public double CalcularVolumen()
        {
            double lado = caras[0].Ancho;
            return lado * lado * lado;
        }
        public string Describir()
        {
            var culture = CultureInfo.InvariantCulture;
            string lateralesDescripcion = "";
            for (int n = 0; n < 6; n++)
            {
                lateralesDescripcion += caras[n].Describir() + ", \n";
            }

            string descripcion = $@"{{  
  ""Tipo"": ""Cubo"", 
  ""Caras"": 
  [
    {lateralesDescripcion}
  ],  
  ""Area"": {CalcularArea().ToString("f2", culture)},
  ""Volumen"": {CalcularVolumen().ToString("f2", culture)}
}}";
            return descripcion;
        }
    }
}
