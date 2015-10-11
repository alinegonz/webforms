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
    protected void btnCalcular_Click(object sender, EventArgs e)
    {
        /*Operacao oper;

        int val1, val2;

        val1 = Convert.ToInt32(txt1.Text);
        val2 = Convert.ToInt32(txt2.Text);

        oper = new Multiplicacao();

        lblResultado.Text = oper.efetuaOperacao(val1, val2).ToString(); */

        Facede concedeCredito = new Facede();
        double val1 = Convert.ToDouble(txt1.Text);
        Cliente cliente1 = new Cliente(txt2.Text);
        lblResultado.Text = concedeCredito.ConcederEmprestimo(cliente1, val1);

        

    }
}