using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class AutoRequest
    {
        private Auto auto;
        public AutoRequest(Auto auto) {
            this.auto = auto;
        }

        public void Enviar()
        {
            Console.WriteLine($"Envío {auto.Marca} y {auto.Modelo}");
        }
    }


}

