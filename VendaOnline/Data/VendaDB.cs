using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Util;

namespace Data
{
    public class VendaDB
    {

        private Conexao conexao;


        public bool Insert(Venda venda)
        {
            try
            {
                //Query de Inclusão de dados
                string sql = string.Format
                    ("insert into tb_vendas (id_cliente, id_produto, dt_venda, qtd_produto, valor_total) values ('{0}','{1}','{2}','{3}','{4}')",
                    venda.Cliente.Codigo, venda.Produto.Codigo, venda.DataVenda, venda.Qtd, venda.ValorTotal);

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


        public List<Venda> All()
        {
            using (conexao = new Conexao())
            {
                var sql = "SELECT V.ID, V.ID_CLIENTE, V.ID_PRODUTO, V.QTD_PRODUTO, V.DT_VENDA, V.VALOR_TOTAL," +
                            " C.NOME, C.TELEFONE," +
                            " P.VALOR, P.QTD, P.DESCRICAO" +
                            " FROM TB_VENDAS V, TB_CLIENTE C, TB_PRODUTOS P" +
                            " WHERE V.ID_CLIENTE = C.ID" +
                            "  AND V.ID_PRODUTO = P.ID";
                var retorno = conexao.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);
            }
        }

        private List<Venda> TransformaSQLReaderEmList(SqlDataReader retorno)
        {
            var listCidade = new List<Venda>();

            while (retorno.Read())
            {
                var item = new Venda()
                {
                    Codigo = Convert.ToInt32(retorno["Id"]),
                    Produto = new Produto() {
                        Codigo = Convert.ToInt32(retorno["ID_PRODUTO"]),
                        Descricao = retorno["DESCRICAO"].ToString(),
                        Qtd = Convert.ToInt32(retorno["QTD"]),
                        Valor = Convert.ToDouble(retorno["VALOR"])
                    },
                    Cliente = new Cliente(){
                       Codigo = Convert.ToInt32(retorno["ID_CLIENTE"]),
                       Nome = retorno["NOME"].ToString(),
                       Telefone = retorno["TELEFONE"].ToString()
                    },
                    DataVenda = retorno["DT_VENDA"].ToString(),
                    Qtd = Convert.ToInt32(retorno["QTD_PRODUTO"]),
                    ValorTotal = Convert.ToDouble(retorno["VALOR_TOTAL"])
                };

                listCidade.Add(item);
            }
            return listCidade;
        }


    }
}
