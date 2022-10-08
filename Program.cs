using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Divisao();
        }



        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;

            Console.WriteLine($"O resultado da soma é {resultado}");

            Console.ReadKey();

        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();

        }

        static void Divisao()
        {

            Console.WriteLine("Digite o promeiro valor: ");
            float v1 = Convert.ToSingle(Console.ReadLine());


            Console.WriteLine("Digite o segundo valor: ");
            float v2 = Convert.ToSingle(Console.ReadLine());

            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da divisão é: {resultado}");

            Console.ReadKey();


        }

        static void Multipicacao()
        {

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = Convert.ToSingle(Console.ReadLine());

            float resultado = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            Console.ReadKey();



        }
    }
}
