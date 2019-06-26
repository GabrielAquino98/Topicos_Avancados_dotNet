using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Util;

namespace Data
{
    public class ClienteDB
    {
        private Conexao conexao;


        public bool Insert(Cliente cliente)
        {
            try
            {
                //Query de Inclusão de dados
                string sql = string.Format
                    ("insert into tb_cliente (nome, telefone) values ('{0}','{1}')",
                    cliente.Nome, cliente.Telefone);

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



        public List<Cliente> All()
        {
            using (conexao = new Conexao())
            {
                var sql = "SELECT Id, Nome, Telefone FROM TB_CLIENTE";
                var retorno = conexao.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);
            }
        }

        private List<Cliente> TransformaSQLReaderEmList(SqlDataReader retorno)
        {
            var listCidade = new List<Cliente>();

            while (retorno.Read())
            {
                var item = new Cliente()
                {
                    Codigo = Convert.ToInt32(retorno["Id"]),
                    Nome = retorno["Nome"].ToString(),
                    Telefone = retorno["Telefone"].ToString()
                };

                listCidade.Add(item);
            }
            return listCidade;
        }

    }
}
