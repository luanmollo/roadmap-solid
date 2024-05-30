using SRPWeb.Models.Db;
using SRPWeb.Models.ViewModels;
using SRPWeb.Utils;

namespace SRPWeb.Service
{
    public class AutoService
    {
        public void Crear(AutoViewModel auto)
        {
            //se encarga de ejecutar los métodos, pero si necesito hacer un cambio en los métodos lo hago directamente en la clase que corresponda,
            //y el servicio no se ve afectado.
            //la responsabilidad de funcionamiento de cada método es de cada una de las clases

            var autoDb = new AutoDb();
            var log = new Log();

            autoDb.Guardar(auto);
            log.Guardar($"Se guardó el auto {auto.GetInfo}");
        }
    }
}
