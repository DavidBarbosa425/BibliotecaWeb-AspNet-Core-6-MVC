using BibliotecaWeb.Models.Contracts.Repositories;
using BibliotecaWeb.Models.Contracts.Services;
using BibliotecaWeb.Models.Dtos;

namespace BibliotecaWeb.Models.Services
{

    public class    ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void Atualizar(ClienteDto cliente)
        {
            try
            {
                var objCliente = cliente.ConverterParaEntidade();
                _clienteRepository.Atualizar(objCliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Cadastrar(ClienteDto cliente)
        {
            try
            {
                var objCliente = cliente.ConverterParaEntidade();
                objCliente.Cadastrar();
                _clienteRepository.Cadastrar(objCliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(string id)
        {
            try
            {
                _clienteRepository.Excluir(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ClienteDto> Listar()
        {

            try
            {
                var clienteDto = new List<ClienteDto>();
                var cliente = _clienteRepository.Listar();
                foreach (var item in cliente)
                {
                    clienteDto.Add(item.ConvertParaDto());
                }

                return clienteDto;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public ClienteDto PesquisarPorId(string id)
        {
            try
            {
                var cliente = _clienteRepository.PesquisarPorId(id);
                return cliente.ConvertParaDto();
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}


