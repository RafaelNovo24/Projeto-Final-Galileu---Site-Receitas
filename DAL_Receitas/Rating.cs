using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Web;

namespace DAL_Receitas
{
    public class Rating
    {
        private int _voto;
        private string _userID;
        private Receita _receita;
        private int _ratingID;
        private double _media;

        public string UserID { get => _userID; set => _userID = value; }
        public Receita Receita { get => _receita; set => _receita = value; }
        public int Voto { get => _voto; set => _voto = value; }
        public int RatingID { get => _ratingID; set => _ratingID = value; }
        public double Media { get => _media; set => _media = value; }

        public Rating()
        {
        }

        public Rating(int receitaID)
        {
            List<int> listaVotos = new List<int>();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Rating_Por_Receita";
                cmd.Parameters.AddWithValue("@ReceitaID", receitaID);

                sqlCon.Open();

                SqlDataReader drRating = cmd.ExecuteReader();

                while (drRating.Read())
                {
                    int votos = drRating.GetInt32(0);
                    listaVotos.Add(votos);
                }

                int soma = 0;
                int contador = 0;

                if (listaVotos.Count != 0)
                {
                    foreach (int voto in listaVotos)
                    {
                        soma += voto;
                        contador++;

                    }
                    Media = (soma / contador);
                }
                else
                {
                    Media = 0;
                }
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

        public bool Votar(int voto, int receitaID, string userID)
        {
            List<Rating> listaPorcao = new List<Rating>();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "dbo.Rating_Votar";
                cmd.Parameters.AddWithValue("@Voto", voto);
                cmd.Parameters.AddWithValue("@ReceitaID", receitaID);
                cmd.Parameters.AddWithValue("@UtilizadorID", userID);

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

        public static List<Rating> ListarPorReceita(Receita receita)
        {
            List<Rating> listaRating = new List<Rating>();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Rating_Listar_Por_Receita";

                sqlCon.Open();
                SqlDataReader drRating = cmd.ExecuteReader();

                if (drRating.HasRows)
                {
                    while (drRating.Read())
                    {
                        Rating rating = new Rating();
                        rating.UserID = drRating.GetString(0);
                        rating.Receita = new Receita(drRating.GetInt32(1));
                        rating.Voto = drRating.GetInt32(2);
                        listaRating.Add(rating);                       
                    }
                }
                return listaRating;
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
