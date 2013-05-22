using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using AsientosWS.Logica;

namespace AsientosWS
{
    [WebService(Namespace = "http://localhost/ServicioAsientos", Name="AsientosWS")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class GuardarAsientosWS : System.Web.Services.WebService
    {
        [WebMethod]
        public void GuardarAsiento(DataTable tabla, string compania, int numAsiento, string detalle)
        {
            LogicaAsientos.crearAsiento(tabla, compania, numAsiento, detalle);
        }
    }
}