using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ModeloUnico
/// </summary>
public class ModeloUnico
{
    private static ModeloUnico instancia = null;

	private ModeloUnico()
	{
	}

    public static ModeloUnico Instacia
    {
        get
        {
            if (instancia == null)
			{
                lock (typeof(ModeloUnico))
				if (instancia == null)
					instancia = new ModeloUnico();
			}
            return instancia;
        }
    }
}