using BibliotecaWeb.Models.Dtos;

namespace BibliotecaWeb.Models.Contracts.Services
{
    public interface IEmprestimoLivroService
    {
        void EfetuarEmprestimo(EmprestimoLivroDto emprestimoLivro);
        void EfetuarDevolucao(EmprestimoLivroDto emprestimoLivro);

    }
}
