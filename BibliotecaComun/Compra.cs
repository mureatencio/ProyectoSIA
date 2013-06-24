using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecasComunes
{
    public class Compra
    {
        public int ID { get; set; }
        public int Consecutivo { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }
        public double Impuesto { get; set; }
        public double TotalJunto { get; set; }
        public string TipoCompra { get; set; }
        public Moneda Moneda { get; set; }
        public Socio Proveedor { get; set; }
        public Proyecto Proyecto { get; set; }
        public List<ServicioCompra> Servicios { get; set; }
    }
}
