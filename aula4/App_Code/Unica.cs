using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Unica
/// </summary>
public class Unica
{
    private static Unica instancia = null;

	private Unica()
	{
	}

    public String nome { get; set; }

    public static Unica Instancia
    {
        get
        {
            if (instancia == null)
            {
                lock (typeof(Unica))
                instancia = new Unica();
            }

            return instancia;
        }
    }
}