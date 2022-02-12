using BibliotecaWeb.Models.Contracts.Contexts;
using BibliotecaWeb.Models.Contracts.Repositories;
using BibliotecaWeb.Models.Dtos;
using BibliotecaWeb.Models.Entidades;

namespace BibliotecaWeb.Models.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly IContextData _contexData;

        public LivroRepository(IContextData contextData)
        {
            _contexData = contextData;
        }

        public void Atualizar(Livro livro)
        {
            _contexData.AtualizarLivro(livro);
        }

        public void Cadastrar(Livro livro)
        {
            _contexData.CadastrarLivro(livro);
        }

        public void Excluir(string id)
        {
           _contexData.ExcluirLivro(id);
        }

        public List<Livro> Listar()
        {
            return _contexData.ListarLivro();
        }

        public Livro PesquisarPorId(string id)
        {
            return _contexData.PesquisarLivroPorId(id);
        }
    }
}
