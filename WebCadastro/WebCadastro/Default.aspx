    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebCadastro.Default" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title></title>
        <style type="text/css">
            .auto-style1 {
                width: 81px;
            }
        </style>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                Cadastro de Pessoas<br />
            </div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">Nome:</td>
                    <td>
                        <asp:TextBox ID="txtNome" runat="server" Width="354px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Telefone:</td>
                    <td>
                        <asp:TextBox ID="txtTelefone" runat="server" Width="354px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" Width="72px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>
                        <asp:Label ID="lblMsg" runat="server" ForeColor="Blue"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>
                        <asp:GridView ID="GVPessoa" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
        </form>
    </body>
    </html>
