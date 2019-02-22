using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdadeEmDias
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano, mes, dia = 0;

            do
            {
                Console.WriteLine("Informe quantos anos voce tem: ");
                ano = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe quantos messes passou desde seu ultimo aniversario: ");
                mes = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o dia do mes: ");
                dia = Convert.ToInt32(Console.ReadLine());


                int idade = (ano * 365) + (mes * 30) + dia;

                Console.WriteLine("Dias vividos: " + idade);
                Console.WriteLine("Digite qualquer valor para continuar ou digite 0 para sair!");
                ano = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
            } while (ano != 0);
        }
    }
}
