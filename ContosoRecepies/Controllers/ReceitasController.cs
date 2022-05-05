using ContosoRecepies.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoRecepies.Controllers
{
    [Route("api/receitas")]
    [ApiController]
    public class ReceitasController : ControllerBase
    {
        

        [HttpGet]
        public IActionResult ObterTodasAsReceitas([FromQuery] int qtd)
        {


            Receita[] receitas =
                {
                    new() { Titulo = "Torta de maçã"},
                    new() { Titulo = "Arroz com feijão"},
                    new() { Titulo = "Ovo frito"}
                };

            return Ok(receitas.Take(qtd));
        }

        //[HttpPut("{nomeAntigo}, {NomeNovo}")]
        //public IActionResult AtualizarReceita(string nomeAntigo, string novoNome)
        //{
        //    for (int i = 0; i < receitas.Length - 1; i++)
        //    {
        //        if(receitas[i] == nomeAntigo)
        //        {
        //            receitas[i] = novoNome;
        //            return NoContent();
        //        }
        //    }

        //    return NotFound();
        //}

        [HttpPost]
        public IActionResult CriarReceita([FromBody] Receita nova)
        {
            // valida os dados antes de salvar
            bool AlgoDeuErrado = false;

            if(AlgoDeuErrado)
            {
                return BadRequest();
            }

            return Created("", nova);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarReceita(string id)
        {
            bool AlgoDeuErrado = false;

            if (AlgoDeuErrado)
            {
                return BadRequest();
            }

            return NoContent();
        }
    }
}
