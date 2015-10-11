<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblNome" runat="server" Text="Nome :"></asp:Label>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Idade"></asp:Label>
        <asp:TextBox ID="txtIdade" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnVai" runat="server" onclick="btnVai_Click" Text="Vai" />
    
    </div>
    </form>
</body>
</html>
