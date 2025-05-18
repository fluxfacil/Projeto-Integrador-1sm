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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void txt_usuarioCadastrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_senhaCadastrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            string nome = txt_usuarioCadastrar.Text.Trim();
            string senha = txt_senhaCadastrar.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            functions.CadastrarUsuario(nome, senha);
            this.Close();

        }


        private void Form5_Load(object sender, EventArgs e)
        {

        }


    }
}
