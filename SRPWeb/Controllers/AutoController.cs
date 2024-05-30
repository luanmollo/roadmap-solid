using Microsoft.AspNetCore.Mvc;
using SRPWeb.Models.ViewModels;
using SRPWeb.Service;

namespace SRPWeb.Controllers
{
    public class AutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Agregar(AutoViewModel autoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Error");
            }

            //en lugar de guardar en db y guardar el log acá, vamos a quitar la responsabilidad a esta clase y se la vamos a dar a la clase AutoService

            var autoService = new AutoService();
            autoService.Crear(autoViewModel);

            return View(autoViewModel);
        }
    }
}
