using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecasComunes
{
    public class Socio
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public double LimiteLocal { get; set; }
        public int CondicionPago { get; set; }
        public string TipoSocio { get; set; }
        public Cuenta Cuenta { get; set; }
        public Moneda Moneda { get; set; }
    }
}
