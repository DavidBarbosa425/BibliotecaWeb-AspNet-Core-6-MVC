using BibliotecaWeb.Models.Contracts.Contexts;
using BibliotecaWeb.Models.Contracts.Repositories;
using BibliotecaWeb.Models.Entidades;

namespace BibliotecaWeb.Models.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly IContextData _contexData;

        public UsuarioRepository(IContextData contextData)
        {
            _contexData = contextData;
        }

        public void Atualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Excluir(string id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> Listar()
        {
            throw new NotImplementedException();
        }

        public Usuario PesquisarPorId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
