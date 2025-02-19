using System;

namespace Calculator
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            float total = primeiroValor + segundoValor;
            Console.WriteLine("Resultado: " + total);
        }
    }
}