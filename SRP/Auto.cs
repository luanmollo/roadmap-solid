using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Auto
    {
        public Auto(string modelo, string marca) { 
            this.Modelo = modelo;
            this.Marca = marca;
        }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }

    }
}
