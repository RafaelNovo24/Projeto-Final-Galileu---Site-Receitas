using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_Receitas
{
    public class Ingredientes_Receita
    {
        private Ingrediente _ingrediente;
        private UnidadeMedida _unidade;
        private Receita _receita;
        private int _quantidade;

        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        public Ingrediente Ingrediente { get => _ingrediente; set => _ingrediente = value; }
        public UnidadeMedida Unidade { get => _unidade; set => _unidade = value; }
        public Receita Receita { get => _receita; set => _receita = value; }

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
                        Ingrediente = new Ingrediente(drIngReceita.GetInt32(0));
                        Quantidade = drIngReceita.GetInt32(1);
                        Unidade = new UnidadeMedida(drIngReceita.GetInt32(2));
                        Receita = new Receita(drIngReceita.GetInt32(3));
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

        public bool Adicionar(int ingredienteId, int unidadeId, int quantidade, int receitaId)
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
            catch (Exception )
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
            catch (Exception)
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
                        ingRec.Ingrediente = new Ingrediente(drIngReceita.GetInt32(0));
                        ingRec.Quantidade = drIngReceita.GetInt32(1);
                        ingRec.Unidade = new UnidadeMedida(drIngReceita.GetInt32(2));
                        ingRec.Receita = new Receita(drIngReceita.GetInt32(3));
                        listaIngReceitas.Add(ingRec);
                    }
                }
                return listaIngReceitas;
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

        public override string ToString()
        {
            return Quantidade + " " + Unidade.Medida + " " + Ingrediente.NomeIngrediente;
        }
    }
}
