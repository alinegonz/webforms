using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class LimiteCredito
{
    public string PossuiLimiteCredito(Cliente cliente, double valor)
    {
        //Verifica o limite de crédito solicitado pelo cliente
        if (valor > 200000.00)
            return cliente.Nome + " Consutado na CREDITO - NEGATIVADO ";
        else
            return cliente.Nome + " Consutado na CREDITO - LIBERADO ";
    }
	public LimiteCredito()
	{
	}
}