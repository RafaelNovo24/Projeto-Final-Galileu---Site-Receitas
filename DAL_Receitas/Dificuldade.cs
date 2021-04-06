using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_Receitas
{
    public class Dificuldade
    {
        private int _dificuldadeId;
        private string _nivel;

        public int DificuldadeID { get => _dificuldadeId; set => _dificuldadeId = value; }
        public string Nivel { get => _nivel; set => _nivel = value; }

        public Dificuldade()
        {
        }

        public Dificuldade(int dificuldadeID)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Dificuldade_ID";
                cmd.Parameters.AddWithValue("@DificuldadeID", dificuldadeID);

                sqlCon.Open();

                SqlDataReader drCategoria = cmd.ExecuteReader();

                if (drCategoria.HasRows)
                {
                    while (drCategoria.Read())
                    {
                        DificuldadeID = drCategoria.GetInt32(0);
                        Nivel = drCategoria.GetString(1);
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
