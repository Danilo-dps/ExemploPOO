using ExemploPOO.Interfaces;
using ExemploPOO.Models;


ICalculadora calc = new Calculadora();// não se instancia uma interface, apenas uma classe
//----------------------Calculadora logo depois do new
Console.WriteLine(calc.Multiplicar(3, 9));

// Computador c = new Computador();
// Console.WriteLine(c.ToString());


// Corrente c = new Corrente();
// c.Creditar(500);
// c.ExibirSaldo();



// Console.WriteLine("--------------------------------------------------------------------");

// Aluno a1 = new Aluno();
// a1.Nome = "Danilo";
// a1.Idade = 26;
// a1.Email = "Danilodpsnilo@gmailcom";
// a1.Nota = 10;
// a1.Apresentar();

// Console.WriteLine("--------------------------------------------------------------------");

// Professor p1 = new Professor();
// p1.Nome = "Eduardo";
// p1.Idade = 30;
// p1.Email = "Eduardoprofedu@gmail.com";
// p1.Salario = 1000;
// p1.Apresentar();

// Console.WriteLine("--------------------------------------------------------------------");





// ContaCorrente c1 = new ContaCorrente(123, 1000);

// c1.ExibirSaldo();
// c1.Sacar(500);
// c1.ExibirSaldo();


// using System.Net.NetworkInformation;
// using ExemploPOO.Models;

// Pessoa p1 = new Pessoa();
// p1.Nome = Console.ReadLine();
// p1.Idade = int.Parse(Console.ReadLine());

// p1.Apresentar();