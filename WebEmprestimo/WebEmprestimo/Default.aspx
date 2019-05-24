<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebEmprestimo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 149px;
        }
        .auto-style2 {
            width: 207px;
        }
        .auto-style3 {
            width: 34%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Cadastrar Emprestimo&nbsp;&nbsp;&nbsp;
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">
                    <br />
                    Descricao:</td>
                <td>
                    <br />
                    <asp:TextBox ID="txtDescricao" runat="server" Height="50px" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <br />
                    Valor:</td>
                <td>
                    <br />
                    <asp:TextBox ID="txtValor" runat="server" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Data de Emprestimo:</td>
                <td>
                    <br />
                    <asp:Calendar ID="calendario" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="200px" NextPrevFormat="FullMonth" Width="250px">
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
                <td class="auto-style1">
                    <br />
                    Porcentagem de Juros:</td>
                <td>
                    <br />
                    <asp:TextBox ID="txtJuros" runat="server" TextMode="Number" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <br />
                    Quantidade de Parcelas:</td>
                <td>
                    <br />
                    <asp:TextBox ID="txtQtdParcela" runat="server" TextMode="Number" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="lblMsgParcela" runat="server"></asp:Label>
                </td>
                <td align="right">
                    <br />
                    <asp:Button ID="btnSalvar" runat="server" Height="30px" Text="Salvar" Width="75px" OnClick="btnSalvar_Click" />
                </td>
            </tr>
        </table>
        <br />
        <table style="width:100%;">
            <tr>
                <td align ="center">Emprestimos</td>
            </tr>
            <tr>
                <td align ="center">
                    <asp:GridView ID="GVEmprestimo" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                </td>
            </tr>
            </table>
        <br />
        <table class="auto-style3">
            <tr>
                <td colspan="2">Consultar Parcelas do Emprestimo:</td>
            </tr>
            <tr>
                <td class="auto-style2">Informe o ID do emprestimo:</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="txtIdEmprestimo" runat="server" Width="166px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnBuscarParcela" runat="server" Text="Buscar" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
