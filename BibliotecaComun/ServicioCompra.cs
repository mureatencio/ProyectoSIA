using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecasComunes
{
    public class ServicioCompra
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Total { get; set; }
        public int Impuesto { get; set; }
        public double TotalImpuesto { get; set; }
    }
}
