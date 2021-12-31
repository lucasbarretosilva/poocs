
using System;
namespace ExemploPoo.Models
{
    public class Pessoa
    {
        public string nome { get; set; }
        public string idade { get; set; }
        public void apresentar()
        {
            Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos");

        }
    }
}
