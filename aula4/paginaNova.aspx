<%@ Page Language="C#" AutoEventWireup="true" CodeFile="paginaNova.aspx.cs" Inherits="paginaNova" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" 
            Text="Estou na nova página que lindo !!!!! heheheh"></asp:Label>
        <br />
        <asp:Label ID="lblIdade" runat="server" Text="Idade"></asp:Label>
        <br />
        <asp:Button ID="btnVolta" runat="server" onclick="btnVolta_Click" 
            Text="Volta" />
    
    </div>
    </form>
</body>
</html>
