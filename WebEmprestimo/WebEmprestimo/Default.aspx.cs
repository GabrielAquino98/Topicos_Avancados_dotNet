using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebEmprestimo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {

            


            Emprestimo emp = new Emprestimo
            {
                Descricao = txtDescricao.Text,
                Dt_emprestimo = calendario.SelectedDate.ToString("yyyy/mm/dd"),
                Juros = Convert.ToDouble(txtJuros.Text),
                Valor = Convert.ToDouble(txtValor.Text),
                Qtd_parcela = Convert.ToInt16(txtQtdParcela.Text)
            };

            if (new EmprestimoDB().Insert(emp))
            {
                lblMsg.Text = "Emprestimo inserido no banco!";
                lblMsg.ForeColor = Color.Blue;
                ReloadGrid();
            }
            else
            {
                lblMsg.Text = "Erro ao inserir emprestimo no banco!";
                lblMsg.ForeColor = Color.Red;
                ReloadGrid();
            }

            CadastraParcelas(emp);
            
        }


        private void ReloadGrid()
        {
            GVEmprestimo.DataSource = new EmprestimoDB().All();
            GVEmprestimo.DataBind();
        }


        private void CadastraParcelas(Emprestimo emp)
        {

            DateTime data_vencimento = calendario.SelectedDate;
            double valor_parcela = emp.Valor / emp.Qtd_parcela;

            for (int i = 1; i <= emp.Qtd_parcela; i++)
            {
                valor_parcela = valor_parcela + ((valor_parcela * emp.Juros) / 100);

                Parcela p = new Parcela
                {
                    Emprestimo = emp,
                    Dt_vencto = data_vencimento.ToString("yyyy/mm/dd"),
                    Vlr_parcela = valor_parcela,

                };

                data_vencimento = data_vencimento.AddDays(30);

                if (new ParcelaDB().Insert(p))
                {
                    lblMsg.Text = i + " Parcelas inseridas no banco!";
                    lblMsg.ForeColor = Color.Blue;
                }
                else
                {
                    lblMsg.Text = "Erro ao inserir parcelas no banco!";
                    lblMsg.ForeColor = Color.Red;
                }
            }


        }
    }
}