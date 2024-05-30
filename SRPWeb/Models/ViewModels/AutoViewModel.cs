namespace SRPWeb.Models.ViewModels
{
    public class AutoViewModel
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }

        public string GetInfo() => Marca + " " + Modelo;
    }
}
