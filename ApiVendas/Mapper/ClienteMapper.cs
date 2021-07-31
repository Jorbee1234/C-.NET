using ApiVendas.Models;
using ApiVendas.Requests;
using ApiVendas.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVendas.Mapper
{
    public static class ClienteMapper
    {
        public static Cliente Mapper(ClienteRequest clienteResquest)
        {
            return new Cliente()
            {
                Id = clienteResquest.Id,
                Nome = clienteResquest.Nome,
                Email = clienteResquest.Email,
                DT_Nascimento = clienteResquest.DT_Nascimento
            };
        }
        public static ClienteResponse Mapper(Cliente cliente)
        {
            return new ClienteResponse()
            {
                Id = cliente.Id.ToString(),
                Nome = cliente.Nome,
                Email = cliente.Email,
                DT_Nascimento = cliente.DT_Nascimento.ToString()
            };
        }
    }
}
