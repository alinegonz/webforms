﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblAno" runat="server" Text="Ano de nascimento :"></asp:Label>
        <asp:TextBox ID="txtAno" runat="server"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" onclick="btnOK_Click" Text="Ok" />
        <asp:Label ID="lblIdade" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
