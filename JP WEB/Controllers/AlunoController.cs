using Microsoft.AspNetCore.Mvc;

namespace JP_WEB.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
