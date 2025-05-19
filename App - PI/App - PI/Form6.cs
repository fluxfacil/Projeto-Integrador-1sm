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
    public partial class Form6 : Form
    {
        private string nomeOriginal, categoriaOriginal, tipoOriginal, dataOriginal, valorOriginal;

        public Form6(string nome, string categoria, string tipo, string data, string valor)
        {
            InitializeComponent();

            nomeOriginal = nome;
            categoriaOriginal = categoria;
            tipoOriginal = tipo;
            dataOriginal = data;
            valorOriginal = valor;

            txt_nome_atualizar.Text = nome;
            txt_categoria_atualizar.Text = categoria;
            comboBox_DR_atualizar.Text = tipo;
            dateTime_Data_atualizar.Value = DateTime.Parse(data);
            txt_valor_atualizar.Text = valor;
        }

        private void txt_nome_atualizar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_categoria_atualizar_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_DR_atualizar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTime_Data_atualizar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_valor_atualizar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_atualizar_Conta_Click(object sender, EventArgs e)
        {
            string novoNome = txt_nome_atualizar.Text.Trim();
            string novaCategoria = txt_categoria_atualizar.Text.Trim();
            string novoTipo = comboBox_DR_atualizar.Text;
            string novaData = dateTime_Data_atualizar.Value.ToShortDateString();
            string novoValor = txt_valor_atualizar.Text.Trim();

            if (string.IsNullOrWhiteSpace(novoNome) || string.IsNullOrWhiteSpace(novaCategoria) ||
                string.IsNullOrWhiteSpace(novoTipo) || string.IsNullOrWhiteSpace(novoValor))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            string usuario = functions.ObterUsuarioLogado();

            // Atualiza a transação de forma segura
            functions.AtualizarTransacao(
                nomeOriginal, categoriaOriginal, tipoOriginal, dataOriginal, valorOriginal,
                novoNome, novaCategoria, novoTipo, novaData, novoValor,
                usuario
            );

            MessageBox.Show("Transação atualizada com sucesso!");
            this.Close();
        }


    }
}
