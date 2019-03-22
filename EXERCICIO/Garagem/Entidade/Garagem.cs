using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Garagem
    {
        public static List<Garagem> lstGaragem = new List<Garagem>();

        #region Propriedades
        public string Cpnj { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public List<Carro> Carro { get; set; }


        #endregion

        #region  Metodos
        public void Inserir()
        {
            lstGaragem.Add(this);

        }

        public override string ToString()
        {
            return "CNPJ: "+this.Cpnj+"\nNome: "+this.Nome+"\nTelefone: "+this.Telefone;
        }
        #endregion
    }
}
