﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
        <asp:TextBox ID="txt2" runat="server"></asp:TextBox>
        <asp:Button ID="btnCalcular" runat="server" onclick="btnCalcular_Click" 
            Text="Calcular" />
        <br />
        <asp:Label ID="lblResultado" runat="server" Text="resultado"></asp:Label>
    
    </div>
    </form>
</body>
</html>
