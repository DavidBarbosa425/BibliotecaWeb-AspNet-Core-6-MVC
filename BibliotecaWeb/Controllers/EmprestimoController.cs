using BibliotecaWeb.Models.Contracts.Services;
using BibliotecaWeb.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaWeb.Controllers
{
    public class EmprestimoController : Controller
    {
        private readonly IEmprestimoLivroService _emprestimo;
        private readonly IClienteService _clienteService;
        private readonly ILivroService _livroService;
        public EmprestimoController(IEmprestimoLivroService emprestimo, IClienteService clienteService, ILivroService livroService)
        {
            _emprestimo = emprestimo;
            _clienteService = clienteService;
            _livroService = livroService;
        }
        public IActionResult Index()
        {
            string login = HttpContext.Session.GetString("_Login");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EfetuarEmprestimo([Bind("Cliente,Livro")]EmprestimoDto emprestimo)
        {
            string login = HttpContext.Session.GetString("_Login");
            return null;
        }

        public IActionResult PesquisarClientes(string term)
        {
            var clientes = _clienteService.Listar();
            var clientesAtivos = clientes.Where(p => p.StatusClienteId.Equals("1")).ToList();
            var listaNomeCliente = clientesAtivos.Select(p => p.Nome).ToList();
            var filtro = listaNomeCliente.Where(p => p.Contains(term, StringComparison.CurrentCultureIgnoreCase)).ToList();
            return Json(filtro);
        }

        public IActionResult PesquisarLivros(string term)
        {
            var livros = _livroService.Listar();
            var livrosDisponiveis = livros.Where(p => p.StatusLivroId == 1).ToList();
            var listaNomeLivro = livrosDisponiveis.Select(p => p.Nome).ToList();
            var filtro = listaNomeLivro.Where(p => p.Contains(term, StringComparison.CurrentCultureIgnoreCase)).ToList();
            return Json(filtro);
        }
    }
}
