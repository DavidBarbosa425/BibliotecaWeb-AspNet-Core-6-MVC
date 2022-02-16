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
                    return Redirect("/Home");
                }
                else
                {
                    return Redirect("/Home");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
