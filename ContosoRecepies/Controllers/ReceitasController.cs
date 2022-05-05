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
        String[] receitas = { "Arroz com feijão", "Galinhada", "Sopa de banana" };

        [HttpGet]
        public IActionResult ObterTodasAsReceitas()
        {


            if (receitas.Length < 1) // receitas.Any(), não funcionou
            {
                return NotFound();
            }

            return Ok(receitas);
        }

        [HttpPut("{nomeAntigo}, {NomeNovo}")]
        public IActionResult AtualizarReceita(string nomeAntigo, string novoNome)
        {
            for (int i = 0; i < receitas.Length - 1; i++)
            {
                if(receitas[i] == nomeAntigo)
                {
                    receitas[i] = novoNome;
                    return NoContent();
                }
            }

            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarReceita(string id)
        {
            bool AlgoDeuErrado = false;

            if(AlgoDeuErrado)
            {
                return BadRequest();
            }

            return NoContent();
        }
    }
}
