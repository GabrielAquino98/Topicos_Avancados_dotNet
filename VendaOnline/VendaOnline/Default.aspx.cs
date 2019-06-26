using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VendaOnline
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReloadGridCliente();
            ReloadGridProduto();
            ReloadGridVenda();

            if (!IsPostBack)
                LoadCboCliente();
                LoadCboProduto();

        }

        private void ReloadGridCliente()
        {
            gvCliente.DataSource = new ClienteDB().All();
            gvCliente.DataBind();
        }


        private void ReloadGridProduto()
        {
            gvProduto.DataSource = new ProdutoDB().All();
            gvProduto.DataBind();
        }

        private void ReloadGridVenda()
        {
            gvVenda.DataSource = new VendaDB().All();
            gvVenda.DataBind();
        }


        private void LoadCboCliente()
        {

            cboCliente.DataSource = new ClienteDB().All();
            cboCliente.DataTextField = "Nome";
            cboCliente.DataValueField = "Codigo";
            cboCliente.DataBind();

        }

        private void LoadCboProduto()
        {

            cboProduto.DataSource = new ProdutoDB().All();
            cboProduto.DataTextField = "Descricao";
            cboProduto.DataValueField = "Codigo";
            cboProduto.DataBind();

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente()
            {
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text,
            };

            if (new ClienteDB().Insert(cliente))
            {
                Label1.Text = "Registro Inserido!";
                Label1.ForeColor = Color.Blue;
                ReloadGridCliente();
                LoadCboCliente();
            }
            else
            {
                Label1.Text = "Erro ao inserir registro";
                Label1.ForeColor = Color.Red;
            }
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {

            Produto cliente = new Produto()
            {
                Descricao = txtDescricao.Text,
                Qtd = Convert.ToInt32(txtQuantidade.Text),
                Valor = Convert.ToDouble(txtValor.Text)
            };

            if (new ProdutoDB().Insert(cliente))
            {
                Label2.Text = "Registro Inserido!";
                Label2.ForeColor = Color.Blue;
                ReloadGridProduto();
                LoadCboProduto();
            }
            else
            {
                Label2.Text = "Erro ao inserir registro";
                Label2.ForeColor = Color.Red;
            }
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Venda venda = new Venda()
            {
                Cliente = new Cliente() { Codigo = int.Parse(cboCliente.SelectedValue.ToString()) },
                Produto = new Produto() { Codigo = int.Parse(cboProduto.SelectedValue.ToString()) },
                Qtd = Convert.ToInt32(txtQtd.Text),
                ValorTotal = Convert.ToDouble(txtValorTotal.Text),
                DataVenda = txtDataVenda.Text
            };

            if (new VendaDB().Insert(venda))
            {
                Label3.Text = "Registro Inserido!";
                Label3.ForeColor = Color.Blue;
                ReloadGridVenda();
            }
            else
            {
                Label3.Text = "Erro ao inserir registro";
                Label3.ForeColor = Color.Red;
            }
        }
    }
}