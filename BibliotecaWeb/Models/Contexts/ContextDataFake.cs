using BibliotecaWeb.Models.Contracts.Contexts;
using BibliotecaWeb.Models.Dtos;

namespace BibliotecaWeb.Models.Contexts
{
    public class ContextDataFake : IContextData
    {
        private static List<LivroDto> livros;

        public ContextDataFake()
        {
            livros = new List<LivroDto>();
            InitializeData();
        }

        public void AtualizarLivro(LivroDto livro)
        {

            try
            {
                var objPesquisa = PesquisarLivroPorId(livro.Id);
                livros.Remove(objPesquisa);

                objPesquisa.Nome = livro.Nome;
                objPesquisa.Editora = livro.Editora;
                objPesquisa.Autor = livro.Autor;

                CadastrarLivro(objPesquisa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CadastrarLivro(LivroDto livro)
        {
            try
            {
                livros.Add(livro);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirLivro(string id)
        {
            try
            {
                var objPesquisa = PesquisarLivroPorId(id);
                livros.Remove(objPesquisa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<LivroDto> ListarLivro()
        {
            try
            {
                return livros.OrderBy(p => p.Nome).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public LivroDto PesquisarLivroPorId(string id)
        {
            try
            {
                return livros.FirstOrDefault(p => p.Id == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void InitializeData()
        {
            var livro = new LivroDto("O Código Da Vinci", "Dan Brown", "Random House");
            livros.Add(livro);

            livro = new LivroDto("Anjos e Demonios", "Dan Brown", "Random House");
            livros.Add(livro);

            livro = new LivroDto("A Estrada da Noite", "Joe Hill", "William Morrow Company");
            livros.Add(livro);

            livro = new LivroDto("Dave Mustaine: Memórias do Heavy Metal", "Dave Mustaine", "Belas Letras");
            livros.Add(livro);

            livro = new LivroDto("Slash", "Slash and Anthony Bozza", "Harper Paperbacks");
            livros.Add(livro);


        }
    }
}
