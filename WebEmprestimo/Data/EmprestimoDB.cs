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
    public class EmprestimoDB
    {
        private StringBuilder sb;
        private Conexao conexao;

        public bool Insert(Emprestimo emp)
        {
            try
            {
                sb = new StringBuilder();
                sb.Append("INSERT INTO TB_EMPRESTIMO(DESCRICAO, DATA_EMP, JUROS, VALOR, QTD_PARCELAS) VALUES ");
                sb.Append(string.Format("('{0}', '{1}', '{2}', '{3}', '{4}')", emp.Descricao, emp.Dt_emprestimo, 
                                                                               emp.Juros, emp.Valor, emp.Qtd_parcela));

                using (conexao = new Conexao())
                {
                    conexao.ExecutaComando(sb.ToString());
                }
                return true;
            }
            catch (Exception)
            {
                throw;
                //return false;
            }
        }

        public List<Emprestimo> All()
        {
            using (conexao = new Conexao())
            {
                var sql = "SELECT * FROM TB_EMPRESTIMO";

                var retorno = conexao.ExecutaComandoRetorno(sql);

                return TransformaSQLReaderEmList(retorno);
            }
        }


        private List<Emprestimo> TransformaSQLReaderEmList(SqlDataReader retorno)
        {
            var listEmprestimo = new List<Emprestimo>();

            while (retorno.Read())
            {
                var item = new Emprestimo()
                {
                    Id = Convert.ToInt32(retorno["id"]),
                    Descricao = retorno["Descricao"].ToString(),
                    Valor = Convert.ToDouble(retorno["Valor"]),
                    Dt_emprestimo = retorno["Data_emp"].ToString(),
                    Qtd_parcela = Convert.ToInt32(retorno["qtd_parcelas"]),
                    Juros = Convert.ToDouble(retorno["juros"])
                };

                listEmprestimo.Add(item);
            }
            return listEmprestimo;
        }

    }
}
