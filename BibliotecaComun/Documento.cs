<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecasComunes
{
    public class Documento
    {
        public string socio { get; set; }
        public string moneda { get; set; }
        public DateTime fechaContabilizacion { get; set; }
        public string tipo { get; set; }
        public string proyecto { get; set; }
        public double totalPrecio { get; set; }
        public double impuesto { get; set; }
        public double total { get; set; }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecasComunes
{
    public class Documento
    {
        public int Numero { get; set; }
        public int ID { get; set; }
        public DateTime fechaContabilizacion { get; set; }
        public double totalPrecio { get; set; }
        public double impuesto { get; set; }
        public double total { get; set; }
        public string tipo { get; set; }
        public string moneda { get; set; }
        public string socio { get; set; }
        public string proyecto { get; set; }
        public List<Linea> Servicios { get; set; }
    }
}
>>>>>>> origin/Compras-y-ventas
