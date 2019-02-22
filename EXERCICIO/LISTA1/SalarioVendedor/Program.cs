using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioVendedor
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Console.WriteLine("Informe o salario fixo do vendedor: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o total de vendas feita pelo vendedor: ");
            double vendas = Convert.ToDouble(Console.ReadLine());

            if(vendas <= 1500)
            {
                 total = salario + (vendas * 0.03);
            }
            else
            {
                 total = salario + (vendas * 0.05 + vendas * 0.03);
            }
            Console.WriteLine("Valor total recebido pelo vendedor: " + total);
            Console.ReadKey();
        }
    }
}
