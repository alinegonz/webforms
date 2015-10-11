using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class tbProdutividadeDTO
{
	public tbProdutividadeDTO()
	{
	}

    public int idProdutividade { get; set; }
    public String dsLinguagem { get; set; }
    public float vlBaixa { get; set; }
    public float vlMedia { get; set; }
    public float vlAlta { get; set; }

    //public tbFabricanteDTO fabricante { get; set; }
}