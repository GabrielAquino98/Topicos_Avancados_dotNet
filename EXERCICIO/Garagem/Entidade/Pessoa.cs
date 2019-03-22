﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public abstract class Pessoa
    {

        public static List<Pessoa> lstPessoa = new List<Pessoa>();

        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return "Id: " + this.Id + "\nNome: "+this.Nome+"\nTelefone: "+this.Telefone;
        }

        public void Inserir()
        {
            lstPessoa.Add(this);
        }
        #endregion
    }
}
