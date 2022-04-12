using BibliotecaWeb.Models.Dtos;

namespace BibliotecaWeb.Models.Contracts.Services
{
    public interface IEmprestimoLivroService
    {
        void EfetuarEmprestimo(EmprestimoLivroDto emprestimoLivro);
        void EfetuarDevolucao(int emprestimoId, string livroId);
        List<ConsultaEmprestimoDto> ConsultaEmprestimos();
        ConsultaEmprestimoDto PesquisarEmprestimo(string nomeLivro, string nomeCliente, DateTime dataEmprestimo);
        void AtualizarStatusEmprestimoLivros();

    }
}
