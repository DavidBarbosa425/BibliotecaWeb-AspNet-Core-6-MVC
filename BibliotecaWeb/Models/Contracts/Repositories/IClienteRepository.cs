using BibliotecaWeb.Models.Entidades;

namespace BibliotecaWeb.Models.Contracts.Repositories
{
    public interface IClienteRepository
    {
        void Cadastrar(Cliente cliente);
        List<Cliente> Listar();
        Cliente PesquisarPorId(string id);
        void Atualizar(Cliente cliente);
        void Excluir(string id);

    }
}
