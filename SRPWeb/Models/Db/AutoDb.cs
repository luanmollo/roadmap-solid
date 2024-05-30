using SRPWeb.Models.ViewModels;

namespace SRPWeb.Models.Db
{
    public class AutoDb
    {
        public void Guardar(AutoViewModel auto)
        {
            Console.WriteLine($"Guardo en base de datos {auto.Marca} y {auto.Modelo}");
        }
    }
}
