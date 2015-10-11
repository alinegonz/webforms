using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ddlMeses_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlMeses.SelectedIndex != 0)
            lblResultado.Text = ddlMeses.SelectedItem.Value;
        else
            lblResultado.Text = "Selecione um item";
    }
    protected void btnIncluir_Click(object sender, EventArgs e)
    {
        if (lstbUm.SelectedIndex != -1)
        {
            lstbDois.Items.Add(new ListItem(lstbUm.SelectedItem.Text, lstbUm.SelectedItem.Value));
            lstbUm.Items.Remove(lstbUm.SelectedItem);
        }
    }
    protected void btnRemover_Click(object sender, EventArgs e)
    {
        if (lstbDois.SelectedIndex != -1)
        {
            lstbUm.Items.Add(new ListItem(lstbDois.SelectedItem.Text, lstbDois.SelectedItem.Value));
            lstbDois.Items.Remove(lstbDois.SelectedItem);
        }
    }
}