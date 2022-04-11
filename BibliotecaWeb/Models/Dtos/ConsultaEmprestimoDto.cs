﻿namespace BibliotecaWeb.Models.Dtos
{
    public class ConsultaEmprestimoDto
    {
        public int Id { get; set; }
        public string LivroId { get; set; }
        public string Livro { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public string Cliente { get; set; }
        public string CPF { get; set; }
        public string DataEmprestimo { get; set; }
        public string DataDevolucao { get; set; }
        public string DataDevolucaoEfetiva { get; set; }
        public string StatusLivro { get; set; }
        public string LoginBibliotecario { get; set; }

    }
}
