namespace BibliotecaWeb.Models.Entidades
{
    public class EmprestimoLivro
    {
        public int Id { get; set; }
        public string ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public string LivroId { get; set; }
        public Livro Livro { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public DateTime DataDevolucaoEfetiva { get; set; }

        public void realizarEmprestimo()
        {
            validarEmprestimo();
            this.DataEmprestimo = DateTime.Now;
            this.DataDevolucao = DateTime.Parse(this.DataEmprestimo.AddDays(7).ToShortDateString());
        }

        public void realizarDevolucao()
        {
            this.DataDevolucaoEfetiva = DateTime.Now;
        }
        private void validarEmprestimo()
        {
            if (Cliente == null || Livro == null || Usuario == null)
            {
                throw new Exception("Dados invalidos");
            }
        }


    }
}
