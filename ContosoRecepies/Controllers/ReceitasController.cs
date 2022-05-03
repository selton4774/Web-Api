using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoRecepies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceitasController : ControllerBase
    {
        [HttpGet]
        public String[] ObterPratos()
        {
            String[] pratos = { "Arroz com feijão", "Galinhada", "Sopa de banana" };
            return pratos;
        }
    }
}
