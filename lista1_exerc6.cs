using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double mediaG;
            Console.WriteLine("Média geométria entre 2 números");
            Console.Write("\nDigite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("\nDigite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());
            mediaG = Math.Sqrt(num1 * num2);
            Console.WriteLine("\nMédia geométrica dos valores: {0}\n", mediaG);
        }
    }
}
