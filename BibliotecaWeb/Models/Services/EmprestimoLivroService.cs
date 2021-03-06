using BibliotecaWeb.Models.Contracts.Repositories;
using BibliotecaWeb.Models.Contracts.Services;
using BibliotecaWeb.Models.Dtos;

namespace BibliotecaWeb.Models.Services
{
    public class EmprestimoLivroService : IEmprestimoLivroService
    {
        private readonly IEmprestimoLivroRepository _emprestimoLivroRepository;

        public EmprestimoLivroService(IEmprestimoLivroRepository emprestimoLivroRepository)
        {
            _emprestimoLivroRepository = emprestimoLivroRepository;
        }

        public void AtualizarStatusEmprestimoLivros()
        {
            _emprestimoLivroRepository.AtualizarStatusEmprestimoLivros();
        }

        public List<ConsultaEmprestimoDto> ConsultaEmprestimos()
        {

             return _emprestimoLivroRepository.ConsultarEmprestimos();

        }

        public void EfetuarDevolucao(int emprestimoId, string livroId)
        {
            try
            {
                
                _emprestimoLivroRepository.EfetuarDevolucao(emprestimoId, livroId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EfetuarEmprestimo(EmprestimoLivroDto emprestimoLivro)
        {
            try
            {
                var entidade = emprestimoLivro.ConverterParaEntidade();
                entidade.realizarEmprestimo();
                _emprestimoLivroRepository.EfetuarEmprestimo(entidade);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ConsultaEmprestimoDto PesquisarEmprestimo(string nomeLivro, string nomeCliente, DateTime dataEmprestimo)
        {
            return _emprestimoLivroRepository.PesquisarEmprestimo(nomeLivro, nomeCliente, dataEmprestimo);
        }
    }
}
