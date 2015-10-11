<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblPeso" runat="server" Text="Peso"></asp:Label>
        <asp:TextBox ID="txtPeso" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAltura" runat="server" Text="Altura"></asp:Label>
        <asp:TextBox ID="txtAltura" runat="server"></asp:TextBox>
        <asp:Button ID="btnIMC" runat="server" Text="Calcula IMC" 
            onclick="btnIMC_Click" />
    
        <br />
        <asp:Label ID="lblTexto" runat="server" Text="Você está :"></asp:Label>
        <asp:Label ID="lblResultado" runat="server" Text="lblResultado"></asp:Label>
    
    </div>
    </form>
</body>
</html>
