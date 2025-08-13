using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Ej1
{
    internal class Ortoedro
    {
        protected Rectangulo[] Bases { get; set; }
        protected Rectangulo[] Laterales { get; set; }
        public Ortoedro (double AnchoBase,double ladoComun,double LargoLateral)
        {
         Laterales = new Rectangulo[4];
         Bases = new Rectangulo[2];
         Bases[0] = new Rectangulo (AnchoBase, ladoComun); 
         Bases[1] = new Rectangulo(AnchoBase, ladoComun);
            Laterales[0] = new Rectangulo(ladoComun, LargoLateral);
            Laterales[1] = new Rectangulo(ladoComun, LargoLateral);
            Laterales[2] = new Rectangulo(ladoComun, LargoLateral);
            Laterales[3] = new Rectangulo(ladoComun, LargoLateral);

        }
       
        public double CalcularArea()
        {
            double area = Bases[0].CalcularArea() + Bases[1].CalcularArea();

            for (int n = 0; n < 4; n++)
            {
                area += Laterales[n].CalcularArea();
            }
            return area;
        }
        public double CalcularVolumen()
        {
            double ancho = Bases[0].Ancho;
            double alto = Bases[0].Largo; 
            double largo = Laterales[0].Ancho;
            return ancho * alto * largo;
        }
            public string Describir()
        {
            var culture = CultureInfo.InvariantCulture;
            string lateralesdescripcion = "";
            for (int n = 0; n < 3; n++)
            {
                lateralesdescripcion += Laterales[n].Describir() +", \n";
            }
            lateralesdescripcion += Laterales[3].Describir();
            string descripcion = $@"{{
    ""Tipo"": ""Ortoedro"",
    ""Tapas"":
[
        {Bases[0].Describir()},
        {Bases[1].Describir()}
    ],
    ""Laterales"":
[
        {lateralesdescripcion}
    ],
    ""Area"": {CalcularArea().ToString("f2", culture)},
    ""Volumen"": {CalcularVolumen().ToString("f2", culture)}
}}";
            return descripcion;
        }
    }
}
    

