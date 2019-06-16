using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosAteN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            do{

                Console.WriteLine("Informe um valor para que seja impresso os numeros de 1 até o valor digitado: ");
                n = Convert.ToInt32(Console.ReadLine());

            } while (n == 0);

            for (int i =1; i<= n; i++){

                Console.Write(i+", ");

            }
            Console.ReadKey();
        }
    }
}
