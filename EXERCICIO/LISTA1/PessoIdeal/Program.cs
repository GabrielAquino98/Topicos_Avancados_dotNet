using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            string sexo = "";
            Console.WriteLine("Informe o Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            do
            {
                Console.WriteLine("Informe o sexo(M/F): ");
                sexo = Console.ReadLine();

            } while (!(sexo.ToUpper().Equals("M")) || !(sexo.ToUpper().Equals("F")));

            if (sexo.ToUpper().Equals("M"))
            {
                Console.WriteLine(nome + " seu pesso ideal é: " + ((72.7 * altura) - 58));
            }
            else
            {
                Console.WriteLine(nome + " seu pesso ideal é: " + ((62.1 * altura) - 44.7));
            }
            Console.ReadKey();
            
        }
    }
}
