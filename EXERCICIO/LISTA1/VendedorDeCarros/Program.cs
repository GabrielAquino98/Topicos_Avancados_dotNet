using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendedorDeCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            int carrosVendidos = 0;
            double salario, totalVendas, valorPorCarro = 0;


            Console.WriteLine("Informe o salario fixo do vendedor: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantia total obtido nas vendas: ");
            totalVendas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor ganho pela comissao por Carro vendido: ");
            valorPorCarro = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe quantos carros o vendedor vendeu ");
            carrosVendidos = Convert.ToInt32(Console.ReadLine());


            double total = salario + (carrosVendidos * valorPorCarro) + (totalVendas * 0.05);

            Console.WriteLine("O Total obetido pelo vendedo foi de: R$" + total);

            Console.ReadKey();
        }
    }
}
