using System;
using fizzbuzz;

namespace consoleapp.fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            Console.WriteLine("Teste do Jogo Fizzbuzz\n");
            Console.WriteLine("Digite um número: \n");
            var comando = Console.ReadLine();

            while (comando != "sair")
            {
                Console.WriteLine("Teste do Jogo Fizzbuzz\n");
                Console.WriteLine("Digite um número: \n");
                comando = Console.ReadLine();
                Console.WriteLine(robot.Fizzbuzz(int.Parse(comando)));
            }
        }
    }
}
