using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecasComunes
{
    public class Moneda
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Simbolo { get; set; }
        public String Codigo { get; set; }
        public int CodigoBC { get; set; }
        public double Factor { get; set; }
    }
}
