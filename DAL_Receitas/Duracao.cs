using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_Receitas
{
    public class Duracao
    {
        private int _duracaoId;
        private string _tempo;

        public int DuracaoID { get => _duracaoId; set => _duracaoId = value; }
        public string Tempo { get => _tempo; set => _tempo = value; }

        public Duracao()
        {

        }

        public Duracao(int duracaoId)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Duracao_ID";
                cmd.Parameters.AddWithValue("@DuracaoID", duracaoId);

                sqlCon.Open();

                SqlDataReader drCategoria = cmd.ExecuteReader();

                if (drCategoria.HasRows)
                {
                    while (drCategoria.Read())
                    {
                        DuracaoID = drCategoria.GetInt32(0);
                        Tempo = drCategoria.GetString(1);
                    }
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

        public static List<Duracao> ListarDuracao()
        {
            List<Duracao> listaDuracao = new List<Duracao>();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Duracao_Listar";

                sqlCon.Open();

                SqlDataReader drDuracao = cmd.ExecuteReader();

                if (drDuracao.HasRows)
                {
                    while (drDuracao.Read())
                    {
                        Duracao duracao = new Duracao();
                        duracao.DuracaoID = drDuracao.GetInt32(0);
                        duracao.Tempo = drDuracao.GetString(1);
                        listaDuracao.Add(duracao);
                    }
                }
                return listaDuracao;
            }
            catch (Exception )
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
