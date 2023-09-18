using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalcularArea
{
    /// <summary>
    /// Descripción breve de CalcularArea
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcularArea : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos, mi nombre es Juan Diego";
        }
        [WebMethod]
        public decimal AreaCuadrado(decimal lado)
        {
            Calcular cala = new Calcular();
            cala.lado = lado;  
            return cala.AreaCuadrado();
        }
        [WebMethod]
        public decimal AreaTriangulo(decimal bas, decimal alt)
        {
            Calcular cala = new Calcular();
            cala.tbase = bas;
            cala.taltura = alt;
            return cala.AreaTriangulo();
        }
        [WebMethod]
        public double AreaCirculo(double radio)
        {
            Calcular cala = new Calcular();
            cala.cradio = radio;
            return cala.AreaCirculo();
        }
    }
}
