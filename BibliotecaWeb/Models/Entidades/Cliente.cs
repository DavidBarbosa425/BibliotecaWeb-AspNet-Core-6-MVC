using BibliotecaWeb.Models.Dtos;
using BibliotecaWeb.Models.Enums;

namespace BibliotecaWeb.Models.Entidades
{
    public class Cliente : EntidadeBase
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Fone { get; set; }
        public int StatusClienteId { get; set; }
        public StatusCliente StatusCliente { get; set; }

        public void Cadastrar()
        {
            this.StatusCliente = StatusCliente.ATIVO;
            this.StatusClienteId = StatusCliente.GetHashCode();
        }

        public ClienteDto ConvertParaDto()
        {
            return new ClienteDto
            {
                Id = this.Id,
                Nome = this.Nome,
                Email = this.Email,
                Fone = this.Fone,
                CPF = this.CPF,
                StatusClienteId = this.StatusClienteId.ToString(),
                Status = GerenciadorDeStatus.PesquisarStatusDoClientePeloId(this.StatusClienteId).ToString()
            };
        }
    }
}
