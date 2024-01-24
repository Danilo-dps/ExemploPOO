using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Diretor : Pessoa
    {
         public override void Apresentar()
        {
            Console.WriteLine("Diretor");
        }
    }
}