using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_Receitas
{
    public class Categorias
    {
        private int _categoriaId;
        private string _nome;

        public int CategoriaID { get => _categoriaId; set => _categoriaId = value; }
        public string Nome { get => _nome; set => _nome = value; }

        public Categorias()
        {
        }

        public Categorias(int categoriaID)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Categorias_ID";
                cmd.Parameters.AddWithValue("@CategoriaID", categoriaID);

                sqlCon.Open();

                SqlDataReader drCategoria = cmd.ExecuteReader();

                if (drCategoria.HasRows)
                {
                    while (drCategoria.Read())
                    {
                        CategoriaID = drCategoria.GetInt32(0);
                        Nome = drCategoria.GetString(1);
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

        public static List<Categorias> TodasCategorias()
        {
            List<Categorias> listarCategorias = new List<Categorias>();

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Properties.Settings.Default.cnDBProjeto;

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlCon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Categorias_Listar";

                sqlCon.Open();

                SqlDataReader drCategoria = cmd.ExecuteReader();

                if (drCategoria.HasRows)
                {
                    while (drCategoria.Read())
                    {
                        Categorias categorias = new Categorias();
                        categorias.CategoriaID = drCategoria.GetInt32(0);
                        categorias.Nome = drCategoria.GetString(1);
                        listarCategorias.Add(categorias);
                    }
                }
                return listarCategorias;
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
