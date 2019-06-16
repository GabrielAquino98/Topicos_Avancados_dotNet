<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebEmprestimo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 25px;
        }
        .auto-style2 {
            width: 220px;
        }
        .auto-style3 {
            height: 25px;
            width: 220px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Cadastrar Emprestimo</div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">
                    <br />
                    Descricao:</td>
                <td>
                    <br />
                    <asp:TextBox ID="txtDescricao" runat="server" Width="500px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <br />
                    Valor:</td>
                <td class="auto-style1">
                    <br />
                    <asp:TextBox ID="txtValor" runat="server" Width="230px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Data de emprestimo:</td>
                <td>
                    <br />
                    <asp:Calendar ID="calendar" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="200px" NextPrevFormat="FullMonth" Width="400px">
                        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                        <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                        <TodayDayStyle BackColor="#CCCCCC" />
                    </asp:Calendar>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <br />
                    Juros:</td>
                <td>
                    <br />
                    <asp:TextBox ID="txtJuros" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <br />
                    Quantidade de Parcelas:</td>
                <td>
                    <br />
                    <asp:TextBox ID="txtQtdParcelas" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <br />
                    <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" Width="100px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
