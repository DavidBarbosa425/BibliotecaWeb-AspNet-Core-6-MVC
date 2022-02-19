using Microsoft.AspNetCore.Mvc;

namespace BibliotecaWeb.Controllers
{
    public class EmprestimoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
