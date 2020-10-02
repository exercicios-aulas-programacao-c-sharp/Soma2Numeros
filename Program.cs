using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUm, numeroDois, soma;

            Console.WriteLine("Cálculo da soma entre dois números.");
            Console.WriteLine();
            
            Console.Write("Digite o primeiro número: ");
            numeroUm = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numeroDois = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            soma = numeroUm + numeroDois;

            Console.WriteLine($"Soma: {soma}");
        }
    }
}
