using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominus.Models
{
    public class Cadastro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public int Patrimonio { get; set; }

    }
}
