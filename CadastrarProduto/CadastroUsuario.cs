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
    public partial class CadastroUsuario : Form
    {
        private UsuariosRepository usuariosRepository = new UsuariosRepository();
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            string nome = usuariosRepository.BuscarNome(inputNome.Text.ToString());

            if (inputNome.Text == "" || inputSenha.Text == "")
            {
                MessageBox.Show("Você deve preencher os formulários");
            }
            else
            {
                if (inputSenha.Text == cofirmarSenha.Text)
                {
                    if (!string.IsNullOrEmpty(nome))
                    {
                        MessageBox.Show("Este nome já está sendo usado");
                    }
                    else
                    {
                        usuariosRepository.CadastrarUsuarios(inputNome.Text, inputSenha.Text);
                        MessageBox.Show("Cadastro realizado com sucesso!");
                    }
                }
                else
                {
                    MessageBox.Show("As senhas não correspondem!");
                }
            }
        }
    }
}
