using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto_Site_Receitas.Classes
{
    class Duracao
    {
        private int _duracaoId;
        private string _tempo;

        public int DuracaoID { get=>_duracaoId; set=>_duracaoId=value; }
        public string Tempo { get=>_tempo; set=>_tempo=value; }

        public Duracao()
        {

        }

        public Duracao(int duracaoId)
        {
            DuracaoID = duracaoId;
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
            catch (Exception ex)
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
