using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public interface IBebida
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public decimal Impuesto { get; set; }

        //en teoría en las interfaces no se implementan métodos pero en las versiones actuales de C# si se puede.
        //En este ejemplo voy a implementar los métodos en las clases que implementen esta interfaz y acá voy a dejar solo la firma del método.
        public decimal GetPrecioFinal();
    }
}
