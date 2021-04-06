using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto_Site_Receitas.Classes
{
    class Ingredientes_Receita
    {
        private int _ingredienteID;
        private int _unidadeID;
        private int _receitaID;
        private int _quantidade;
        private string _nome;
        private string _unidadeNome;

        public int IngredienteID { get=> _ingredienteID; set=>_ingredienteID=value; }
        public int UnidadeID { get=>_unidadeID; set=>_unidadeID=value; }
        public int ReceitaID { get=>_receitaID; set=>_receitaID=value; }
        public int Quantidade { get=>_quantidade; set=>_quantidade=value; }
        public string Nome { get=>_nome; set=>_nome=value; }
        public string UnidadeNome { get=>_unidadeNome; set=>_unidadeNome=value; }
        public string DadosLista { get=>Nome + ":   " + Quantidade + " " + UnidadeNome; }

        public Ingredientes_Receita()
        {
        }

        public Ingredientes_Receita(int ingredienteId)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Ingredientes_Receita_ID";
                cmd.Parameters.AddWithValue("@IngredienteID", ingredienteId);

                sqlCon.Open();

                SqlDataReader drIngReceita = cmd.ExecuteReader();

                if (drIngReceita.HasRows)
                {
                    while (drIngReceita.Read())
                    {
                        IngredienteID = drIngReceita.GetInt32(0);
                        Quantidade = drIngReceita.GetInt32(1);
                        UnidadeID = drIngReceita.GetInt32(2);
                        ReceitaID = drIngReceita.GetInt32(3);
                        Nome = drIngReceita.GetString(4);
                    }
                } 
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

        public bool Adicionar(int ingredienteId, int unidadeId, int quantidade , int receitaId)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Ingredientes_Definir_Ingredientes_Receitas";
                cmd.Parameters.AddWithValue("@IngredienteID", ingredienteId);
                cmd.Parameters.AddWithValue("@UnidadeID", unidadeId);
                cmd.Parameters.AddWithValue("@Quantidade", quantidade);
                cmd.Parameters.AddWithValue("@ReceitaID", receitaId);

                sqlCon.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                sqlCon.Close();
            }
            return true;
        }

        public bool Remover(int ingredienteId, int receitaId)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Ingredientes_Receitas_Eliminar";
                cmd.Parameters.AddWithValue("@IngredienteID", ingredienteId);
                cmd.Parameters.AddWithValue("@ReceitaID", receitaId);

                sqlCon.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                sqlCon.Close();
            }
            return true;
        }

        public static List<Ingredientes_Receita> ListarIngredientesReceita(int idReceita)
        {
            List<Ingredientes_Receita> listaIngReceitas = new List<Ingredientes_Receita>();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Ingredientes_Listar_Receita";
                cmd.Parameters.AddWithValue("@ReceitaID", idReceita);

                sqlCon.Open();

                SqlDataReader drIngReceita = cmd.ExecuteReader();

                if (drIngReceita.HasRows)
                {
                    while (drIngReceita.Read())
                    {
                        Ingredientes_Receita ingRec = new Ingredientes_Receita();
                        ingRec.IngredienteID = drIngReceita.GetInt32(0);
                        ingRec.Quantidade = drIngReceita.GetInt32(1);
                        ingRec.UnidadeID = drIngReceita.GetInt32(2);
                        ingRec.ReceitaID = drIngReceita.GetInt32(3);
                        ingRec.Nome = drIngReceita.GetString(4);
                        ingRec.UnidadeNome = drIngReceita.GetString(5);
                        listaIngReceitas.Add(ingRec);
                    }
                }
                return listaIngReceitas;
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
