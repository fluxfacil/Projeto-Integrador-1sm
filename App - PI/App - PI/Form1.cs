using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App___PI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string nome = txt_usuario.Text.Trim();
            string senha = txt_senha.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Por favor, insira o nome de usuário.");
                txt_usuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, insira a senha.");
                txt_senha.Focus();
                return;
            }

            // Cria os arquivos se não existirem
            functions.CriarArquivosSeNaoExistir();

            if (functions.FazerLogin(nome, senha))
            {
                MessageBox.Show($"Login realizado com sucesso! Bem-vindo, {nome}!");

                // Abre o Form2 (Home)
                Form2 home = new Form2();
                home.Show();

                // Esconde o form de login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha incorretos!");
                txt_senha.Clear();
                txt_usuario.Focus();
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Form5 formsDeCadastro = new Form5();
            formsDeCadastro.Show();

         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        
    }
}