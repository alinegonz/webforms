using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Facade
{
    private LimiteCredito limite = new LimiteCredito();
    private Serasa serasa = new Serasa();
    private Spc spc = new Spc();


    public string ConcedeEmprestimo(Cliente cliente, double valor)
    {
        string retorno = "";

        retorno += limite.PossuiLimiteDeCredito(cliente, valor);
        retorno += "<br />" + serasa.EstaNoSerasa(cliente);
        retorno += "<br />" + spc.ConsultaSPC(cliente);

        return retorno;
    }


	public Facade()
	{
	}
}