using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class AutoDb
    {
        private Auto auto;
        public AutoDb(Auto auto) {
            this.auto = auto;
        }

        public void Guardar()
        {
            Console.WriteLine($"Guardo {auto.Marca} y {auto.Modelo}");
        }

    }
}
