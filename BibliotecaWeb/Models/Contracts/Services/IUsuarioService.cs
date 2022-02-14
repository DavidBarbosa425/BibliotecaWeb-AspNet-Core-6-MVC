using BibliotecaWeb.Models.Dtos;

namespace BibliotecaWeb.Models.Contracts.Services
{
    public interface IUsuarioService
    {

        void Cadastrar(UsuarioDto usuario);
        List<UsuarioDto> Listar();
        UsuarioDto PesquisarPorId(int id);
        void Atualizar(UsuarioDto usuario);
        void Excluir(int id);

    }
}
