using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using DAL_Receitas;

namespace AspNet
{
    public partial class AreaPessoal : System.Web.UI.Page
    {
        MembershipUser utilizador;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                utilizador = Membership.GetUser(User.Identity.Name);
                string userID = Membership.GetUser().ProviderUserKey.ToString();
                DAL_Receitas.Favorito favorito = new DAL_Receitas.Favorito();

                Session["user"] = utilizador;

                txtBoxUserEmail.Text = utilizador.UserName;
                txtUserPass.Text = utilizador.UserName;
                txtBoxMail.Text = utilizador.Email;

                List<Favorito> listaOriginalFavoritos = DAL_Receitas.Favorito.ListarFavoritoPorUser(userID);
                List<DAL_Receitas.Receita> listaFavoritos = new List<DAL_Receitas.Receita>();

                foreach (DAL_Receitas.Favorito fav in listaOriginalFavoritos)
                {
                    DAL_Receitas.Receita rec = new DAL_Receitas.Receita(fav.Receita.IdReceita);
                    rec.Nome = fav.Receita.Nome;
                    rec.IdReceita = fav.Receita.IdReceita;
                    listaFavoritos.Add(rec);
                }
                lbReceitasFav.DataSource = listaFavoritos;
                lbReceitasFav.DataValueField = "IdReceita";
                lbReceitasFav.DataTextField = "Nome";
                lbReceitasFav.DataBind();

                lbMinhasReceitas.DataSource = DAL_Receitas.Receita.ListarPorUser(userID);
                lbMinhasReceitas.DataTextField = "Nome";
                lbMinhasReceitas.DataValueField = "IdReceita";
                lbMinhasReceitas.DataBind();
            }
            else if (Page.IsPostBack)

            {
                utilizador = Membership.GetUser(User.Identity.Name);

                Session["user"] = utilizador;

                txtBoxUserEmail.Text = utilizador.UserName;
                txtUserPass.Text = utilizador.UserName;
                txtBoxMail.Text = utilizador.Email;
            }
        }

        protected void btnPassConfirmar_Click(object sender, EventArgs e)
        {
            string newPassword = "";
            try
            {
                newPassword = Membership.Provider.ResetPassword(txtUserPass.Text, txtPassResposta.Text);

            }
            catch (NotSupportedException)
            {
                lblPass.Text = "Ocorreu um erro durante o processo.Por favor volte a inserir os dados.";
            }
            catch (MembershipPasswordException)
            {
                lblPass.Text = "Resposta de segurança inválida. Por favor tente novamente.";
                return;
            }
            if (newPassword != "")
            {
                lblPass.Text = "Password alterada com sucesso!";
            }

            Response.Redirect(@"~\AreaPessoal.aspx");
        }

        protected void btnAlterarEmail_Click(object sender, EventArgs e)
        {
            try
            {
                utilizador = (MembershipUser)Session["user"];

                utilizador.Email = txtBoxUserNovoMail.Text;

                Membership.UpdateUser(utilizador);

                lblAlterarEmail.Text = "Email alterado com sucesso.";
            }
            catch (System.Configuration.Provider.ProviderException)
            {
                lblAlterarEmail.Text = "Por favor tente novamente.";
            }
            Response.Redirect(@"~\AreaPessoal.aspx");
        }

        protected void btnProcurarReceitasfav_Click(object sender, EventArgs e)
        {
            if (lbReceitasFav.SelectedIndex != -1)
            {
                string flag = lbReceitasFav.SelectedValue;
                Session["Receita"] = int.Parse(flag);
                Response.Redirect(@"~\Receita.aspx");
            }
            else
            {
                lblReceitasFavoritasErro.Text = "Por favor seleccione uma receita!";
            }
        }

        protected void btnProcurarMinhasReceitas_Click(object sender, EventArgs e)
        {
            if (lbMinhasReceitas.SelectedIndex != -1)
            {
                string flag = lbMinhasReceitas.SelectedValue;
                Session["Receita"] = int.Parse(flag);
                Response.Redirect(@"~\Receita.aspx");
            }
            else
            {
                lblMinhasReceitasErro.Text = "Por favor seleccione uma receita!";
            }
        }
    }
}