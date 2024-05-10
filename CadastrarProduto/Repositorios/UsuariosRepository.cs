using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrarProduto.Repositorios
{
    internal class UsuariosRepository
    {
        const string connectionString = @"Data Source=DESKTOP-14Q5HH4\SQLEXPRESS; Initial Catalog=PROJETO_WINDOWS_FORM; Integrated Security=True;";

        SqlConnection conn = new SqlConnection(connectionString);

        public void CadastrarUsuarios(string nome, string senha)
        {
            conn.Open();

            string sqlInsert = "INSERT INTO USUARIOS (NOME, SENHA) VALUES (@nome, @senha)";
            SqlCommand cmd = new SqlCommand(sqlInsert, conn);

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public string BuscarNome(string nome)
        {
            conn.Open();
            string sqlSelect = "SELECT NOME FROM USUARIOS WHERE NOME = @nome";

            SqlCommand cmd = new SqlCommand(sqlSelect, conn);

            cmd.Parameters.AddWithValue("@nome", nome);

            string valor = (string)cmd.ExecuteScalar();

            conn.Close();

            return valor;
        }

        public string BuscarSenha(string senha)
        {
            conn.Open();
            string sqlSelect = "SELECT senha FROM USUARIOS WHERE SENHA = @senha";

            SqlCommand cmd = new SqlCommand(sqlSelect, conn);

            cmd.Parameters.AddWithValue("@senha", senha);

            string valor = (string)cmd.ExecuteScalar();

            conn.Close();

            return valor;
        }
    }
}
