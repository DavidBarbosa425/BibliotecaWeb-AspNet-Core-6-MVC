using BibliotecaWeb.Models.Dtos;

namespace BibliotecaWeb.Models.Contracts.Services
{
    public interface IEmprestimoLivroService
    {
        void EfetuarEmprestimo(EmprestimoLivroDto emprestimoLivro);
        void EfetuarDevolucao(EmprestimoLivroDto emprestimoLivro);
        List<ConsultaEmprestimoDto> ConsultaEmprestimos();
        ConsultaEmprestimoDto PesquisarEmprestimo(string nomeLivro, string nomeCliente, DateTime dataEmprestimo);

    }
}
