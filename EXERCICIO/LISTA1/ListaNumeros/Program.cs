using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lstInt = new List<int>();

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Adicione um numero na lista(digite 0 para sair): ");
                lstInt.Add(Convert.ToInt32(Console.ReadLine()));

                if (lstInt[lstInt.Count-1]==0)
                {
                    continuar = false;
                }
                
            }

            lstInt.Sort();

            foreach(var i in lstInt)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
