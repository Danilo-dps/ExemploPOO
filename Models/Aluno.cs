using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public Aluno()
        {

        }
        public Aluno(string nome) : base(nome)
        {

        }
        public double Nota { get; set; }

        public override void Apresentar() //override é para executar o polimorfismo
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou um aluno nota {Nota}");
            Console.WriteLine($"Meu email é {Email}");
        }
    }
}