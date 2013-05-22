using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecasComunes
{
    public class Cuenta
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string NombreInternacional{ get; set; }
        public string CodigoCuenta { get; set; }
        public int Nivel { get; set; }
        public bool Titulo { get; set; }
        public Moneda Moneda { get; set; }
        public bool MonedaUnica { get; set; }
        public string TipoCuenta { get; set; }
        public double SaldoSistema { get; set; }
        public double SaldoLocal { get; set; }
        public Cuenta Padre { get; set; } //??? tal vez
        public bool TieneMovimientosAsociados { get; set; } //??? tal vez  
    }
}
