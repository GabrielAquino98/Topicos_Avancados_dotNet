using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Data
{
    public class PessoaDB
    {

        private Conexao conexao;

        public bool Insert(Pessoa p)
        {
            
                try
                {

                    string sql = string.Format("insert into tb_pessoa(nome, telefone) values('{0}','{1}');",
                                             p.Nome, p.Telefone);
                    using (conexao = new Conexao())
                    {

                        conexao.ExecutaComando(sql);

                    }

                    return true;
                }
                catch (Exception)
                {

                    throw;
                    //return false;
                }
        }

        public List<Pessoa> All()
        {
            using (conexao = new Conexao())
            {
                var sql = "SELECT ID, NOME, TELEFONE FROM TB_PESSOA";

                var retorno = conexao.ExecutaComandoRetorno(sql);

                return TransformaSQLReaderEmList(retorno);
            }
        }


        private List<Pessoa> TransformaSQLReaderEmList(SqlDataReader retorno)
        {
            var listPessoa = new List<Pessoa>();

            while (retorno.Read())
            {
                var item = new Pessoa()
                {
                    Id = Convert.ToInt32(retorno["id"]),
                    Nome = retorno["Nome"].ToString(),
                    Telefone = retorno["Telefone"].ToString()
                };

                listPessoa.Add(item);
            }
            return listPessoa;
        }
            

    }
}
