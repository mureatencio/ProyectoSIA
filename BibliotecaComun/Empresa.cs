using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BibliotecasComunes
{
    public class Empresa
    {
        public string Nombre { get; set; }
        public long CedulaJuridica { get; set; }
        public long Telefono { get; set; }
        public long Fax { get; set; }
        public byte[] Imagen {get; set;}
        public string MonedaLocal { get; set; }
        public string MonedaSistema { get; set; }
//        public Bitmap Logotipo { get; set; }
    }
}
