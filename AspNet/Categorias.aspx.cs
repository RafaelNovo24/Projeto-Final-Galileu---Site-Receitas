using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL_Receitas;

namespace AspNet
{
    public partial class Categorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlCategorias.DataSource = DAL_Receitas.Categorias.TodasCategorias();
                ddlCategorias.DataValueField = "categoriaID";
                ddlCategorias.DataTextField = "Nome";
                ddlCategorias.DataBind();
            }
        }
        protected void btnSelect_Click(object sender, EventArgs e)
        {
            listBoxReceitas.DataSource = DAL_Receitas.Receita.ReceitasPorCategoria(int.Parse(ddlCategorias.SelectedValue));
            listBoxReceitas.DataValueField = "IdReceita";
            listBoxReceitas.DataTextField = "Nome";
            listBoxReceitas.DataBind();
            lblErroListReceitas.Text = String.Empty;
        }

        protected void btnProcurar_Click(object sender, EventArgs e)
        {
            if (listBoxReceitas.Items.Count > 0)
            {
                if (listBoxReceitas.SelectedIndex > -1)
                {
                    string flag = listBoxReceitas.SelectedValue;
                    Session["Receita"] = int.Parse(flag);
                    Response.Redirect(@"~\Receita.aspx");
                }
                else
                {
                    lblErroListReceitas.Text = "Escolha uma receita primeiro!";
                }
            }
            else
            {
                lblErroListReceitas.Text = "Seleccione uma categoria primeiro!";
            }
        }
    }
}