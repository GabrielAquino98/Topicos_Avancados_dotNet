using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Util;

namespace Data
{
    public class ProdutoDB
    {

        private Conexao conexao;

        public bool Insert(Produto produto)
        {
            try
            {
                //Query de Inclusão de dados
                string sql = string.Format
                    ("insert into tb_produtos (descricao, qtd, valor) values ('{0}','{1}','{2}')",
                    produto.Descricao, produto.Qtd, produto.Valor);

                //Abrir conexão para inclusão das informações
                using (conexao = new Conexao())
                {
                    conexao.ExecutaComando(sql);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public List<Produto> All()
        {
            using (conexao = new Conexao())
            {
                var sql = "SELECT Id, Descricao, Qtd, Valor  FROM TB_PRODUTOS";
                var retorno = conexao.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);
            }
        }

        private List<Produto> TransformaSQLReaderEmList(SqlDataReader retorno)
        {
            var listCidade = new List<Produto>();

            while (retorno.Read())
            {
                var item = new Produto()
                {
                    Codigo = Convert.ToInt32(retorno["Id"]),
                    Descricao = retorno["Descricao"].ToString(),
                    Qtd = Convert.ToInt32(retorno["Qtd"]),
                    Valor = Convert.ToDouble(retorno["Valor"])
                };

                listCidade.Add(item);
            }
            return listCidade;
        }

    }
}
