﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecasComunes
{
    public class Linea
    {
        public int documento { get; set; }
        public string articuloCodigo { get; set; }
        public double Cantidad { get; set; }
        public double Total { get; set; }
        public double Impuesto { get; set; }
        public double TotalGeneral { get; set; }
    } 
}
