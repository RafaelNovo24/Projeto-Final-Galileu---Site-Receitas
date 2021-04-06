using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto_Site_Receitas.Classes
{
    class Dificuldade
    {
        private int _dificuldadeId;
        private string _nivel;

        public int DificuldadeID { get=>_dificuldadeId; set=>_dificuldadeId=value; }
        public string Nivel { get=>_nivel; set=>_nivel=value; }

        public Dificuldade()
        {
        }

        public Dificuldade(int dificuldadeID)
        {
            DificuldadeID = dificuldadeID;
        }

        public static List<Dificuldade> TodasDificuldades()
        {
            List<Dificuldade> listaDificuldade = new List<Dificuldade>();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Dificuldade_Listar";

                sqlCon.Open();

                SqlDataReader drDificuldade = cmd.ExecuteReader();

                if (drDificuldade.HasRows)
                {
                    while (drDificuldade.Read())
                    {
                        Dificuldade dificuldade = new Dificuldade();
                        dificuldade.DificuldadeID = drDificuldade.GetInt32(0);
                        dificuldade.Nivel = drDificuldade.GetString(1);
                        listaDificuldade.Add(dificuldade);
                    }
                }
                return listaDificuldade;
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
