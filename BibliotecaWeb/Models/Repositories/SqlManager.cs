using BibliotecaWeb.Models.Enums;

namespace BibliotecaWeb.Models.Repositories
{
    public class SqlManager
    {

        public static string GetSql(TSql tsql)
        {
            var sql = "";

            switch (tsql)
            {
                case TSql.CADASTRAR_LIVRO:
                    sql = "insert into livro(id,nome,autor,editora,statusLivroId) values(convert(binary(36),@id),@nome,@autor,@editora,@statusLivroId)";
                    break;
                case TSql.LISTAR_LIVRO:
                    sql = "select convert(varchar(36),id)'id',nome,autor,editora from livro order by nome";
                    break;
                case TSql.PESQUISAR_LIVRO:
                    sql = "select convert(varchar(36),id)'id',nome,autor,editora from livro where id = @id";
                    break;
                case TSql.ATUALIZAR_LIVRO:
                    sql = "update livro set nome = @nome, autor = @autor, editora = @editora where id = @id";
                    break;
                case TSql.EXCLUIR_LIVRO:
                    sql = "delete livro where id = @id";
                    break;

                case TSql.CADASTRAR_CLIENTE:
                    sql = "insert into cliente(id,nome,cpf,email,fone, statusClienteId) values(convert(binary(36),@id),@nome,@autor,@cpf,@email,@fone,@statusClienteId)";
                    break;
                case TSql.LISTAR_CLIENTE:
                    sql = "select convert(varchar(36),id)'id',nome,cpf,email,fone, statusClienteId from cliente order by nome";
                    break;
                case TSql.PESQUISAR_CLIENTE:
                    sql = "select convert(varchar(36),id)'id',nome,cpf,email,fone, statusClienteId from cliente where convert(binary(36),id) = @id";
                    break;
                case TSql.ATUALIZAR_CLIENTE:
                    sql = "update cliente set nome = @nome, cpf = @cpf, email = @email fone = @fone where convert(varchar(36),id) = @id";
                    break;
                case TSql.EXCLUIR_CLIENTE:
                    sql = "delete cliente where convert(varchar(36),id) = @id";
                    break;
            }
            return sql;
        }
    }
}
