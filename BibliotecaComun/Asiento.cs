using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecasComunes
{
    public class Asiento
    {
        public int Codigo { get; set; }
        public string Detalle { get; set; }
        public string FechaDocumento { get; set; }
        public string FechaContabilizacion { get; set; }
        public string TipoAsiento { get; set; }
        public string TotalDebeLocal { get; set; }
        public string TotalHaberLocal { get; set; }
        public string TotalDebeSistema { get; set; }
        public string TotalHaberSistema { get; set; }
    }
}
