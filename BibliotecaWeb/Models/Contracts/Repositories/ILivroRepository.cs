using BibliotecaWeb.Models.Dtos;
using BibliotecaWeb.Models.Entidades;

namespace BibliotecaWeb.Models.Contracts.Repositories
{
    public interface ILivroRepository
    {
        void Cadastrar(Livro livro);
        List<Livro> Listar();

        Livro PesquisarPorId(string id);

        void Atualizar(Livro livro);

        void Excluir(string id);
    }
}
