using Microsoft.AspNetCore.Mvc;

namespace PazYSalvoAPP.Layer.Controllers
{
    public class PersonaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
