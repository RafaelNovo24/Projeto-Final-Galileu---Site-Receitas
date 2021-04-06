using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto_Site_Receitas.Classes
{
    class Ingrediente
    {
        private int _idIngrediente;
        private string _nomeIngrediente;

        public int IdIngrediente { get => _idIngrediente; set => _idIngrediente = value; }
        public string NomeIngrediente { get => _nomeIngrediente; set => _nomeIngrediente = value; }

        public Ingrediente()
        {

        }

        public Ingrediente(int idIngrediente)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Ingredientes_ID";
                cmd.Parameters.AddWithValue("@ID", idIngrediente);

                sqlCon.Open();

                SqlDataReader drIngrediente = cmd.ExecuteReader();

                if (drIngrediente.HasRows)
                {
                    while (drIngrediente.Read())
                    {
                        IdIngrediente = drIngrediente.GetInt32(0);
                        NomeIngrediente = drIngrediente.GetString(1);
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

        public Ingrediente(int idIngrediente, string nomeIngrediente)
        {
            IdIngrediente = idIngrediente;
            NomeIngrediente = nomeIngrediente;
        }

        public Ingrediente(string nomeIngrediente)
        {
            NomeIngrediente = nomeIngrediente;
        }

        public bool Inserir(string nome)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Ingredientes_Adicionar";
                cmd.Parameters.AddWithValue("@Nome", nome);

                sqlCon.Open();
                cmd.ExecuteNonQuery();
                return true;
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
        public bool Remover(int idIngrediente)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Ingredientes_Eliminar";
                cmd.Parameters.AddWithValue("@IngredienteID", idIngrediente);

                sqlCon.Open();
                cmd.ExecuteNonQuery();
                return true;
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

        public bool Atualizar()
        {
            return true;
        }
        public static List<Ingrediente> TodosIngredientes()
        {
            List<Ingrediente> listaIngredientes = new List<Ingrediente>();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Ingredientes_Listar";

                sqlCon.Open();

                SqlDataReader drIngrediente = cmd.ExecuteReader();

                if (drIngrediente.HasRows)
                {
                    while (drIngrediente.Read())
                    {
                        Ingrediente ing = new Ingrediente();
                        ing.IdIngrediente = drIngrediente.GetInt32(0);
                        ing.NomeIngrediente = drIngrediente.GetString(1);
                        listaIngredientes.Add(ing);
                    }
                }
                return listaIngredientes;
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


    
