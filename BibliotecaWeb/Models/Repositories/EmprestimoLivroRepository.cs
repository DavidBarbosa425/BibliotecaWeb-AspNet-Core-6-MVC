using BibliotecaWeb.Models.Contracts.Contexts;
using BibliotecaWeb.Models.Contracts.Repositories;
using BibliotecaWeb.Models.Dtos;
using BibliotecaWeb.Models.Entidades;

namespace BibliotecaWeb.Models.Repositories
{
    public class EmprestimoLivroRepository : IEmprestimoLivroRepository
    {
        private readonly IContextData _contextData;

        public EmprestimoLivroRepository(IContextData contextData)
        {
            _contextData = contextData; 
        }

        public void AtualizarStatusEmprestimoLivros()
        {
            _contextData.AtualizarStatusEmprestimoLivros();
        }

        public List<ConsultaEmprestimoDto> ConsultarEmprestimos()
        {
            return _contextData.ConsultarEmprestimos();
        }

        public void EfetuarDevolucao(int emprestimoId, string livroId)
        {
            _contextData.EfetuarDevolucaoLivro(emprestimoId, livroId);
        }

        public void EfetuarEmprestimo(EmprestimoLivro emprestimoLivro)
        {
            _contextData.EfetuarEmprestimoLivro(emprestimoLivro);   
        }

        public ConsultaEmprestimoDto PesquisarEmprestimo(string nomeLivro, string nomeCliente, DateTime dataEmprestimo)
        {
            return _contextData.PesquisarEmprestimo(nomeLivro, nomeCliente, dataEmprestimo);
        }
    }
}
