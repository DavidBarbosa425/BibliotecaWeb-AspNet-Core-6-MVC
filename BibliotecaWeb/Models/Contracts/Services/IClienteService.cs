using BibliotecaWeb.Models.Dtos;

namespace BibliotecaWeb.Models.Contracts.Services
{
    public interface IClienteService
    {

        void Cadastrar(ClienteDto cliente);
        List<ClienteDto> Listar();
        ClienteDto PesquisarPorId(string id);
        void Atualizar(ClienteDto cliente);
        void Excluir(string id);

    }
}
