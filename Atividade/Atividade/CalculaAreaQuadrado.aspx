<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculaAreaQuadrado.aspx.cs" Inherits="Atividade.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Informe o lado do quadrado para calcular sua area:
            <asp:TextBox ID="txtLado" runat="server"></asp:TextBox>
            <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular" />
        </p>
        <p>
            <asp:Label ID="lblArea" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
