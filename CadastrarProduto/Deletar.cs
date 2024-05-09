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
    public partial class Deletar : Form
    {
        private ProdutosRepository repository = new ProdutosRepository();
        public Deletar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputId.Value == 0)
            {
                MessageBox.Show("Desculpe, mas você deve mencionar o id");
            }
            else
            {
                repository.DeletarProduto(int.Parse(inputId.Value.ToString()));
                MessageBox.Show("Produto deletado com sucesso");
            }
        }
    }
}
