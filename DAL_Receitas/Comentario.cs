using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_Receitas
{
    public class Comentario
    {
        private int _id;
        private string _user;
        private string _texto;
        private Receita _receita;

        public int ID { get => _id; set => _id = value; }
        public string Texto { get => _texto; set => _texto = value; }
        public Receita Receita { get => _receita; set => _receita = value; }
        public string User { get => _user; set => _user = value; }

        public Comentario()
        {

        }

        public Comentario(int iD)
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
                        Receita = new Receita(drComentario.GetInt32(2));
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

        public bool Inserir(string utilizadorId, string comentario, int receitaId)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Comentarios_Inserir";
                cmd.Parameters.AddWithValue("@UtilizadorID", utilizadorId);
                cmd.Parameters.AddWithValue("@ComentarioTexto", comentario);
                cmd.Parameters.AddWithValue("@ReceitaID", receitaId);

                sqlCon.Open();
                cmd.ExecuteNonQuery();
                return true;
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
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlCon.Close();
            }
        }

        public static List<Comentario> ComentariosPorRceita(int receitaId)
        {
            List<Comentario> listaComentarios = new List<Comentario>();

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
                        Comentario comentario = new Comentario();
                        comentario.ID = drComentario.GetInt32(0);
                        comentario.Texto = drComentario.GetString(1);
                        comentario.Receita = new Receita(drComentario.GetInt32(2));
                        comentario.User = drComentario.GetString(3);
                        listaComentarios.Add(comentario);
                    }
                }
                return listaComentarios;
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
