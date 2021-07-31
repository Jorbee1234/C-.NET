using ApiVendas.Mapper;
using ApiVendas.Models;
using ApiVendas.Requests;
using ApiVendas.Responses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ClienteRequestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<ClienteResponse>> Get()
        {
            var Cliente = new Cliente()
            {
                Id = 1,
                Nome = "Diego",
                Email = "diego@gmail.com",
                DT_Nascimento = DateTime.Now.AddYears(-20)
            };
            var Cliente2 = new Cliente()
            {
                Id = 2,
                Nome = "Juraci",
                Email = "juraci@gmail.com",
                DT_Nascimento = DateTime.Now.AddYears(-30)
            };
            var ClienteResponses = new List<ClienteResponse>();
            ClienteResponses.Add(ClienteMapper.Mapper(Cliente));
            ClienteResponses.Add(ClienteMapper.Mapper(Cliente2));

            return ClienteResponses;
        }

        [HttpGet("{Id}")]
        public ActionResult<ClienteResponse> Get(string Id)
        {
            var ClienteResponse = new ClienteResponse()
            {
                Id = "2",
                Nome = "Matheus",
                Email = "matheus@gmail.com",
                DT_Nascimento = DateTime.Now.AddYears(-25).ToString()
            };

            return ClienteResponse;
        }

        [HttpPost]
        public ActionResult<ReturnResponse> Post([FromBody] ClienteRequest request)
        {
            var meuNovoCliente = ClienteMapper.Mapper(request);
            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = "Registro cadastro com sucesso!"
            };
            return retorno;
        }

        [HttpPut]
        public ActionResult<ReturnResponse> Put([FromBody] ClienteRequest request)
        {
            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = "Registro atualizado com sucesso!"
            };
            return retorno;
        }

        [HttpDelete("{Id}")]
        public ActionResult<ReturnResponse> Delete(string Id)
        {
            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = "Registro deletado com sucesso!"
            };
            return retorno;
        }
    }
}
