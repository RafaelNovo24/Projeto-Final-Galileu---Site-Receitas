using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Web;

namespace DAL_Receitas
{
    public class Favorito
    {
        private int _favoritoID;
        private Receita _receita;
        private string _user;


        public Receita Receita { get => _receita; set => _receita = value; }
        public string User { get => _user; set => _user = value; }
        public int FavoritoID { get => _favoritoID; set => _favoritoID = value; }

        public Favorito()
        {
        }

        public Favorito(int favorito)
        {
            FavoritoID = favorito;
        }

        public bool FavoritoReceita(int receita)
        {
            List<Receita> listaReceitas = new List<Receita>();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Receita_Listar";

                sqlCon.Open();

                SqlDataReader drReceita = cmd.ExecuteReader();

                if (drReceita.HasRows)
                {
                    while (drReceita.Read())
                    {
                        Favorito fav = new Favorito();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlCon.Close();
            }
        }

        public bool Adicionar(string userID, int receitaID)
        {
            List<Receita> listaReceitas = new List<Receita>();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Favoritos_Adicionar";
                cmd.Parameters.AddWithValue("@IdUtilizador", userID);
                cmd.Parameters.AddWithValue("@ReceitaID", receitaID);

                sqlCon.Open();
                cmd.ExecuteNonQuery();
   
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                sqlCon.Close();
            }
        }

        public bool Remover(string userID, int receitaID)
        {
            List<Receita> listaReceitas = new List<Receita>();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Favoritos_Eliminar";
                cmd.Parameters.AddWithValue("@ReceitaID", receitaID);
                cmd.Parameters.AddWithValue("@IdUtilizador", userID);

                sqlCon.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                sqlCon.Close();
            }
        }

        public static List<Favorito> ListarFavoritoPorUser(string userID)
        {
            List<Favorito> listaFav = new List<Favorito>();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Favoritos_Listar_User";
                cmd.Parameters.AddWithValue("@UserID", userID);

                sqlCon.Open();

                SqlDataReader drfavorito = cmd.ExecuteReader();

                if (drfavorito.HasRows)
                {
                    while (drfavorito.Read())
                    {
                        Favorito fav = new Favorito();
                        fav.Receita = new Receita(drfavorito.GetInt32(0));
                        fav.FavoritoID = drfavorito.GetInt32(1);
                        listaFav.Add(fav);
                    }
                }
                return listaFav;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlCon.Close();
            }
        }

    }
}
