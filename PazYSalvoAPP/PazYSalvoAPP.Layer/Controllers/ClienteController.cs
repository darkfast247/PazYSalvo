using Microsoft.AspNetCore.Mvc;

namespace PazYSalvoAPP.Layer.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
