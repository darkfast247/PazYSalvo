using Microsoft.AspNetCore.Mvc;

namespace PazYSalvoAPP.Layer.Controllers
{
    public class ServicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
