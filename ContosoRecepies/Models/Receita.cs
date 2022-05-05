using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoRecepies.Models
{
    public record Receita
    {
        public String Titulo { get; init; }
        public String Descricao { get; init; }
        public IEnumerable<String> Ingredientes { get; init; }
        public IEnumerable<String> Direcoes { get; init; }
        public DateTime Atualizado { get; init; }
    }
}
