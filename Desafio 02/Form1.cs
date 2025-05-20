using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Net.Http;

namespace Desafio_02
{
    public partial class Form1 : Form
    {
        Connection conn;
        List<Produto> produtos =  new List<Produto>();
        public Form1()
        {
            InitializeComponent();
            Buscar();
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=db_Produtos;Integrated Security=True;";
            conn = new Connection(connectionString);
            produtos = conn.GetProdutos();

            // Garante que o DataGridView vai criar as colunas automaticamente
            dgvProdutos.AutoGenerateColumns = true;

            // Associa o evento Load do form
            this.Load += Form1_Load;

            // Associa o evento do botão Obter (garanta que o nome do botão está correto)
            btnObter.Click += btnObter_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

private async Task Buscar()
        {
            string url = "https://fakestoreapi.com/products";

            using (HttpClient cliente = new HttpClient())
            {
                try
                {
                    string json = await cliente.GetStringAsync(url);

                    produtos = JsonSerializer.Deserialize<List<Produto>>(json);

                    dgvProdutos.DataSource = null;
                    dgvProdutos.DataSource = produtos;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar produtos: " + ex.Message);
                }
            }
        }

        private List<Produto> FiltrarPorCategoria(string categoria)
        {
            var filtrarCategoria = produtos.Where(p => p.category == categoria).ToList();
            return filtrarCategoria;
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnObter_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnFiltrarPreco_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txFiltrarPreco.Text, out decimal precoMin) &&
                decimal.TryParse(txPreco2.Text, out decimal precoMax))
            {
                if (precoMin > precoMax)
                {
                    MessageBox.Show("O preço mínimo não pode ser maior que o preço máximo.");
                    return;
                }

                try
                {
                    var produtosFiltrados = conn.FiltrarPorFaixaDePreco(precoMin, precoMax);

                    dgvProdutos.DataSource = null;
                    dgvProdutos.DataSource = produtosFiltrados;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao filtrar produtos: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Digite valores válidos para os preços mínimo e máximo.");
            }
        }

        private void btnFiltrarCategoria_Click(object sender, EventArgs e)
        {
            string categoria = txFiltrarCategoria.Text;
            List<Produto> filtrados = FiltrarPorCategoria(categoria);
            dgvProdutos.DataSource = filtrados;

        }

        private void btnAdicionarFavorito_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProdutos.SelectedRows[0];

                int id = Convert.ToInt32(row.Cells["id"].Value);
                string title = row.Cells["title"].Value.ToString();
                decimal price = Convert.ToDecimal(row.Cells["price"].Value);
                string category = row.Cells["category"].Value.ToString();

                conn.AdicionarProdutoAosFavoritos(id, title, price, category);
            }
            else
            {
                MessageBox.Show("Selecione um produto para adicionar aos favoritos.");
            }
        }

        private void btnListarFavoritos_Click(object sender, EventArgs e)
        {
            var favoritos = conn.GetFavoritos();

            // Limpa o DataGridView e define a nova fonte de dados
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = favoritos;
        }

        private void dgvProdutos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnObter_Click_1(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
