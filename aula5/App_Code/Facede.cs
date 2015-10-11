using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Facede
{
    private LimiteCredito limite = new LimiteCredito();
    private Serasa serasa = new Serasa();
    private Cadin cadin = new Cadin();

    public string ConcederEmprestimo(Cliente cliente, double valor)
    {
        //Verifica a possibilidade de conceder emprestimo
        string ConcedeEmprestimo = "";
        ConcedeEmprestimo += "<br />" + serasa.EstaNosSerasa(cliente);
        ConcedeEmprestimo += "<br />" + cadin.EstaNoCadin(cliente);
        ConcedeEmprestimo += "<br />" + limite.PossuiLimiteCredito(cliente, valor);
        return ConcedeEmprestimo;
    }

	public Facede()
	{
	}
}