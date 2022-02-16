using BibliotecaWeb.Models.Contracts.Repositories;
using BibliotecaWeb.Models.Contracts.Services;
using BibliotecaWeb.Models.Dtos;

namespace BibliotecaWeb.Models.Services
{

    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void Atualizar(UsuarioDto usuario)
        {
            try
            {
                var objUsuario = usuario.ConverterParaEntidade();
                _usuarioRepository.Atualizar(objUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Cadastrar(UsuarioDto usuario)
        {
            try
            {
                var objUsuario = usuario.ConverterParaEntidade();
                _usuarioRepository.Cadastrar(objUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public UsuarioDto EfetuarLogin(UsuarioDto usuario)
        {
            try
            {
                var validacao = _usuarioRepository.EfetuarLogin(usuario);
                return validacao;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(int id)
        {
            try
            {
                _usuarioRepository.Excluir(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<UsuarioDto> Listar()
        {

            try
            {
                var usuarios = new List<UsuarioDto>();
                var lista = _usuarioRepository.Listar();

                foreach (var item in lista)
                {
                    var usuario = item.ConverterParaDto();
                    usuarios.Add(usuario);
                }

                return usuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public UsuarioDto PesquisarPorId(int id)
        {
            try
            {
                var usuario = _usuarioRepository.PesquisarPorId(id);
                return usuario.ConverterParaDto();
            } 
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}


