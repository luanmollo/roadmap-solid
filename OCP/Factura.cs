using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Factura
    {
        //De esta manera, si hubiera un nuevo tipo de bebida en el futuro, ejemplo energizante, deberíamos modificar esta clase para que admita nuestra nueva bebida,
        //lo cuál no corresponde.

        //public class Bebida
        //{
        //    public string Nombre { get; set; }
        //    public string Tipo { get; set; }
        //    public decimal Precio { get; set; }
        //}

        //public decimal GetTotal(IEnumerable<Bebida> bebidas)
        //{
        //    decimal total = 0;
        //    foreach (var b in bebidas)
        //    {
        //        if (b.Tipo == "Agua")
        //            total += b.Precio;
        //        else if (b.Tipo == "Azucar")
        //            total += b.Precio * 1.03m;
        //        else if (b.Tipo == "Alcohol")
        //            total += b.Precio * 1.16m;
        //    }

        //    return total;
        //}


        //En cambio, de la siguiente manera, utilizamos una interfaz para abstraer el tipo de bebida y creamos la firma de un método para que cada una 
        //de las clases que implementa la interfaz, lo implemente como necesite.

        public decimal GetTotal(IEnumerable<IBebida> bebidas)
        {
            decimal total = 0;
            foreach(var b in bebidas)
            {
                //de esta forma la implementación del método GetPrecioFinal puede modificarse y/o extenderse en cada una de las clases que implementen la interfaz IBebida,
                //y eso no va a cambiar como implementamos este método.
                //si en un futuro necesitamos una nueva bebida debemos agregarla e implementar la interfaz IBebida, y por consecuencia implementar el método
                //GetPrecioFinal como corresponda en dicha clase.

                total += b.GetPrecioFinal();
            }

            return total;
        }
    }
}
