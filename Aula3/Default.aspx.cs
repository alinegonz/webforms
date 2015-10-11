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
    protected void btnIMC_Click(object sender, EventArgs e)
    {
        double peso = 0, altura = 0, imc = 0, aux;
        string texto = "Impossível fazer o calculo";

        if ( double.TryParse(txtPeso.Text, out aux) ) peso = aux;
        aux = 0;
        if (double.TryParse(txtAltura.Text, out aux)) altura = aux;

        if (altura != 0) imc = peso / (altura * altura);

        if (imc >= 1.0 && imc < 17.0)
            texto = "Muito abaixo do peso";
        else
            if (imc >= 17.0 && imc <= 18.49)
                texto = "Abaixo do peso";

        lblResultado.Text = texto;
        ModeloUnico mod;

        mod = ModeloUnico.Instacia;



    }
}