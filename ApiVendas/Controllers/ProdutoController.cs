using ApiVendas.Mapper;
using ApiVendas.Models;
using ApiVendas.Repositories;
using ApiVendas.Requests;
using ApiVendas.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProdutoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Produto>> Get()
        {/*
            var ProdutoResponse = new ProdutoResponse()
            {
                Id = "1",
                Descricao = "Notebook",
                Estoque = "2",
                Valor = "2499"
            };
            var ProdutoResponse2 = new ProdutoResponse()
            {
                Id = "2",
                Descricao = "Teclado",
                Estoque = "10",
                Valor = "50"
            };
            var ProdutoResponses = new List<ProdutoResponse>();
            ProdutoResponses.Add(ProdutoResponse);
            ProdutoResponses.Add(ProdutoResponse2);

            return ProdutoResponses;*/
            return ProdutoRepository.Buscar(0, "");
        }

        [HttpGet("{Id}")]
        public ActionResult<ProdutoResponse> Get(string Id)
        {
            var ProdutoResponse = new ProdutoResponse()
            {
                Id = "3",
                Descricao = "Mouse",
                Estoque = "20",
                Valor = "30"
            };

            return ProdutoResponse;
        }

        [HttpPost]
        public ActionResult<ReturnResponse> Post([FromBody] ProdutoRequest request)
        {

            var produto = ProdutoMapper.Mapper(request);
            ProdutoRepository.Gravar(produto);

            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = "Registro cadastro com sucesso!"
            };
            return retorno;
        }

        [HttpPut]
        public ActionResult<ReturnResponse> Put([FromBody] ProdutoRequest request)
        {
            var produto = ProdutoMapper.Mapper(request);
            ProdutoRepository.Atualizar(produto);

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
