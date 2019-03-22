using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Funcionario : Pessoa
    {

        public static List<Funcionario> lstFunc = new List<Funcionario>();

        #region Propriedades

        public decimal Salario { get; set; }

        #endregion

        #region Metodos
        public override string ToString()
        {
            return base.ToString() + "\nSalario: " + this.Salario;
        }

        public void Inserir()
        {
            lstFunc.Add(this);
        }

        #endregion
    }
}
