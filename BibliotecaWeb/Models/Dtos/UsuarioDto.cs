using BibliotecaWeb.Models.Entidades;

namespace BibliotecaWeb.Models.Dtos
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public Usuario ConverterParaEntidade()
        {
            return new Usuario { Id = this.Id, Login = this.Login, Senha = this.Senha };
        }
    }
}
