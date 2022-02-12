using BibliotecaWeb.Models.Entidades;
using BibliotecaWeb.Models.Enums;

namespace BibliotecaWeb.Models.Dtos 
{
    public class LivroDto : EntidadeBase
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int StatusLivroId { get; set; }
        public string Status { get; set; }

        public LivroDto()
        {


        }
    

        public Livro ConvertParaEntidade()
        {
            return new Livro
            {
                Id = this.Id,
                Nome = this.Nome,
                Autor = this.Autor,
                Editora = this.Editora,
                StatusLivro = GerenciadorDeStatus.PesquisarStatusDoLivroPorId(this.StatusLivroId)
            };
        }
    }
}
