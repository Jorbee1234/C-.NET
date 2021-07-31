using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVendas.Responses
{
    public class ClienteResponse
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string DT_Nascimento { get; set; }
    }
}
