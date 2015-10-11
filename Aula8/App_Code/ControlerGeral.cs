using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ControlerGeral
/// </summary>
public class ControlerGeral
{
	public ControlerGeral()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public ListaDeProdutividade ListaProdutividadeOFF(tbProdutividadeDTO prodDTO)
    {
        tbProdutividadeBLL prodAux = new tbProdutividadeBLL();

        return prodAux.ListaOFF(prodDTO);
    }
}