using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Serasa
{
    public string EstaNosSerasa(Cliente cliente)
    {
        //Aqui verifica a SERASA para o cliente fulano
        return cliente.Nome + " Consutado na SERASA - LIBERADO ";
    }
	public Serasa()
	{
	}
}