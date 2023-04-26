using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double aresta;
            double quadTotal;
            Console.WriteLine("Área do quadrado de acordo com a aresta");
            Console.Write("\nEntre com a aresta do quadrado que será calculado: ");
            aresta = double.Parse(Console.ReadLine());
            quadTotal = aresta * aresta;
            Console.WriteLine("\nA área total do quadrado descrito é de: {0}\n", quadTotal);
        }
    }
}
