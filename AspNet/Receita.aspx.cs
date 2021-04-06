using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using DAL_Receitas;
using System.Web.UI.HtmlControls;
using System.Web.Security;

namespace AspNet
{
    public partial class Receita : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = (int)Session["Receita"];
            DAL_Receitas.Receita receita = new DAL_Receitas.Receita(id);

            lbTituloReceita.Text = receita.Nome;
            lblData.Text = receita.DataCriacao.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
            lblCategoria.Text = receita.Categoria.Nome;
            lblDificuldade.Text = receita.Dificuldade.Nivel;
            lblDuracao.Text = receita.Duracao.Tempo;
            lblPorcao.Text = receita.Porcao.Valor;
            lblRating.Text = receita.MediaVotos.ToString();

            List<string> lIng = new List<string>();
            List<Ingredientes_Receita> lIngOriginal = DAL_Receitas.Ingredientes_Receita.ListarIngredientesReceita(id);
            string detail;

            foreach (Ingredientes_Receita ing in lIngOriginal)
            {
                detail = ing.Quantidade.ToString() + " " + ing.Unidade.Medida + " " + ing.Ingrediente.NomeIngrediente;
                lIng.Add(detail);
            }
            listBoxIngredientes.DataSource = lIng;
            listBoxIngredientes.DataBind();

            txtBoxPreparacao.Text = receita.Preparacao;
            PopularComentarios();
        }

        protected void btnVotar_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    DAL_Receitas.Rating rating = new DAL_Receitas.Rating();
                    int voto = int.Parse(txtVotacao.Text);
                    string userID = Membership.GetUser().ProviderUserKey.ToString();
                    int receitaID = (int)Session["Receita"];

                    if (rating.Votar(voto, receitaID, userID))
                    {
                        lbVotarSucesso.Text = "Obrigado por votar!";
                        lblVote1a10.Text = "";
                    }
                }
                else
                {
                    lblVotarErro.Text = "Registe-se para poder votar nas receitas!";
                }
            }
            catch (Exception ex)
            {

                lblVotarErro.Text = ex.Message;
            }
        }

        protected void btnInserirComentário_Click(object sender, EventArgs e)
        {
            if (System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string userID = Membership.GetUser().ProviderUserKey.ToString();
                string comentario = txtInserirComentario.Text;
                int receitaID = (int)Session["Receita"];

                Comentario com = new Comentario();
                if (com.Inserir(userID, comentario, receitaID))
                {
                    lbltxtComentarioSucesso.Text = "Comentário Inserido com sucesso";
                }
                
            }
            else
            {
                btnComRegistar.Visible = true;
                lbltxtComentarioErro.Text = "Por favor faça Login ou registe-se para poder comentar.";
            }
            PopularComentarios();
        }

        protected void btnAdicionarFavs_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    DAL_Receitas.Favorito fav = new DAL_Receitas.Favorito();
                    string userID = Membership.GetUser().ProviderUserKey.ToString();
                    fav.Adicionar(userID, (int)Session["Receita"]);
                    lblFavoritosSucesso.Text = "Receita adicionada aos favoritos com sucesso.";
                }
                else
                {
                    lblFavoritosErro.Text = "Registe-se para poder adicionar receitas aos favoritos!";
                }

            }
            catch (Exception ex)
            {

                lblFavoritosErro.Text = ex.Message;
            }
        }

        protected void btnComRegistar_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"~\Login.aspx");
        }

        private void PopularComentarios()
        {
            int id = (int)Session["Receita"];
            List<string> listaCom = new List<string>();
            List<Comentario> listaOriginalCom = DAL_Receitas.Comentario.ComentariosPorRceita(id);
            string texto;
            foreach (Comentario comentario in listaOriginalCom)
            {
                texto = comentario.Texto;
                listaCom.Add(texto);
            }

            lbComentarios.DataSource = listaCom;
            lbComentarios.DataBind();

        }
    }
}