using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Data;
using System.Data.OleDb;

public class tbProdutividadeBLL : AcessoDAL
{
    private OleDbConnection conexao;
    private OleDbCommand command;
    private OleDbDataReader drOleDb;
    private OleDbDataAdapter daOleDb;
    private DataSet dsOleDb;

    private String erro;

	public tbProdutividadeBLL()
	{
	}

    private String MontaQuery(tbProdutividadeDTO prodDTO)
    {
        String sSQL = "SELECT * FROM tbProdutividade WHERE 1=1 ";
        if (prodDTO.idProdutividade > 0)
        {
            sSQL += " AND idProdutividade = " + prodDTO.idProdutividade;
        }
        if (prodDTO.dsLinguagem.Trim() != "")
        {
            sSQL += " AND dsLinguagem like '%" + prodDTO.dsLinguagem + "%'";
        }
        if (prodDTO.vlAlta > 0.0)
        {
            sSQL += " AND vlAlta = " + prodDTO.vlAlta;
        }
        if (prodDTO.vlMedia > 0.0)
        {
            sSQL += " AND vlMedia = " + prodDTO.vlMedia;
        }
        if (prodDTO.vlBaixa > 0.0)
        {
            sSQL += " AND vlBaixa = " + prodDTO.vlBaixa;
        }
        return sSQL;
    }

    public tbProdutividadeDTO BuscaPorID(tbProdutividadeDTO prodDTO)
    {
        String sSQL = MontaQuery(prodDTO);
        tbProdutividadeDTO prodAux = new tbProdutividadeDTO();
        //tbFabricanteDTO fabri = new tbFabricanteDTO();
        //tbFabricanteBLL fabriBLL = new tbFabricanteBLL();

        try
        {
            conexao = (OleDbConnection)CriaConexaoOleDb();
            drOleDb = cria_DataReader_OleDb(sSQL, conexao);
            while (drOleDb.Read())
            {
                prodAux.idProdutividade = (int)drOleDb["idProdutividade"];
                prodAux.dsLinguagem = (string)drOleDb["dsLinguagem"];
                prodAux.vlAlta = (float)(double)drOleDb["vlAlta"];
                prodAux.vlBaixa = (float)(double)drOleDb["vlBaixa"];
                prodAux.vlMedia = (float)(double)drOleDb["vlMedia"];

                //tbFabricanteDTO fabriAux = new tbFabricanteDTO();
                //fabriAux.idFabricante = (int)drOleDb["idFabricante"];
               //prodAux.fabricante = fabriBLL.BuscaPorID(fabriAux);
            }
        }
        catch (SystemException e)
        {
            erro = e.Message;
        }
        return prodAux;
    }

    public ListaDeProdutividade ListaOFF(tbProdutividadeDTO prodDTO)
    {
        ListaDeProdutividade listaRet = new ListaDeProdutividade();
        String sSQL = MontaQuery(prodDTO);
        try
        {
            conexao = (OleDbConnection)CriaConexaoOleDb();
            drOleDb = cria_DataReader_OleDb(sSQL, conexao);
            while (drOleDb.Read())
            {
                tbProdutividadeDTO prodAux = new tbProdutividadeDTO();
                prodAux.idProdutividade = (int)drOleDb["idProdutividade"];
                prodAux.dsLinguagem = (string)drOleDb["dsLinguagem"];
                prodAux.vlAlta = (float)(double)drOleDb["vlAlta"];
                prodAux.vlBaixa = (float)(double)drOleDb["vlBaixa"];
                prodAux.vlMedia = (float)(double)drOleDb["vlMedia"];
                listaRet.Add(prodAux);
            }
        }
        catch (SystemException e)
        {
            erro = e.Message;
        }

        return listaRet;
    }


    public DataSet listAll(tbProdutividadeDTO prodDTO)
    {
        String sSQL = MontaQuery(prodDTO);
        try
        {
            conexao = (OleDbConnection)CriaConexaoOleDb();
            daOleDb = cria_DataAdapter_OleDb(sSQL, conexao);
            dsOleDb = cria_DataSet_OleDb(daOleDb);

        }
        catch (SystemException e)
        {
            erro = e.Message;
        }
        return dsOleDb;
    }
    
    public void SalvaDados(tbProdutividadeDTO prodDTO)
    {
        string sSQL;
        sSQL = "INSERT INTO tbProdutividade (idProdutividade, dsLinguagem, vlBaixa, ";
        sSQL += "vlMedia, vlAlta) VALUES ";
        sSQL += "( @idProdutividade, @dsLinguagem, @vlBaixa, @vlMedia, @vlAlta)";

        conexao = (OleDbConnection)CriaConexaoOleDb();

        command = new OleDbCommand("sp_Produtividade_Ins", conexao);
        command.CommandType = CommandType.StoredProcedure;

        OleDbParameter parametro = command.Parameters.Add("RETURN_VALUE", OleDbType.Integer);
        parametro.Direction = ParameterDirection.ReturnValue;

        parametro = command.Parameters.Add("@idProdutividade", OleDbType.Integer);
        parametro.Value = prodDTO.idProdutividade;

        parametro = command.Parameters.Add("@dsLinguagem", OleDbType.VarChar);
        parametro.Value = prodDTO.dsLinguagem;

        parametro = command.Parameters.Add("@vlBaixa", OleDbType.Double);
        parametro.Value = prodDTO.vlBaixa;

        parametro = command.Parameters.Add("@vlMedia", OleDbType.Double);
        parametro.Value = prodDTO.vlMedia;

        parametro = command.Parameters.Add("@vlAlta", OleDbType.Double);
        parametro.Value = prodDTO.vlAlta;

        try
        {
            drOleDb = command.ExecuteReader();
            drOleDb.Close();
            conexao.Close();
            int iRet = (int)command.Parameters["RETURN_VALUE"].Value;
        }
        catch (SystemException e)
        {
            erro = e.Message;
        }

    }
}