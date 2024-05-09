using System;
using System.Data;
using System.Data.SqlClient;

namespace CadastrarProduto.Repositorios
{
    internal class ProdutosRepository
    {
        const string connectionString = @"Data Source=DESKTOP-14Q5HH4\SQLEXPRESS; Initial Catalog=PROJETO_WINDOWS_FORM; Integrated Security=True;";

        SqlConnection conn = new SqlConnection(connectionString);

        public void CadastrarProduto(string nome, decimal preco, string marca, string disponibilidade, int quantidade, DateTime dataDeValidade, string descricao)
        {
            conn.Open();

            string sqlInsert = "INSERT INTO PRODUTOS(NOME, PRECO, MARCA, DISPONIBILIDADE, QUANTIDADE, DATA_DE_VALIDADE, DESCRICAO) VALUES (@nome, @preco, @marca, @disponibilidade, @quantidade, @dataDeValidade, @descricao)";
            SqlCommand cmd = new SqlCommand(sqlInsert, conn);

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@preco", preco);
            cmd.Parameters.AddWithValue("@marca", marca);
            cmd.Parameters.AddWithValue("@disponibilidade", disponibilidade);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@dataDeValidade", dataDeValidade);
            cmd.Parameters.AddWithValue("@descricao", descricao);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public DataTable BuscarProdutos(string nome, DateTime dataInicial, DateTime dataFinal)
        {
            DataTable dataTable = new DataTable();
            string sqlQuery = "SELECT * FROM PRODUTOS WHERE (NOME LIKE @nome OR NOME = null) AND DATA_DE_VALIDADE BETWEEN @dataInicial AND @dataFinal";

            using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
            {
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
                cmd.Parameters.AddWithValue("@dataInicial", dataInicial);
                cmd.Parameters.AddWithValue("@dataFinal", dataFinal);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    conn.Open();

                    adapter.Fill(dataTable);
                }
            }

            conn.Close();

            return dataTable;
        }

        public void UpdateProduto(int id, string nome, decimal preco, string marca, string disponibilidade, int quantidade, DateTime dataDeValidade, string descricao)
        {
            conn.Open();

            string sqlUpdate = $"UPDATE PRODUTOS SET NOME = @nome, PRECO = @preco, MARCA = @marca, DISPONIBILIDADE = @disponibilidade, QUANTIDADE = @quantidade, DATA_DE_VALIDADE = @dataDeValidade, DESCRICAO = @descricao WHERE ID = {id}";
            SqlCommand cmd = new SqlCommand(sqlUpdate, conn);

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@preco", preco);
            cmd.Parameters.AddWithValue("@marca", marca);
            cmd.Parameters.AddWithValue("@disponibilidade", disponibilidade);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@dataDeValidade", dataDeValidade);
            cmd.Parameters.AddWithValue("@descricao", descricao);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void DeletarProduto(int id)
        {
            conn.Open();

            string sqlDelete = $"DELETE FROM PRODUTOS WHERE ID = {id}";
            SqlCommand cmd = new SqlCommand(sqlDelete, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
