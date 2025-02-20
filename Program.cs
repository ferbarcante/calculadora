using System;

namespace Calculator
{
    class Program 
    {
        static void Main(string[] args)
        {

            
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            float total = primeiroValor + segundoValor;
            Console.WriteLine("Resultado: " + total);
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            float total = primeiroValor - segundoValor;
            Console.WriteLine("Resultado: " + total);
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o dividendo: ");
            float dividendo = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o divisor: ");
            float divisor = float.Parse(Console.ReadLine());

            if (divisor == 0)
            {
                Console.WriteLine("Não é possível dividir por zero!");
                return;
            }

            float total = dividendo / divisor;
            Console.WriteLine("Resultado: " + total);
        }
        
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            float total = primeiroValor * segundoValor;
            Console.WriteLine("Resultado: " + total);
        }
    }
}