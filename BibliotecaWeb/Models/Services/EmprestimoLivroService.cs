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
        public void EfetuarDevolucao(EmprestimoLivroDto emprestimoLivro)
        {
            try
            {
                var entidade = emprestimoLivro.ConverterParaEntidade();
                _emprestimoLivroRepository.EfetuarDevolucao(entidade);
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
                _emprestimoLivroRepository.EfetuarEmprestimo(entidade);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
