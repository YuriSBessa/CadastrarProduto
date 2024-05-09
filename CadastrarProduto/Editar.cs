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
    public partial class Editar : Form
    {
        private ProdutosRepository repository = new ProdutosRepository();
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Marca { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataDeValidade { get; set; }
        public string Descricao { get; set; }

        public Editar(int id, string nome, decimal preco, string marca, int quantidade, DateTime dataDeValidade, string descricao)
        {
            this.Id = id;
            this.Nome = nome;
            this.Preco = preco;
            this.Marca = marca;
            this.Quantidade = quantidade;
            this.DataDeValidade = dataDeValidade;
            this.Descricao = descricao;

            InitializeComponent();

            if (Id != 0 && Nome != null && Preco != 0 && Marca != null && DataDeValidade != null && Descricao != null)
            {
                inputId.Value += this.Id;
                inputNome.Text = this.Nome;
                inputPreco.Text = this.Preco.ToString();
                inputMarca.Text = this.Marca;
                inputQuantidade.Value = this.Quantidade;
                inputDataDeValidade.Value = this.DataDeValidade;
                inputDescricao.Text = this.Descricao;
            }
        }
        public Editar()
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
            else if (int.Parse(inputId.Value.ToString()) == 0)
            {
                MessageBox.Show("Você esqueceu de mencionar o id");
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
                repository.UpdateProduto(int.Parse(inputId.Value.ToString()) ,inputNome.Text, decimal.Parse(inputPreco.Text), inputMarca.Text, disponibilidade, int.Parse(inputQuantidade.Value.ToString()), inputDataDeValidade.Value, inputDescricao.Text);
                MessageBox.Show("Produto editado com sucesso");
            }
        }
    }
}
