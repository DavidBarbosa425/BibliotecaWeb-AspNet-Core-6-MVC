using Microsoft.AspNetCore.Mvc;

namespace BibliotecaWeb.Controllers
{
    public class EmprestimoController : Controller
    {
        public IActionResult Index()
        {
            string login = HttpContext.Session.GetString("_Login");
            return View();
        }
    }
}
