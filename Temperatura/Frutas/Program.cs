using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frutas
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Frutas> frutas = new List<Frutas>();

            int continuar = 0;
            do
            {
                Frutas f = new Frutas();

                Console.WriteLine("Informe o nome da fruta: ");
                f.Nome = Console.ReadLine();
                Console.WriteLine("Informe o id da fruta: ");
                f.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe a descricao da fruta: ");
                f.Descricao = Console.ReadLine();
                Console.WriteLine("Informe a quantidade da fruta: ");
                f.Qtd = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Deseja continuar?(digite 0 para sair e 1 para continuar)");
                continuar = Convert.ToInt32(Console.ReadLine());
            } while (continuar == 1);


            foreach(var fruta in frutas)
            {
                if(fruta.Qtd >= 5)
                {
                    Console.WriteLine("Fruta: " + fruta.Nome);
                    Console.WriteLine("ID: " + fruta.Id);
                    Console.WriteLine("Descricao: " + fruta.Descricao);
                    Console.WriteLine("Quantidade: " + fruta.Qtd);
                    
                }
            }

            Console.ReadKey();
        }
    }
}
