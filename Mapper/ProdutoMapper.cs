using ApiVendas.Models;
using ApiVendas.Requests;
using ApiVendas.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVendas.Mapper
{
    public static class ProdutoMapper
    {
        public static Produto Mapper(ProdutoRequest ProdutoResquest)
        {
            return new Produto()
            {
                Id = ProdutoResquest.Id,
                Descricao = ProdutoResquest.Descricao,
                Estoque = ProdutoResquest.Estoque,
                Valor = ProdutoResquest.Valor
            };
        }
        public static ProdutoResponse Mapper(Produto Produto)
        {
            return new ProdutoResponse()
            {
                Id = Produto.Id.ToString(),
                Descricao = Produto.Descricao,
                Estoque = Produto.Estoque.ToString(),
                Valor = Produto.Valor.ToString()
            };
        }
    }
}
