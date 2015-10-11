<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="idProdutividade" DataSourceID="SqlTeste">
            <Columns>
                <asp:BoundField DataField="idProdutividade" HeaderText="idProdutividade" 
                    ReadOnly="True" SortExpression="idProdutividade" />
                <asp:BoundField DataField="dsLinguagem" HeaderText="dsLinguagem" 
                    SortExpression="dsLinguagem" />
                <asp:BoundField DataField="vlBaixa" HeaderText="vlBaixa" 
                    SortExpression="vlBaixa" />
                <asp:BoundField DataField="vlMedia" HeaderText="vlMedia" 
                    SortExpression="vlMedia" />
                <asp:BoundField DataField="vlAlta" HeaderText="vlAlta" 
                    SortExpression="vlAlta" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlTeste" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BD_XFPAConnectionString %>" 
            SelectCommand="SELECT * FROM [tbProdutividade]"></asp:SqlDataSource>
        <br />
        <asp:TextBox ID="txtLinguagem" runat="server" Width="261px"></asp:TextBox>
        <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" 
            onclick="btnFiltrar_Click" />
        <br />
    
    </div>
    <asp:GridView ID="grdProdutividade" runat="server" AutoGenerateColumns="False"
         DataKeyNames="idProdutividade" RowHeaderColumn="idProdutividade"
          AllowPaging="True" EmptyDataText="Sem registros....." 
        onpageindexchanging="grdProdutividade_PageIndexChanging" PageSize="5">

          <Columns>
            <asp:BoundField DataField="idProdutividade" HeaderText="ID" Visible="true"
                      ReadOnly="true" SortExpression="idProdutividade"/>
              <asp:BoundField DataField="dsLinguagem" HeaderText="LINGUAGEM" />
              <asp:BoundField DataField="vlBaixa" HeaderText="BAIXA" />
              <asp:BoundField DataField="vlMedia" HeaderText="MEDIA" />
              <asp:BoundField DataField="vlAlta" HeaderText="ALTA" />
          </Columns>


    </asp:GridView>
    </form>
</body>
</html>
