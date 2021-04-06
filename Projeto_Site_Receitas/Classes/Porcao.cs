using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto_Site_Receitas.Classes
{
    class Porcao
    {
        private int _id;
        private string _valor;

        public int ID { get => _id; set => _id = value; }
        public string Valor { get => _valor; set => _valor = value; }

        public Porcao()
        {
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
