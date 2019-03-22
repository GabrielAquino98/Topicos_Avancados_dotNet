﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Funcionario : Pessoa
    {
        #region Propriedades
        public decimal Salario { get; set; }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return base.ToString() + "\nSalario: " + this.Salario;
        }
        #endregion
    }
}
