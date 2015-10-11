using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnFiltrar_Click(object sender, EventArgs e)
    {
        carregarGrid(filtroTela());
    }

    protected void carregarGrid(tbProdutividadeDTO prodDTO)
    {
        /*tbProdutividadeBLL produtividade = new tbProdutividadeBLL();
        grdProdutividade.DataSource = produtividade.listAll(prodDTO);
        grdProdutividade.DataBind();*/

        ControlerGeral conGeral = new ControlerGeral();
        grdProdutividade.DataSource = conGeral.ListaProdutividadeOFF(prodDTO);
        grdProdutividade.DataBind();


    }
    protected void grdProdutividade_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdProdutividade.PageIndex = e.NewPageIndex;
        carregarGrid(filtroTela());
    }

    protected tbProdutividadeDTO filtroTela()
    {
        tbProdutividadeDTO prod = new tbProdutividadeDTO();

        prod.dsLinguagem = txtLinguagem.Text.Trim();
         return prod;
    }
}