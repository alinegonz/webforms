using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class paginaNova : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Request.Params.Get("idNome");
        lblIdade.Text = Request.Params.Get("idIdade");
    }
    protected void btnVolta_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}