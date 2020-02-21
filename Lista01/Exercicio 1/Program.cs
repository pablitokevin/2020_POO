using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string s = Console.ReadLine();
            Console.WriteLine($"Bem vindo, {s}");
            Console.ReadKey();
        }
    }
}
