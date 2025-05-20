using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Desafio_02
{
    internal class Connection
    {
        private string connectionString;

        public Connection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void SetProduto(Produto produto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO tb_produto (id, title, price, category) VALUES (@id, @title, @price, @category)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", produto.id);
                    cmd.Parameters.AddWithValue("@title", produto.title);
                    cmd.Parameters.AddWithValue("@price", produto.price);
                    cmd.Parameters.AddWithValue("@category", produto.category);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Erro: {ex.Message}");
                }
            }
        }

        public List<Produto> GetProdutos()
        {
            List<Produto> produtos = new List<Produto>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, title, price, category FROM tb_Produto";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            produtos.Add(new Produto
                            {
                                id = reader.GetInt32(0),
                                title = reader.GetString(1),
                                price = reader.GetDecimal(2), // <- CORRETO para DECIMAL
                                category = reader.GetString(3),
                            });
                        }
                    }
                    return produtos;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public List<Produto> FiltrarPorFaixaDePreco(decimal precoMin, decimal precoMax)
        {
            List<Produto> produtosFiltrados = new List<Produto>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, title, price, category FROM tb_Produto WHERE price BETWEEN @min AND @max";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@min", precoMin);
                        cmd.Parameters.AddWithValue("@max", precoMax);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                produtosFiltrados.Add(new Produto
                                {
                                    id = reader.GetInt32(0),
                                    title = reader.GetString(1),
                                    price = reader.GetDecimal(2),
                                    category = reader.GetString(3)
                                });
                            }
                        }
                    }

                    return produtosFiltrados;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao filtrar produtos por faixa de preço", ex);
                }
            }
        }



        public bool AdicionarProdutoAosFavoritos(int id, string title, decimal price, string category)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                IF NOT EXISTS (SELECT 1 FROM tb_Favoritos WHERE id = @id)
                BEGIN
                    INSERT INTO tb_Favoritos (id, title, price, category)
                    VALUES (@id, @title, @price, @category)
                END";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@category", category);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            return true;
                        else
                            return false;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao adicionar aos favoritos: " + ex.Message);
                }
            }

        }

        public List<Produto> GetFavoritos()
        {
            List<Produto> favoritos = new List<Produto>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, title, price, category FROM tb_Favoritos";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            favoritos.Add(new Produto
                            {
                                id = reader.GetInt32(0),
                                title = reader.GetString(1),
                                price = reader.GetDecimal(2),
                                category = reader.GetString(3)
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao listar favoritos: " + ex.Message);
                }
            }

            return favoritos;
        }
    }
}
