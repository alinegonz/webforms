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
        Unica primeiro;// = new Unica();
        primeiro = Unica.Instancia;
        primeiro.nome = "Ze";
        Unica segundo; // = new Unica();
        segundo = Unica.Instancia;
        segundo.nome = "maria";

        txtNome.Text = primeiro.nome;
        txtIdade.Text = segundo.nome;
    }
    protected void btnVai_Click(object sender, EventArgs e)
    {
        String parametros = "";

        parametros = "idNome=" + txtNome.Text;
        parametros += "&idIdade=" + txtIdade.Text;

        Response.Redirect("paginaNova.aspx?" + parametros, true);
    }
}