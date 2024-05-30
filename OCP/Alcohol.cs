﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Alcohol : IBebida
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public decimal Impuesto { get; set; }

        public decimal GetPrecioFinal()
        {
            return Precio * (1 + Impuesto);
        }
    }
}
