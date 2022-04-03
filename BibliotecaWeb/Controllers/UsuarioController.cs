using BibliotecaWeb.Models.Contracts.Services;
using BibliotecaWeb.Models.Dtos;
using BibliotecaWeb.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaWeb.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string login, string senha)
        {
            try
            {
                UsuarioDto usuario = new UsuarioDto { Login = login, Senha = senha };
                UsuarioDto resultado = _usuarioService.EfetuarLogin(usuario);


                if (resultado != null)
                {

                    HttpContext.Session.SetString("_UserId", resultado.Id.ToString());
                    HttpContext.Session.SetString("_Login", resultado.Login);

                    TempData["loginError"] = false;

                    return Redirect("/Emprestimo/Index");
                }
                else
                {
                    TempData["loginError"] = true;
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult logout()
        {

            HttpContext.Session.Remove("_UserId");
            HttpContext.Session.Remove("_Login");
            TempData["loginError"] = false;

            return Redirect("/Home");
        }
    }
}
