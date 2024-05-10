using CadastrarProduto.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastrarProduto
{
    public partial class Principal : Form
    {
        private ProdutosRepository repository = new ProdutosRepository();
        private string userName { get; set; }
        public Principal(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            usuarioCadastrado.Text = $"Usuario cadastrado: {this.userName}";
        }

        private void cadastar_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar();
            cadastrar.Show();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                Editar editar = new Editar(int.Parse(row.Cells["ID"].Value.ToString()), row.Cells["NOME"].Value.ToString(), decimal.Parse(row.Cells["PRECO"].Value.ToString()), row.Cells["MARCA"].Value.ToString(), int.Parse(row.Cells["QUANTIDADE"].Value.ToString()), DateTime.Parse(row.Cells["DATA_DE_VALIDADE"].Value.ToString()), row.Cells["DESCRICAO"].Value.ToString());
                editar.Show();
            }
            else
            {
                Editar editar = new Editar();
                editar.Show();
            }
        }

        private void deletar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                var result = MessageBox.Show("Você deseja deletar esse produto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    repository.DeletarProduto(int.Parse(row.Cells["ID"].Value.ToString()));
                }
            }

            else
            {
                Deletar deletar = new Deletar();
                deletar.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = repository.BuscarProdutos(inputNome.Text, inputDataInicial.Value, inputDataFinal.Value);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Refresh();
        }
    }
}
