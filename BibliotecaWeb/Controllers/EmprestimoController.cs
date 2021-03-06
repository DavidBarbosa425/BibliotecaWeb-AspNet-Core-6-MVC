using BibliotecaWeb.Models.Contracts.Services;
using BibliotecaWeb.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaWeb.Controllers
{
    public class EmprestimoController : Controller
    {
        private readonly IEmprestimoLivroService _emprestimoService;
        private readonly IClienteService _clienteService;
        private readonly ILivroService _livroService;
        public EmprestimoController(IEmprestimoLivroService emprestimoService, IClienteService clienteService, ILivroService livroService)
        {
            _emprestimoService = emprestimoService;
            _clienteService = clienteService;
            _livroService = livroService;
        }
        public IActionResult Index()
        {
            string login = HttpContext.Session.GetString("_Login");
            return View();
        }

        public IActionResult Consulta()
        {
            try
            {
                _emprestimoService.AtualizarStatusEmprestimoLivros();
                var emprestimos = _emprestimoService.ConsultaEmprestimos();
                return View(emprestimos);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }

        public IActionResult PesquisarEmprestimo(string nomeLivro, string nomeCliente, string dataEmprestimo)
        {

            try
            {

                DateTime dataEmprestimoFormatada = DateTime.Parse(dataEmprestimo);
                ConsultaEmprestimoDto result = _emprestimoService.PesquisarEmprestimo(nomeLivro, nomeCliente, dataEmprestimoFormatada);
                return View(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult EfetuarDevolucao(int emprestimoId, string livroId)
        {
            try
            {
                _emprestimoService.EfetuarDevolucao(emprestimoId, livroId);
                return RedirectToAction("Consulta");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EfetuarEmprestimo([Bind("Cliente,Livro")] EmprestimoDto emprestimo)
        {
            try
            {
                int userId = Int32.Parse(HttpContext.Session.GetString("_UserId"));
                string login = HttpContext.Session.GetString("_Login");

                EmprestimoLivroDto entidade = new EmprestimoLivroDto();

                entidade.Cliente = PesquisarCliente(emprestimo.Cliente);
                entidade.ClienteId = entidade.Cliente.Id;

                entidade.Livro = PesquisarLivro(emprestimo.Livro);
                entidade.LivroId = entidade.Livro.Id;

                entidade.UsuarioId = userId;
                entidade.Usuario = new UsuarioDto { Id = userId, Login = login };

                _emprestimoService.EfetuarEmprestimo(entidade);

                return RedirectToAction("Consulta"); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public ClienteDto PesquisarCliente(string nome)
        {

            var cliente = _clienteService.Listar()
                .Where(p => p.Nome.Equals(nome)).FirstOrDefault();
            return cliente;


        }

        public LivroDto PesquisarLivro(string nome)
        {

            var livro = _livroService.Listar()
                .Where(p => p.Nome.Equals(nome)).FirstOrDefault();
            return livro;
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
