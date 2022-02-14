using BibliotecaWeb.Models.Entidades;

namespace BibliotecaWeb.Models.Contracts.Repositories
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);
        List<Usuario> Listar();
        Usuario PesquisarPorId(string id);
        void Atualizar(Usuario usuario);
        void Excluir(string id);
    }
}
