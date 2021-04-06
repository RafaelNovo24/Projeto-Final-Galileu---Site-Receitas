using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL_Receitas;
using System.Web.Security;

namespace AspNet
{
    public partial class CriarReceita : System.Web.UI.Page
    {
        List<DAL_Receitas.Ingredientes_Receita> ListaIngredientes;
        DAL_Receitas.Receita receita;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ListaIngredientes = new List<DAL_Receitas.Ingredientes_Receita>();
                receita = new DAL_Receitas.Receita();
                Session["novaReceita"] = receita;
                Session["listaIngredientes"] = ListaIngredientes;

                ddlCategoria.DataSource = DAL_Receitas.Categorias.TodasCategorias();
                ddlCategoria.DataTextField = "Nome";
                ddlCategoria.DataValueField = "CategoriaID";
                ddlCategoria.DataBind();

                ddbDuracao.DataSource = DAL_Receitas.Duracao.ListarDuracao();
                ddbDuracao.DataTextField = "Tempo";
                ddbDuracao.DataValueField = "DuracaoID";
                ddbDuracao.DataBind();

                ddlDificuldade.DataSource = DAL_Receitas.Dificuldade.TodasDificuldades();
                ddlDificuldade.DataTextField = "Nivel";
                ddlDificuldade.DataValueField = "DificuldadeID";
                ddlDificuldade.DataBind();

                ddlPorcao.DataSource = DAL_Receitas.Porcao.ListarPorcao();
                ddlPorcao.DataTextField = "Valor";
                ddlPorcao.DataValueField = "ID";
                ddlPorcao.DataBind();

                ddlUnidadeMedida.DataSource = DAL_Receitas.UnidadeMedida.TodasUnidadesMedida();
                ddlUnidadeMedida.DataTextField = "Medida";
                ddlUnidadeMedida.DataValueField = "ID";
                ddlUnidadeMedida.DataBind();

                ddlIngrediente.DataSource = DAL_Receitas.Ingrediente.TodosIngredientes();
                ddlIngrediente.DataTextField = "NomeIngrediente";
                ddlIngrediente.DataValueField = "IdIngrediente";
                ddlIngrediente.DataBind();

                PopularLBIngredientes();
            }
            else
            {
                receita = (DAL_Receitas.Receita)Session["novaReceita"];
                ListaIngredientes = (List<DAL_Receitas.Ingredientes_Receita>)Session["listaIngredientes"];

            }
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListaIngredientes.Count > 0)
                {
                    if (txtBoxPreparacao.Text.Length > 0)
                    {
                        if (txtTitulo.Text.Length > 0)
                        {
                            string titulo = txtTitulo.Text;
                            string preparacao = txtBoxPreparacao.Text;
                            int categoria = int.Parse(ddlCategoria.SelectedValue);
                            int duracao = int.Parse(ddbDuracao.SelectedValue);
                            int dificuldade = int.Parse(ddlDificuldade.SelectedValue);
                            int porcao = int.Parse(ddlPorcao.SelectedValue);

                            string userID = Membership.GetUser().ProviderUserKey.ToString();

                            receita = (DAL_Receitas.Receita)Session["novaReceita"];
                            receita.AdicionarReceita(titulo, dificuldade, categoria, duracao, preparacao, porcao, userID);

                            try
                            {
                                receita.InserirIngredientesUltimaReceitaCriada();
                            }
                            catch (Exception ex)
                            {

                                lblEstadoCriar.Text = ex.Message;
                            }                         

                            Response.Redirect(@"~\ReceitaInserida.aspx",false);
                        }
                        else
                        {
                            lblEstadoCriar.Text = "Por favor insira o nome da receita!";
                        }
                    }
                    else
                    {
                        lblErroPrep.Text = "Insira a preparação da receita!";
                    }

                }
                else
                {
                    lblErroIng.Text = "Por favor insira os ingredientes necessários";
                }
            }
            catch (Exception ex)
            {

                lblEstadoCriar.Text = "Houve um problema a criar a receita: " + ex.Message + " Por favor tente novamente";
            }
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            InserirIngrediente();
            lbIngredientes.Items.Clear();
            PopularLBIngredientes();

        }

        protected void InserirIngrediente()
        {
            DAL_Receitas.Ingredientes_Receita linhaIngrediente = new DAL_Receitas.Ingredientes_Receita();
            ListaIngredientes = (List<DAL_Receitas.Ingredientes_Receita>)Session["listaIngredientes"];
            receita = (DAL_Receitas.Receita)Session["novaReceita"];

            try
            {
                if (txtQuantidade.Text.Length > 0)
                {
                    Ingrediente ingrediente = new Ingrediente(int.Parse(ddlIngrediente.SelectedValue));
                    UnidadeMedida unMed = new UnidadeMedida(int.Parse(ddlUnidadeMedida.SelectedValue));

                    linhaIngrediente.Ingrediente = ingrediente;
                    linhaIngrediente.Quantidade = int.Parse(txtQuantidade.Text);
                    linhaIngrediente.Unidade = unMed;

                    receita.AdicionarIngrediente(linhaIngrediente);
                    ListaIngredientes.Add(linhaIngrediente);

                    lblErroQuantidade.Visible = false;
                }
                else
                {
                    lblErroQuantidade.Text = "Insira a quantidade!";
                }
            }
            catch (Exception e)
            {
                lblErroQuantidade.Text = "Erro na escolha! Tenha atenção a: " + e.Message;
            }
        }

        protected void PopularLBIngredientes()
        {
            receita = (DAL_Receitas.Receita)Session["novaReceita"];
            ListaIngredientes = (List<DAL_Receitas.Ingredientes_Receita>)Session["listaIngredientes"];
            lbIngredientes.Items.Clear();
            try
            {
                foreach (Ingredientes_Receita ing in receita.ListaIngredientes)
                {
                    lbIngredientes.Items.Add(ing.ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}