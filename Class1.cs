using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploPoo.Models;

namespace poocs
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.nome = "Lucas";
            p1.idade = "23";
            p1.apresentar();
        }
    }
}
;