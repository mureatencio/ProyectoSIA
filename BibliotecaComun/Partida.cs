using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecasComunes
{
    public class Partida
    {
        public string Cuenta { get; set; }
        public string Moneda { get; set; }
        public string Debe { get; set; }
        public string Haber { get; set; }
        public string DebeLocal { get; set; }
        public string HaberLocal { get; set; }
        public string DebeSistema { get; set; }
        public string HaberSistema { get; set; }
    }
}
