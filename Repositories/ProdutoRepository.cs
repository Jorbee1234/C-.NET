using ApiVendas.Models;
using ApiVendas.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVendas.Repositories
{
    public static class ProdutoRepository
    {
        public static void Gravar(Produto produto)
        {
            BaseRepository.Command(produto);
        }

        public static void Atualizar(Produto produto) 
        {
            BaseRepository.Command(produto, true);
        }
        public static List<Produto> Buscar(int Id, string Descricao)
        {
            string sql = "select * from produto";

            if(Id > 0)
            {
                sql += " where id = @idProduto";
            }

            if(Descricao != null)
            {
                if(sql.Contains("where"))
                sql += " and descricao like @descricaoProduto";
                else
                sql += " where descricao like @descricaoProduto";
            }

            var retorno = BaseRepository.QuerySql<Produto>(sql, new {idPrdduto = Id, descricaoProduto = "%" + Descricao + "%"});
            return retorno;
        }

        internal static void Gravar(ProdutoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
