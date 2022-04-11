using BibliotecaWeb.Models.Dtos;
using BibliotecaWeb.Models.Entidades;

namespace BibliotecaWeb.Models.Contracts.Repositories
{
    public interface IEmprestimoLivroRepository
    {
        void EfetuarEmprestimo(EmprestimoLivro emprestimoLivro);
        void EfetuarDevolucao(int emprestimoId, string livroId);
        List<ConsultaEmprestimoDto> ConsultarEmprestimos();
        ConsultaEmprestimoDto PesquisarEmprestimo(string nomeLivro, string nomeCliente, DateTime dataEmprestimo);

    }
}
