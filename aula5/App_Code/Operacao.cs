using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


abstract public class Operacao
{
    abstract public int handelOperacao(int valor1, int valor2);

    public int efetuaOperacao(int valor1, int valor2){
        //Código... lógica... regras de negício...
        int resultado = handelOperacao(valor1, valor2);

        return resultado;
    }

	public Operacao()
	{
	}
}