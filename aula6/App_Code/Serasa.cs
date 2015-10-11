using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Serasa
{
    public string EstaNoSerasa(Cliente cliente)
    {
        //Código de consulta ao SERASA
        return cliente.Nome + " Liberado no SERASA";          
    }
	public Serasa()
	{
	}
}