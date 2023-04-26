using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double milhasmar;
            double conversao;
            Console.WriteLine("Conversor de milhas marítimas para quilômetros");
            Console.Write("\nInsira o valor em milhas marítimas: ");
            milhasmar = double.Parse(Console.ReadLine());
            conversao = milhasmar * 1.852;
            Console.WriteLine("\nValor convertido em quilômetros: {0}km\n", conversao);
        }
    }
}
