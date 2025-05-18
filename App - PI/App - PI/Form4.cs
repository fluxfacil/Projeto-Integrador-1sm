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
    public partial class Form4 : Form
    {
        private string nomeUsuarioLogado;

        public Form4(string nomeUsuario)
        {
            InitializeComponent();
            nomeUsuarioLogado = nomeUsuario;
        }


        private void txt_adicionarSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_salvarNovoSaldo_Click(object sender, EventArgs e)
        {

            var valor = txt_adicionarSaldo.Text.ToString();
            decimal realValue = Convert.ToDecimal(valor);

            if (realValue <= 0)
            {
                MessageBox.Show("Digite um valor maior que zero.");
                return;
            }

            functions.AtualizarSaldoUsuario(nomeUsuarioLogado, realValue, true);
            MessageBox.Show("Saldo atualizado com sucesso!");
            this.Close();
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
