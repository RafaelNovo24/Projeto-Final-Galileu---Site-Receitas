using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto_Site_Receitas.Classes
{
    class UnidadeMedida
    {
        private int _id;
        private string _medida;

        public int ID { get=>_id; set=>_id=value; }
        public string Medida { get=>_medida; set=>_medida=value; }

        public UnidadeMedida() { }

        public UnidadeMedida(int iD, string medida)
        {
            ID = iD;
            Medida = medida;
        }

        public bool Inserir()
        {
            return true;
        }
        public bool Eliminar()
        {
            return true;
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
