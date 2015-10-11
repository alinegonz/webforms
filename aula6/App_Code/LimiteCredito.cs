using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class LimiteCredito
{
    public string PossuiLimiteDeCredito(Cliente cliente, double valor)
    {
        //Verifica junto ao banco o limite possível
        if (valor > 20000.00)
            return cliente.Nome + " Solicitação de limite negada";
        else
            return cliente.Nome + " Solicitação de limite APROVADA";
    }

	public LimiteCredito()
	{
	}
}