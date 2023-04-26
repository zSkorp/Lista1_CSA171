using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseRet;
            double largRet;
            double areaRet;
            Console.WriteLine("Área de um retângulo");
            Console.Write("\nInsira a base do retângulo: ");
            baseRet = double.Parse(Console.ReadLine());
            Console.Write("\nInsira a altura do retângulo: ");
            largRet = double.Parse(Console.ReadLine());
            areaRet = baseRet * largRet;
            Console.WriteLine("\nA área total do retângulo é: {0}\n", areaRet);
        }
    }
}
