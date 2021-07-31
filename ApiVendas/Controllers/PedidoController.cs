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
    
    public class PedidoRequestController : ControllerBase
    {
        [HttpGet]//Regra que o metodo tem que respeitar
        public ActionResult<List<PedidoResponse>> Get()
        {
            var PedidoResponse = new PedidoResponse()
            {
                Nr_Pedido = "1",
                Cliente = new ClienteResponse(),
                DT_Pedido = DateTime.Now.ToString(),
                Tipo = "V",
                Itens = new List<PedidoItemResponse>()
            };

            var PedidoResponse2 = new PedidoResponse()
            {
                Nr_Pedido = "2",
                Cliente = new ClienteResponse(),
                DT_Pedido = DateTime.Now.ToString(),
                Tipo = "V",
                Itens = new List<PedidoItemResponse>()
            };

            var PedidoResponses = new List<PedidoResponse>();
            PedidoResponses.Add(PedidoResponse);
            PedidoResponses.Add(PedidoResponse2);

            return PedidoResponses;
        }

        [HttpGet("{Id}")]
        public ActionResult<PedidoResponse> Get(string Id)
        {
            var PedidoResponse = new PedidoResponse()
            {
                Nr_Pedido = "3",
                Cliente = new ClienteResponse(),
                DT_Pedido = DateTime.Now.ToString(),
                Tipo = "V",
                Itens = new List<PedidoItemResponse>()
            };
            return PedidoResponse;
        }

        [HttpPost] //Salva o cliente
        public ActionResult<ReturnResponse> Post([FromBody] PedidoRequest request)
        {
            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = "Registro cadastro com sucesso!"
            };
            return retorno;
        }

        [HttpPut] 
        public ActionResult<ReturnResponse> Put([FromBody] PedidoRequest request)//FromBody quer dizer que vai vir do corpo 
        {
            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = "Registro atualizado com sucesso!"
            };
            return retorno;
        }

        [HttpDelete("{nr_PedidoRequest}")]
        public ActionResult<ReturnResponse> Delete(string nr_PedidoRequest)
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
