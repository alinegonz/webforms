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
    protected void btnOK_Click(object sender, EventArgs e)
    {
        int idade = 0, teste;

        if ( int.TryParse(txtAno.Text, out teste) ) {
            idade = 2015 - teste;
        }

        lblIdade.Text = idade.ToString();
    }
}