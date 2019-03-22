using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAulaOO2
{
    public class TesteGrauSatisfacao
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Teste Proj Grau de Satisfacao");

            GrauSatisfacao gf1 = new GrauSatisfacao()
            {
                Id = 1,
                Descricao = "Ruim"
            };

            GrauSatisfacao gf2 = new GrauSatisfacao()
            {
                Id = 2,
                Descricao = "Bom"
            };

            GrauSatisfacao gf3 = new GrauSatisfacao()
            {
                Id = 3,
                Descricao = "Muito bom"
            };

            gf1.addGrauSatisfacao();
            gf2.addGrauSatisfacao();
            gf3.addGrauSatisfacao();

            foreach(var item in gf1.getAll())
            {
                Console.WriteLine(item);
            }

            

            Console.ReadKey();
        }
    }
}