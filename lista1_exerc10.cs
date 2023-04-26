using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cotacao;
            double dolar;
            double reais;
            Console.WriteLine("Conversor de Dólar para Real");
            Console.Write("\nEntre com a cotação do dólar: ");
            cotacao = double.Parse(Console.ReadLine());
            Console.Write("\nEntre com o valor em dólares a ser convertido: ");
            dolar = double.Parse(Console.ReadLine());
            reais = cotacao * dolar;
            Console.WriteLine("\nValor convertido em reais: R${0}\n", reais);
        }
    }
}
