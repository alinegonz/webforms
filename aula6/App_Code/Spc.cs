using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Spc
{
    public string ConsultaSPC(Cliente cliente)
    {
        //Parte do código que faz a consulta no SPC.....
        return cliente.Nome + " Liberado no SPC";
    }
	public Spc()
	{
	}
}