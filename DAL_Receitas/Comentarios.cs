using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_Receitas
{
    public class Comentarios
    {
        private int _id;
        private int _idUtilizador;
        private string _texto;
        private int _receitaId;
        private string _receitaNome;
        private string _utilizadorNome;

        public int ID { get => _id; set => _id = value; }
        public int IdUtilizador { get => _idUtilizador; set => _idUtilizador = value; }
        public string Texto { get => _texto; set => _texto = value; }
        public int ReceitaID { get => _receitaId; set => _receitaId = value; }
        public string ReceitaNome { get => _receitaNome; set => _receitaNome = value; }
        public string UtilizadorNome { get => _utilizadorNome; set => _utilizadorNome = value; }

        public Comentarios()
        {

        }

        public Comentarios(int iD)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Comentarios_Listar_ID";
                cmd.Parameters.AddWithValue("@ComentarioID", iD);

                sqlCon.Open();

                SqlDataReader drComentario = cmd.ExecuteReader();

                if (drComentario.HasRows)
                {
                    while (drComentario.Read())
                    {
                        ID = drComentario.GetInt32(0);
                        Texto = drComentario.GetString(1);
                        ReceitaNome = drComentario.GetString(2);
                        UtilizadorNome = drComentario.GetString(3);
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

        public bool Inserir(int utilizadorId, string comentario, int receitaId)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Ingredientes_Adicionar";
                cmd.Parameters.AddWithValue("@UtilizadorID", utilizadorId);
                cmd.Parameters.AddWithValue("@ComentarioTexto", comentario);
                cmd.Parameters.AddWithValue("@ReceitaID", receitaId);

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

        public bool Eliminar(int comentario)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Comentarios_Eliminar";
                cmd.Parameters.AddWithValue("@ComentarioID", comentario);


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

        public static List<Comentarios> ComentariosPorRceita(int receitaId)
        {
            List<Comentarios> listaComentarios = new List<Comentarios>();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Comentarios_Listar_Receita";
                cmd.Parameters.AddWithValue("ReceitaID", receitaId);

                sqlCon.Open();

                SqlDataReader drComentario = cmd.ExecuteReader();

                if (drComentario.HasRows)
                {
                    while (drComentario.Read())
                    {
                        Comentarios comentario = new Comentarios();
                        comentario.ID = drComentario.GetInt32(0);
                        comentario.Texto = drComentario.GetString(1);
                        comentario.ReceitaNome = drComentario.GetString(2);
                        comentario.UtilizadorNome = drComentario.GetString(3);
                        listaComentarios.Add(comentario);
                    }
                }
                return listaComentarios;
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

        public static List<Comentarios> ComentariosPorUtilizador(int utilizadorId)
        {
            List<Comentarios> listaComentarios = new List<Comentarios>();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Comentarios_Listar_Utilizador";
                cmd.Parameters.AddWithValue("UtilizadorID", utilizadorId);

                sqlCon.Open();

                SqlDataReader drComentario = cmd.ExecuteReader();

                if (drComentario.HasRows)
                {
                    while (drComentario.Read())
                    {
                        Comentarios comentario = new Comentarios();
                        comentario.IdUtilizador = drComentario.GetInt32(0);
                        comentario.Texto = drComentario.GetString(2);
                        listaComentarios.Add(comentario);
                    }
                }
                return listaComentarios;
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
