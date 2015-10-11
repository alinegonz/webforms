using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Cadin
{
    public string EstaNoCadin(Cliente cliente)
    {
        //Verifica  se o cliente está no CADIN
        return cliente.Nome + " Consutado na CADIN - LIBERADO ";
    }
	public Cadin()
	{
	}
}