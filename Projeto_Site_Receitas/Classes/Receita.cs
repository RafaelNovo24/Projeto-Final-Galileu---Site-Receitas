using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto_Site_Receitas.Classes
{
    class Receita
    {
        private int _id;
        private string _nome;
        private int _dificuldadeId;
        private int _categoriaId;
        private int _duracaoId;
        private string _preparacao;
        private int _utilizadorId;
        private bool _validacao = false;
        private int _porcaoId;
        private DateTime _dataCriacao;


        public int IdReceita { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public int DificuldadeID { get => _dificuldadeId; set => _dificuldadeId = value; }
        public int CategoriaID { get => _categoriaId; set => _categoriaId = value; }
        public int DuracaoID { get => _duracaoId; set => _duracaoId = value; }
        public string Preparacao { get => _preparacao; set => _preparacao = value; }
        public int UtilizadorID { get => _utilizadorId; set => _utilizadorId = value; }
        public int PorcaoID { get => _porcaoId; set => _porcaoId = value; }
        public DateTime DataCriacao { get => _dataCriacao; set => _dataCriacao = value; }

        public bool Validacao { get => _validacao; set => _validacao = value; }

        public Receita() { }

        public Receita(int idReceita)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Receita_ID";
                cmd.Parameters.AddWithValue("@ReceitaID", idReceita);

                sqlCon.Open();

                SqlDataReader drReceita = cmd.ExecuteReader();

                if (drReceita.HasRows)
                {
                    while (drReceita.Read())
                    {
                        IdReceita = drReceita.GetInt32(0);
                        Nome = drReceita.GetString(1);
                        DificuldadeID = drReceita.GetInt32(2);
                        CategoriaID = drReceita.GetInt32(3);
                        DuracaoID = drReceita.GetInt32(5);
                        Preparacao = drReceita.GetString(6);
                        UtilizadorID = drReceita.GetInt32(7);
                        Validacao = drReceita.GetBoolean(8);
                        PorcaoID = drReceita.GetInt32(9);
                        DataCriacao = drReceita.GetDateTime(10);
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

        public bool Inserir()
        {
            return true;
        }

        public bool Eliminar(int idReceita)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Receita_Eliminar";
                cmd.Parameters.AddWithValue("@ReceitaID", idReceita);

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

        public bool Atualizar(int idReceita, string nome, int dificuldadeid, int categoriaID, int duracaoID, string preparacao, int porcaoID)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Receita_Atualizar";
                cmd.Parameters.AddWithValue("@ReceitaID", idReceita);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@DificuldadeID", dificuldadeid);
                cmd.Parameters.AddWithValue("@CategoriaID", categoriaID);
                cmd.Parameters.AddWithValue("@DuracaoID", duracaoID);
                cmd.Parameters.AddWithValue("@Preparacao", preparacao);
                cmd.Parameters.AddWithValue("@PorcaoID", porcaoID);

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


        public bool Aprovar(int idReceita, string nome, int dificuldadeid, int categoriaID, int duracaoID, string preparacao, int porcaoID)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Receita_Aprovar";
                cmd.Parameters.AddWithValue("@ReceitaID", idReceita);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@DificuldadeID", dificuldadeid);
                cmd.Parameters.AddWithValue("@CategoriaID", categoriaID);
                cmd.Parameters.AddWithValue("@DuracaoID", duracaoID);
                cmd.Parameters.AddWithValue("@Preparacao", preparacao);
                cmd.Parameters.AddWithValue("@PorcaoID", porcaoID);

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


        public static List<Receita> TodasReceitas()
        {
            List<Receita> listaReceitas = new List<Receita>();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Receita_Listar";

                sqlCon.Open();

                SqlDataReader drReceita = cmd.ExecuteReader();

                if (drReceita.HasRows)
                {
                    while (drReceita.Read())
                    {
                        Receita receita = new Receita();
                        receita.IdReceita = drReceita.GetInt32(0);
                        receita.Nome = drReceita.GetString(1);
                        receita.DificuldadeID = drReceita.GetInt32(2);
                        receita.CategoriaID = drReceita.GetInt32(3);
                        receita.DuracaoID = drReceita.GetInt32(5);
                        receita.Preparacao = drReceita.GetString(6);
                        receita.UtilizadorID = drReceita.GetInt32(7);
                        receita.Validacao = drReceita.GetBoolean(8);
                        receita.PorcaoID = drReceita.GetInt32(9);
                        receita.DataCriacao = drReceita.GetDateTime(10);
                        listaReceitas.Add(receita);
                    }
                }
                return listaReceitas;
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

        public static List<Receita> ReceitasAprovadas()
        {
            List<Receita> listaReceitasAprovadas = new List<Receita>();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Receitas_Listar_Aprovadas";

                sqlCon.Open();

                SqlDataReader drReceita = cmd.ExecuteReader();

                if (drReceita.HasRows)
                {
                    while (drReceita.Read())
                    {
                        Receita receita = new Receita();
                        receita.IdReceita = drReceita.GetInt32(0);
                        receita.Nome = drReceita.GetString(1);
                        receita.DificuldadeID = drReceita.GetInt32(2);
                        receita.CategoriaID = drReceita.GetInt32(3);
                        receita.DuracaoID = drReceita.GetInt32(5);
                        receita.Preparacao = drReceita.GetString(6);
                        receita.UtilizadorID = drReceita.GetInt32(7);
                        receita.Validacao = drReceita.GetBoolean(8);
                        receita.PorcaoID = drReceita.GetInt32(9);
                        receita.DataCriacao = drReceita.GetDateTime(10);
                        listaReceitasAprovadas.Add(receita);
                    }
                }
                return listaReceitasAprovadas;
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

        public static List<Receita> ReceitasPendentes()
        {
            List<Receita> listaReceitasPendentes = new List<Receita>();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Receitas_Listar_Pendentes";

                sqlCon.Open();

                SqlDataReader drReceita = cmd.ExecuteReader();

                if (drReceita.HasRows)
                {
                    while (drReceita.Read())
                    {
                        Receita receita = new Receita();
                        receita.IdReceita = drReceita.GetInt32(0);
                        receita.Nome = drReceita.GetString(1);
                        receita.DificuldadeID = drReceita.GetInt32(2);
                        receita.CategoriaID = drReceita.GetInt32(3);
                        receita.DuracaoID = drReceita.GetInt32(5);
                        receita.Preparacao = drReceita.GetString(6);
                        receita.UtilizadorID = drReceita.GetInt32(7);
                        receita.Validacao = drReceita.GetBoolean(8);
                        receita.PorcaoID = drReceita.GetInt32(9);
                        receita.DataCriacao = drReceita.GetDateTime(10);
                        listaReceitasPendentes.Add(receita);
                    }
                }
                return listaReceitasPendentes;
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

