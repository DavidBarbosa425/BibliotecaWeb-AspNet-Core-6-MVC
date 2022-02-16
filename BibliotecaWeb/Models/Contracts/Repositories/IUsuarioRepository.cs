using BibliotecaWeb.Models.Dtos;
using BibliotecaWeb.Models.Entidades;

namespace BibliotecaWeb.Models.Contracts.Repositories
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);
        List<Usuario> Listar();
        Usuario PesquisarPorId(int id);
        void Atualizar(Usuario usuario);
        void Excluir(int id);
        UsuarioDto EfetuarLogin(UsuarioDto usuario);
    }
}
