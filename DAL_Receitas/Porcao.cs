using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_Receitas
{
    public class Porcao
    {
        private int _id;
        private string _valor;

        public int ID { get => _id; set => _id = value; }
        public string Valor { get => _valor; set => _valor = value; }

        public Porcao()
        {
        }

        public Porcao(int id)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Porcao_ID";
                cmd.Parameters.AddWithValue("@PorcaoID", id);

                sqlCon.Open();

                SqlDataReader drCategoria = cmd.ExecuteReader();

                if (drCategoria.HasRows)
                {
                    while (drCategoria.Read())
                    {
                        ID = drCategoria.GetInt32(0);
                        Valor = drCategoria.GetString(1);
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

        public static List<Porcao> ListarPorcao()
        {
            List<Porcao> listaPorcao = new List<Porcao>();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "dbo.Porcoes_Listar";

                sqlCon.Open();

                SqlDataReader drPorcao = cmd.ExecuteReader();

                if (drPorcao.HasRows)
                {
                    while (drPorcao.Read())
                    {
                        Porcao porcao = new Porcao();
                        porcao.ID = drPorcao.GetInt32(0);
                        porcao.Valor = drPorcao.GetString(1);
                        listaPorcao.Add(porcao);
                    }
                }
                return listaPorcao;
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
