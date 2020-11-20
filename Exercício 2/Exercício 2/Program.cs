using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Quadrado();
            double k;

            do
            {
                Console.Write("Informe o valor do lado: ");
                k = double.Parse(Console.ReadLine());

                if (k > 0) a1.SetLado(k);
            }
            while (k <= 0);
            

            Console.WriteLine($"A area do quadrado é igual a {a1.CalcularArea()}");
        }
    }
}
