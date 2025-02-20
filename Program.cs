using System;

namespace Calculator
{
    class Program 
    {
        static void Main(string[] args)
        {

            Menu();
            
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            Console.WriteLine("---------------------------");
            Console.WriteLine("Selecione uma opção:");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Multiplicacao();
                    break;
                case 4:
                    Divisao();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

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