using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace BibliotecasComunes
{
    public class Servicio
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Comentario { get; set; }
        public string Unidad { get; set; }
        public double Precio { get; set; }
       // public List<byte[]> Imagenes { get; set; }
    }
}
