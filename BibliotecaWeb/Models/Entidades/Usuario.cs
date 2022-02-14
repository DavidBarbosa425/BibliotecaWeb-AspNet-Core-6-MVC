using BibliotecaWeb.Models.Dtos;

namespace BibliotecaWeb.Models.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public UsuarioDto ConverterParaDto()
        {
            return new UsuarioDto { Id = this.Id, Login = this.Login, Senha = this.Senha };
        }
    }
}
