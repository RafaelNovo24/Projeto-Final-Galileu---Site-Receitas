using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Web;

namespace DAL_Receitas
{
    public class Receita
    {
        private int _id;
        private string _nome;
        private Dificuldade _dificuldade;
        private Categorias _categoria;
        private List<Ingredientes_Receita> _listaIngredientes;
        private Duracao _duracao;
        private string _preparacao;
        private string _user;
        private bool _validacao = false;
        private Porcao _porcao;
        private DateTime _dataCriacao;
        private List<Rating> _listaVotos;
        private List<Comentario> _listaComentarios;
        private double _mediaVotos;


        public int IdReceita { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public Categorias Categoria { get => _categoria; set => _categoria = value; }
        public string Preparacao { get => _preparacao; set => _preparacao = value; }
        public DateTime DataCriacao { get => _dataCriacao; set => _dataCriacao = value; }
        public bool Validacao { get => _validacao; set => _validacao = value; }
        public List<Ingredientes_Receita> ListaIngredientes { get => _listaIngredientes; set => _listaIngredientes = value; }
        public Dificuldade Dificuldade { get => _dificuldade; set => _dificuldade = value; }
        public Duracao Duracao { get => _duracao; set => _duracao = value; }
        public Porcao Porcao { get => _porcao; set => _porcao = value; }
        internal List<Rating> ListaVotos { get => _listaVotos; set => _listaVotos = value; }
        public List<Comentario> ListaComentarios { get => _listaComentarios; set => _listaComentarios = value; }
        public string User { get => _user; set => _user = value; }
        public double MediaVotos { get => _mediaVotos; set => _mediaVotos = value; }

        public Receita()
        {
            _listaIngredientes = new List<Ingredientes_Receita>();
            _listaComentarios = new List<Comentario>();
        }

        public Receita(int idReceita)
        {
            _listaIngredientes = new List<Ingredientes_Receita>();
            _listaVotos = new List<Rating>();
            _listaComentarios = new List<Comentario>();

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
                        Dificuldade = new Dificuldade(drReceita.GetInt32(2));
                        Categoria = new Categorias(drReceita.GetInt32(3));
                        Duracao = new Duracao(drReceita.GetInt32(4));
                        Preparacao = drReceita.GetString(5);
                        User = drReceita.GetString(6);
                        Validacao = drReceita.GetBoolean(7);
                        Porcao = new Porcao(drReceita.GetInt32(8));
                        DataCriacao = drReceita.GetDateTime(9);
                    }
                }
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Ingredientes_Listar_Receita";
                cmd.Parameters.AddWithValue("@ReceitaID", idReceita);

                if (drReceita.HasRows)
                {
                    while (drReceita.Read())
                    {
                        Ingredientes_Receita ingRec = new Ingredientes_Receita();
                        ingRec.Ingrediente = new Ingrediente(drReceita.GetInt32(0));
                        ingRec.Quantidade = drReceita.GetInt32(1);
                        ingRec.Unidade = new UnidadeMedida(drReceita.GetInt32(2));
                        ingRec.Receita = new Receita(drReceita.GetInt32(3));
                        ListaIngredientes.Add(ingRec);
                    }
                }

                Rating rating = new Rating(idReceita);
                MediaVotos = rating.Media;

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Comentarios_Listar_Receita";
                cmd.Parameters.AddWithValue("ReceitaID", idReceita);

                if (drReceita.HasRows)
                {
                    while (drReceita.Read())
                    {
                        Comentario comentario = new Comentario();
                        comentario.ID = drReceita.GetInt32(0);
                        comentario.Texto = drReceita.GetString(1);
                        comentario.Receita = new Receita(drReceita.GetInt32(2));
                        comentario.User = drReceita.GetString(3);
                        ListaComentarios.Add(comentario);
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

        public bool InserirIngredientesUltimaReceitaCriada()
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;

            sqlCon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            SqlTransaction transaction;

            transaction = sqlCon.BeginTransaction("Transação");
            cmd.Transaction = transaction;
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Receita_Buscar_ID";
                int novoID = (int)cmd.ExecuteScalar();

                foreach (Ingredientes_Receita ing in _listaIngredientes)
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "Ingredientes_Definir_Ingredientes_Receitas";
                    cmd.Parameters.AddWithValue("@IngredienteID", ing.Ingrediente.IdIngrediente);
                    cmd.Parameters.AddWithValue("@UnidadeID", ing.Unidade.ID);
                    cmd.Parameters.AddWithValue("@Quantidade", ing.Quantidade);
                    cmd.Parameters.AddWithValue("@ReceitaID", novoID);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                transaction.Rollback();
                return false;
            }
            finally
            {
                sqlCon.Close();
            }

        }

