using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            double fahrenheit;
            Console.WriteLine("Conversor de graus Celsius para Fahrenheit");
            Console.Write("\nValor em graus Celsius (ºC): ");
            celsius = double.Parse(Console.ReadLine());
            fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("\nConversão em Fahrenheit: {0}ºF\n", fahrenheit);
        }
    }
}
