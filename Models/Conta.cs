using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta//abstract é para abstrair a classe
    {
        protected decimal saldo;//Em vez de private, usa o protected

        public abstract void Creditar(decimal valor);
        public void ExibirSaldo()
        {
            Console.WriteLine("O seu saldo é: " + saldo);
        }
    }
}