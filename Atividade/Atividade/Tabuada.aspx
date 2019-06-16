<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tabuada.aspx.cs" Inherits="Atividade.Tabuada" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <h2>Clique no botão &quot;Gerar&quot; para gerar a tabuada do numero 2 </h2>
                <asp:Button ID="btnGerar" runat="server" Text="Gerar" Height="30px" Width="100px" OnClick="btnGerar_Click"/> 
        </p>
        <asp:Label ID="lblTabuada" runat="server"></asp:Label>
    </form>
</body>
</html>
