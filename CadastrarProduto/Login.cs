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
    public partial class Login : Form
    {
        private UsuariosRepository usuariosRepository = new UsuariosRepository();
        public Login()
        {
            InitializeComponent();
        }

        private void criarConta_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastroUsuario = new CadastroUsuario();
            cadastroUsuario.Show();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            string nome = usuariosRepository.BuscarNome(inputNome.Text);
            string senha = usuariosRepository.BuscarSenha(inputSenha.Text);

            if (inputNome.Text == "" || inputNome.Text == "")
            {
                MessageBox.Show("Todos os Formulários devem ser preenchidos");
            }
            else
            {
                if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(senha))
                {
                    MessageBox.Show("Nome ou senha devem estar incorretos");
                }
                else
                {
                    MessageBox.Show("Login realizado com sucesso!");

                    Principal principal = new Principal(inputNome.Text);
                    principal.Show();
                }
            }
        }
    }
}
