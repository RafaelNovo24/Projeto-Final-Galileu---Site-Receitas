using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL_Receitas;

namespace AspNet
{
    public partial class Pesquisa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddbDuracao.DataSource = DAL_Receitas.Duracao.ListarDuracao();
                ddbDuracao.DataTextField = "Tempo";
                ddbDuracao.DataValueField = "DuracaoID";
                ddbDuracao.DataBind();


                ddlDificuldade.DataSource = DAL_Receitas.Dificuldade.TodasDificuldades();
                ddlDificuldade.DataTextField = "Nivel";
                ddlDificuldade.DataValueField = "DificuldadeID";
                ddlDificuldade.DataBind();
            }
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            lbltextoErroLista.Text = "";

            string pesquisa;
            int? duracao; 
            int? dificuldade;
            if (txBoxPesquisa == null && ddbDuracao.SelectedIndex == 0 && ddlDificuldade == null)
            {
                lbltextoErroLista.Text = "Por favor selecione um  método de pesquisa!";
            }
            if (txBoxPesquisa.Text != null)
            {
                pesquisa = txBoxPesquisa.Text;
            }
            else
            {
                pesquisa = null;
            }

            if (ddbDuracao.SelectedIndex > 0)
            {
                duracao = int.Parse(ddbDuracao.SelectedValue);
            }
            else
            {
                duracao = null;
            }

            if (ddlDificuldade.SelectedIndex > 0)
            {
                dificuldade = int.Parse(ddlDificuldade.SelectedValue);
            }
            else
            {
                dificuldade = null;
            }

            listBoxReceitas.Items.Clear();

            List<DAL_Receitas.Receita> listaReceitasPesquisa = DAL_Receitas.Receita.Pesquisa(pesquisa, duracao, dificuldade);
            List<DAL_Receitas.Receita> receitasPesquisadas = new List<DAL_Receitas.Receita>();

            foreach (DAL_Receitas.Receita item in listaReceitasPesquisa)
            {
                DAL_Receitas.Receita r = new DAL_Receitas.Receita(item.IdReceita);
                r.Nome = item.Nome;
                r.IdReceita = item.IdReceita;
                receitasPesquisadas.Add(r);
            }

            listBoxReceitas.DataSource = receitasPesquisadas;
            listBoxReceitas.DataValueField = "IdReceita";
            listBoxReceitas.DataTextField = "Nome";
            listBoxReceitas.DataBind();

            if (listBoxReceitas.Items.Count == 0)
            {
                lbltextoErroLista.Text = "Pesquisa sem resultados!";
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
                lbltextoErroLista.Text = "Escolha uma receita primeiro!";
            }
        }
    }

}