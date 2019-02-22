using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> temperatura = new List<double>();


            for (int i =0; i < 5; i++) 
            {
                Console.WriteLine("Informe a temperatura do "+(i+1)+" dia: ");
                temperatura.Add(Convert.ToDouble(Console.ReadLine()));
            }

            Console.WriteLine("Maior temperatura: " + temperatura.Max());
            Console.WriteLine("Menor temperatura: " + temperatura.Min());
            Console.WriteLine("Media das temperaturas: " + temperatura.Average());
            Console.ReadKey();
        }
    }
}
