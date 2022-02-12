using BibliotecaWeb.Models.Contracts.Repositories;
using BibliotecaWeb.Models.Contracts.Services;
using BibliotecaWeb.Models.Dtos;

namespace BibliotecaWeb.Models.Services
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public void Atualizar(LivroDto livro)
        {
            try
            {
                var objLivro = livro.ConvertParaEntidade();
                _livroRepository.Atualizar(objLivro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Cadastrar(LivroDto livro)
        {
            try
            {
                var objLivro = livro.ConvertParaEntidade();
                objLivro.Cadastrar();
                _livroRepository.Cadastrar(objLivro);
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
                _livroRepository.Excluir(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<LivroDto> Listar()
        {

            try
            {
                var livroDto = new List<LivroDto>();
                var livros = _livroRepository.Listar();
                foreach (var item in livros)
                {
                    livroDto.Add(item.ConverterParaDto());
                }

                return livroDto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public LivroDto PesquisarPorId(string id)
        {
            try
            {
                var livro = _livroRepository.PesquisarPorId(id);
                return livro.ConverterParaDto();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
