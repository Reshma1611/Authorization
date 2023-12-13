using Microsoft.AspNetCore.Mvc;

namespace Authorization.Controllers
{
    public class ValuesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
