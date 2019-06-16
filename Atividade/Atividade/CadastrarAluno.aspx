<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastrarAluno.aspx.cs" Inherits="Atividade.CadastrarAluno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server"  >
        <div>
            <h2 align ="center"> Cadastro de Aluno</h2>
        </div>
        <p align ="center">
            Id:
            <asp:TextBox ID="txtId" runat="server" Height="30px" Width="120px"></asp:TextBox>
        </p>
        <p align ="center">
            Nome:
            <asp:TextBox ID="txtNome" runat="server" Width="300px" Height="30px"></asp:TextBox>
        </p>
        <p align ="center">
            Telefone:
            <asp:TextBox ID="txtTel" runat="server" Height="30px" Width="250px"></asp:TextBox>
        </p>
        <p align ="center">
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
        </p>
        <p align="center">
            <asp:ListBox ID="lstAluno" runat="server" Height="200px" Width="300px"></asp:ListBox>
        </p>
    </form>
</body>
</html>
