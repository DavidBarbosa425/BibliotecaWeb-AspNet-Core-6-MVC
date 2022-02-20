﻿using BibliotecaWeb.Models.Entidades;

namespace BibliotecaWeb.Models.Dtos
{
    public class EmprestimoLivroDto
    {
        public string ClienteId { get; set; }
        public ClienteDto Cliente { get; set; }
        public string LivroId { get; set; }
        public LivroDto Livro { get; set; }
        public string UsuarioId { get; set; }
        public UsuarioDto Usuario { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public DateTime DataDevolucaoEfetiva { get; set; }
        public EmprestimoLivro ConverterParaEntidade()
        {
            return new EmprestimoLivro
            {
                ClienteId = this.ClienteId,
                Cliente = this.Cliente.ConverterParaEntidade(),
                LivriId = this.LivroId,
                Livro = this.Livro.ConvertParaEntidade(),
                UsuarioId = this.UsuarioId,
                Usuario = this.Usuario.ConverterParaEntidade(),
                DataEmprestimo = this.DataEmprestimo,
                DataDevolucao = this.DataDevolucao,
                DataDevolucaoEfetiva = this.DataDevolucaoEfetiva

            };
        }
    }
}
