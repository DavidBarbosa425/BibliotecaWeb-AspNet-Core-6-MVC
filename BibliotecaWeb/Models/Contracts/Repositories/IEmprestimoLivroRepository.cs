﻿using BibliotecaWeb.Models.Entidades;

namespace BibliotecaWeb.Models.Contracts.Repositories
{
    public interface IEmprestimoLivroRepository
    {
        void EfetuarEmprestimo(EmprestimoLivro emprestimoLivro);
        void EfetuarDevolucao(EmprestimoLivro emprestimoLivro);

    }
}