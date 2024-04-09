using Microsoft.AspNetCore.Mvc;

namespace PazYSalvoAPP.Layer.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
