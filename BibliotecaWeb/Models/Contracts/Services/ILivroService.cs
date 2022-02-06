using BibliotecaWeb.Models.Dtos;

namespace BibliotecaWeb.Models.Contracts.Services
{
    public interface ILivroService
    {
        void Cadastrar(LivroDto livro);
        List<LivroDto> Listar();

        LivroDto PesquisarPorId(string id);

        void Atualizar(LivroDto livro);

        void Excluir(string id);
    }
}
