using Microsoft.AspNetCore.Mvc;

namespace PazYSalvoAPP.Layer.Controllers
{
    public class FacturaController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Mensaje = "hola clase";
            return View();
        }
    }
}
