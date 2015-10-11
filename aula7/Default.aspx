<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1 {
            width: 8px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="ddlMeses" runat="server" Height="16px" Width="229px" 
            AutoPostBack="True" onselectedindexchanged="ddlMeses_SelectedIndexChanged">
            <asp:ListItem Value="-1">- - - Selecione um Item - - - </asp:ListItem>
            <asp:ListItem Value="1">Janeiro</asp:ListItem>
            <asp:ListItem Value="2">Fevereiro</asp:ListItem>
            <asp:ListItem Value="3">Março</asp:ListItem>
            <asp:ListItem Value="4">Abril</asp:ListItem>
            <asp:ListItem Value="5">Maio</asp:ListItem>
            <asp:ListItem Value="6">Junho</asp:ListItem>
            <asp:ListItem Value="7">Julho</asp:ListItem>
            <asp:ListItem Value="8">Agosto</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblResultado" runat="server"></asp:Label>
    
        <br />
        <br />
        <table border="0">
            <tr>
                <td>
                    <asp:ListBox ID="lstbUm" runat="server" Height="109px" Width="148px">
                        <asp:ListItem Value="1">Casa</asp:ListItem>
                        <asp:ListItem Value="2">Carro</asp:ListItem>
                        <asp:ListItem Value="3">Rua</asp:ListItem>
                        <asp:ListItem Value="4">Mala</asp:ListItem>
                        <asp:ListItem Value="5">Caderno</asp:ListItem>
                        <asp:ListItem Value="6">Caneta</asp:ListItem>
                    </asp:ListBox>
                </td>
          
                <td class="style1">
                    <asp:Button ID="btnIncluir" runat="server" Text=">" 
                        onclick="btnIncluir_Click" />
                    <asp:Button ID="btnTodosIda" runat="server" Text=">>"/>
                    <asp:Button ID="btnRemover" runat="server" Text="<" 
                        onclick="btnRemover_Click" />
                </td>
            
                <td>
                    <asp:ListBox ID="lstbDois" runat="server" Height="109px" Width="148px">
                    </asp:ListBox>
                </td>
            </tr>
        </table>
        
        
    
    </div>
    </form>
</body>
</html>
