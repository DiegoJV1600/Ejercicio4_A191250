using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace CalcularArea
{
    public class Calcular
    {
        public decimal lado { get; set; }
        public decimal taltura { get; set; }
        public decimal tbase { get; set; }
        public double cradio { get; set; }
        public decimal AreaCuadrado()
        {
            return lado * lado;
        }
        public decimal AreaTriangulo()
        {
            var resultado = tbase * taltura;
            return resultado / 2;
        }
        public double AreaCirculo()
        {
            return (cradio * cradio) * Math.PI;
        }
    }
}