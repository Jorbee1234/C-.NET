using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVendas.Responses
{
    public class ProdutoResponse
    {
        public string Id { get; set; }
        public string Descricao { get; set; }
        public string Estoque { get; set; }
        public string Valor { get; set; }
    }
}
