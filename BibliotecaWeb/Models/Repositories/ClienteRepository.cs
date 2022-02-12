using BibliotecaWeb.Models.Contracts.Contexts;
using BibliotecaWeb.Models.Contracts.Repositories;
using BibliotecaWeb.Models.Entidades;

namespace BibliotecaWeb.Models.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IContextData _contextData;
        public ClienteRepository(IContextData contextData)
        {
            _contextData = contextData;
        }
        public void Atualizar(Cliente cliente)
        {
            _contextData.AtualizarCliente(cliente);
        }

        public void Cadastrar(Cliente cliente)
        {
            _contextData.CadastrarCliente(cliente);
        }

        public void Excluir(string id)
        {
            _contextData.ExcluirCliente(id);
        }

        public List<Cliente> Listar()
        {
            return _contextData.ListarCliente();
        }

        public Cliente PesquisarPorId(string id)
        {
            return _contextData.PesquisarClientePorId(id);
        }
    }
}
