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
    protected void btnVerificaCredito_Click(object sender, EventArgs e)
    {
        Cliente cli1 = new Cliente(txtNome.Text);
        Facade facade = new Facade();

        double val = Convert.ToDouble(txtValor.Text);

        lblResposta.Text = facade.ConcedeEmprestimo(cli1, val);
    }
    protected void btnPagina2_Click(object sender, EventArgs e)
    {
        Session["resposta"] = lblResposta.Text;
        Response.Redirect("PaginaDois.aspx");
    }
}