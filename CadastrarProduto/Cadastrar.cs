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
    public partial class Cadastrar : Form
    {
        private ProdutosRepository repository = new ProdutosRepository();
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string disponibilidade = "";
            if (inputNome.Text == "" || inputMarca.Text == "" || inputDataDeValidade.Value == null || inputDescricao.Text == "")
            {
                MessageBox.Show("Desculpe mas todos os formulários devem ser preenchidos");
            }
            else if (inputDataDeValidade.Value < DateTime.Now)
            {
                MessageBox.Show("Data inválida");
            }
            else
            {
                if (inputQuantidade.Value == 0)
                {
                    disponibilidade = "Esgotado";
                }
                else
                {
                    disponibilidade = "Disponível";
                }
                repository.CadastrarProduto(inputNome.Text, decimal.Parse(inputPreco.Text), inputMarca.Text, disponibilidade, int.Parse(inputQuantidade.Value.ToString()), inputDataDeValidade.Value, inputDescricao.Text);
                MessageBox.Show("Produto cadastrado com sucesso");
            }
        }
    }
}
