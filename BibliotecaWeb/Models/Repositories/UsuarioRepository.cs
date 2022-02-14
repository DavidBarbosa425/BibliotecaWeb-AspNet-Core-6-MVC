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
            _contexData.AtualizarUsuario(usuario);
        }

        public void Cadastrar(Usuario usuario)
        {
            _contexData.CadastrarUsuario(usuario);
        }

        public void Excluir(int id)
        {
            _contexData.ExcluirUsuario(id);
        }

        public List<Usuario> Listar()
        {
           return _contexData.ListarUsuarios();
        }

        public Usuario PesquisarPorId(int id)
        {
            return _contexData.PesquisarUsuarioPorId(id);
        }
    }
}
