namespace BibliotecaWeb.Models.Dtos
{
    public class EmprestimoLivroDto
    {
        public string ClienteId { get; set; }
        public ClienteDto Cliente { get; set; }
        public string LivriId { get; set; }
        public LivroDto Livro { get; set; }
        public string UsuarioId { get; set; }
        public UsuarioDto Usuario { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public DateTime DataDevolucaoEfetiva { get; set; }
    }
}
