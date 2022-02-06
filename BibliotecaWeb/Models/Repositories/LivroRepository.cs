using BibliotecaWeb.Models.Contracts.Contexts;
using BibliotecaWeb.Models.Contracts.Repositories;
using BibliotecaWeb.Models.Dtos;

namespace BibliotecaWeb.Models.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly IContextData _contexData;

        public LivroRepository(IContextData contextData)
        {
            _contexData = contextData;
        }

        public void Atualizar(LivroDto livro)
        {
            _contexData.AtualizarLivro(livro);
        }

        public void Cadastrar(LivroDto livro)
        {
            _contexData.CadastrarLivro(livro);
        }

        public void Excluir(string id)
        {
           _contexData.ExcluirLivro(id);
        }

        public List<LivroDto> Listar()
        {
            return _contexData.ListarLivro();
        }

        public LivroDto PesquisarPorId(string id)
        {
            return _contexData.PesquisarLivroPorId(id);
        }
    }
}
