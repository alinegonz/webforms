using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Subtracao : Operacao
{
	public Subtracao()
	{
	}

    public override int handelOperacao(int valor1, int valor2)
    {
        return valor1 - valor2;
    }
}