        public bool InserirIngredientesUltimaReceitaAprovada()
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;

            sqlCon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            SqlTransaction transaction;

            transaction = sqlCon.BeginTransaction("Transação");
            cmd.Transaction = transaction;
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Receita_Buscar_ID_Ultima_Aprovada";
                int novoID = (int)cmd.ExecuteScalar();

                foreach (Ingredientes_Receita ing in _listaIngredientes)
                {
                    cmd.CommandText = "Ingredientes_Definir_Ingredientes_Receitas";
                    cmd.Parameters.AddWithValue("@IngredienteID", ing.Ingrediente.IdIngrediente);
                    cmd.Parameters.AddWithValue("@UnidadeID", ing.Unidade.ID);
                    cmd.Parameters.AddWithValue("@Quantidade", ing.Quantidade);
                    cmd.Parameters.AddWithValue("@ReceitaID", novoID);
                    cmd.ExecuteNonQuery();
                }


                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
            }
            finally
            {
                sqlCon.Close();
            }
            return true;
        }

        public bool AdicionarReceita(string nome, int dificuldadeid, int categoriaID, int duracaoID, string preparacao, int porcaoID, string userID)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;

            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Receita_Inserir";
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@DificuldadeID", dificuldadeid);
                cmd.Parameters.AddWithValue("@CategoriaID", categoriaID);
                cmd.Parameters.AddWithValue("@DuracaoID", duracaoID);
                cmd.Parameters.AddWithValue("@Preparacao", preparacao);
                cmd.Parameters.AddWithValue("@UtilizadorID", userID);
                cmd.Parameters.AddWithValue("@PorcaoID", porcaoID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                sqlCon.Close();
            }
            return true;
        }

        public bool AdicionarIngrediente(Ingredientes_Receita novoIngrediente)
        {
            try
            {
                ListaIngredientes.Add(novoIngrediente);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public bool RemoverIngrediente(Ingredientes_Receita Ingrediente)
        {
            try
            {
                ListaIngredientes.Remove(Ingrediente);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

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
            catch (Exception)
            {
                return false;
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
                        receita.Dificuldade = new Dificuldade(drReceita.GetInt32(2));
                        receita.Categoria = new Categorias(drReceita.GetInt32(3));
                        receita.Duracao = new Duracao(drReceita.GetInt32(4));
                        receita.Preparacao = drReceita.GetString(5);
                        receita.User = drReceita.GetString(6);
                        receita.Validacao = drReceita.GetBoolean(7);
                        receita.Porcao = new Porcao(drReceita.GetInt32(8));
                        receita.DataCriacao = drReceita.GetDateTime(9);
                        listaReceitas.Add(receita);
                    }
                }
                return listaReceitas;
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
                        receita.Dificuldade = new Dificuldade(drReceita.GetInt32(2));
                        receita.Categoria = new Categorias(drReceita.GetInt32(3));
                        receita.Duracao = new Duracao(drReceita.GetInt32(4));
                        receita.Preparacao = drReceita.GetString(5);
                        receita.User = drReceita.GetString(6);
                        receita.Validacao = drReceita.GetBoolean(7);
                        receita.Porcao = new Porcao(drReceita.GetInt32(8));
                        receita.DataCriacao = drReceita.GetDateTime(9);
                        listaReceitasAprovadas.Add(receita);
                    }
                }
                return listaReceitasAprovadas;
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
                        receita.Dificuldade = new Dificuldade(drReceita.GetInt32(2));
                        receita.Categoria = new Categorias(drReceita.GetInt32(3));
                        receita.Duracao = new Duracao(drReceita.GetInt32(4));
                        receita.Preparacao = drReceita.GetString(5);
                        receita.User = drReceita.GetString(6);
                        receita.Validacao = drReceita.GetBoolean(7);
                        receita.Porcao = new Porcao(drReceita.GetInt32(8));
                        receita.DataCriacao = drReceita.GetDateTime(9);
                        listaReceitasPendentes.Add(receita);
                    }
                }
                return listaReceitasPendentes;
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

        public static List<Receita> ReceitasPorCategoria(int idCategoria)
        {
            List<Receita> listaReceitasAprovadas = new List<Receita>();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Receita_Listar_Categoria";
                cmd.Parameters.AddWithValue("@CategoriaID", idCategoria);

                sqlCon.Open();

                SqlDataReader drReceita = cmd.ExecuteReader();

                if (drReceita.HasRows)
                {
                    while (drReceita.Read())
                    {
                        Receita receita = new Receita();
                        receita.IdReceita = drReceita.GetInt32(0);
                        receita.Nome = drReceita.GetString(1);
                        receita.Dificuldade = new Dificuldade(drReceita.GetInt32(2));
                        receita.Categoria = new Categorias(drReceita.GetInt32(3));
                        receita.Duracao = new Duracao(drReceita.GetInt32(4));
                        receita.Preparacao = drReceita.GetString(5);
                        receita.User = drReceita.GetString(6);
                        receita.Validacao = drReceita.GetBoolean(7);
                        receita.Porcao = new Porcao(drReceita.GetInt32(8));
                        receita.DataCriacao = drReceita.GetDateTime(9);
                        listaReceitasAprovadas.Add(receita);
                    }
                }
                return listaReceitasAprovadas;
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

        public static List<Receita> Novidades()
        {
            List<Receita> listaReceitas = new List<Receita>();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Receita_Listar_Novidades";

                sqlCon.Open();

                SqlDataReader drReceita = cmd.ExecuteReader();

                if (drReceita.HasRows)
                {
                    while (drReceita.Read())
                    {
                        Receita receita = new Receita();
                        receita.IdReceita = drReceita.GetInt32(0);
                        receita.Nome = drReceita.GetString(1);
                        receita.Dificuldade = new Dificuldade(drReceita.GetInt32(2));
                        receita.Categoria = new Categorias(drReceita.GetInt32(3));
                        receita.Duracao = new Duracao(drReceita.GetInt32(4));
                        receita.Preparacao = drReceita.GetString(5);
                        receita.User = drReceita.GetString(6);
                        receita.Validacao = drReceita.GetBoolean(7);
                        receita.Porcao = new Porcao(drReceita.GetInt32(8));
                        receita.DataCriacao = drReceita.GetDateTime(9);
                        listaReceitas.Add(receita);
                    }
                }
                return listaReceitas;
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

        public static List<Receita> ListarPorUser(string userID)
        {
            List<Receita> listaReceitas = new List<Receita>();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Receita_Listar_Por_User";
                cmd.Parameters.AddWithValue("@UserID", userID);

                sqlCon.Open();

                SqlDataReader drReceita = cmd.ExecuteReader();

                if (drReceita.HasRows)
                {
                    while (drReceita.Read())
                    {
                        Receita receita = new Receita();
                        receita.IdReceita = drReceita.GetInt32(0);
                        receita.Nome = drReceita.GetString(1);
                        listaReceitas.Add(receita);
                    }
                }
                return listaReceitas;
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

        public static List<Receita> Pesquisa(string pesquisa, int? duracaoID, int? dificuldadeID)
        {
            List<Receita> listaReceitas = new List<Receita>();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Receita_Procurar_Nome";
                cmd.Parameters.AddWithValue("@Procura", pesquisa ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DificuldadeID", (object)dificuldadeID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DuracaoID", (object)duracaoID ?? DBNull.Value);

                sqlCon.Open();

                SqlDataReader drReceita = cmd.ExecuteReader();

                if (drReceita.HasRows)
                {
                    while (drReceita.Read())
                    {
                        Receita receita = new Receita();
                        receita.IdReceita = drReceita.GetInt32(0);
                        receita.Nome = drReceita.GetString(1);
                        listaReceitas.Add(receita);
                    }
                }
                return listaReceitas;
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
