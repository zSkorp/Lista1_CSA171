using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double num3;
            double num4;
            double media;
            Console.WriteLine("Média Aritmética");
            Console.Write("\nEntre com o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("\nEntre com o segundo número: ");
            num2 = double.Parse(Console.ReadLine());
            Console.Write("\nEntre com o terceiro número: ");
            num3 = double.Parse(Console.ReadLine());
            Console.Write("\nEntre com o quarto número: ");
            num4 = double.Parse(Console.ReadLine());
            media = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("\nMédia entre os 4 números: {0}\n", media);
        }
    }
}
