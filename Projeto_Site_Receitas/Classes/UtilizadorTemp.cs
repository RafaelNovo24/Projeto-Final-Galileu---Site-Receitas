using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto_Site_Receitas.Classes
{
    class UtilizadorTemp
    {
        private int _id;
        private string _nome;
        private string _apelido;
        private string _email;

        public int UtilizadorID { get => _id; set =>_id=value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Apelido { get => _apelido; set => _apelido = value; }
        public string Email { get => _email; set => _email = value; }

        public UtilizadorTemp()
        {
        }

        public UtilizadorTemp(int iD)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Utilizador_Listar_ID";
                cmd.Parameters.AddWithValue("@UtilizadorID", iD);

                sqlCon.Open();

                SqlDataReader drUtilizador = cmd.ExecuteReader();

                if (drUtilizador.HasRows)
                {
                    while (drUtilizador.Read())
                    {
                        UtilizadorID = drUtilizador.GetInt32(0);
                        Nome = drUtilizador.GetString(1);
                        Apelido = drUtilizador.GetString(2);
                        Email = drUtilizador.GetString(3);
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

        public static List<UtilizadorTemp> ListarUtilizadores()
        {
            List<UtilizadorTemp> listarUtilizadores = new List<UtilizadorTemp>();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Utilizadores_Listar";

                sqlCon.Open();

                SqlDataReader drUtilizador = cmd.ExecuteReader();

                if (drUtilizador.HasRows)
                {
                    while (drUtilizador.Read())
                    {
                        UtilizadorTemp utilizador = new UtilizadorTemp();
                        utilizador.UtilizadorID = drUtilizador.GetInt32(0);
                        utilizador.Nome = drUtilizador.GetString(1);
                        utilizador.Apelido = drUtilizador.GetString(2);
                        utilizador.Email = drUtilizador.GetString(3);
                        listarUtilizadores.Add(utilizador);
                    }
                }
                return listarUtilizadores;
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

