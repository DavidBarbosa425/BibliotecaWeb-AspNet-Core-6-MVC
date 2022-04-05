using BibliotecaWeb.Models.Contracts.Contexts;
using BibliotecaWeb.Models.Dtos;
using BibliotecaWeb.Models.Entidades;

namespace BibliotecaWeb.Models.Contexts
{
    public class ContextDataFake : IContextData
    {
        private static List<Livro> livros;

        public ContextDataFake()
        {
            //livros = new List<LivroDto>();
            InitializeData();
        }

        public void AtualizarCliente(Livro livro)
        {
            throw new NotImplementedException();
        }

        public void AtualizarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void AtualizarCliente(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void AtualizarLivro(Livro livro)
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

        public void AtualizarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void CadastrarCliente(Livro livro)
        {
            throw new NotImplementedException();
        }

        public void CadastrarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void CadastrarLivro(Livro livro)
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

        public void CadastrarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public List<ConsultaEmprestimoDto> ConsultarEmprestimos()
        {
            throw new NotImplementedException();
        }

        public void EfetuarDevolucaoLivro(EmprestimoLivro emprestimoLivro)
        {
            throw new NotImplementedException();
        }

        public void EfetuarEmprestimoLivro(EmprestimoLivro emprestimoLivro)
        {
            throw new NotImplementedException();
        }

        public UsuarioDto EfetuarLogin(UsuarioDto usuario)
        {
            throw new NotImplementedException();
        }

        public void ExcluirCliente(string id)
        {
            throw new NotImplementedException();
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

        public void ExcluirUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public List<Livro> ListarCliente()
        {
            throw new NotImplementedException();
        }

        public List<Livro> ListarLivro()
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

        public List<Usuario> ListarUsuarios()
        {
            throw new NotImplementedException();
        }

        public Livro PesquisarClientePorId(string id)
        {
            throw new NotImplementedException();
        }

        public Livro PesquisarLivroPorId(string id)
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

        public Cliente PesquisarUsuarioPorId(int id)
        {
            throw new NotImplementedException();
        }

        private void InitializeData()
        {
            var livro = new Livro { Nome = "Código da Vince", Autor = "Dan Brown", Editora = "Qualq" };
            livros.Add(livro);

            //livro = new LivroDto("Anjos e Demonios", "Dan Brown", "Random House");
            //livros.Add(livro);

            //livro = new LivroDto("A Estrada da Noite", "Joe Hill", "William Morrow Company");
            //livros.Add(livro);

            //livro = new LivroDto("Dave Mustaine: Memórias do Heavy Metal", "Dave Mustaine", "Belas Letras");
            //livros.Add(livro);

            //livro = new LivroDto("Slash", "Slash and Anthony Bozza", "Harper Paperbacks");
            //livros.Add(livro);


        }

        List<Cliente> IContextData.ListarCliente()
        {
            throw new NotImplementedException();
        }

        Cliente IContextData.PesquisarClientePorId(string id)
        {
            throw new NotImplementedException();
        }

        Usuario IContextData.PesquisarUsuarioPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
