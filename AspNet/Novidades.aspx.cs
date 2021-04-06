using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL_Receitas;

namespace AspNet
{
    public partial class Novidades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listBoxReceitas.Items.Clear();
                listBoxReceitas.DataSource = DAL_Receitas.Receita.Novidades();
                listBoxReceitas.DataValueField = "IdReceita";
                listBoxReceitas.DataTextField = "Nome";
                listBoxReceitas.DataBind();
            }
        }

        protected void btnProcurar_Click(object sender, EventArgs e)
        {
            if (listBoxReceitas.SelectedIndex > -1)
            {
                string flag = listBoxReceitas.SelectedValue;
                Session["Receita"] = int.Parse(flag);
                Response.Redirect(@"~\Receita.aspx");
            }
            else
            {
                lblErro.Text = "Escolha uma receita antes de avançar!";
            }
        }
    }
}