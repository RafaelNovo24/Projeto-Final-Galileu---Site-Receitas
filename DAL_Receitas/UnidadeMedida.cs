using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_Receitas
{
    public class UnidadeMedida
    {
        private int _id;
        private string _medida;
        private string _simbolo;

        public int ID { get => _id; set => _id = value; }
        public string Medida { get => _medida; set => _medida = value; }
        public string Simbolo { get => _simbolo; set => _simbolo = value; }

        public UnidadeMedida() { }

        public UnidadeMedida(int id)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "UnidadeMedida_ID";
                cmd.Parameters.AddWithValue("@UnidadeID", id);

                sqlCon.Open();

                SqlDataReader drUnidade = cmd.ExecuteReader();

                if (drUnidade.HasRows)
                {
                    while (drUnidade.Read())
                    {
                        ID = drUnidade.GetInt32(0);
                        Medida = drUnidade.GetString(1);
                        Simbolo = drUnidade.GetString(2);
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

        public static List<UnidadeMedida> TodasUnidadesMedida()
        {
            List<UnidadeMedida> listaUnidadeMedida = new List<UnidadeMedida>();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Unidades_Listar";

                sqlCon.Open();

                SqlDataReader drUnidadeMedida = cmd.ExecuteReader();

                if (drUnidadeMedida.HasRows)
                {
                    while (drUnidadeMedida.Read())
                    {
                        UnidadeMedida unMedida = new UnidadeMedida();
                        unMedida.ID = drUnidadeMedida.GetInt32(0);
                        unMedida.Medida = drUnidadeMedida.GetString(1);
                        listaUnidadeMedida.Add(unMedida);
                    }
                }
                return listaUnidadeMedida;
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
