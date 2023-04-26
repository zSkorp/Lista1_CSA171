using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double result;
            Console.WriteLine("Valores para potênciação");
            Console.Write("\nDigite o valor de X: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("\nDigite o valor de Y: ");
            y = double.Parse(Console.ReadLine());
            result = Math.Pow(x, y);
            Console.WriteLine("\nO resultado de {0} elevado a {1} é {2}\n", x, y, result);
        }
    }
}
